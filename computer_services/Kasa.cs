using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Business.Concrete;
using Entities.Abstract;
using Entities.Concrete;
using DevExpress.XtraGrid;

namespace computer_services
{
    public partial class Kasa : DevExpress.XtraEditors.XtraForm
    {
        public Kasa()
        {
            InitializeComponent();
            resolvecFaults();
            productsSold();

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private CashManager<T> createManager<T>(T entity) where T:IEntity
        {
            return new CashManager<T>();

        }
        private void resolvecFaults()
        {
            gc_arizalar.DataSource = createManager<Fault>(new Fault()).getAllResolvedFault();

            //Datagridview de görünmesini istemediğimiz sütunların gizlenmesi
            gv_arizalar.Columns["id"].Visible = false;
            gv_arizalar.Columns["customer_ID"].Visible = false;
            gv_arizalar.Columns["identificationNumber"].Visible = false;
            gv_arizalar.Columns["name"].Visible = false;
            gv_arizalar.Columns["surname"].Visible = false;
            gv_arizalar.Columns["phoneNumber"].Visible = false;
            gv_arizalar.Columns["faultProduct_ID"].Visible = false;
            gv_arizalar.Columns["solutionDetail"].Visible = false;
            gv_arizalar.Columns["faultProduct_reason"].Visible = false;
            gv_arizalar.Columns["component"].Visible = false;
            gv_arizalar.Columns["fault_status"].Visible = false;
            gv_arizalar.Columns["statusID"].Visible = false;

            // Sütun sıralama
            gv_arizalar.Columns["startDate"].VisibleIndex = 0;
            gv_arizalar.Columns["startDate"].Caption = "Başlangıç Tarihi";
            gv_arizalar.Columns["finishDate"].VisibleIndex = 1;
            gv_arizalar.Columns["finishDate"].Caption = "Bitiş Tarihi";
            gv_arizalar.Columns["model"].VisibleIndex = 2;
            gv_arizalar.Columns["model"].Caption = "Model";
            gv_arizalar.Columns["detail"].VisibleIndex = 3;
            gv_arizalar.Columns["detail"].Caption= "Detay";
            gv_arizalar.Columns["price"].VisibleIndex = 4;
            gv_arizalar.Columns["price"].Caption = "Ücret";

            //Datagridviewde footer alanında ki toplam
            gv_arizalar.Columns["price"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gv_arizalar.Columns["price"].SummaryItem.DisplayFormat = "Toplam = {0:C2}";
        }
        private void productsSold()
        {
            gc_satis.DataSource = createManager<SoldProduct>(new SoldProduct()).getAllSoldProducts();

            //Datagridview de görünmesini istemediğimiz sütunların gizlenmesi
            gv_satis.Columns["productSold_ID"].Visible = false;
            gv_satis.Columns["productSold_customerID"].Visible = false;
            gv_satis.Columns["productSold_productID"].Visible = false;
            gv_satis.Columns["productSold_reasonID"].Visible = false;

            gv_satis.Columns["product_name"].Caption = "Ürün İsmi";
            gv_satis.Columns["productSold_unit"].Caption = "Adet";
            gv_satis.Columns["productSold_totalPrice"].Caption = "Toplam Ücret";
            gv_satis.Columns["productSold_soldDate"].Caption = "Satış Tarihi";

            //Sütun sıralama
            gv_satis.Columns["product_name"].VisibleIndex = 0;

            //Datagridviewde footer alanında ki toplam
            gv_satis.Columns["productSold_totalPrice"].SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            gv_satis.Columns["productSold_totalPrice"].SummaryItem.DisplayFormat = "Toplam = {0:C2}";

        }

        private void groupControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpC_arizalar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gc_arizalar_Click(object sender, EventArgs e)
        {

        }

        private void groupControl5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gc_satis_Click(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}