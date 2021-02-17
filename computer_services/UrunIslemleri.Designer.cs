namespace computer_services
{
    partial class UrunIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIslemleri));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tPanel_product = new DevExpress.Utils.Layout.TablePanel();
            this.gc_products = new DevExpress.XtraGrid.GridControl();
            this.gv_products = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tPanel_productMenu = new DevExpress.Utils.Layout.TablePanel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btn_stokEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_urunSil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_UrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_kategori = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.gc_subCategory = new DevExpress.XtraGrid.GridControl();
            this.grdV_subCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tPanel_subCategory = new DevExpress.Utils.Layout.TablePanel();
            this.btn_anaKategoriEkle = new DevExpress.XtraEditors.SimpleButton();
            this.le_mainCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btn_kategoriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kategoriEkle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPanel_product)).BeginInit();
            this.tPanel_product.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPanel_productMenu)).BeginInit();
            this.tPanel_productMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_subCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_subCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPanel_subCategory)).BeginInit();
            this.tPanel_subCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.le_mainCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tablePanel1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 28.73F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 31.27F)});
            this.tablePanel1.Controls.Add(this.groupControl2);
            this.tablePanel1.Controls.Add(this.groupControl1);
            resources.ApplyResources(this.tablePanel1, "tablePanel1");
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = ((System.Drawing.Font)(resources.GetObject("groupControl2.AppearanceCaption.Font")));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.tablePanel1.SetColumn(this.groupControl2, 1);
            this.groupControl2.Controls.Add(this.tPanel_product);
            this.groupControl2.Controls.Add(this.tPanel_productMenu);
            resources.ApplyResources(this.groupControl2, "groupControl2");
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Name = "groupControl2";
            this.tablePanel1.SetRow(this.groupControl2, 0);
            // 
            // tPanel_product
            // 
            this.tPanel_product.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 12.25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 87.5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.25F)});
            this.tPanel_product.Controls.Add(this.gc_products);
            resources.ApplyResources(this.tPanel_product, "tPanel_product");
            this.tPanel_product.Name = "tPanel_product";
            this.tPanel_product.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 352F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            // 
            // gc_products
            // 
            this.tPanel_product.SetColumn(this.gc_products, 1);
            resources.ApplyResources(this.gc_products, "gc_products");
            this.gc_products.MainView = this.gv_products;
            this.gc_products.Name = "gc_products";
            this.tPanel_product.SetRow(this.gc_products, 1);
            this.gc_products.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_products});
            // 
            // gv_products
            // 
            this.gv_products.GridControl = this.gc_products;
            this.gv_products.Name = "gv_products";
            this.gv_products.OptionsBehavior.Editable = false;
            this.gv_products.OptionsView.ShowGroupPanel = false;
            // 
            // tPanel_productMenu
            // 
            this.tPanel_productMenu.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 110F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 110F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 110F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 110F)});
            this.tPanel_productMenu.Controls.Add(this.labelControl6);
            this.tPanel_productMenu.Controls.Add(this.labelControl5);
            this.tPanel_productMenu.Controls.Add(this.btn_stokEkle);
            this.tPanel_productMenu.Controls.Add(this.btn_urunSil);
            this.tPanel_productMenu.Controls.Add(this.btn_UrunEkle);
            this.tPanel_productMenu.Controls.Add(this.lbl_kategori);
            this.tPanel_productMenu.Controls.Add(this.labelControl1);
            resources.ApplyResources(this.tPanel_productMenu, "tPanel_productMenu");
            this.tPanel_productMenu.Name = "tPanel_productMenu";
            this.tPanel_productMenu.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl6.Appearance.Font")));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.tPanel_productMenu.SetColumn(this.labelControl6, 3);
            resources.ApplyResources(this.labelControl6, "labelControl6");
            this.labelControl6.Name = "labelControl6";
            this.tPanel_productMenu.SetRow(this.labelControl6, 0);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl5.Appearance.Font")));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.tPanel_productMenu.SetColumn(this.labelControl5, 2);
            resources.ApplyResources(this.labelControl5, "labelControl5");
            this.labelControl5.Name = "labelControl5";
            this.tPanel_productMenu.SetRow(this.labelControl5, 0);
            // 
            // btn_stokEkle
            // 
            this.tPanel_productMenu.SetColumn(this.btn_stokEkle, 0);
            this.btn_stokEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_stokEkle.ImageOptions.Image")));
            resources.ApplyResources(this.btn_stokEkle, "btn_stokEkle");
            this.btn_stokEkle.Name = "btn_stokEkle";
            this.tPanel_productMenu.SetRow(this.btn_stokEkle, 1);
            this.btn_stokEkle.Click += new System.EventHandler(this.btn_stokEkle_Click);
            // 
            // btn_urunSil
            // 
            this.tPanel_productMenu.SetColumn(this.btn_urunSil, 2);
            this.btn_urunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_urunSil.ImageOptions.Image")));
            resources.ApplyResources(this.btn_urunSil, "btn_urunSil");
            this.btn_urunSil.Name = "btn_urunSil";
            this.tPanel_productMenu.SetRow(this.btn_urunSil, 1);
            this.btn_urunSil.Click += new System.EventHandler(this.btn_urunSil_Click);
            // 
            // btn_UrunEkle
            // 
            this.tPanel_productMenu.SetColumn(this.btn_UrunEkle, 1);
            this.btn_UrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunEkle.ImageOptions.Image")));
            resources.ApplyResources(this.btn_UrunEkle, "btn_UrunEkle");
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.tPanel_productMenu.SetRow(this.btn_UrunEkle, 1);
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbl_kategori.Appearance.Font")));
            this.lbl_kategori.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_kategori.Appearance.Options.UseFont = true;
            this.lbl_kategori.Appearance.Options.UseForeColor = true;
            this.lbl_kategori.Appearance.Options.UseTextOptions = true;
            this.lbl_kategori.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tPanel_productMenu.SetColumn(this.lbl_kategori, 1);
            resources.ApplyResources(this.lbl_kategori, "lbl_kategori");
            this.lbl_kategori.Name = "lbl_kategori";
            this.tPanel_productMenu.SetRow(this.lbl_kategori, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.tPanel_productMenu.SetColumn(this.labelControl1, 0);
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            this.tPanel_productMenu.SetRow(this.labelControl1, 0);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = ((System.Drawing.Font)(resources.GetObject("groupControl1.AppearanceCaption.Font")));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.tablePanel1.SetColumn(this.groupControl1, 0);
            this.groupControl1.Controls.Add(this.tablePanel3);
            this.groupControl1.Controls.Add(this.tPanel_subCategory);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Name = "groupControl1";
            this.tablePanel1.SetRow(this.groupControl1, 0);
            // 
            // tablePanel3
            // 
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.13F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 88.48F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 11.39F)});
            this.tablePanel3.Controls.Add(this.gc_subCategory);
            resources.ApplyResources(this.tablePanel3, "tablePanel3");
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 351F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            // 
            // gc_subCategory
            // 
            this.tablePanel3.SetColumn(this.gc_subCategory, 1);
            resources.ApplyResources(this.gc_subCategory, "gc_subCategory");
            this.gc_subCategory.MainView = this.grdV_subCategory;
            this.gc_subCategory.Name = "gc_subCategory";
            this.tablePanel3.SetRow(this.gc_subCategory, 1);
            this.gc_subCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdV_subCategory});
            // 
            // grdV_subCategory
            // 
            this.grdV_subCategory.GridControl = this.gc_subCategory;
            this.grdV_subCategory.Name = "grdV_subCategory";
            this.grdV_subCategory.OptionsBehavior.Editable = false;
            this.grdV_subCategory.OptionsView.ShowGroupPanel = false;
            this.grdV_subCategory.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grdV_subCategory_FocusedRowChanged);
            // 
            // tPanel_subCategory
            // 
            this.tPanel_subCategory.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.72F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35.05F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36.23F)});
            this.tPanel_subCategory.Controls.Add(this.btn_anaKategoriEkle);
            this.tPanel_subCategory.Controls.Add(this.le_mainCategory);
            this.tPanel_subCategory.Controls.Add(this.labelControl4);
            this.tPanel_subCategory.Controls.Add(this.btn_kategoriSil);
            this.tPanel_subCategory.Controls.Add(this.btn_kategoriEkle);
            resources.ApplyResources(this.tPanel_subCategory, "tPanel_subCategory");
            this.tPanel_subCategory.Name = "tPanel_subCategory";
            this.tPanel_subCategory.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tPanel_subCategory.Click += new System.EventHandler(this.tPanel_subCategory_Click);
            // 
            // btn_anaKategoriEkle
            // 
            this.tPanel_subCategory.SetColumn(this.btn_anaKategoriEkle, 2);
            resources.ApplyResources(this.btn_anaKategoriEkle, "btn_anaKategoriEkle");
            this.btn_anaKategoriEkle.Name = "btn_anaKategoriEkle";
            this.tPanel_subCategory.SetRow(this.btn_anaKategoriEkle, 0);
            this.btn_anaKategoriEkle.Click += new System.EventHandler(this.btn_anaKategoriEkle_Click);
            // 
            // le_mainCategory
            // 
            this.tPanel_subCategory.SetColumn(this.le_mainCategory, 1);
            resources.ApplyResources(this.le_mainCategory, "le_mainCategory");
            this.le_mainCategory.Name = "le_mainCategory";
            this.le_mainCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("le_mainCategory.Properties.Buttons"))))});
            this.le_mainCategory.Properties.NullText = resources.GetString("le_mainCategory.Properties.NullText");
            this.le_mainCategory.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.le_mainCategory_Properties_QueryPopUp);
            this.le_mainCategory.Properties.EditValueChanged += new System.EventHandler(this.le_mainCategory_Properties_EditValueChanged);
            this.tPanel_subCategory.SetRow(this.le_mainCategory, 0);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl4.Appearance.Font")));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.tPanel_subCategory.SetColumn(this.labelControl4, 0);
            resources.ApplyResources(this.labelControl4, "labelControl4");
            this.labelControl4.Name = "labelControl4";
            this.tPanel_subCategory.SetRow(this.labelControl4, 0);
            // 
            // btn_kategoriSil
            // 
            this.btn_kategoriSil.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_kategoriSil.Appearance.Font")));
            this.btn_kategoriSil.Appearance.Options.UseFont = true;
            this.tPanel_subCategory.SetColumn(this.btn_kategoriSil, 1);
            resources.ApplyResources(this.btn_kategoriSil, "btn_kategoriSil");
            this.btn_kategoriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kategoriSil.ImageOptions.Image")));
            this.btn_kategoriSil.Name = "btn_kategoriSil";
            this.tPanel_subCategory.SetRow(this.btn_kategoriSil, 1);
            this.btn_kategoriSil.Click += new System.EventHandler(this.btn_kategoriSil_Click);
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_kategoriEkle.Appearance.Font")));
            this.btn_kategoriEkle.Appearance.Options.UseFont = true;
            this.tPanel_subCategory.SetColumn(this.btn_kategoriEkle, 0);
            resources.ApplyResources(this.btn_kategoriEkle, "btn_kategoriEkle");
            this.btn_kategoriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kategoriEkle.ImageOptions.Image")));
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.tPanel_subCategory.SetRow(this.btn_kategoriEkle, 1);
            this.btn_kategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // UrunIslemleri
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Name = "UrunIslemleri";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tPanel_product)).EndInit();
            this.tPanel_product.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPanel_productMenu)).EndInit();
            this.tPanel_productMenu.ResumeLayout(false);
            this.tPanel_productMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_subCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdV_subCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPanel_subCategory)).EndInit();
            this.tPanel_subCategory.ResumeLayout(false);
            this.tPanel_subCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.le_mainCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.Utils.Layout.TablePanel tPanel_subCategory;
        private DevExpress.Utils.Layout.TablePanel tPanel_productMenu;
        private DevExpress.XtraEditors.SimpleButton btn_stokEkle;
        private DevExpress.XtraEditors.SimpleButton btn_urunSil;
        private DevExpress.XtraEditors.SimpleButton btn_UrunEkle;
        private DevExpress.XtraEditors.LabelControl lbl_kategori;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_kategoriEkle;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SimpleButton btn_kategoriSil;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gc_subCategory;
        private DevExpress.XtraGrid.Views.Grid.GridView grdV_subCategory;
        private DevExpress.Utils.Layout.TablePanel tPanel_product;
        private DevExpress.XtraEditors.LookUpEdit le_mainCategory;
        private DevExpress.XtraGrid.GridControl gc_products;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_products;
        private DevExpress.XtraEditors.SimpleButton btn_anaKategoriEkle;
    }
}