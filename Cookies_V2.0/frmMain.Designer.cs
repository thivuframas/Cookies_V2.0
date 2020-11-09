namespace Cookies_V2._0
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.windowsUIView = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(this.components);
            this.tileContainer = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(this.components);
            this.ucScaleManualTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroup1 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.ucShiftInfoDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucItemInfoDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucScaleManualDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucScalewScanTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.pageGroup2 = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup(this.components);
            this.ucScalewScanDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.ucStatisticTile = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(this.components);
            this.ucStatisticDocument = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(this.components);
            this.closeAppFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.saveFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.saveWeightFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            this.finishScaleCookiesFlyout = new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScaleManualTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucShiftInfoDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucItemInfoDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScaleManualDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScalewScanTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScalewScanDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucStatisticTile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucStatisticDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppFlyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFlyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveWeightFlyout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishScaleCookiesFlyout)).BeginInit();
            this.SuspendLayout();
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.windowsUIView;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.windowsUIView});
            // 
            // windowsUIView
            // 
            this.windowsUIView.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI Light", 36F);
            this.windowsUIView.AppearanceCaption.Options.UseFont = true;
            this.windowsUIView.Caption = "Scan & Scale Cookies";
            this.windowsUIView.ContentContainers.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer[] {
            this.tileContainer,
            this.pageGroup1,
            this.pageGroup2,
            this.closeAppFlyout,
            this.saveFlyout,
            this.saveWeightFlyout,
            this.finishScaleCookiesFlyout});
            this.windowsUIView.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.ucScaleManualDocument,
            this.ucStatisticDocument,
            this.ucScalewScanDocument,
            this.ucShiftInfoDocument,
            this.ucItemInfoDocument});
            this.windowsUIView.Tiles.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.ucScaleManualTile,
            this.ucStatisticTile,
            this.ucScalewScanTile});
            // 
            // tileContainer
            // 
            this.tileContainer.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile[] {
            this.ucScaleManualTile,
            this.ucScalewScanTile,
            this.ucStatisticTile});
            this.tileContainer.Name = "tileContainer1";
            this.tileContainer.Properties.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.tileContainer.Properties.ShowGroupText = DevExpress.Utils.DefaultBoolean.True;
            // 
            // ucScaleManualTile
            // 
            this.ucScaleManualTile.ActivationTarget = this.pageGroup1;
            this.ucScaleManualTile.Document = this.ucShiftInfoDocument;
            tileItemElement1.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement1.Appearance.Hovered.Options.UseFont = true;
            tileItemElement1.Appearance.Hovered.Options.UseTextOptions = true;
            tileItemElement1.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement1.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement1.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement1.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement1.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement1.Appearance.Selected.Options.UseFont = true;
            tileItemElement1.Appearance.Selected.Options.UseTextOptions = true;
            tileItemElement1.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement1.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement1.ImageOptions.ImageLocation = new System.Drawing.Point(6, 4);
            tileItemElement1.MaxWidth = 240;
            tileItemElement1.Text = "Scale Cookies with manual";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement1.TextLocation = new System.Drawing.Point(118, 4);
            tileItemElement2.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement2.Appearance.Hovered.Options.UseFont = true;
            tileItemElement2.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement2.Appearance.Normal.Options.UseFont = true;
            tileItemElement2.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement2.Appearance.Selected.Options.UseFont = true;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement2.ImageOptions.ImageLocation = new System.Drawing.Point(12, 16);
            tileItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement2.ImageOptions.ImageSize = new System.Drawing.Size(96, 96);
            tileItemElement2.TextLocation = new System.Drawing.Point(6, 4);
            this.ucScaleManualTile.Elements.Add(tileItemElement1);
            this.ucScaleManualTile.Elements.Add(tileItemElement2);
            this.tileContainer.SetID(this.ucScaleManualTile, 5);
            this.ucScaleManualTile.Name = "ucScaleManualTile";
            this.ucScaleManualTile.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ucScaleManualTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // pageGroup1
            // 
            this.pageGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucShiftInfoDocument,
            this.ucItemInfoDocument,
            this.ucScaleManualDocument});
            this.pageGroup1.Name = "pageGroup1";
            this.pageGroup1.Parent = this.tileContainer;
            // 
            // ucShiftInfoDocument
            // 
            this.ucShiftInfoDocument.Caption = "Thông tin ca làm việc";
            this.ucShiftInfoDocument.ControlName = "ucShiftInfo";
            this.ucShiftInfoDocument.ControlTypeName = "Cookies_V2._0.Views.ucShiftInfo";
            // 
            // ucItemInfoDocument
            // 
            this.ucItemInfoDocument.Caption = "Thông tin sản phẩm";
            this.ucItemInfoDocument.ControlName = "ucItemInfo";
            this.ucItemInfoDocument.ControlTypeName = "Cookies_V2._0.Views.ucItemInfo";
            // 
            // ucScaleManualDocument
            // 
            this.ucScaleManualDocument.Caption = "Cân Cookies";
            this.ucScaleManualDocument.ControlName = "ucScaleManual";
            this.ucScaleManualDocument.ControlTypeName = "Cookies_V2._0.Views.ucScaleManual";
            // 
            // ucScalewScanTile
            // 
            this.ucScalewScanTile.ActivationTarget = this.pageGroup2;
            this.ucScalewScanTile.Document = this.ucScalewScanDocument;
            tileItemElement3.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement3.Appearance.Hovered.Options.UseFont = true;
            tileItemElement3.Appearance.Hovered.Options.UseTextOptions = true;
            tileItemElement3.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement3.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement3.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement3.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement3.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement3.Appearance.Selected.Options.UseFont = true;
            tileItemElement3.Appearance.Selected.Options.UseTextOptions = true;
            tileItemElement3.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement3.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement3.ImageOptions.ImageLocation = new System.Drawing.Point(6, 4);
            tileItemElement3.MaxWidth = 240;
            tileItemElement3.Text = "Scale Cookies with Mixing label";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement3.TextLocation = new System.Drawing.Point(118, 4);
            tileItemElement4.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement4.Appearance.Hovered.Options.UseFont = true;
            tileItemElement4.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement4.Appearance.Normal.Options.UseFont = true;
            tileItemElement4.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement4.Appearance.Selected.Options.UseFont = true;
            tileItemElement4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement4.ImageOptions.ImageLocation = new System.Drawing.Point(12, 16);
            tileItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement4.ImageOptions.ImageSize = new System.Drawing.Size(96, 96);
            tileItemElement4.TextLocation = new System.Drawing.Point(6, 4);
            this.ucScalewScanTile.Elements.Add(tileItemElement3);
            this.ucScalewScanTile.Elements.Add(tileItemElement4);
            this.tileContainer.SetID(this.ucScalewScanTile, 3);
            this.ucScalewScanTile.Name = "ucScalewScanTile";
            this.ucScalewScanTile.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ucScalewScanTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // pageGroup2
            // 
            this.pageGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document[] {
            this.ucItemInfoDocument,
            this.ucShiftInfoDocument,
            this.ucScaleManualDocument});
            this.pageGroup2.Name = "pageGroup2";
            this.pageGroup2.Parent = this.tileContainer;
            // 
            // ucScalewScanDocument
            // 
            this.ucScalewScanDocument.Caption = "Cân Cookies";
            this.ucScalewScanDocument.ControlName = "ucScalewScan";
            this.ucScalewScanDocument.ControlTypeName = "Cookies_V2._0.Views.ucScalewScan";
            // 
            // ucStatisticTile
            // 
            this.ucStatisticTile.Document = this.ucStatisticDocument;
            tileItemElement5.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement5.Appearance.Hovered.Options.UseFont = true;
            tileItemElement5.Appearance.Hovered.Options.UseTextOptions = true;
            tileItemElement5.Appearance.Hovered.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement5.Appearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement5.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Appearance.Normal.Options.UseTextOptions = true;
            tileItemElement5.Appearance.Normal.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement5.Appearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement5.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI Light", 25.5F);
            tileItemElement5.Appearance.Selected.Options.UseFont = true;
            tileItemElement5.Appearance.Selected.Options.UseTextOptions = true;
            tileItemElement5.Appearance.Selected.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            tileItemElement5.Appearance.Selected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            tileItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement5.ImageOptions.ImageLocation = new System.Drawing.Point(6, 4);
            tileItemElement5.MaxWidth = 240;
            tileItemElement5.Text = "Statistic";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement5.TextLocation = new System.Drawing.Point(118, 4);
            tileItemElement6.Appearance.Hovered.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement6.Appearance.Hovered.Options.UseFont = true;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Appearance.Selected.Font = new System.Drawing.Font("Segoe UI", 12.375F);
            tileItemElement6.Appearance.Selected.Options.UseFont = true;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual;
            tileItemElement6.ImageOptions.ImageLocation = new System.Drawing.Point(12, 16);
            tileItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomOutside;
            tileItemElement6.ImageOptions.ImageSize = new System.Drawing.Size(96, 96);
            tileItemElement6.TextLocation = new System.Drawing.Point(6, 4);
            this.ucStatisticTile.Elements.Add(tileItemElement5);
            this.ucStatisticTile.Elements.Add(tileItemElement6);
            this.tileContainer.SetID(this.ucStatisticTile, 1);
            this.ucStatisticTile.Name = "ucStatisticTile";
            this.ucStatisticTile.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.ucStatisticTile.Properties.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            // 
            // ucStatisticDocument
            // 
            this.ucStatisticDocument.Caption = "Thống kê";
            this.ucStatisticDocument.ControlName = "ucStatistic";
            this.ucStatisticDocument.ControlTypeName = "Cookies_V2._0.Views.ucStatistic";
            // 
            // closeAppFlyout
            // 
            this.closeAppFlyout.Name = "closeAppFlyout";
            this.closeAppFlyout.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.closeAppFlyout.Properties.Appearance.Options.UseBackColor = true;
            this.closeAppFlyout.Properties.AppearanceButtons.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.closeAppFlyout.Properties.AppearanceButtons.ForeColor = System.Drawing.Color.White;
            this.closeAppFlyout.Properties.AppearanceButtons.Options.UseFont = true;
            this.closeAppFlyout.Properties.AppearanceButtons.Options.UseForeColor = true;
            this.closeAppFlyout.Properties.AppearanceCaption.BackColor = System.Drawing.Color.White;
            this.closeAppFlyout.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.closeAppFlyout.Properties.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.closeAppFlyout.Properties.AppearanceCaption.Options.UseBackColor = true;
            this.closeAppFlyout.Properties.AppearanceCaption.Options.UseFont = true;
            this.closeAppFlyout.Properties.AppearanceCaption.Options.UseForeColor = true;
            this.closeAppFlyout.Properties.AppearanceDescription.BackColor = System.Drawing.Color.White;
            this.closeAppFlyout.Properties.AppearanceDescription.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.closeAppFlyout.Properties.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.closeAppFlyout.Properties.AppearanceDescription.Options.UseBackColor = true;
            this.closeAppFlyout.Properties.AppearanceDescription.Options.UseFont = true;
            this.closeAppFlyout.Properties.AppearanceDescription.Options.UseForeColor = true;
            this.closeAppFlyout.Properties.ButtonSize = new System.Drawing.Size(150, 70);
            // 
            // saveFlyout
            // 
            this.saveFlyout.Name = "saveFlyout";
            this.saveFlyout.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveFlyout.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.saveFlyout.Properties.Appearance.Options.UseBackColor = true;
            this.saveFlyout.Properties.Appearance.Options.UseForeColor = true;
            this.saveFlyout.Properties.AppearanceButtons.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.saveFlyout.Properties.AppearanceButtons.ForeColor = System.Drawing.Color.White;
            this.saveFlyout.Properties.AppearanceButtons.Options.UseFont = true;
            this.saveFlyout.Properties.AppearanceButtons.Options.UseForeColor = true;
            this.saveFlyout.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.saveFlyout.Properties.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.saveFlyout.Properties.AppearanceCaption.Options.UseFont = true;
            this.saveFlyout.Properties.AppearanceCaption.Options.UseForeColor = true;
            this.saveFlyout.Properties.AppearanceDescription.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.saveFlyout.Properties.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.saveFlyout.Properties.AppearanceDescription.Options.UseFont = true;
            this.saveFlyout.Properties.AppearanceDescription.Options.UseForeColor = true;
            this.saveFlyout.Properties.ButtonSize = new System.Drawing.Size(100, 80);
            // 
            // saveWeightFlyout
            // 
            this.saveWeightFlyout.Name = "saveWeightFlyout";
            this.saveWeightFlyout.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveWeightFlyout.Properties.Appearance.Options.UseBackColor = true;
            this.saveWeightFlyout.Properties.AppearanceButtons.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.saveWeightFlyout.Properties.AppearanceButtons.ForeColor = System.Drawing.Color.White;
            this.saveWeightFlyout.Properties.AppearanceButtons.Options.UseFont = true;
            this.saveWeightFlyout.Properties.AppearanceButtons.Options.UseForeColor = true;
            this.saveWeightFlyout.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.saveWeightFlyout.Properties.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.saveWeightFlyout.Properties.AppearanceCaption.Options.UseFont = true;
            this.saveWeightFlyout.Properties.AppearanceCaption.Options.UseForeColor = true;
            this.saveWeightFlyout.Properties.AppearanceDescription.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.saveWeightFlyout.Properties.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.saveWeightFlyout.Properties.AppearanceDescription.Options.UseFont = true;
            this.saveWeightFlyout.Properties.AppearanceDescription.Options.UseForeColor = true;
            this.saveWeightFlyout.Properties.ButtonSize = new System.Drawing.Size(100, 80);
            // 
            // finishScaleCookiesFlyout
            // 
            this.finishScaleCookiesFlyout.Name = "finishScaleCookiesFlyout";
            this.finishScaleCookiesFlyout.Properties.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.finishScaleCookiesFlyout.Properties.Appearance.Options.UseBackColor = true;
            this.finishScaleCookiesFlyout.Properties.AppearanceButtons.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.finishScaleCookiesFlyout.Properties.AppearanceButtons.ForeColor = System.Drawing.Color.White;
            this.finishScaleCookiesFlyout.Properties.AppearanceButtons.Options.UseFont = true;
            this.finishScaleCookiesFlyout.Properties.AppearanceButtons.Options.UseForeColor = true;
            this.finishScaleCookiesFlyout.Properties.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.finishScaleCookiesFlyout.Properties.AppearanceCaption.ForeColor = System.Drawing.Color.White;
            this.finishScaleCookiesFlyout.Properties.AppearanceCaption.Options.UseFont = true;
            this.finishScaleCookiesFlyout.Properties.AppearanceCaption.Options.UseForeColor = true;
            this.finishScaleCookiesFlyout.Properties.AppearanceDescription.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.finishScaleCookiesFlyout.Properties.AppearanceDescription.ForeColor = System.Drawing.Color.White;
            this.finishScaleCookiesFlyout.Properties.AppearanceDescription.Options.UseFont = true;
            this.finishScaleCookiesFlyout.Properties.AppearanceDescription.Options.UseForeColor = true;
            this.finishScaleCookiesFlyout.Properties.ButtonSize = new System.Drawing.Size(100, 80);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 717);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsUIView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScaleManualTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucShiftInfoDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucItemInfoDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScaleManualDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScalewScanTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pageGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucScalewScanDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucStatisticTile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucStatisticDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeAppFlyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveFlyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveWeightFlyout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishScaleCookiesFlyout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView windowsUIView;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer tileContainer;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucScaleManualTile;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucScaleManualDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucStatisticTile;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucStatisticDocument;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile ucScalewScanTile;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucScalewScanDocument;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucShiftInfoDocument;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document ucItemInfoDocument;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup pageGroup1;
        public DevExpress.XtraBars.Docking2010.Views.WindowsUI.PageGroup pageGroup2;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout closeAppFlyout;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout saveFlyout;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout saveWeightFlyout;
        private DevExpress.XtraBars.Docking2010.Views.WindowsUI.Flyout finishScaleCookiesFlyout;
    }
}

