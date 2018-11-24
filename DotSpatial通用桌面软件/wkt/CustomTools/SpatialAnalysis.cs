using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using DotSpatial.Analysis;

namespace wkt.CustomTools
{
    static class SpatialAnalysis
    {
        //面分割栅格
        public static IRaster ClipRasterWithPolygon(IFeatureSet polygon, IRaster raster, string RRaster)
        {
            if (raster == null || polygon == null || RRaster == null)
            {
                return null;
            }

            IRaster resultRaster = ClipRaster.ClipRasterWithPolygon(polygon.Features[0], raster, RRaster, null);
            return resultRaster;
        }
        //面分割面
        public static bool ClipPoygonWithPolygon(IFeatureSet WPolygon, IFeatureSet TPolygon, IFeatureSet RPolygon)
        {
            if (WPolygon == null || TPolygon == null)
            {
                return false;
            }
            if (TPolygon.FeatureType != FeatureType.Polygon)
            {
                return false;
            }

            RPolygon.FeatureType = FeatureType.Polygon;

            IFeatureSet tempRPolygon = WPolygon.Intersection(TPolygon, FieldJoinType.LocalOnly, null);

            foreach (DataColumn wpColumn in tempRPolygon.DataTable.Columns)
            {
                RPolygon.DataTable.Columns.Add(new DataColumn(wpColumn.ColumnName, wpColumn.DataType));
            }
            foreach (var fe in tempRPolygon.Features)
            {
                RPolygon.Features.Add(fe);
            }
            RPolygon.SaveAs(RPolygon.Filename, true);

            return true;
        }
        //相交
        public static FeatureSet Intersection(IFeatureSet self, IFeatureSet other)
        {

            FeatureSet resultFeature = new FeatureSet();
            for (int i = 0; i <= self.ShapeIndices.Count - 1; i++)
            {
                IFeature iTF, iSF, f;
                iTF = self.GetFeature(i);
                for (int j = 0; j <= other.ShapeIndices.Count - 1; j++)
                {
                    iSF = other.GetFeature(j);
                    if (iSF.Envelope.Intersects(iTF.Envelope))
                    {
                        f = FeatureExt.Intersection(iSF, iTF);
                        resultFeature.AddFeature(f).CopyAttributes(self.GetFeature(i));
                    }
                }
            }
            return resultFeature;
        }

        public static List<IFeature> Intersections(IFeatureSet inFeatureSet1, IFeatureSet inFeatureSet2)
        {
            List<IFeature> resultFeature = new List<IFeature>();
            for (int i = 0; i <= inFeatureSet1.ShapeIndices.Count - 1; i++)
            {
                IFeature iTF, iSF, f;
                iTF = inFeatureSet1.GetFeature(i);
                for (int j = 0; j <= inFeatureSet2.ShapeIndices.Count - 1; j++)
                {
                    iSF = inFeatureSet2.GetFeature(j);
                    if (iSF.Envelope.Intersects(iTF.Envelope))
                    {
                        f = FeatureExt.Intersection(iSF, iTF);
                        resultFeature.Add(f);
                    }
                }
            }
            return resultFeature;
        }

        //线分割面
        public static IFeatureSet ClipPolygonByLine(IFeatureSet polygon, IFeatureSet line, IFeatureSet result)
        {

            IFeatureSet tempFS = new FeatureSet();
            string fileName = result.Filename;

            for (int i = 0; i <= line.Features.Count - 1; i++)
            {
                IFeature iLF = line.GetFeature(i);

                int numPolygonFeature = polygon.Features.Count;
                int index = 0;
                for (int j = 0; j < numPolygonFeature; j++)
                {
                    bool succeededClip = false;
                    IFeature iPF = polygon.GetFeature(index);

                    if (iLF.Intersects(iPF))
                    {
                        polygon.RemoveShapeAt(index);

                        succeededClip = DotSpatial.Tools.ClipPolygonWithLine.DoClipPolygonWithLine(ref iPF, ref iLF, ref tempFS);

                        if (succeededClip == true)
                        {
                            for (int f = 0; f < tempFS.Features.Count; f++)
                            {
                                polygon.AddFeature(tempFS.GetFeature(f));
                            }
                            tempFS.Features.Clear();
                        }
                    }
                    else
                    {
                        index++;
                    }
                }
            }
            result = polygon;
            result.Filename = fileName;
            return result;
        }

        //提取边界
        public static FeatureSet ExtractBoundary(FeatureSet polygonFs)
        {
            FeatureSet boundary = new FeatureSet(FeatureType.Line);
            List<string> boundaryStr = new List<string>();
            for (int i = 0; i < polygonFs.Features.Count; i++)
            {
                int numParts = 0;
                IFeature polygon = polygonFs.GetFeature(i);
                numParts = polygon.NumPoints;

                Coordinate[][] polyVertArray = new Coordinate[numParts][];
                ConvertPolyToVertexArray(ref polygon, ref polyVertArray);

                boundaryStr.Add(ToLineString(polyVertArray));
            }
            boundary = WktToShape(boundaryStr);
            return boundary;
        }

