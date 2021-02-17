namespace computer_services
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.menuBtnUrunSatis = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.menuBtn_Kasa = new DevExpress.XtraBars.BarButtonItem();
            this.menuBtnAriza = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.menuBtnUrunIslemleri = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mdi = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.AutoSizeItems = true;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonItem1,
            this.menuBtnUrunSatis,
            this.barButtonItem3,
            this.menuBtn_Kasa,
            this.menuBtnAriza,
            this.barButtonItem2,
            this.barButtonItem5,
            this.menuBtnUrunIslemleri,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem6,
            this.barButtonItem10});
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.Image = global::computer_services.Properties.Resources.ariza_64px;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // menuBtnUrunSatis
            // 
            resources.ApplyResources(this.menuBtnUrunSatis, "menuBtnUrunSatis");
            this.menuBtnUrunSatis.Id = 4;
            this.menuBtnUrunSatis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuBtnUrunSatis.ImageOptions.Image")));
            this.menuBtnUrunSatis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuBtnUrunSatis.ImageOptions.LargeImage")));
            this.menuBtnUrunSatis.Name = "menuBtnUrunSatis";
            this.menuBtnUrunSatis.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menuBtnUrunSatis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBtnUrunSatis_ItemClick);
            // 
            // barButtonItem3
            // 
            resources.ApplyResources(this.barButtonItem3, "barButtonItem3");
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // menuBtn_Kasa
            // 
            resources.ApplyResources(this.menuBtn_Kasa, "menuBtn_Kasa");
            this.menuBtn_Kasa.Id = 6;
            this.menuBtn_Kasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn_Kasa.ImageOptions.Image")));
            this.menuBtn_Kasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuBtn_Kasa.ImageOptions.LargeImage")));
            this.menuBtn_Kasa.Name = "menuBtn_Kasa";
            this.menuBtn_Kasa.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menuBtn_Kasa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBtn_Kasa_ItemClick);
            // 
            // menuBtnAriza
            // 
            resources.ApplyResources(this.menuBtnAriza, "menuBtnAriza");
            this.menuBtnAriza.Id = 8;
            this.menuBtnAriza.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuBtnAriza.ImageOptions.Image")));
            this.menuBtnAriza.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuBtnAriza.ImageOptions.LargeImage")));
            this.menuBtnAriza.Name = "menuBtnAriza";
            this.menuBtnAriza.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menuBtnAriza.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBtnAriza_ItemClick);
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 9;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem5
            // 
            resources.ApplyResources(this.barButtonItem5, "barButtonItem5");
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // menuBtnUrunIslemleri
            // 
            resources.ApplyResources(this.menuBtnUrunIslemleri, "menuBtnUrunIslemleri");
            this.menuBtnUrunIslemleri.Id = 11;
            this.menuBtnUrunIslemleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("menuBtnUrunIslemleri.ImageOptions.Image")));
            this.menuBtnUrunIslemleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("menuBtnUrunIslemleri.ImageOptions.LargeImage")));
            this.menuBtnUrunIslemleri.Name = "menuBtnUrunIslemleri";
            this.menuBtnUrunIslemleri.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menuBtnUrunIslemleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBtnUrunIslemleri_ItemClick);
            // 
            // barButtonItem7
            // 
            resources.ApplyResources(this.barButtonItem7, "barButtonItem7");
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            resources.ApplyResources(this.barButtonItem8, "barButtonItem8");
            this.barButtonItem8.Id = 13;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            resources.ApplyResources(this.barButtonItem9, "barButtonItem9");
            this.barButtonItem9.Id = 14;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem6
            // 
            resources.ApplyResources(this.barButtonItem6, "barButtonItem6");
            this.barButtonItem6.Id = 15;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem10
            // 
            resources.ApplyResources(this.barButtonItem10, "barButtonItem10");
            this.barButtonItem10.Id = 16;
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.menuBtnAriza);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.menuBtnUrunSatis);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.menuBtnUrunIslemleri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.menuBtn_Kasa);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            resources.ApplyResources(this.ribbonPage3, "ribbonPage3");
            // 
            // mdi
            // 
            this.mdi.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.mdi.MdiParent = this;
            this.mdi.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.True;
            // 
            // Anasayfa
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Anasayfa.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "Anasayfa";
            this.Ribbon = this.ribbonControl1;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem menuBtnUrunSatis;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem menuBtn_Kasa;
        private DevExpress.XtraBars.BarButtonItem menuBtnAriza;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem menuBtnUrunIslemleri;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
    }
}

