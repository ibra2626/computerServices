using Business.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_services
{
    public partial class Anasayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Arizalar ariza;
        UrunSatis urunSatis;
        Musteriler musteriler;
        Kasa kasa;
        UrunIslemleri urunIslemleri;
      
        public Anasayfa()
        {
            InitializeComponent();
            if(ariza == null || ariza.IsDisposed)
            {
                ariza = new Arizalar();
                ariza.MdiParent = this;
                ariza.Show();
            }
            else
            {
                ariza.Focus();
            }
        }

        private void menuBtnAriza_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(ariza == null || ariza.IsDisposed)
            {
                ariza = new Arizalar();
                ariza.MdiParent = this;
                ariza.Show();
            }
            else
            {
                ariza.Focus();
            }
        }

        private void btnAnasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void menuBtnUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunSatis == null || urunSatis.IsDisposed)
            {
                urunSatis = new UrunSatis();
                urunSatis.MdiParent = this;
                urunSatis.Show();
            }
            else
            {
                urunSatis.Focus();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteriler == null || musteriler.IsDisposed)
            {
                musteriler = new Musteriler();
                musteriler.MdiParent = this;
                musteriler.Show();
            }
            else
            {
                musteriler.Focus();
            }
        }

        private void menuBtn_Kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (kasa == null || kasa.IsDisposed)
            {
                kasa = new Kasa();
                kasa.MdiParent = this;
                kasa.Show();
            }
            else
            {
                kasa.Focus();
            }
        }

        private void menuBtnUrunIslemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (urunIslemleri == null || urunIslemleri.IsDisposed)
            {
                urunIslemleri = new UrunIslemleri();
                urunIslemleri.MdiParent = this;
                urunIslemleri.Show();
            }
            else
            {
                urunIslemleri.Focus();
            }
        }

        public void headerChange(String header)
        {
            ribbonControl1.ApplicationCaption = header;
        }
    }
}
