using DotSpatial.Data;
using DotSpatial.Controls;
using DotSpatial.Topology;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DotSpatial.Symbology;
using NetTopologySuite.IO;
using DotSpatial.Plugins.Measure;
using DotSpatial.Symbology.Forms;
using System.Data.OleDb;
using DotSpatial.Projections;
using DotSpatial.Plugins.ShapeEditor;
using DotSpatial.Topology.Utilities;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Types;
using System.Drawing;
using GeoAPI.Geometries;

namespace wkt
{
    public partial class mainForm : Form
    {
        MapFunctionMeasure ff = null;
        bool doSnapping = false;
        private MoveVertexFunction moveVertexFunction;
        private AddShapeFunction addShapeFunction;

        public mainForm()
        {
            InitializeComponent();
            appManager.LoadExtensions();
            ff = new MapFunctionMeasure(mapControl);
        }
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "dspx files(*.dspx)|*.dspx";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFile.FileName;
                SerializationManager save = new SerializationManager(appManager);
                save.OpenProject(fileName);
            }
            mapControl.FunctionMode = FunctionMode.Pan;
        }

        private void clearFile_Click(object sender, EventArgs e)
        {
            mapControl.Layers.Clear();
        }

        private void inputWKT_Click(object sender, EventArgs e)
        {
            ImportWKT importWKT = new ImportWKT();
            importWKT.TransfEvent += TransfEvent;
            importWKT.ShowDialog();

        }
        //WKT转shape
        void TransfEvent(string fileName)
        {
            IFeatureSet pointFSet = new FeatureSet(FeatureType.Point);
            IFeatureSet lineFSet = new FeatureSet(FeatureType.Line);
            IFeatureSet polygonFSet = new FeatureSet(FeatureType.Polygon);
            IFeatureSet multipointFSet = new FeatureSet(FeatureType.MultiPoint);
            IFeatureSet unspeicifiedFSet = new FeatureSet(FeatureType.Unspecified);

            if (fileName != "")
            {
                WKTReader reader = new WKTReader();
                string[] wktFile = System.IO.File.ReadAllLines(fileName);
                foreach (string str in wktFile)
                {
                    GeoAPI.Geometries.IGeometry geo = reader.Read(str);
                    DotSpatial.Topology.IGeometry dotgeo = GeoAPI.Geometries.GeometryConverter.ToDotSpatial(geo);
                    FeatureType res = dotgeo.FeatureType;
                    switch (res)
                    {
                        case FeatureType.Polygon:
                            polygonFSet.AddFeature(dotgeo);
                            break;
                        case FeatureType.Line:
                            lineFSet.AddFeature(dotgeo);
                            break;
                        case FeatureType.Point:
                            pointFSet.AddFeature(dotgeo);
                            break;
                    }
                }
                int polygonFeatureCount = polygonFSet.Features.Count;
                int lineFeatureCount = lineFSet.Features.Count;
                int pointFeantureCount = pointFSet.Features.Count;
                if (polygonFeatureCount != 0)
                {
                    MapPolygonLayer polygonlayer = (MapPolygonLayer)mapControl.Layers.Add(polygonFSet);
                    polygonlayer.LegendText = "面要素图层";
                    polygonlayer.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;
                }
                if (lineFeatureCount != 0)
                {
                    MapLineLayer linelayer = (MapLineLayer)mapControl.Layers.Add(lineFSet);
                    linelayer.LegendText = "线要素图层";
                    linelayer.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;
                }
                if (pointFeantureCount != 0)
                {
                    MapPointLayer pointlayer = (MapPointLayer)mapControl.Layers.Add(pointFSet);
                    pointlayer.LegendText = "点要素图层";
                    pointlayer.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;
                }
                mapControl.ZoomToMaxExtent();
                mapControl.FunctionMode = FunctionMode.Pan;
            }
            else
            {
                MessageBox.Show("请输入正确的WKT文本！");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否退处应用？", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void zoomIn_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.ZoomIn;
        }

        private void zoomToMax_Click(object sender, EventArgs e)
        {
            mapControl.ZoomToMaxExtent();
        }

        private void pan_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Pan;
        }

        //定义鼠标滚轮事件
        private void mapControl_MouseWheel(object sender, MouseEventArgs e)
        {
            //if (e.Delta < 0)
            //{
            //    mapControl.ZoomIn();
            //}
            //else
            //{
            //    mapControl.ZoomOut();
            //}
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            mapControl.ZoomIn();
            string xpanel = String.Format("X:");
            string ypanel = String.Format("Y:");
            tsCoordinateStatus.Text = xpanel + " " + ypanel;
            tsmStopEditting.Enabled = false;
            btnEdit.Enabled = false;
            btnMoveVertex.Enabled = false;
            btnSnapping.Enabled = false;
            tsbtnInterruptLineWithPoint.Enabled = false;
            tsbClipRasterWP.Enabled = false;
            mapControl.ZoomOutFartherThanMaxExtent = true;
        }

        private void mapControl_MouseMove(object sender, MouseEventArgs e)
        {
            IMap mainMap = mapControl as Map;
            GeoMouseArgs mouseArgs = new GeoMouseArgs(e, mainMap);
            if (mouseArgs.GeographicLocation.X == 0 && mouseArgs.GeographicLocation.Y == 0)
            {
                mouseArgs.GeographicLocation.X = 0.0000000000001;
                mouseArgs.GeographicLocation.Y = 0.0000000000001;
            }
            string xpanel = String.Format("X: {0:0.0000000000000}", mouseArgs.GeographicLocation.X);
            string ypanel = String.Format("Y: {0:0.0000000000000}", mouseArgs.GeographicLocation.Y);
            tsCoordinateStatus.Text = xpanel + " " + ypanel;
        }

        //另存为
        private void saveAs_Click(object sender, EventArgs e)
        {
            SerializationManager save = new SerializationManager(appManager);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "dspx files(*.dspx)|*.dspx";
            saveFileDialog.FileName = "";
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                save.SaveProject(saveFileDialog.FileName);
                MessageBox.Show("地图文档保存成功。");
            }
        }

        //要素选择
        private void selectFeature_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Select;
        }
        //禁用所有的工具
        private void clSelection_Click(object sender, EventArgs e)
        {
            mapControl.ClearSelection();
        }
        //简单测量
        private void simpleMeasure_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
            MapFunctionMeasure ff = new MapFunctionMeasure(mapControl);
            mapControl.MapFunctions.Add(ff);
            ff.Activate();
        }
        //地图打印
        private void printMap_Click(object sender, EventArgs e)
        {
            LayoutForm frm = new LayoutForm();
            frm.MapControl = mapControl;
            frm.Show();
        }
        //要素属性表操作
        private void showAtrributes_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers;
            if (mainMap != null)
                layers = mainMap.GetAllLayers();
            else
            {
                layers = mainMap.GetLayers();
            }
            IFeatureLayer fl = null;
            foreach (ILayer layer in layers)
            {
                if (layer.IsSelected)
                {
                    fl = layer as IFeatureLayer;
                    break;
                }
                else
                {
                    fl = layers[layers.Count - 1] as IFeatureLayer;
                }
            }
            if (fl == null)
            {
                MessageBox.Show("请先选择一个图层！");
                return;
            }
            IFeatureLayer _activeLayer = mapControl.Layers.SelectedLayer as IFeatureLayer;
            FeatureLayerActions ff = new FeatureLayerActions();
            ff.ShowAttributes(_activeLayer);
        }
        //属性查询
        private void queryAttribute_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Info;
        }
        //坐标定位
        private void coorPosition_Click(object sender, EventArgs e)
        {
            ZoomToCoordinatesDialog map = new ZoomToCoordinatesDialog(mapControl);
            map.ShowDialog();
        }
        //前一视图
        private void lastView_Click(object sender, EventArgs e)
        {
            mapControl.ZoomToPrevious();
        }
        //后一视图
        private void laterView_Click(object sender, EventArgs e)
        {
            mapControl.ZoomToNext();
        }

        private void mapControl_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Pan;
        }

        //导入EXCEL点要素
        private void importExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel Files|*.xlsx";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                string excelFileName = openDialog.FileName;
                string connectionString = String.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=\"Excel 12.0 Xml;HDR=YES;IMEX=1\"", excelFileName);
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM [Sheet1$]";
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                    DataTable excelTable = new DataTable();
                    adapter.Fill(excelTable);
                    if (excelTable.Columns.Contains("lat") & excelTable.Columns.Contains("long"))
                    {
                        FeatureSet fs = new FeatureSet(FeatureType.Point);
                        fs.Projection = KnownCoordinateSystems.Geographic.World.WGS1984;
                        fs.DataTable = excelTable.Clone();
                        foreach (DataRow excelRow in excelTable.Rows)
                        {
                            double lat = Double.Parse(excelRow["lat"].ToString().Trim());
                            double lon = Double.Parse(excelRow["long"].ToString().Trim());

                            DotSpatial.Topology.Coordinate coord = new DotSpatial.Topology.Coordinate(lon, lat);
                            DotSpatial.Topology.Point point = new DotSpatial.Topology.Point(coord);
                            IFeature feature = fs.AddFeature(point);

                            for (int i = 0; i <= excelTable.Columns.Count - 1; i++)
                            {
                                feature.DataRow[i] = excelRow[i];
                            }
                        }
                        MapPointLayer pointLayer = (MapPointLayer)mapControl.Layers.Add(fs);
                        pointLayer.LegendText = "EXCEL点要素图层";
                    }
                    else
                    {
                        MessageBox.Show("EXCEL表中必须包含“lat”和“long”字段");
                    }
                }
            }

        }
        private void btnClearAllLayers_Click(object sender, EventArgs e)
        {
            mapControl.Layers.Clear();
            mapControl.FunctionMode = FunctionMode.None;
            mapControl.Refresh();
        }
        private void btnPan_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Pan;
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            tsmRremoveFeature.Visible = false;
            mapControl.FunctionMode = FunctionMode.ZoomIn;
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            tsmRremoveFeature.Visible = false;
            mapControl.FunctionMode = FunctionMode.ZoomOut;
        }

        private void btnExtent_Click(object sender, EventArgs e)
        {
            //缩放到选中图层
            //var layer = mapControl.Layers.SelectedLayer;
            //if (layer != null)
            //{
            //    CustomTools.MapFunctionOperating.ZoomToSpecifiedLayer(mapControl, layer);
            //}
            mapControl.ZoomToMaxExtent();
        }

        private void btnLastView_Click(object sender, EventArgs e)
        {
            mapControl.MapFrame.ZoomToPrevious();
        }

        private void btnLaterLayer_Click(object sender, EventArgs e)
        {
            mapControl.MapFrame.ZoomToNext();
        }
        //定位到目标位置
        private void btnZoomToCoor_Click(object sender, EventArgs e)
        {
            using (ZoomToCoordinatesDialog CoordinateDialog = new ZoomToCoordinatesDialog(mapControl))
                CoordinateDialog.ShowDialog();
        }
        //要素选择
        private void btnSelectFeature_Click(object sender, EventArgs e)
        {
            tsmRremoveFeature.Visible = true;
            mapControl.FunctionMode = FunctionMode.Select;
        }
        //属性查询
        private void btnQueryAttri_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Info;
        }
        //简单测量
        private void btnMeasure_Click(object sender, EventArgs e)
        {
            tsmRremoveFeature.Visible = false;
            mapControl.FunctionMode = FunctionMode.None;
            mapControl.MapFunctions.Add(ff);
            if (!ff.Enabled)
            {
                ff.Activate();
            }
            else
            {
                ff.Unload();
                //ff.Deactivate();
                ff = new MapFunctionMeasure(mapControl);
            }

            mapControl.Cursor = Cursors.Cross;
        }
        //查看属性表
        private void btnQueryAttributes_Click(object sender, EventArgs e)
        {
            mapControl.ClearSelection();
            Map mainMap = mapControl as Map;
            FeatureLayerActions ff = new FeatureLayerActions();

            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            IFeatureLayer fl = null;

            foreach (ILayer layer in layers)
            {
                if (layer.IsSelected)
                {
                    fl = layer as IFeatureLayer;
                    break;
                }
            }
            if (fl != null)
            {
                ff.ShowAttributes(fl);
            }
            else
            {
                return;
            }
        }

        //查询要素
        private void btnFindFreatrue_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers;
            if (mainMap != null)
                layers = mainMap.GetAllLayers();
            else
                layers = mainMap.GetLayers();
            IFeatureLayer fl = null;
            foreach (ILayer layer in layers)
            {
                if (layer.IsSelected)
                {
                    fl = layer as IFeatureLayer;
                    break;
                }
                else
                {
                    fl = layers[layers.Count - 1] as IFeatureLayer;
                }
            }
            if (fl == null)
            {
                MessageBox.Show("请先选择一个图层！");
                return;
            }
            SQLExpressionDialog qd = new SQLExpressionDialog();
            if (fl.DataSet.AttributesPopulated)
                qd.Table = fl.DataSet.DataTable;
            else
                qd.AttributeSource = fl.DataSet;
            // Note: User must click ok button to see anything.
            qd.ShowDialog();
            if (!String.IsNullOrWhiteSpace(qd.Expression))
            {
                try
                {
                    fl.SelectByAttribute(qd.Expression);
                }
                catch (SyntaxErrorException ex)
                {
                    MessageBox.Show("查询语法不正确 " + ex.Message);
                }
            }
        }
        //取消要素选择
        private void btnCancelSelect_Click(object sender, EventArgs e)
        {
            mapControl.ClearSelection();
        }
        //导出选中的图层
        private void btnSave_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            IFeatureLayer fl = null;
            foreach (ILayer layer in layers)
            {
                if (layer.IsSelected)
                {
                    fl = layer as IFeatureLayer;
                    break;
                }
                else
                {
                    fl = layers[layers.Count - 1] as IFeatureLayer;
                }
            }
            if (fl == null)
            {
                MessageBox.Show("请先选择一个图层！");
                return;
            }
            FeatureLayerActions p = new FeatureLayerActions();
            p.ExportData(fl);
        }


        //导出wkt文本
        private void btnExportWKT_Click_1(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers;
            layers = CustomTools.GetAllLayers.Execute(mainMap);
            IFeatureLayer fl = null;
            string layerName = "";
            foreach (ILayer layer in layers)
            {
                if (layer.IsSelected)
                {
                    fl = layer as IFeatureLayer;
                    layerName = layer.LegendText;
                    break;
                }
                else
                {
                    fl = layers[layers.Count - 1] as IFeatureLayer;
                }
            }
            if (fl == null)
            {
                MessageBox.Show("当前没有图层可以导出！");
                return;
            }
            List<string> str = new List<string>();
            fl.SelectAll();
            List<IFeature> selectedFeatureList = fl.Selection.ToFeatureList();
            foreach (IFeature feature in selectedFeatureList)
            {
                Geometry geometry = feature.BasicGeometry as Geometry;
                WktWriter wktWriter = new WktWriter();
                str.Add(wktWriter.Write(geometry));
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
            saveFileDialog.FileName = string.Format("{0}", layerName);
            saveFileDialog.AddExtension = true;
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.IO.File.WriteAllLines(saveFileDialog.FileName, str);
                MessageBox.Show("该图层对应的WKT文本保存成功");
            }
        }
        //查看要素wkt
        private void btnCheckWKT_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            IFeatureLayer fl = null;
            foreach (ILayer layer in layers)
            {
                if (layer.IsSelected)
                {
                    fl = layer as IFeatureLayer;
                    break;
                }
            }
            if (fl == null)
            {
                MessageBox.Show("请先选中一个图层！", "提醒");
                return;
            }
            else
            {
                int numSelectedFeatures = fl.Selection.Count;
                if (numSelectedFeatures == 0)
                {
                    MessageBox.Show("请先选中一个要素！", "提醒");
                    return;
                }
            }
            string wktStr = "";
            List<IFeature> selectedFeatureList = fl.Selection.ToFeatureList();
            for (int i = 0; i < selectedFeatureList.Count; i++)
            {
                IFeature selectedFeature = selectedFeatureList[i];
                Geometry geometry = selectedFeature.BasicGeometry as Geometry;
                WktWriter wktWriter = new WktWriter();
                wktStr += wktWriter.Write(geometry) + "\n";
            }
            wktStr = wktStr.TrimEnd("\n".ToCharArray());
            WKTViwer sf = new WKTViwer(wktStr);
            sf.Show();
        }
        //新建
        private void btnNew_Click(object sender, EventArgs e)
        {
            NewShapefile newShape = new NewShapefile();
            newShape.TransfEvent += TransfEvent;
            newShape.ShowDialog();
        }

        List<string> layerPath = new List<string>();
        void TransfEvent(FeatureType layertype, string layername)
        {
            string name = "";
            IFeatureLayer fl;
            IFeatureSet fs;
            switch (layertype)
            {
                case FeatureType.Point:
                    MapPointLayer pointlayer = new MapPointLayer();
                    name = Path.GetFileName(layername);
                    pointlayer.LegendText = name;
                    fl = pointlayer as IFeatureLayer;
                    fs = fl.DataSet;
                    fs.SaveAs(layername, true);

                    layerPath.Add(layername);
                    mapControl.AddLayer(layername);
                    break;
                case FeatureType.Line:
                    MapLineLayer linelayer = new MapLineLayer();
                    name = Path.GetFileName(layername);
                    linelayer.LegendText = name;

                    fl = linelayer as IFeatureLayer;
                    fs = fl.DataSet;
                    fs.SaveAs(layername, true);
                    layerPath.Add(layername);
                    mapControl.AddLayer(layername);
                    break;
                case FeatureType.Polygon:
                    MapPolygonLayer polygonlayer = new MapPolygonLayer();
                    name = Path.GetFileName(layername);
                    polygonlayer.LegendText = name;

                    fl = polygonlayer as IFeatureLayer;
                    fs = fl.DataSet;
                    fs.SaveAs(layername, true);
                    layerPath.Add(layername);
                    mapControl.AddLayer(layername);
                    break;
                case FeatureType.MultiPoint:
                    MapPointLayer multipointlayer = new MapPointLayer();
                    name = Path.GetFileName(layername);
                    multipointlayer.LegendText = name;

                    fl = multipointlayer as IFeatureLayer;
                    fs = fl.DataSet;
                    fs.SaveAs(layername, true);
                    layerPath.Add(layername);
                    mapControl.AddLayer(layername);
                    break;
            }
        }

        //编辑
        private void btnEdit_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
            tsmRremoveFeature.Visible = false;

            if (mapControl.Layers.Count > 0)
            {
                IMapFeatureLayer activeLayer = (IMapFeatureLayer)mapControl.Layers.SelectedLayer;
                if (activeLayer != null)
                {
                    //activeLayer.EditMode = true;
                    mapControl.Cursor = Cursors.Hand;
                    addShapeFunction = new AddShapeFunction(mapControl);
                    mapControl.MapFunctions.Add(addShapeFunction);
                    SetSnapLayers2(addShapeFunction, mapControl);
                    addShapeFunction.Layer = activeLayer;
                    addShapeFunction.Activate();
                }
                else
                {
                    MessageBox.Show("请选择一个需要编辑的图层！", "提醒");
                }
            }
            else
            {
                MessageBox.Show("请首先添加图层！", "提醒");
            }
        }

        //绘制要素
        private void createFeatures_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
            tsmRremoveFeature.Visible = false;
            if (mapControl.Layers.Count > 0)
            {
                IMapFeatureLayer activeLayer = (IMapFeatureLayer)mapControl.Layers.SelectedLayer;
                if (activeLayer != null)
                {
                    addShapeFunction = new AddShapeFunction(mapControl);
                    mapControl.MapFunctions.Add(addShapeFunction);
                    SetSnapLayers2(addShapeFunction, mapControl);
                    addShapeFunction.Layer = activeLayer;
                    addShapeFunction.Activate();
                }
                else
                {
                    MessageBox.Show("请选择一个需要编辑的图层！", "提醒");
                }
            }
            else
            {
                MessageBox.Show("请首先添加图层！", "提醒");
            }
        }

        //设置编辑图层
        public void SetSnapLayers(SnappableMapFunction func)
        {
            //IMapFeatureLayer activelayer = (IMapFeatureLayer)mapControl.Layers[mapControl.Layers.Count - 1];
            IMapFeatureLayer activeLayer = (IMapFeatureLayer)mapControl.Layers.SelectedLayer;
            func.DoSnapping = doSnapping;
            if (!doSnapping)
            {
                return;
            }
            foreach (var layer in mapControl.Layers)
            {
                IFeatureLayer f = layer as IFeatureLayer;
                if (f != null && f.DataSet.FeatureType != activeLayer.DataSet.FeatureType && f != activeLayer)
                {
                    func.AddLayerToSnap(f);
                }
            }
        }
        //设置要移动的图层
        public void SetMoveLayers(MoveVertexFunction func)
        {
            IMapFeatureLayer moveactivelayer = (IMapFeatureLayer)mapControl.Layers[mapControl.Layers.Count - 1];
            func.DoSnapping = doSnapping;
            if (!doSnapping)
            {
                return;
            }
            foreach (var layer in mapControl.Layers)
            {
                IFeatureLayer f = layer as IFeatureLayer;
                if (f != null && f.DataSet.FeatureType != moveactivelayer.DataSet.FeatureType && f != moveactivelayer)
                {
                    func.AddLayerToSnap(f);
                }
            }
        }
        private void SetSnapLayers2(SnappableMapFunction func, IMap geoMap)
        {

            func.DoSnapping = doSnapping;
            if (!doSnapping)
                return;

            foreach (var fl in geoMap.GetFeatureLayers())
            {
                func.AddLayerToSnap(fl);
            }
        }

        private void SetMoveLayers2(MoveVertexFunction func, IMap geoMap)
        {

            func.DoSnapping = doSnapping;
            if (!doSnapping)
                return;

            foreach (var fl in geoMap.GetFeatureLayers())
            {
                func.AddLayerToSnap(fl);
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            mapControl.AddLayers();
            mapControl.FunctionMode = FunctionMode.Pan;
        }

        private void zoomOut_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.ZoomOut;
        }

        private void clearTools_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
        }
        //创建图层
        private void createLayer_Click(object sender, EventArgs e)
        {
            NewShapefile newShape = new NewShapefile();
            newShape.TransfEvent += TransfEvent;
            newShape.ShowDialog();
        }

        //移动节点
        private void btnMoveVertex_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
            if (mapControl.Layers.Count > 0)
            {
                IMapFeatureLayer movableLayer = (IMapFeatureLayer)mapControl.Layers.SelectedLayer;
                moveVertexFunction = new MoveVertexFunction(mapControl);
                mapControl.MapFunctions.Add(moveVertexFunction);
                moveVertexFunction.Layer = movableLayer;
                moveVertexFunction.Activate();
                mapControl.Refresh();
                mapControl.ResetBuffer();
            }
        }

        private void tvTools_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            List<string> layerName = new List<string>();
            string selectedLayerName = tvTools.SelectedNode.Text.ToString();

            if (selectedLayerName == "缓冲区")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                Buffer buffer = new Buffer(layerName);
                buffer.bufferEvent += bufferEvent;
                buffer.ShowDialog();
            }
            if (selectedLayerName == "联合")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                Union union = new Union(layerName);
                union.unionEvent += unionEvent;
                union.ShowDialog();
            }
            if (selectedLayerName == "擦除")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                Erease erease = new Erease(layerName);
                erease.ereaseEvent += ereaseEvent;
                erease.ShowDialog();
            }
            if (selectedLayerName == "矢量转栅格")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                VectorToRaster VTR = new VectorToRaster(layers);
                VTR.VTREvent += VTREvent;
                VTR.ShowDialog();
            }
            if (selectedLayerName == "栅格转矢量")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                RasterToVertor RTV = new RasterToVertor(layerName);
                RTV.RTVEvent += RTVEvent;
                RTV.ShowDialog();
            }
            if (selectedLayerName == "相交")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                Intersect Sect = new Intersect(layerName);
                Sect.IntersectionEvent += IntersectionEvent;
                Sect.ShowDialog();
            }
            if (selectedLayerName == "交集取反")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                ReverseIntersect ReSect = new ReverseIntersect(layerName);
                ReSect.ReverseIntersectEvent += ReverseIntersectEvent;
                ReSect.ShowDialog();
            }
            if (selectedLayerName == "线分割面")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }
                ClipPolygonsWithLines ClipPoly = new ClipPolygonsWithLines(layerName);
                ClipPoly.ClipPolygonWithLineEvent += ClipPoly_ClipPolygonWithLineEvent;
                ClipPoly.ShowDialog();
            }
            if (selectedLayerName == "提取边界")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }

                ExtractBoundary ExtBound = new ExtractBoundary(layerName);
                ExtBound.ExtractBoundaryEvent += ExtBound_ExtractBoundaryEvent;
                ExtBound.ShowDialog();
            }
            if (selectedLayerName == "线打断线")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }

                InterruptLineWithLine InterruptLineWL = new InterruptLineWithLine(layerName);
                InterruptLineWL.InterruptLineWLEvent += InterruptLineWL_InterruptLineWLEvent;
                InterruptLineWL.ShowDialog();
            }
            if (selectedLayerName == "点打断线")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                    Console.Write(layer.LegendText);
                }

                InterruptLineWithPoint InterruptLineWP = new InterruptLineWithPoint(layerName);
                InterruptLineWP.InterruptLineWPEvent += InterruptLineWP_InterruptLineWPEvent;
                InterruptLineWP.ShowDialog();
            }
            if (selectedLayerName == "面分割面")
            {
                Map mainMap = mapControl as Map;
                List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
                foreach (ILayer layer in layers)
                {
                    layerName.Add(layer.LegendText);
                }

                ClipPolygonWithPolygon ClipPolygonWP = new ClipPolygonWithPolygon(layerName);
                ClipPolygonWP.ClipPolygonWPEvent += ClipPolygonWP_ClipPolygonWPEvent;
                ClipPolygonWP.ShowDialog();
            }
        }



        #region 委托注册事件
        private void ClipPolygonWP_ClipPolygonWPEvent(string WPolygonLayer, string TPolygonLayer, string RPolyLayer)
        {
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mapControl);
            IFeatureSet WPolygonFeatureSet = null;
            IFeatureSet TPolygonFeatureSet = null;
            IFeatureSet resultFeatureSet = new FeatureSet();

            resultFeatureSet.Filename = RPolyLayer;

            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == WPolygonLayer)
                {
                    WPolygonFeatureSet = (IFeatureSet)layer.DataSet;
                    if (WPolygonFeatureSet.FeatureType != FeatureType.Polygon)
                    {
                        MessageBox.Show("请选择面图层！");

                    }
                    break;
                }
            }
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == TPolygonLayer)
                {
                    TPolygonFeatureSet = (IFeatureSet)layer.DataSet;
                    break;
                }
            }

            bool clipSucceeded = CustomTools.SpatialAnalysis.ClipPoygonWithPolygon(WPolygonFeatureSet, TPolygonFeatureSet, resultFeatureSet);
            if (clipSucceeded)
            {
                resultFeatureSet.SaveAs(resultFeatureSet.Filename, true);
                mapControl.AddLayer(resultFeatureSet.Filename);
            }
        }
        //点打断线
        private void InterruptLineWP_InterruptLineWPEvent(string lineName, string pointName, string path)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            FeatureSet inTargetFS = null;
            FeatureSet inSourceFS = null;
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == lineName)
                {
                    inTargetFS = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == pointName)
                {
                    inSourceFS = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            IFeatureSet resultFeature = new FeatureSet(FeatureType.Line);

            bool interruptSucceeded = CustomTools.SpatialAnalysis.InterruptLinesWithPoints(inTargetFS, inSourceFS, ref resultFeature);
            if (interruptSucceeded)
            {
                resultFeature.SaveAs(path, true);
                mapControl.AddLayer(path);
            }

        }
        //线打断线
        private void InterruptLineWL_InterruptLineWLEvent(string selectedName, string targetName, string path)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            FeatureSet inTargetFS = null;
            FeatureSet inSourceFS = null;
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == selectedName)
                {
                    inTargetFS = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == targetName)
                {
                    inSourceFS = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            IFeatureSet resultFeature = new FeatureSet(FeatureType.Line);

            bool succeededInterrupt = CustomTools.SpatialAnalysis.InterruptLineWithLine(inTargetFS, inSourceFS, ref resultFeature);
            if (succeededInterrupt)
            {
                resultFeature.SaveAs(path, true);
                mapControl.AddLayer(path);
            }

        }
        //提取边界
        private void ExtBound_ExtractBoundaryEvent(string layerName, string path)
        {
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mapControl);
            FeatureSet polygon = new FeatureSet();
            FeatureSet boundary = new FeatureSet(FeatureType.Line);
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == layerName)
                {
                    polygon = (FeatureSet)layer.DataSet;
                    break;
                }
            }

            boundary = CustomTools.SpatialAnalysis.ExtractBoundary(polygon);

            boundary.SaveAs(path, true);
            mapControl.AddLayer(path);
        }
        //线分割面
        private void ClipPoly_ClipPolygonWithLineEvent(string linelayer, string polygonLayer, string resultLayer)
        {
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mapControl);
            IFeatureSet lineFeatureSet = null;
            IFeatureSet polygonFeatureSet = null;
            IFeatureSet resultFeatureSet = new FeatureSet();
            IFeatureSet result = new FeatureSet();
            List<IFeature> lineFeature = new List<IFeature>();
            List<IFeature> polygonFeature = new List<IFeature>();

            string resultPath = resultLayer;
            resultFeatureSet.Filename = resultPath;
            result.Filename = resultPath;

            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == linelayer)
                {
                    lineFeatureSet = (IFeatureSet)layer.DataSet;
                    break;
                }
            }
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == polygonLayer)
                {
                    polygonFeatureSet = (IFeatureSet)layer.DataSet;
                    break;
                }
            }

            IFeatureSet polygonFS = new FeatureSet(FeatureType.Polygon);
            List<int> indecies = new List<int>();
            polygonFS = polygonFeatureSet.CopySubset("");

            result = CustomTools.SpatialAnalysis.ClipPolygonByLine(polygonFeatureSet, lineFeatureSet, resultFeatureSet);
            if (result != null)
            {
                result.SaveAs(resultPath, true);
                mapControl.AddLayer(resultPath);
            }
        }
        //交集取反
        void ReverseIntersectEvent(string inlayer, string updateLayer, string path)
        {
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mapControl);
            FeatureSet resultFeatureSet = new FeatureSet();
            List<FeatureSet> inFeatureSets = new List<FeatureSet>();
            string[] layerNames = new string[2] { inlayer, updateLayer };
            foreach (string name in layerNames)
            {
                foreach (ILayer item in layers)
                {
                    if (item.LegendText == name)
                    {
                        FeatureSet fs = item.DataSet as FeatureSet;
                        inFeatureSets.Add(fs);
                    }
                }
            }

            IFeatureSet resultFeature = new FeatureSet(FeatureType.Polygon);
            resultFeature = CustomTools.SpatialAnalysis.SymmetricDiffence(inFeatureSets[0], inFeatureSets[1]);

            if (resultFeature != null)
            {
                resultFeature.SaveAs(path, true);
                mapControl.AddLayer(path);
            }
        }
        //相交
        void IntersectionEvent(List<string> layerName, string path)
        {
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mapControl);
            FeatureSet resultFeatureSet = new FeatureSet();
            List<FeatureSet> inFeatureSets = new List<FeatureSet>();
            foreach (string name in layerName)
            {
                foreach (ILayer item in layers)
                {
                    if (item.LegendText == name)
                    {
                        FeatureSet fs = item.DataSet as FeatureSet;
                        inFeatureSets.Add(fs);
                    }
                }
            }

            for (int i = 0; i < inFeatureSets.Count - 1; i++)
            {
                for (int j = i + 1; j < inFeatureSets.Count; j++)
                {
                    FeatureSet fs = new FeatureSet();

                    fs = CustomTools.SpatialAnalysis.Intersection(inFeatureSets[i], inFeatureSets[j]);
                    resultFeatureSet = CustomTools.SpatialAnalysis.AppendFeatures(resultFeatureSet, fs);
                }
            }

            if (resultFeatureSet != null)
            {
                resultFeatureSet.SaveAs(path, true);
                mapControl.AddLayer(path);
            }
        }
        //缓冲区
        void bufferEvent(string selectedLayerName, double bufferDistance, string path)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            IFeatureSet inFeatureSet = null;
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == selectedLayerName)
                {
                    inFeatureSet = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            double distance = bufferDistance;
            IFeatureSet iOutSet = new FeatureSet(FeatureType.Polygon);
            if (DotSpatial.Analysis.Buffer.AddBuffer(inFeatureSet, distance, iOutSet, null))
            {
                iOutSet.SaveAs(path, true);

                IMapLayer polygonlayer = (IMapLayer)mapControl.Layers.Add(iOutSet);
                polygonlayer.LegendText = Path.GetFileNameWithoutExtension(path); 
            }
        }
        //联合
        void unionEvent(string shapeName1, string shapeName2, string path)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            FeatureSet inFeatureSet1 = null;
            FeatureSet inFeatureSet2 = null;
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == shapeName1)
                {
                    inFeatureSet1 = (FeatureSet)layer.DataSet;
                }
                else
                {
                    inFeatureSet2 = (FeatureSet)layer.DataSet;
                }
            }

            FeatureSet resultFeature = new FeatureSet(FeatureType.Polygon);
            IFeatureSet eTFS, eSFS, eTFS1, eSFS1;

            //从一个中擦除另一个
            eTFS = inFeatureSet1;
            eSFS = inFeatureSet2;
            eTFS1 = inFeatureSet2;
            eSFS1 = inFeatureSet1;
            resultFeature.CopyTableSchema(inFeatureSet1);

            //求交
            resultFeature = CustomTools.SpatialAnalysis.Intersection(inFeatureSet1, inFeatureSet2);

            //求差
            List<FeatureSet> eResultSet = new List<FeatureSet>();
            eResultSet.Add(DotSpatial.Analysis.Overlay.EraseFeatures(eTFS, eSFS, null));
            eResultSet.Add(DotSpatial.Analysis.Overlay.EraseFeatures(eTFS1, eSFS1, null));

            foreach (FeatureSet fs in eResultSet)
            {
                for (int i = 0; i < fs.Features.Count; i++)
                {
                    resultFeature.AddFeature(fs.GetFeature(i)).CopyAttributes(fs.GetFeature(i));
                }
            }

            resultFeature.SaveAs(path, true);
            mapControl.AddLayer(path);
        }
        //擦除
        void ereaseEvent(string selectedName, string targetName, string path)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            FeatureSet inFeatureSet = null;
            FeatureSet inFeatureSet1 = null;
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == selectedName)
                {
                    inFeatureSet = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == targetName)
                {
                    inFeatureSet1 = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            IFeatureSet resultFeature = new FeatureSet(FeatureType.Polygon);
            resultFeature = DotSpatial.Analysis.Overlay.EraseFeatures(inFeatureSet, inFeatureSet1, null);
            resultFeature.SaveAs(path, true);
            mapControl.AddLayer(path);
        }
        //矢量转栅格
        void VTREvent(string featureName, double cellsize, string filedName, string outputFileName)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);
            IFeatureSet inFeatureSet = null;
            foreach (ILayer layer in layers)
            {
                if (layer.LegendText == featureName)
                {
                    inFeatureSet = (FeatureSet)layer.DataSet;
                    break;
                }
            }
            IFeatureSet iOutSet = new FeatureSet(FeatureType.Polygon);

            IRaster resultRaster = DotSpatial.Analysis.VectorToRaster.ToRaster(inFeatureSet, cellsize, filedName, outputFileName);//ICancelProgressHandler这个参数应该是控制进度的。
            resultRaster.Save();

            if (resultRaster != null)
            {
                mapControl.Layers.Add(resultRaster);
            }
        }
        //栅格转矢量
        void RTVEvent(string input, string outputFileName)
        {
            Map mainMap = mapControl as Map;
            IMapRasterLayer[] rasters;
            IRaster inRaster = null;
            FeatureSet outputFeatureSet = new FeatureSet(FeatureType.Polygon);
            outputFeatureSet.FilePath = outputFileName;
            if (mainMap != null)
            {
                rasters = mainMap.GetRasterLayers();
            }
            else
            {
                return;
            }
            foreach (RasterLayer raster in rasters)
            {
                if (raster.LegendText == input)
                {
                    inRaster = raster.DataSet as IRaster;//将单个IMapRasterLayer转换成IRaster
                }
            }

            if (RTVCore.Execute(inRaster, null, outputFeatureSet))
            {
                IMapLayer polygonlayer = (IMapLayer)mapControl.Layers.Add(outputFeatureSet);
                polygonlayer.LegendText = Path.GetFileName(outputFileName);
            }
        }
        //连接数据库传递TableName
        List<DataTable> DBTablelayer = new List<DataTable>();
        private void pullDTEvent(List<string> tableName, List<DataTable> table)
        {
            DBTree.Nodes.Clear();
            for (int i = 0; i < tableName.Count; i++)
            {
                TreeNode node = new TreeNode();
                node.Text = tableName[i];
                DBTree.Nodes.Add(node);
            }

            DBTablelayer = table;
        }
        #endregion

        private void btnLinkDB_Click(object sender, EventArgs e)
        {
            LinkDB ldb = new LinkDB();
            ldb.pullDTEvent += pullDTEvent;
            ldb.ShowDialog();
        }

        private void DBTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            GeoAPI.GeometryServiceProvider.Instance = NetTopologySuite.NtsGeometryServices.Instance;
            MsSql2008GeometryReader GeometryReader = new MsSql2008GeometryReader();

            foreach (DataTable table in DBTablelayer)
            {
                FeatureSet Fset = new FeatureSet();
                Fset.DataTable = table.Clone();
                string selectedStr = DBTree.SelectedNode.Text.ToString();
                if (table.TableName == selectedStr)
                {
                    foreach (DataRow tablerow in table.Rows)
                    {
                        SqlString s = new SqlString(tablerow["shape"].ToString());//逐行获取shape值。tablerow不能写死
                        SqlChars c = new SqlChars(s);
                        SqlGeometry p = SqlGeometry.STGeomFromText(c, 0);
                        IBasicGeometry geom = GeometryReader.Read(p).ToDotSpatial();
                        IFeature feature = Fset.AddFeature(geom);

                        for (int i = 0; i < table.Columns.Count; i++)
                        {
                            feature.DataRow[i] = tablerow[i];
                        }
                    }

                    IFeatureLayer lay = mapControl.Layers.Add(Fset);
                    lay.LegendText = table.TableName;
                    mapControl.ZoomToMaxExtent();
                }
            }
        }

        private void legend_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.Select;

            List<ILayer> layers = new List<ILayer>();
            layers = mapControl.GetAllLayers();
            foreach (ILayer layer in layers)
            {
                //if (1==1)
                //{
                //    MessageBox.Show(layer.LegendText);
                //}
            }
        }

        private void RemoveFeature_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            FeatureSet fs = new FeatureSet();
            FeatureLayer featureLayer = mainMap.Layers[mainMap.Layers.Count - 1] as FeatureLayer;
            fs = (FeatureSet)mainMap.Layers[mainMap.Layers.Count - 1].DataSet;
            featureLayer.RemoveSelectedFeatures();
            mainMap.Refresh();
        }


        private void btnSnapping_Click(object sender, EventArgs e)
        {
            if (btnSnapping.Checked == true)
            {
                btnSnapping.Checked = false;
                btnSnapping.ToolTipText = "捕捉节点关闭";
            }
            else
            {
                btnSnapping.Checked = true;
                btnSnapping.ToolTipText = "捕捉节点开启";
            }

            doSnapping = btnSnapping.Checked;

            AddShapeFunction addShapeFunc = new AddShapeFunction(mapControl);
            mapControl.MapFunctions.Add(addShapeFunc);
            SetSnapLayers2(addShapeFunc, mapControl);
            if (moveVertexFunction != null) moveVertexFunction.DoSnapping = doSnapping;
            if (addShapeFunction != null) addShapeFunction.DoSnapping = doSnapping;
        }

        private void tsbtnInterruptLineWithPoint_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
            tsmRremoveFeature.Visible = false;

            IMapFeatureLayer activeLayer = (IMapFeatureLayer)mapControl.Layers.SelectedLayer;
            if (activeLayer != null && activeLayer.DataSet.FeatureType == FeatureType.Line)
            {
                CustomTools.InterruptLineFunction irlFunc = new CustomTools.InterruptLineFunction(mapControl);
                mapControl.MapFunctions.Add(irlFunc);
                SetSnapLayers2(irlFunc, mapControl);
                irlFunc.Layer = activeLayer;
                irlFunc.Activate();
                if (mapControl != null)
                {
                    mapControl.Refresh();
                    mapControl.ResetBuffer();
                }
            }
            else
            {
                MessageBox.Show("请选择线图层", "提醒");
            }

        }

        private void tsmStartEditting_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

            foreach (ILayer layer in layers)
            {
                IFeatureLayer fly = layer as IFeatureLayer;
            }
            tsbClipRasterWP.Enabled = true;
            btnEdit.Enabled = true;
            btnMoveVertex.Enabled = true;
            btnSnapping.Enabled = true;
            tsbtnInterruptLineWithPoint.Enabled = true;
            tsmStartEditting.Enabled = false;
            tsmStopEditting.Enabled = true;
            mapControl.FunctionMode = FunctionMode.Select;
        }

        private void tsmStopEditting_Click(object sender, EventArgs e)
        {
            Map mainMap = mapControl as Map;
            List<ILayer> layers = CustomTools.GetAllLayers.Execute(mainMap);

            foreach (ILayer layer in layers)
            {
                IFeatureLayer fly = layer as IFeatureLayer;
            }

            tsbClipRasterWP.Enabled = false;
            btnEdit.Enabled = false;
            btnMoveVertex.Enabled = false;
            btnSnapping.Enabled = false;
            tsbtnInterruptLineWithPoint.Enabled = false;
            tsmStartEditting.Enabled = true;
            tsmStopEditting.Enabled = false;
            mapControl.FunctionMode = FunctionMode.Pan;
        }

        private void tsbClipRasterWP_Click(object sender, EventArgs e)
        {
            mapControl.FunctionMode = FunctionMode.None;
            tsmRremoveFeature.Visible = false;

            mapControl.Cursor = Cursors.Hand;
            CustomTools.AddPolygonFunction addPolygonFunction = new CustomTools.AddPolygonFunction(mapControl);
            mapControl.MapFunctions.Add(addPolygonFunction);
            
            //设置一个虚拟的可编辑面图层
            MapPolygonLayer mapPolygonLayer = new MapPolygonLayer();
            addPolygonFunction.Layer = mapPolygonLayer;

            //激活
            addPolygonFunction.Activate();
        }
    }
}



