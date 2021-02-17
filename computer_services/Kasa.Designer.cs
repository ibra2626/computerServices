namespace computer_services
{
    partial class Kasa
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
            this.grpC_arizalar = new DevExpress.XtraEditors.GroupControl();
            this.gc_arizalar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gv_arizalar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gc_satis = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gv_satis = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grpC_arizalar)).BeginInit();
            this.grpC_arizalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_arizalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_arizalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_satis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_satis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpC_arizalar
            // 
            this.grpC_arizalar.Controls.Add(this.gc_arizalar);
            this.grpC_arizalar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpC_arizalar.Location = new System.Drawing.Point(2, 2);
            this.grpC_arizalar.Name = "grpC_arizalar";
            this.grpC_arizalar.Size = new System.Drawing.Size(1002, 220);
            this.grpC_arizalar.TabIndex = 2;
            this.grpC_arizalar.Text = "Giderilen Arızalar";
            this.grpC_arizalar.Paint += new System.Windows.Forms.PaintEventHandler(this.grpC_arizalar_Paint);
            // 
            // gc_arizalar
            // 
            this.gc_arizalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_arizalar.Location = new System.Drawing.Point(2, 27);
            this.gc_arizalar.MainView = this.gv_arizalar;
            this.gc_arizalar.Name = "gc_arizalar";
            this.gc_arizalar.Size = new System.Drawing.Size(998, 191);
            this.gc_arizalar.TabIndex = 0;
            this.gc_arizalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_arizalar});
            this.gc_arizalar.Click += new System.EventHandler(this.gc_arizalar_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gc_arizalar;
            this.gridView1.Name = "gridView1";
            // 
            // gv_arizalar
            // 
            this.gv_arizalar.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gv_arizalar.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Black;
            this.gv_arizalar.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gv_arizalar.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gv_arizalar.Appearance.GroupFooter.BackColor = System.Drawing.Color.Black;
            this.gv_arizalar.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gv_arizalar.AppearancePrint.FooterPanel.BackColor = System.Drawing.Color.Black;
            this.gv_arizalar.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gv_arizalar.AppearancePrint.FooterPanel.Options.UseBackColor = true;
            this.gv_arizalar.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gv_arizalar.AppearancePrint.GroupFooter.BackColor = System.Drawing.Color.Black;
            this.gv_arizalar.AppearancePrint.GroupFooter.Options.UseBackColor = true;
            this.gv_arizalar.GridControl = this.gc_arizalar;
            this.gv_arizalar.Name = "gv_arizalar";
            this.gv_arizalar.OptionsMenu.EnableFooterMenu = false;
            this.gv_arizalar.OptionsView.ShowFooter = true;
            this.gv_arizalar.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gc_satis);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.Location = new System.Drawing.Point(2, 222);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(1002, 222);
            this.groupControl5.TabIndex = 3;
            this.groupControl5.Text = "Satılan Ürünler";
            this.groupControl5.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl5_Paint);
            // 
            // gc_satis
            // 
            this.gc_satis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_satis.Location = new System.Drawing.Point(2, 27);
            this.gc_satis.MainView = this.gv_satis;
            this.gc_satis.Name = "gc_satis";
            this.gc_satis.Size = new System.Drawing.Size(998, 193);
            this.gc_satis.TabIndex = 0;
            this.gc_satis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_satis});
            this.gc_satis.Click += new System.EventHandler(this.gc_satis_Click);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gc_satis;
            this.gridView2.Name = "gridView2";
            // 
            // gv_satis
            // 
            this.gv_satis.GridControl = this.gc_satis;
            this.gv_satis.Name = "gv_satis";
            this.gv_satis.OptionsView.ShowFooter = true;
            this.gv_satis.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl5);
            this.panelControl1.Controls.Add(this.grpC_arizalar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1006, 529);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.panelControl1);
            this.Name = "Kasa";
            this.Text = "Kasa";
            ((System.ComponentModel.ISupportInitialize)(this.grpC_arizalar)).EndInit();
            this.grpC_arizalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_arizalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_arizalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_satis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_satis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpC_arizalar;
        private DevExpress.XtraGrid.GridControl gc_arizalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_arizalar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gc_satis;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_satis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}