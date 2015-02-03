namespace cmctj
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gcDxTiempo = new DevExpress.XtraGrid.GridControl();
            this.gvCorredores = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDxTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCorredores)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(919, 142);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "F1 - Nuevo tiempo";
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
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Opciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tiempo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Corredor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gcDxTiempo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 327);
            this.panel1.TabIndex = 1;
            // 
            // gcDxTiempo
            // 
            this.gcDxTiempo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcDxTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDxTiempo.Location = new System.Drawing.Point(0, 0);
            this.gcDxTiempo.MainView = this.gvCorredores;
            this.gcDxTiempo.MenuManager = this.ribbonControl1;
            this.gcDxTiempo.Name = "gcDxTiempo";
            this.gcDxTiempo.Size = new System.Drawing.Size(919, 327);
            this.gcDxTiempo.TabIndex = 0;
            this.gcDxTiempo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCorredores});
            // 
            // gvCorredores
            // 
            this.gvCorredores.GridControl = this.gcDxTiempo;
            this.gvCorredores.Name = "gvCorredores";
            this.gvCorredores.OptionsBehavior.Editable = false;
            this.gvCorredores.OptionsFind.AlwaysVisible = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(919, 469);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDxTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCorredores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gcDxTiempo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCorredores;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}