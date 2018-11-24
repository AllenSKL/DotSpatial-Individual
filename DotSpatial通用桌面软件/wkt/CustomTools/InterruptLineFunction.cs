using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Plugins.ShapeEditor;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using Point = System.Drawing.Point;

namespace wkt.CustomTools
{
    public class InterruptLineFunction : SnappableMapFunction
    {
     
        private CoordinateDialog _coordinateDialog;
        private IFeatureSet _featureSet;
        private bool _standBy;
        private List<Coordinate> _coordinates;
        private IMapLineLayer _tempLayer;
        private IFeatureLayer _layer;
        private Point _mousePosition;
        Coordinate _interruptCoordinate = new Coordinate();

        public IFeatureLayer Layer
        {
            get { return _layer; }
            set
            {
                if (_layer == value) return;
                _layer = value;
                _featureSet = _layer != null ? _layer.DataSet : null;
            }
        }

        public InterruptLineFunction(IMap map) : base(map)
        {
            Configure();
        }

        private void Configure()
        {
        }

        protected override void OnActivate()
        {
            if (_coordinateDialog == null) _coordinateDialog = new CoordinateDialog();

            _coordinateDialog.ShowZValues = _featureSet.CoordinateType == CoordinateType.Z;
            _coordinateDialog.ShowMValues = _featureSet.CoordinateType == CoordinateType.M || _featureSet.CoordinateType == CoordinateType.Z;

            _coordinateDialog.Show();
            if (!_standBy) _coordinates = new List<Coordinate>();
            if (_tempLayer != null)
            {
                Map.MapFrame.DrawingLayers.Remove(_tempLayer);
                Map.MapFrame.Invalidate();
                Map.Invalidate();
                _tempLayer = null;
            }
            _standBy = false;
            base.OnActivate();
        }

        protected override void OnMouseDown(GeoMouseArgs e)
        {
            bool succeedInterrupt = false;

            FeatureSet lineFeatureSet = _layer.DataSet as FeatureSet;
            succeedInterrupt = CustomTools.SpatialAnalysis.InterruptLineWithPoint(_interruptCoordinate, ref lineFeatureSet);
            CustomTools.AttriIndexProcessing.CorrectIndexError(_layer);//处理要素删除后的index混乱问题
            if (succeedInterrupt)
            {
                MessageBox.Show("打断成功！");
            }
            else
            {
                MessageBox.Show("失败！请重试。");
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(GeoMouseArgs e)
        {
            base.OnMouseUp(e);
        }
        protected override void OnDraw(MapDrawArgs e)
        {
            DoSnapDrawing(e.Graphics, _mousePosition);
            base.OnDraw(e);
        }
        protected override void OnMouseMove(GeoMouseArgs e)
        {
            if (_standBy) { return; }
            // Begin snapping changes
            Coordinate snappedCoord = e.GeographicLocation;
            bool prevWasSnapped = this.isSnapped;
            this.isSnapped = ComputeSnappedLocation(e, ref snappedCoord);
            _coordinateDialog.X = snappedCoord.X;
            _coordinateDialog.Y = snappedCoord.Y;
            _interruptCoordinate.X = snappedCoord.X;
            _interruptCoordinate.Y = snappedCoord.Y;
            // End snapping changes

            if (_coordinates != null && _coordinates.Count > 0)
            {
                List<Point> points = _coordinates.Select(coord => Map.ProjToPixel(coord)).ToList();
                Rectangle oldRect = SymbologyGlobal.GetRectangle(_mousePosition, points[points.Count - 1]);
                Rectangle newRect = SymbologyGlobal.GetRectangle(e.Location, points[points.Count - 1]);
                Rectangle invalid = Rectangle.Union(newRect, oldRect);
                invalid.Inflate(20, 20);
                Map.Invalidate(invalid);
            }

            // Begin snapping changes
            _mousePosition = this.isSnapped ? Map.ProjToPixel(snappedCoord) : e.Location;
            DoMouseMoveForSnapDrawing(prevWasSnapped, _mousePosition);
            // End snapping changes

            base.OnMouseMove(e);
        }

    }
}
