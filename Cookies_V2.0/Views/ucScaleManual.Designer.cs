namespace Cookies_V2._0.Views
{
    partial class ucScaleManual
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series9 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series10 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series11 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series12 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmdFinish = new DevExpress.XtraEditors.SimpleButton();
            this.cmdPurgingCookie = new DevExpress.XtraEditors.SimpleButton();
            this.cmdMixedCookie = new DevExpress.XtraEditors.SimpleButton();
            this.cmdItemCookie = new DevExpress.XtraEditors.SimpleButton();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutScaleWeight = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutCookieType = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutScaleWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCookieType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.textEdit1);
            this.layoutControl1.Controls.Add(this.cmdFinish);
            this.layoutControl1.Controls.Add(this.cmdPurgingCookie);
            this.layoutControl1.Controls.Add(this.cmdMixedCookie);
            this.layoutControl1.Controls.Add(this.cmdItemCookie);
            this.layoutControl1.Controls.Add(this.chartControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(899, 9, 650, 899);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1628, 637);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmdFinish
            // 
            this.cmdFinish.Appearance.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.cmdFinish.Appearance.Options.UseFont = true;
            this.cmdFinish.Appearance.Options.UseTextOptions = true;
            this.cmdFinish.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.cmdFinish.Location = new System.Drawing.Point(24, 267);
            this.cmdFinish.Name = "cmdFinish";
            this.cmdFinish.Size = new System.Drawing.Size(360, 74);
            this.cmdFinish.StyleController = this.layoutControl1;
            this.cmdFinish.TabIndex = 8;
            this.cmdFinish.Text = "Hoàn thành";
            this.cmdFinish.Click += new System.EventHandler(this.cmdFinish_Click);
            // 
            // cmdPurgingCookie
            // 
            this.cmdPurgingCookie.Appearance.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.cmdPurgingCookie.Appearance.Options.UseFont = true;
            this.cmdPurgingCookie.Location = new System.Drawing.Point(24, 129);
            this.cmdPurgingCookie.Name = "cmdPurgingCookie";
            this.cmdPurgingCookie.Size = new System.Drawing.Size(360, 65);
            this.cmdPurgingCookie.StyleController = this.layoutControl1;
            this.cmdPurgingCookie.TabIndex = 7;
            this.cmdPurgingCookie.Text = "Purging";
            this.cmdPurgingCookie.Click += new System.EventHandler(this.cmdPurgingCookie_Click);
            // 
            // cmdMixedCookie
            // 
            this.cmdMixedCookie.Appearance.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.cmdMixedCookie.Appearance.Options.UseFont = true;
            this.cmdMixedCookie.Location = new System.Drawing.Point(24, 198);
            this.cmdMixedCookie.Name = "cmdMixedCookie";
            this.cmdMixedCookie.Size = new System.Drawing.Size(360, 65);
            this.cmdMixedCookie.StyleController = this.layoutControl1;
            this.cmdMixedCookie.TabIndex = 6;
            this.cmdMixedCookie.Text = "Mixed";
            this.cmdMixedCookie.Click += new System.EventHandler(this.cmdMixedCookie_Click);
            // 
            // cmdItemCookie
            // 
            this.cmdItemCookie.Appearance.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.cmdItemCookie.Appearance.Options.UseFont = true;
            this.cmdItemCookie.Location = new System.Drawing.Point(24, 60);
            this.cmdItemCookie.Name = "cmdItemCookie";
            this.cmdItemCookie.Size = new System.Drawing.Size(360, 65);
            this.cmdItemCookie.StyleController = this.layoutControl1;
            this.cmdItemCookie.TabIndex = 5;
            this.cmdItemCookie.Text = "Item";
            this.cmdItemCookie.Click += new System.EventHandler(this.cmdItemCookie_Click);
            // 
            // chartControl1
            // 
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.Location = new System.Drawing.Point(400, 12);
            this.chartControl1.Name = "chartControl1";
            series9.Name = "Total";
            series10.Name = "TPU Cookie";
            series11.Name = "Purging Cookie";
            series12.Name = "Mixed Cookie";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series9,
        series10,
        series11,
        series12};
            this.chartControl1.Size = new System.Drawing.Size(1216, 613);
            this.chartControl1.TabIndex = 4;
            chartTitle3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle3.Text = "Current on scale";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutScaleWeight,
            this.layoutCookieType,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1628, 637);
            this.Root.TextVisible = false;
            // 
            // layoutScaleWeight
            // 
            this.layoutScaleWeight.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.layoutScaleWeight.AppearanceGroup.Options.UseFont = true;
            this.layoutScaleWeight.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6});
            this.layoutScaleWeight.Location = new System.Drawing.Point(0, 365);
            this.layoutScaleWeight.Name = "layoutScaleWeight";
            this.layoutScaleWeight.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutScaleWeight.Size = new System.Drawing.Size(388, 252);
            this.layoutScaleWeight.Text = "Khối lượng cân (Kg)";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.chartControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(388, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(1220, 617);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutCookieType
            // 
            this.layoutCookieType.AppearanceGroup.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.layoutCookieType.AppearanceGroup.Options.UseFont = true;
            this.layoutCookieType.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4});
            this.layoutCookieType.Location = new System.Drawing.Point(0, 0);
            this.layoutCookieType.Name = "layoutCookieType";
            this.layoutCookieType.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutCookieType.Size = new System.Drawing.Size(388, 345);
            this.layoutCookieType.Text = "Bạn đang cân";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cmdFinish;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 207);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(364, 78);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cmdMixedCookie;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(364, 69);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmdItemCookie;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(364, 69);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmdPurgingCookie;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(364, 69);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "55.25";
            this.textEdit1.Location = new System.Drawing.Point(15, 416);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.Appearance.Options.UseTextOptions = true;
            this.textEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.textEdit1.Size = new System.Drawing.Size(378, 206);
            this.textEdit1.StyleController = this.layoutControl1;
            this.textEdit1.TabIndex = 9;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.textEdit1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(382, 210);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 345);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(388, 20);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucScaleManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "ucScaleManual";
            this.Size = new System.Drawing.Size(1628, 637);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutScaleWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutCookieType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton cmdFinish;
        private DevExpress.XtraEditors.SimpleButton cmdPurgingCookie;
        private DevExpress.XtraEditors.SimpleButton cmdMixedCookie;
        private DevExpress.XtraEditors.SimpleButton cmdItemCookie;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutScaleWeight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutCookieType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