        //点打断线简单方式
        public static bool InterruptLineWithPoint(Coordinate point, ref FeatureSet lineFS)
        {
            IList<Coordinate> lineCoordinates = new List<Coordinate>();
            var newLine1 = new LineString(new List<Coordinate> { });
            LineString newLine2 = null;
            int pointsNum = lineFS.Features.Count;
            for (int i = 0; i < pointsNum; i++)
            {
                IFeature lFeature = lineFS.GetFeature(i);
                for (int m = 0; m < lFeature.Coordinates.Count; m++)
                {
                    lineCoordinates.Add(lFeature.Coordinates[m]);
                }

                bool onLine = DotSpatial.Topology.Algorithm.CgAlgorithms.IsOnLine(point, lineCoordinates);
                if (onLine)
                {
                    for (int j = 0; j < lineCoordinates.Count; j++)
                    {
                        newLine1.Coordinates.Add(lineCoordinates[j]);
                        bool isEqual = point.Equals(lineCoordinates[j]);
                        if (isEqual)
                        {
                            newLine2 = new LineString(new List<Coordinate> { });
                            for (int n = j; n < lineCoordinates.Count; n++)
                            {
                                newLine2.Coordinates.Add(lineCoordinates[n]);
                            }
                            lineFS.RemoveShapeAt(i);

                            if (newLine2 != null)
                                lineFS.AddFeature(newLine2);
                            lineFS.AddFeature(newLine1);
                        }
                        if (newLine2 != null)
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            if (newLine2 != null)
            { return true; }
            else
            { return false; }
        }

        //点打断线
        public static bool InterruptLinesWithPoints(FeatureSet lineFS, FeatureSet pointFS, ref IFeatureSet reslultFS)
        {
            IList<Coordinate> pointCoordinates = new List<Coordinate>();
            IList<Coordinate> lineCoordinates = new List<Coordinate>();
            var newLine1 = new LineString(new List<Coordinate> { });
            LineString newLine2 = null;
            FeatureSet resultFeatures = new FeatureSet();

            for (int m = 0; m < lineFS.GetFeature(0).Coordinates.Count; m++)
            {
                lineCoordinates.Add(lineFS.GetFeature(0).Coordinates[m]);
            }

            for (int n = 0; n < pointFS.Features.Count; n++)
            {
                pointCoordinates.Add(pointFS.GetFeature(n).Coordinates[0]);
            }

            for (int i = 0; i < lineCoordinates.Count; i++)
            {
                newLine1.Coordinates.Add(lineCoordinates[i]);

                for (int j = 0; j < pointCoordinates.Count; j++)
                {
                    //判断点是否在线上，并且与当前线上的点是否相同。
                    bool onLine = DotSpatial.Topology.Algorithm.CgAlgorithms.IsOnLine(pointCoordinates[j], lineCoordinates);
                    bool isEqual = pointCoordinates[j].Equals(lineCoordinates[i]);
                    if (onLine && isEqual)
                    {
                        newLine2 = new LineString(new List<Coordinate> { });
                        for (int k = i; k < lineCoordinates.Count; k++)
                        {
                            newLine2.Coordinates.Add(lineCoordinates[k]);
                        }
                        if (newLine2 != null)
                            reslultFS.AddFeature(newLine2);
                        reslultFS.AddFeature(newLine1);
                    }
                }
                if (newLine2 != null)
                    break;
            }

            if (newLine2 != null)
                return true;
            return false;
        }

        //线打断线
        public static bool InterruptLineWithLine(FeatureSet interruptedLineFS, FeatureSet interruptLineFS, ref IFeatureSet resultFS)
        {
            var newLine1 = new LineString(new List<Coordinate> { });
            LineString newLine2 = null;
            IList<Coordinate> lineCoordinates = new List<Coordinate>();

            for (int i = 0; i < interruptedLineFS.Features.Count; i++)
            {
                IFeature interruptedLineF = interruptedLineFS.GetFeature(i);
                for (int j = 0; j < interruptLineFS.Features.Count; j++)
                {
                    IFeature interruptLineF = interruptLineFS.GetFeature(j);
                    if (interruptLineF.Intersects(interruptedLineF))
                    {
                        IList<Coordinate> intersectCoor = interruptLineF.Intersection(interruptedLineF).Coordinates;
                        lineCoordinates = interruptedLineF.Coordinates;

                        for (int m = 1; m < lineCoordinates.Count; m++)
                        {
                            newLine1.Coordinates.Add(lineCoordinates[i]);
                            var segmL1 = new LineString(new Coordinate[] { interruptedLineF.Coordinates[m - 1], interruptedLineF.Coordinates[m] });

                            for (int n = 1; n < interruptLineF.Coordinates.Count; j++)
                            {
                                var segmL2 = new LineString(new Coordinate[] { interruptLineF.Coordinates[n - 1], interruptLineF.Coordinates[n] });

                                // If intersecting, identify intersection point and create new line

                                if (segmL1.Intersects(segmL2))
                                {
                                    // Get intersection point
                                    Coordinate intersectionPoint = segmL1.Intersection(segmL2).Coordinates[0];

                                    // Insert intersection point as last point of first part of the split line and as the first point of the second part
                                    if (!intersectionPoint.Equals(interruptedLineF.Coordinates[m - 1]))
                                        newLine1.Coordinates.Add(intersectionPoint);

                                    // Create second part as new line
                                    newLine2 = new LineString(new List<Coordinate> { });
                                    if (!intersectionPoint.Equals(interruptedLineF.Coordinates[m]))
                                        newLine2.Coordinates.Add(intersectionPoint);

                                    for (int k = m; k < lineCoordinates.Count; k++)
                                        newLine2.Coordinates.Add(interruptedLineF.Coordinates[k]);
                                    if (newLine2 != null)
                                        resultFS.AddFeature(newLine2);
                                    resultFS.AddFeature(newLine1);
                                    break;
                                }
                            }
                            if (newLine2 != null)
                                break;
                        }
                    }
                }
            }
            if (newLine2 != null)
                return true;
            return false;
        }

        public static void ConvertPolyToVertexArray(ref IFeature poly, ref Coordinate[][] polyVertArray)
        {
            int numParts = poly.NumGeometries;
            if (numParts == 0)
            {
                numParts = 1;
            }

            int numPoints = poly.NumPoints;
            Coordinate[][] vertArray = new Coordinate[numParts][];
            if (numParts > 1)
            {
                // separate parts of polygon
                for (int i = 0; i <= numParts - 1; i++)
                {
                    int numPtsInPart = poly.GetBasicGeometryN(i).Coordinates.Count;
                    vertArray[i] = new Coordinate[numPtsInPart];
                    for (int j = 0; j <= numPtsInPart - 2; j++)
                    {
                        vertArray[i][j] = poly.GetBasicGeometryN(i).Coordinates[j];
                    }

                    // be sure to 'close' the polygon in the vertex array!
                    vertArray[i][numPtsInPart - 1] = vertArray[i][0];
                }
            }
            else
            {
                // all points in polygon go into same vertex array
                vertArray[0] = new Coordinate[numPoints];
                for (int i = 0; i <= numPoints - 1; i++)
                {
                    vertArray[0][i] = poly.Coordinates[i];
                }
            }

            polyVertArray = vertArray;
        }

        public static string ToLineString(Coordinate[][] pointsSeq)
        {
            StringBuilder buf = new StringBuilder();
            buf.Append("LINESTRING ");
            if (pointsSeq.Length == 0)
            {
                buf.Append(" EMPTY");
            }
            else
            {
                buf.Append("(");

                for (int i = 0; i < pointsSeq.Length; i++)
                {
                    for (int j = 0; j < pointsSeq[i].Length; j++)
                    {
                        if (j > 0)
                        {
                            buf.Append(",");
                        }
                        buf.Append(pointsSeq[i][j].X + " " + pointsSeq[i][j].Y);
                    }
                }
                buf.Append(")");
            }
            return buf.ToString();
        }

        public static FeatureSet WktToShape(List<string> shapeStr)
        {
            FeatureSet featureSet = new FeatureSet(FeatureType.Unspecified);
            WKTReader reader = new WKTReader();
            foreach (string str in shapeStr)
            {
                GeoAPI.Geometries.IGeometry geo = reader.Read(str);
                DotSpatial.Topology.IGeometry dotgeo = GeoAPI.Geometries.GeometryConverter.ToDotSpatial(geo);//转换到dotspatial类型geometry
                featureSet.AddFeature(dotgeo);
            }
            return featureSet;
        }

        //交集取反
        public static FeatureSet SymmetricDiffence(IFeatureSet self, IFeatureSet other)
        {
            FeatureSet resultFeature = new FeatureSet();
            for (int i = 0; i <= self.ShapeIndices.Count - 1; i++)
            {
                IFeature iTF, iSF, f;
                iTF = self.GetFeature(i);
                for (int j = 0; j <= other.ShapeIndices.Count - 1; j++)
                {
                    iSF = other.GetFeature(j);
                    if (iSF.Envelope.Intersects(iTF.Envelope))
                    {
                        f = FeatureExt.SymmetricDifference(iSF, iTF);
                        resultFeature.AddFeature(f).CopyAttributes(self.GetFeature(i));
                    }
                }
            }
            return resultFeature;
        }

        //追加要素
        public static FeatureSet AppendFeatures(FeatureSet TargetFeatures, FeatureSet SourceFeatures)
        {
            IFeature SF;
            for (int i = 0; i <= SourceFeatures.Features.Count - 1; i++)
            {
                SF = SourceFeatures.GetFeature(i);
                TargetFeatures.AddFeature(SF).CopyAttributes(SourceFeatures.GetFeature(i));   //by default this will try to copy attributes over that have the same name.
            }
            return TargetFeatures;
        }
    }
}
