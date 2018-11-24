namespace wkt
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("缓冲区");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("联合");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("擦除");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("相交");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("交集取反");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("线分割面");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("提取边界");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("线打断线");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("点打断线");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("面分割面");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("空间分析工具", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("矢量转栅格");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("栅格转矢量");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("转换工具", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFile = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.inputWKT = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Mapbrowsing = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToMax = new System.Windows.Forms.ToolStripMenuItem();
            this.pan = new System.Windows.Forms.ToolStripMenuItem();
            this.lastView = new System.Windows.Forms.ToolStripMenuItem();
            this.laterView = new System.Windows.Forms.ToolStripMenuItem();
            this.FeatureSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.clSelection = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertyTabelOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.showAtrributes = new System.Windows.Forms.ToolStripMenuItem();
            this.queryAttribute = new System.Windows.Forms.ToolStripMenuItem();
            this.Draw = new System.Windows.Forms.ToolStripMenuItem();
            this.createLayer = new System.Windows.Forms.ToolStripMenuItem();
            this.createFeatures = new System.Windows.Forms.ToolStripMenuItem();
            this.OtherOperation = new System.Windows.Forms.ToolStripMenuItem();
            this.coorPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleMeasure = new System.Windows.Forms.ToolStripMenuItem();
            this.printMap = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTools = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnNewShapefile = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnClearAllLayers = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExtent = new System.Windows.Forms.ToolStripButton();
            this.btnPan = new System.Windows.Forms.ToolStripButton();
            this.btnZoomIn = new System.Windows.Forms.ToolStripButton();
            this.btnZoomOut = new System.Windows.Forms.ToolStripButton();
            this.btnLastView = new System.Windows.Forms.ToolStripButton();
            this.btnLaterLayer = new System.Windows.Forms.ToolStripButton();
            this.btnSelectFeature = new System.Windows.Forms.ToolStripButton();
            this.btnClSelectedFeatures = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslEditting = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmStartEditting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStopEditting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSnapping = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnMoveVertex = new System.Windows.Forms.ToolStripButton();
            this.tsbtnInterruptLineWithPoint = new System.Windows.Forms.ToolStripButton();
            this.tsbClipRasterWP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnQueryAttriTable = new System.Windows.Forms.ToolStripButton();
            this.btnZoomToCoor = new System.Windows.Forms.ToolStripButton();
            this.btnQueryAttribute = new System.Windows.Forms.ToolStripButton();
            this.btnFindFreatrue = new System.Windows.Forms.ToolStripButton();
            this.btnMeasure = new System.Windows.Forms.ToolStripButton();
            this.btnWKTViewer = new System.Windows.Forms.ToolStripButton();
            this.btnExportWKT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLinkDB = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cmsMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmRremoveFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialStatusStrip = new DotSpatial.Controls.SpatialStatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsCoordinateStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.tabList = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.legend = new DotSpatial.Controls.Legend();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tvTools = new System.Windows.Forms.TreeView();
            this.DBList = new System.Windows.Forms.TabPage();
            this.DBTree = new System.Windows.Forms.TreeView();
            this.tabMap = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapControl = new DotSpatial.Controls.Map();
            this.spatialHeaderControl1 = new DotSpatial.Controls.SpatialHeaderControl();
            this.appManager = new DotSpatial.Controls.AppManager();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.cmsMap.SuspendLayout();
            this.spatialStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.DBList.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Mapbrowsing,
            this.FeatureSelection,
            this.PropertyTabelOperation,
            this.Draw,
            this.OtherOperation});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(876, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFile,
            this.clearFile,
            this.importExcel,
            this.inputWKT,
            this.saveAs,
            this.exit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(44, 21);
            this.File.Text = "文件";
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(171, 22);
            this.openFile.Text = "打开文件";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // clearFile
            // 
            this.clearFile.Name = "clearFile";
            this.clearFile.Size = new System.Drawing.Size(171, 22);
            this.clearFile.Text = "清除文件";
            this.clearFile.Click += new System.EventHandler(this.clearFile_Click);
            // 
            // importExcel
            // 
            this.importExcel.Name = "importExcel";
            this.importExcel.Size = new System.Drawing.Size(171, 22);
            this.importExcel.Text = "导入EXCEL";
            this.importExcel.Click += new System.EventHandler(this.importExcel_Click);
            // 
            // inputWKT
            // 
            this.inputWKT.Name = "inputWKT";
            this.inputWKT.Size = new System.Drawing.Size(171, 22);
            this.inputWKT.Text = "导入WKT";
            this.inputWKT.Click += new System.EventHandler(this.inputWKT_Click);
            // 
            // saveAs
            // 
            this.saveAs.Name = "saveAs";
            this.saveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAs.Size = new System.Drawing.Size(171, 22);
            this.saveAs.Text = "另存为";
            this.saveAs.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exit.Size = new System.Drawing.Size(171, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Mapbrowsing
            // 
            this.Mapbrowsing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomIn,
            this.zoomOut,
            this.zoomToMax,
            this.pan,
            this.lastView,
            this.laterView});
            this.Mapbrowsing.Name = "Mapbrowsing";
            this.Mapbrowsing.Size = new System.Drawing.Size(68, 21);
            this.Mapbrowsing.Text = "地图浏览";
            // 
            // zoomIn
            // 
            this.zoomIn.Name = "zoomIn";
            this.zoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.zoomIn.Size = new System.Drawing.Size(194, 22);
            this.zoomIn.Text = "放大地图";
            this.zoomIn.Click += new System.EventHandler(this.zoomIn_Click);
            // 
            // zoomOut
            // 
            this.zoomOut.Name = "zoomOut";
            this.zoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.zoomOut.Size = new System.Drawing.Size(194, 22);
            this.zoomOut.Text = "缩小地图";
            this.zoomOut.Click += new System.EventHandler(this.zoomOut_Click);
            // 
            // zoomToMax
            // 
            this.zoomToMax.Name = "zoomToMax";
            this.zoomToMax.Size = new System.Drawing.Size(194, 22);
            this.zoomToMax.Text = "显示全图";
            this.zoomToMax.Click += new System.EventHandler(this.zoomToMax_Click);
            // 
            // pan
            // 
            this.pan.Name = "pan";
            this.pan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pan.Size = new System.Drawing.Size(194, 22);
            this.pan.Text = "平移";
            this.pan.Click += new System.EventHandler(this.pan_Click);
            // 
            // lastView
            // 
            this.lastView.Name = "lastView";
            this.lastView.Size = new System.Drawing.Size(194, 22);
            this.lastView.Text = "前一视图";
            this.lastView.Click += new System.EventHandler(this.lastView_Click);
            // 
            // laterView
            // 
            this.laterView.Name = "laterView";
            this.laterView.Size = new System.Drawing.Size(194, 22);
            this.laterView.Text = "后一视图";
            this.laterView.Click += new System.EventHandler(this.laterView_Click);
            // 
            // FeatureSelection
            // 
            this.FeatureSelection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFeature,
            this.clSelection});
            this.FeatureSelection.Name = "FeatureSelection";
            this.FeatureSelection.Size = new System.Drawing.Size(68, 21);
            this.FeatureSelection.Text = "要素选择";
            // 
            // selectFeature
            // 
            this.selectFeature.Name = "selectFeature";
            this.selectFeature.Size = new System.Drawing.Size(148, 22);
            this.selectFeature.Text = "选择要素";
            this.selectFeature.Click += new System.EventHandler(this.selectFeature_Click);
            // 
            // clSelection
            // 
            this.clSelection.Name = "clSelection";
            this.clSelection.Size = new System.Drawing.Size(148, 22);
            this.clSelection.Text = "取消要素选择";
            this.clSelection.Click += new System.EventHandler(this.clSelection_Click);
            // 
            // PropertyTabelOperation
            // 
            this.PropertyTabelOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAtrributes,
            this.queryAttribute});
            this.PropertyTabelOperation.Name = "PropertyTabelOperation";
            this.PropertyTabelOperation.Size = new System.Drawing.Size(80, 21);
            this.PropertyTabelOperation.Text = "属性表操作";
            // 
            // showAtrributes
            // 
            this.showAtrributes.Name = "showAtrributes";
            this.showAtrributes.Size = new System.Drawing.Size(136, 22);
            this.showAtrributes.Text = "查看属性表";
            this.showAtrributes.Click += new System.EventHandler(this.showAtrributes_Click);
            // 
            // queryAttribute
            // 
            this.queryAttribute.Name = "queryAttribute";
            this.queryAttribute.Size = new System.Drawing.Size(136, 22);
            this.queryAttribute.Text = "属性查询";
            this.queryAttribute.Click += new System.EventHandler(this.queryAttribute_Click);
            // 
            // Draw
            // 
            this.Draw.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLayer,
            this.createFeatures});
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(68, 21);
            this.Draw.Text = "地图绘制";
            // 
            // createLayer
            // 
            this.createLayer.Name = "createLayer";
            this.createLayer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createLayer.Size = new System.Drawing.Size(195, 22);
            this.createLayer.Text = "创建要素图层";
            this.createLayer.Click += new System.EventHandler(this.createLayer_Click);
            // 
            // createFeatures
            // 
            this.createFeatures.Name = "createFeatures";
            this.createFeatures.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.createFeatures.Size = new System.Drawing.Size(195, 22);
            this.createFeatures.Text = "绘制要素";
            this.createFeatures.Click += new System.EventHandler(this.createFeatures_Click);
            // 
            // OtherOperation
            // 
            this.OtherOperation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coorPosition,
            this.simpleMeasure,
            this.printMap,
            this.clearTools});
            this.OtherOperation.Name = "OtherOperation";
            this.OtherOperation.Size = new System.Drawing.Size(68, 21);
            this.OtherOperation.Text = "其它操作";
            // 
            // coorPosition
            // 
            this.coorPosition.Name = "coorPosition";
            this.coorPosition.Size = new System.Drawing.Size(148, 22);
            this.coorPosition.Text = "坐标定位";
            this.coorPosition.Click += new System.EventHandler(this.coorPosition_Click);
            // 
            // simpleMeasure
            // 
            this.simpleMeasure.Name = "simpleMeasure";
            this.simpleMeasure.Size = new System.Drawing.Size(148, 22);
            this.simpleMeasure.Text = "简单计算";
            this.simpleMeasure.Click += new System.EventHandler(this.simpleMeasure_Click);
            // 
            // printMap
            // 
            this.printMap.Name = "printMap";
            this.printMap.Size = new System.Drawing.Size(148, 22);
            this.printMap.Text = "地图打印";
            this.printMap.Click += new System.EventHandler(this.printMap_Click);
            // 
            // clearTools
            // 
            this.clearTools.Name = "clearTools";
            this.clearTools.Size = new System.Drawing.Size(148, 22);
            this.clearTools.Text = "清除所有工具";
            this.clearTools.Click += new System.EventHandler(this.clearTools_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "11";
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnNewShapefile,
            this.btnSave,
            this.btnClearAllLayers,
            this.toolStripSeparator2,
            this.btnExtent,
            this.btnPan,
            this.btnZoomIn,
            this.btnZoomOut,
            this.btnLastView,
            this.btnLaterLayer,
            this.btnSelectFeature,
            this.btnClSelectedFeatures,
            this.toolStripSeparator1,
            this.tslEditting,
            this.btnSnapping,
            this.btnEdit,
            this.btnMoveVertex,
            this.tsbtnInterruptLineWithPoint,
            this.tsbClipRasterWP,
            this.toolStripSeparator4,
            this.btnQueryAttriTable,
            this.btnZoomToCoor,
            this.btnQueryAttribute,
            this.btnFindFreatrue,
            this.btnMeasure,
            this.btnWKTViewer,
            this.btnExportWKT,
            this.toolStripSeparator5,
            this.btnLinkDB});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(656, 25);
            this.toolStrip.TabIndex = 5;
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.ToolTipText = "打开文件,Ctrl+O";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNewShapefile
            // 
            this.btnNewShapefile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewShapefile.Image = ((System.Drawing.Image)(resources.GetObject("btnNewShapefile.Image")));
            this.btnNewShapefile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewShapefile.Name = "btnNewShapefile";
            this.btnNewShapefile.Size = new System.Drawing.Size(23, 22);
            this.btnNewShapefile.ToolTipText = "新建,Ctrl+N";
            this.btnNewShapefile.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.ToolTipText = "保存,Ctrl+S";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClearAllLayers
            // 
            this.btnClearAllLayers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearAllLayers.Image = ((System.Drawing.Image)(resources.GetObject("btnClearAllLayers.Image")));
            this.btnClearAllLayers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearAllLayers.Name = "btnClearAllLayers";
            this.btnClearAllLayers.Size = new System.Drawing.Size(23, 22);
            this.btnClearAllLayers.ToolTipText = "清除所有图层";
            this.btnClearAllLayers.Click += new System.EventHandler(this.btnClearAllLayers_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExtent
            // 
            this.btnExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExtent.Image = ((System.Drawing.Image)(resources.GetObject("btnExtent.Image")));
            this.btnExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExtent.Name = "btnExtent";
            this.btnExtent.Size = new System.Drawing.Size(23, 22);
            this.btnExtent.ToolTipText = "显示全图";
            this.btnExtent.Click += new System.EventHandler(this.btnExtent_Click);
            // 
            // btnPan
            // 
            this.btnPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPan.Image = ((System.Drawing.Image)(resources.GetObject("btnPan.Image")));
            this.btnPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(23, 22);
            this.btnPan.ToolTipText = "平移";
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 22);
            this.btnZoomIn.ToolTipText = "放大,Ctrl+Up";
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 22);
            this.btnZoomOut.ToolTipText = "缩小,Ctrl+Down";
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnLastView
            // 
            this.btnLastView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLastView.Image = ((System.Drawing.Image)(resources.GetObject("btnLastView.Image")));
            this.btnLastView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLastView.Name = "btnLastView";
            this.btnLastView.Size = new System.Drawing.Size(23, 22);
            this.btnLastView.ToolTipText = "返回上一视图";
            this.btnLastView.Click += new System.EventHandler(this.btnLastView_Click);
            // 
            // btnLaterLayer
            // 
            this.btnLaterLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLaterLayer.Image = ((System.Drawing.Image)(resources.GetObject("btnLaterLayer.Image")));
            this.btnLaterLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLaterLayer.Name = "btnLaterLayer";
            this.btnLaterLayer.Size = new System.Drawing.Size(23, 22);
            this.btnLaterLayer.ToolTipText = "返回下一视图";
            this.btnLaterLayer.Click += new System.EventHandler(this.btnLaterLayer_Click);
            // 
            // btnSelectFeature
            // 
            this.btnSelectFeature.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelectFeature.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFeature.Image")));
            this.btnSelectFeature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectFeature.Name = "btnSelectFeature";
            this.btnSelectFeature.Size = new System.Drawing.Size(23, 22);
            this.btnSelectFeature.ToolTipText = "选择要素，按住Shift多选";
            this.btnSelectFeature.Click += new System.EventHandler(this.btnSelectFeature_Click);
            // 
            // btnClSelectedFeatures
            // 
            this.btnClSelectedFeatures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClSelectedFeatures.Image = ((System.Drawing.Image)(resources.GetObject("btnClSelectedFeatures.Image")));
            this.btnClSelectedFeatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClSelectedFeatures.Name = "btnClSelectedFeatures";
            this.btnClSelectedFeatures.Size = new System.Drawing.Size(23, 22);
            this.btnClSelectedFeatures.ToolTipText = "清除要素选择";
            this.btnClSelectedFeatures.Click += new System.EventHandler(this.btnCancelSelect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tslEditting
            // 
            this.tslEditting.AutoToolTip = false;
            this.tslEditting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStartEditting,
            this.tsmStopEditting});
            this.tslEditting.Name = "tslEditting";
            this.tslEditting.Size = new System.Drawing.Size(45, 22);
            this.tslEditting.Text = "编辑";
            // 
            // tsmStartEditting
            // 
            this.tsmStartEditting.Name = "tsmStartEditting";
            this.tsmStartEditting.Size = new System.Drawing.Size(180, 22);
            this.tsmStartEditting.Text = "开始编辑";
            this.tsmStartEditting.Click += new System.EventHandler(this.tsmStartEditting_Click);
            // 
            // tsmStopEditting
            // 
            this.tsmStopEditting.Name = "tsmStopEditting";
            this.tsmStopEditting.Size = new System.Drawing.Size(180, 22);
            this.tsmStopEditting.Text = "停止编辑";
            this.tsmStopEditting.Click += new System.EventHandler(this.tsmStopEditting_Click);
            // 
            // btnSnapping
            // 
            this.btnSnapping.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSnapping.Image = ((System.Drawing.Image)(resources.GetObject("btnSnapping.Image")));
            this.btnSnapping.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSnapping.Name = "btnSnapping";
            this.btnSnapping.Size = new System.Drawing.Size(23, 22);
            this.btnSnapping.Text = "捕捉节点";
            this.btnSnapping.ToolTipText = "捕捉设置";
            this.btnSnapping.Click += new System.EventHandler(this.btnSnapping_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "编辑,Ctrl+D";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMoveVertex
            // 
            this.btnMoveVertex.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoveVertex.Image = ((System.Drawing.Image)(resources.GetObject("btnMoveVertex.Image")));
            this.btnMoveVertex.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMoveVertex.Name = "btnMoveVertex";
            this.btnMoveVertex.Size = new System.Drawing.Size(23, 22);
            this.btnMoveVertex.ToolTipText = "移动节点";
            this.btnMoveVertex.Click += new System.EventHandler(this.btnMoveVertex_Click);
            // 
            // tsbtnInterruptLineWithPoint
            // 
            this.tsbtnInterruptLineWithPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnInterruptLineWithPoint.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInterruptLineWithPoint.Image")));
            this.tsbtnInterruptLineWithPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInterruptLineWithPoint.Name = "tsbtnInterruptLineWithPoint";
            this.tsbtnInterruptLineWithPoint.Size = new System.Drawing.Size(23, 22);
            this.tsbtnInterruptLineWithPoint.Text = "点打断线";
            this.tsbtnInterruptLineWithPoint.Click += new System.EventHandler(this.tsbtnInterruptLineWithPoint_Click);
            // 
            // tsbClipRasterWP
            // 
            this.tsbClipRasterWP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClipRasterWP.Image = ((System.Drawing.Image)(resources.GetObject("tsbClipRasterWP.Image")));
            this.tsbClipRasterWP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClipRasterWP.Name = "tsbClipRasterWP";
            this.tsbClipRasterWP.Size = new System.Drawing.Size(23, 22);
            this.tsbClipRasterWP.Text = "toolStripButton1";
            this.tsbClipRasterWP.ToolTipText = "面要素分割栅格";
            this.tsbClipRasterWP.Click += new System.EventHandler(this.tsbClipRasterWP_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnQueryAttriTable
            // 
            this.btnQueryAttriTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQueryAttriTable.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryAttriTable.Image")));
            this.btnQueryAttriTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueryAttriTable.Name = "btnQueryAttriTable";
            this.btnQueryAttriTable.Size = new System.Drawing.Size(23, 22);
            this.btnQueryAttriTable.ToolTipText = "查看图层属性表";
            this.btnQueryAttriTable.Click += new System.EventHandler(this.btnQueryAttributes_Click);
            // 
            // btnZoomToCoor
            // 
            this.btnZoomToCoor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnZoomToCoor.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomToCoor.Image")));
            this.btnZoomToCoor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnZoomToCoor.Name = "btnZoomToCoor";
            this.btnZoomToCoor.Size = new System.Drawing.Size(23, 22);
            this.btnZoomToCoor.ToolTipText = "定位到位置";
            this.btnZoomToCoor.Click += new System.EventHandler(this.btnZoomToCoor_Click);
            // 
            // btnQueryAttribute
            // 
            this.btnQueryAttribute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnQueryAttribute.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryAttribute.Image")));
            this.btnQueryAttribute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQueryAttribute.Name = "btnQueryAttribute";
            this.btnQueryAttribute.Size = new System.Drawing.Size(23, 22);
            this.btnQueryAttribute.ToolTipText = "查询要素属性";
            this.btnQueryAttribute.Click += new System.EventHandler(this.btnQueryAttri_Click);
            // 
            // btnFindFreatrue
            // 
            this.btnFindFreatrue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFindFreatrue.Image = ((System.Drawing.Image)(resources.GetObject("btnFindFreatrue.Image")));
            this.btnFindFreatrue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFindFreatrue.Name = "btnFindFreatrue";
            this.btnFindFreatrue.Size = new System.Drawing.Size(23, 22);
            this.btnFindFreatrue.ToolTipText = "查找要素";
            this.btnFindFreatrue.Click += new System.EventHandler(this.btnFindFreatrue_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMeasure.Image = ((System.Drawing.Image)(resources.GetObject("btnMeasure.Image")));
            this.btnMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(23, 22);
            this.btnMeasure.ToolTipText = "简单测量";
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnWKTViewer
            // 
            this.btnWKTViewer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWKTViewer.Image = ((System.Drawing.Image)(resources.GetObject("btnWKTViewer.Image")));
            this.btnWKTViewer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWKTViewer.Name = "btnWKTViewer";
            this.btnWKTViewer.Size = new System.Drawing.Size(23, 22);
            this.btnWKTViewer.Text = "查看要素WKT";
            this.btnWKTViewer.ToolTipText = "查看要素WKT文本";
            this.btnWKTViewer.Click += new System.EventHandler(this.btnCheckWKT_Click);
            // 
            // btnExportWKT
            // 
            this.btnExportWKT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportWKT.Image = ((System.Drawing.Image)(resources.GetObject("btnExportWKT.Image")));
            this.btnExportWKT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportWKT.Name = "btnExportWKT";
            this.btnExportWKT.Size = new System.Drawing.Size(23, 22);
            this.btnExportWKT.Text = "toolStripButton16";
            this.btnExportWKT.ToolTipText = "当前图层导出为WKT文本";
            this.btnExportWKT.Click += new System.EventHandler(this.btnExportWKT_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLinkDB
            // 
            this.btnLinkDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLinkDB.Image = global::wkt.Properties.Resources.if_eccomerce___wallet_3440917;
            this.btnLinkDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLinkDB.Name = "btnLinkDB";
            this.btnLinkDB.Size = new System.Drawing.Size(23, 22);
            this.btnLinkDB.Text = "连接数据库";
            this.btnLinkDB.Click += new System.EventHandler(this.btnLinkDB_Click);
            // 
            // cmsMap
            // 
            this.cmsMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRremoveFeature});
            this.cmsMap.Name = "cmsMap";
            this.cmsMap.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmRremoveFeature
            // 
            this.tsmRremoveFeature.Name = "tsmRremoveFeature";
            this.tsmRremoveFeature.Size = new System.Drawing.Size(100, 22);
            this.tsmRremoveFeature.Text = "删除";
            this.tsmRremoveFeature.Click += new System.EventHandler(this.RemoveFeature_Click);
            // 
            // spatialStatusStrip
            // 
            this.spatialStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsCoordinateStatus});
            this.spatialStatusStrip.Location = new System.Drawing.Point(0, 530);
            this.spatialStatusStrip.Name = "spatialStatusStrip";
            this.spatialStatusStrip.ProgressBar = null;
            this.spatialStatusStrip.ProgressLabel = this.toolStripStatusLabel1;
            this.spatialStatusStrip.Size = new System.Drawing.Size(876, 22);
            this.spatialStatusStrip.TabIndex = 4;
            this.spatialStatusStrip.Text = "spatialStatusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(430, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.ToolTipText = "当前坐标";
            // 
            // tsCoordinateStatus
            // 
            this.tsCoordinateStatus.Name = "tsCoordinateStatus";
            this.tsCoordinateStatus.Size = new System.Drawing.Size(430, 17);
            this.tsCoordinateStatus.Spring = true;
            this.tsCoordinateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsCoordinateStatus.ToolTipText = "当前坐标";
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spatialDockManager1.Location = new System.Drawing.Point(0, 53);
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.tabList);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.tabMap);
            this.spatialDockManager1.Size = new System.Drawing.Size(876, 474);
            this.spatialDockManager1.SplitterDistance = 240;
            this.spatialDockManager1.TabControl1 = this.tabList;
            this.spatialDockManager1.TabControl2 = this.tabMap;
            this.spatialDockManager1.TabIndex = 1;
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.tabPage1);
            this.tabList.Controls.Add(this.tabPage3);
            this.tabList.Controls.Add(this.DBList);
            this.tabList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabList.Location = new System.Drawing.Point(0, 0);
            this.tabList.Name = "tabList";
            this.tabList.SelectedIndex = 0;
            this.tabList.Size = new System.Drawing.Size(240, 474);
            this.tabList.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.legend);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(232, 448);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图例";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // legend
            // 
            this.legend.BackColor = System.Drawing.Color.White;
            this.legend.ControlRectangle = new System.Drawing.Rectangle(0, 0, 226, 442);
            this.legend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend.HorizontalScrollEnabled = true;
            this.legend.Indentation = 30;
            this.legend.IsInitialized = false;
            this.legend.Location = new System.Drawing.Point(3, 3);
            this.legend.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend.Name = "legend";
            this.legend.ProgressHandler = null;
            this.legend.ResetOnResize = false;
            this.legend.SelectionFontColor = System.Drawing.Color.Black;
            this.legend.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend.Size = new System.Drawing.Size(226, 442);
            this.legend.TabIndex = 0;
            this.legend.Text = "图例";
            this.legend.VerticalScrollEnabled = true;
            this.legend.Click += new System.EventHandler(this.legend_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tvTools);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(232, 448);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "工具";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tvTools
            // 
            this.tvTools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvTools.Location = new System.Drawing.Point(0, 0);
            this.tvTools.Name = "tvTools";
            treeNode1.Name = "节点4";
            treeNode1.Text = "缓冲区";
            treeNode2.Name = "节点5";
            treeNode2.Text = "联合";
            treeNode3.Name = "节点6";
            treeNode3.Text = "擦除";
            treeNode4.Name = "节点0";
            treeNode4.Text = "相交";
            treeNode5.Name = "节点1";
            treeNode5.Text = "交集取反";
            treeNode6.Name = "节点0";
            treeNode6.Text = "线分割面";
            treeNode7.Name = "节点0";
            treeNode7.Text = "提取边界";
            treeNode8.Name = "节点0";
            treeNode8.Text = "线打断线";
            treeNode9.Name = "节点0";
            treeNode9.Text = "点打断线";
            treeNode10.Name = "节点0";
            treeNode10.Text = "面分割面";
            treeNode11.Name = "节点3";
            treeNode11.Text = "空间分析工具";
            treeNode12.Name = "节点1";
            treeNode12.Text = "矢量转栅格";
            treeNode13.Name = "节点2";
            treeNode13.Text = "栅格转矢量";
            treeNode14.Name = "节点7";
            treeNode14.Text = "转换工具";
            this.tvTools.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode14});
            this.tvTools.Size = new System.Drawing.Size(232, 448);
            this.tvTools.TabIndex = 1;
            this.tvTools.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvTools_NodeMouseDoubleClick);
            // 
            // DBList
            // 
            this.DBList.Controls.Add(this.DBTree);
            this.DBList.Location = new System.Drawing.Point(4, 22);
            this.DBList.Name = "DBList";
            this.DBList.Padding = new System.Windows.Forms.Padding(3);
            this.DBList.Size = new System.Drawing.Size(232, 448);
            this.DBList.TabIndex = 2;
            this.DBList.Text = "数据库";
            this.DBList.UseVisualStyleBackColor = true;
            // 
            // DBTree
            // 
            this.DBTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DBTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DBTree.Location = new System.Drawing.Point(3, 3);
            this.DBTree.Name = "DBTree";
            this.DBTree.Size = new System.Drawing.Size(226, 442);
            this.DBTree.TabIndex = 0;
            this.DBTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DBTree_NodeMouseDoubleClick);
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.tabPage2);
            this.tabMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMap.Location = new System.Drawing.Point(0, 0);
            this.tabMap.Name = "tabMap";
            this.tabMap.SelectedIndex = 0;
            this.tabMap.Size = new System.Drawing.Size(632, 474);
            this.tabMap.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mapControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 448);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "地图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mapControl
            // 
            this.mapControl.AllowDrop = true;
            this.mapControl.AutoSize = true;
            this.mapControl.BackColor = System.Drawing.Color.White;
            this.mapControl.CollectAfterDraw = false;
            this.mapControl.CollisionDetection = false;
            this.mapControl.ContextMenuStrip = this.cmsMap;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.ExtendBuffer = false;
            this.mapControl.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.mapControl.IsBusy = false;
            this.mapControl.IsZoomedToMaxExtent = false;
            this.mapControl.Legend = this.legend;
            this.mapControl.Location = new System.Drawing.Point(3, 3);
            this.mapControl.Name = "mapControl";
            this.mapControl.ProgressHandler = null;
            this.mapControl.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.mapControl.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.mapControl.RedrawLayersWhileResizing = false;
            this.mapControl.SelectionEnabled = true;
            this.mapControl.Size = new System.Drawing.Size(618, 442);
            this.mapControl.TabIndex = 0;
            this.mapControl.ZoomOutFartherThanMaxExtent = false;
            this.mapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mapControl_MouseMove);
            // 
            // spatialHeaderControl1
            // 
            this.spatialHeaderControl1.ApplicationManager = null;
            this.spatialHeaderControl1.MenuStrip = null;
            this.spatialHeaderControl1.ToolbarsContainer = null;
            // 
            // appManager
            // 
            this.appManager.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("appManager.Directories")));
            this.appManager.DockManager = this.spatialDockManager1;
            this.appManager.HeaderControl = this.spatialHeaderControl1;
            this.appManager.Legend = this.legend;
            this.appManager.Map = this.mapControl;
            this.appManager.ProgressHandler = this.spatialStatusStrip;
            this.appManager.ShowExtensionsDialogMode = DotSpatial.Controls.ShowExtensionsDialogMode.MapGlyph;
            // 
            // mainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(876, 552);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.spatialStatusStrip);
            this.Controls.Add(this.spatialDockManager1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(610, 400);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DotSpatial通用工具";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.cmsMap.ResumeLayout(false);
            this.spatialStatusStrip.ResumeLayout(false);
            this.spatialStatusStrip.PerformLayout();
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.DBList.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.AppManager appManager;
        private System.Windows.Forms.MenuStrip menuStrip;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem openFile;
        private System.Windows.Forms.ToolStripMenuItem clearFile;
        private System.Windows.Forms.ToolStripMenuItem inputWKT;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private DotSpatial.Controls.Legend legend;
        private DotSpatial.Controls.Map mapControl;
        private System.Windows.Forms.ToolStripMenuItem Mapbrowsing;
        private System.Windows.Forms.ToolStripMenuItem zoomIn;
        private System.Windows.Forms.ToolStripMenuItem zoomOut;
        private System.Windows.Forms.ToolStripMenuItem zoomToMax;
        private System.Windows.Forms.ToolStripMenuItem pan;
        private System.Windows.Forms.ToolStripMenuItem OtherOperation;
        private DotSpatial.Controls.SpatialHeaderControl spatialHeaderControl1;
        private System.Windows.Forms.ToolStripMenuItem saveAs;
        private System.Windows.Forms.ToolStripMenuItem FeatureSelection;
        private System.Windows.Forms.ToolStripMenuItem selectFeature;
        private System.Windows.Forms.ToolStripMenuItem clSelection;
        private System.Windows.Forms.ToolStripMenuItem simpleMeasure;
        private System.Windows.Forms.ToolStripMenuItem printMap;
        private System.Windows.Forms.ToolStripMenuItem PropertyTabelOperation;
        private System.Windows.Forms.ToolStripMenuItem showAtrributes;
        private System.Windows.Forms.ToolStripMenuItem queryAttribute;
        private System.Windows.Forms.ToolStripMenuItem coorPosition;
        private System.Windows.Forms.ToolStripMenuItem lastView;
        private System.Windows.Forms.ToolStripMenuItem laterView;
        private System.Windows.Forms.ToolStripMenuItem importExcel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnClearAllLayers;
        private System.Windows.Forms.ToolStripButton btnPan;
        private System.Windows.Forms.ToolStripButton btnZoomIn;
        private System.Windows.Forms.ToolStripButton btnZoomOut;
        private System.Windows.Forms.ToolStripButton btnExtent;
        private System.Windows.Forms.ToolStripButton btnLastView;
        private System.Windows.Forms.ToolStripButton btnLaterLayer;
        private System.Windows.Forms.ToolStripButton btnZoomToCoor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSelectFeature;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnQueryAttribute;
        private System.Windows.Forms.ToolStripButton btnFindFreatrue;
        private System.Windows.Forms.ToolStripButton btnMeasure;
        private System.Windows.Forms.ToolStripButton btnQueryAttriTable;
        private System.Windows.Forms.TabControl tabList;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabMap;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton btnClSelectedFeatures;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton btnExportWKT;
        private System.Windows.Forms.ToolStripButton btnWKTViewer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolTip toolTip;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsCoordinateStatus;
        private System.Windows.Forms.ToolStripButton btnNewShapefile;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripMenuItem clearTools;
        private System.Windows.Forms.ToolStripMenuItem Draw;
        private System.Windows.Forms.ToolStripMenuItem createLayer;
        private System.Windows.Forms.ToolStripMenuItem createFeatures;
        private System.Windows.Forms.ToolStripButton btnMoveVertex;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView tvTools;
        private System.Windows.Forms.ToolStripButton btnLinkDB;
        private System.Windows.Forms.TabPage DBList;
        private System.Windows.Forms.TreeView DBTree;
        private System.Windows.Forms.ContextMenuStrip cmsMap;
        private System.Windows.Forms.ToolStripMenuItem tsmRremoveFeature;
        private System.Windows.Forms.ToolStripButton btnSnapping;
        private System.Windows.Forms.ToolStripButton tsbtnInterruptLineWithPoint;
        private System.Windows.Forms.ToolStripDropDownButton tslEditting;
        private System.Windows.Forms.ToolStripMenuItem tsmStopEditting;
        private System.Windows.Forms.ToolStripMenuItem tsmStartEditting;
        private System.Windows.Forms.ToolStripButton tsbClipRasterWP;
    }
}

