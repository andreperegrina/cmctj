namespace cmctj.Reporte
{
    partial class FormReporteTiempo
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
            DevExpress.XtraPivotGrid.PivotGridGroup pivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteTiempo));
            this.pivotGridField2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcDxTiempo = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.pivotGridField1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField5 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField6 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField12 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDxIniciarCarrera = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pivotGridField7 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField8 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField9 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField10 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridField11 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDxTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridField2
            // 
            this.pivotGridField2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.pivotGridField2.AreaIndex = 0;
            this.pivotGridField2.FieldName = "Vuelta";
            this.pivotGridField2.Name = "pivotGridField2";
            this.pivotGridField2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcDxTiempo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 312);
            this.panel1.TabIndex = 2;
            // 
            // gcDxTiempo
            // 
            this.gcDxTiempo.Appearance.FieldValue.Options.UseTextOptions = true;
            this.gcDxTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDxTiempo.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.pivotGridField1,
            this.pivotGridField2,
            this.pivotGridField3,
            this.pivotGridField5,
            this.pivotGridField6,
            this.pivotGridField4,
            this.pivotGridField12});
            pivotGridGroup1.Fields.Add(this.pivotGridField2);
            pivotGridGroup1.Hierarchy = null;
            pivotGridGroup1.ShowNewValues = true;
            this.gcDxTiempo.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {
            pivotGridGroup1});
            this.gcDxTiempo.Location = new System.Drawing.Point(0, 0);
            this.gcDxTiempo.Name = "gcDxTiempo";
            this.gcDxTiempo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gcDxTiempo.Size = new System.Drawing.Size(885, 312);
            this.gcDxTiempo.TabIndex = 0;
            this.gcDxTiempo.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(this.gcDxTiempo_CustomSummary);
            this.gcDxTiempo.CustomCellValue += new System.EventHandler<DevExpress.XtraPivotGrid.PivotCellValueEventArgs>(this.gcDxTiempo_CustomCellValue);
            // 
            // pivotGridField1
            // 
            this.pivotGridField1.AreaIndex = 0;
            this.pivotGridField1.FieldName = "TiempoId";
            this.pivotGridField1.Name = "pivotGridField1";
            this.pivotGridField1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // pivotGridField3
            // 
            this.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField3.AreaIndex = 1;
            this.pivotGridField3.FieldName = "Nombre";
            this.pivotGridField3.Name = "pivotGridField3";
            this.pivotGridField3.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // pivotGridField5
            // 
            this.pivotGridField5.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField5.AreaIndex = 2;
            this.pivotGridField5.CellFormat.FormatString = "d";
            this.pivotGridField5.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField5.FieldName = "TiempoRegistrado";
            this.pivotGridField5.Name = "pivotGridField5";
            this.pivotGridField5.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max;
            this.pivotGridField5.UnboundFieldName = "pivotGridField5";
            this.pivotGridField5.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.pivotGridField5.ValueFormat.FormatString = "d";
            this.pivotGridField5.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pivotGridField6
            // 
            this.pivotGridField6.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField6.AreaIndex = 0;
            this.pivotGridField6.FieldName = "Categoria";
            this.pivotGridField6.Name = "pivotGridField6";
            this.pivotGridField6.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            // 
            // pivotGridField4
            // 
            this.pivotGridField4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField4.AreaIndex = 1;
            this.pivotGridField4.FieldName = "Tiempo";
            this.pivotGridField4.Name = "pivotGridField4";
            this.pivotGridField4.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min;
            // 
            // pivotGridField12
            // 
            this.pivotGridField12.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.pivotGridField12.AreaIndex = 0;
            this.pivotGridField12.FieldName = "Numero";
            this.pivotGridField12.Name = "pivotGridField12";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.bbiDxIniciarCarrera,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(885, 142);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "F1 - Actualizar";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1);
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "F2- Crear Corredor";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F2);
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bbiDxIniciarCarrera
            // 
            this.bbiDxIniciarCarrera.Caption = "F3 - Iniciar carrera";
            this.bbiDxIniciarCarrera.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiDxIniciarCarrera.Glyph")));
            this.bbiDxIniciarCarrera.Id = 3;
            this.bbiDxIniciarCarrera.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F3);
            this.bbiDxIniciarCarrera.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiDxIniciarCarrera.LargeGlyph")));
            this.bbiDxIniciarCarrera.Name = "bbiDxIniciarCarrera";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "F5 - Actualizar Datos";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "F6 - Borrar Tiempo";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F6);
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "F7 - Borrar Inicio de carrera";
            this.barButtonItem5.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.Glyph")));
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F7);
            this.barButtonItem5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.LargeGlyph")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Exportar XLS";
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 7;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Exportar PDF";
            this.barButtonItem7.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.Glyph")));
            this.barButtonItem7.Id = 8;
            this.barButtonItem7.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.LargeGlyph")));
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Opciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tiempo";
            // 
            // pivotGridField7
            // 
            this.pivotGridField7.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField7.AreaIndex = 0;
            this.pivotGridField7.CellFormat.FormatString = "d";
            this.pivotGridField7.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField7.FieldName = "TiempoRegistrado";
            this.pivotGridField7.Name = "pivotGridField7";
            this.pivotGridField7.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.RankInColumnLargestToSmallest;
            this.pivotGridField7.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.pivotGridField7.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.pivotGridField7.ValueFormat.FormatString = "d";
            this.pivotGridField7.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pivotGridField8
            // 
            this.pivotGridField8.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField8.AreaIndex = 0;
            this.pivotGridField8.CellFormat.FormatString = "d";
            this.pivotGridField8.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField8.FieldName = "TiempoRegistrado";
            this.pivotGridField8.Name = "pivotGridField8";
            this.pivotGridField8.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.RankInColumnLargestToSmallest;
            this.pivotGridField8.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.pivotGridField8.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.pivotGridField8.ValueFormat.FormatString = "d";
            this.pivotGridField8.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pivotGridField9
            // 
            this.pivotGridField9.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField9.AreaIndex = 0;
            this.pivotGridField9.CellFormat.FormatString = "d";
            this.pivotGridField9.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField9.FieldName = "TiempoRegistrado";
            this.pivotGridField9.Name = "pivotGridField9";
            this.pivotGridField9.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.RankInColumnLargestToSmallest;
            this.pivotGridField9.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.pivotGridField9.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.pivotGridField9.ValueFormat.FormatString = "d";
            this.pivotGridField9.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pivotGridField10
            // 
            this.pivotGridField10.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField10.AreaIndex = 0;
            this.pivotGridField10.CellFormat.FormatString = "d";
            this.pivotGridField10.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField10.FieldName = "TiempoRegistrado";
            this.pivotGridField10.Name = "pivotGridField10";
            this.pivotGridField10.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.RankInColumnLargestToSmallest;
            this.pivotGridField10.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.pivotGridField10.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.pivotGridField10.ValueFormat.FormatString = "d";
            this.pivotGridField10.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // pivotGridField11
            // 
            this.pivotGridField11.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.pivotGridField11.AreaIndex = 0;
            this.pivotGridField11.CellFormat.FormatString = "d";
            this.pivotGridField11.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.pivotGridField11.FieldName = "TiempoRegistrado";
            this.pivotGridField11.Name = "pivotGridField11";
            this.pivotGridField11.SummaryDisplayType = DevExpress.Data.PivotGrid.PivotSummaryDisplayType.RankInColumnLargestToSmallest;
            this.pivotGridField11.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
            this.pivotGridField11.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.pivotGridField11.ValueFormat.FormatString = "d";
            this.pivotGridField11.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            // 
            // FormReporteTiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormReporteTiempo";
            this.Text = "FormReporteTiempo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDxTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraPivotGrid.PivotGridControl gcDxTiempo;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem bbiDxIniciarCarrera;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField2;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField3;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField5;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField6;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField7;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField8;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField9;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField10;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField11;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField4;
        private DevExpress.XtraPivotGrid.PivotGridField pivotGridField12;
    }
}