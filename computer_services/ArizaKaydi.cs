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
using DevExpress.Utils.Behaviors;
using Entities.Concrete;
using System.Collections;

namespace computer_services
{
    public partial class ArizaKaydi : DevExpress.XtraEditors.XtraForm
    {
        ProductManager<Product> products;
        FaultManager<FaultStatus> faultStatus;
        FaultManager<Fault> faults;
        public int customer_id;
        public ArizaKaydi()
        {
            InitializeComponent();
            gelAllProduct();
            getAllFaultStatus();
        }
        private void gelAllProduct()
        {

            products = new ProductManager<Product>();
            gc_urunler.DataSource = products.getAllProductsAndBrand();
            /*sütun gizleme*/
            gv_urunler.Columns["product_ID"].Visible = false;
            gv_urunler.Columns["product_stock"].Visible = false;
            gv_urunler.Columns["product_subCategoryID"].Visible = false;
            gv_urunler.Columns["product_purchaseprice"].Visible = false;
            gv_urunler.Columns["product_brandID"].Visible = false;

            /*sütun ismi dğeiştirme*/

            gv_urunler.Columns["product_name"].Caption = "Ürün İsmi";
            gv_urunler.Columns["brand_name"].Caption = "Marka İsmi";
            gv_urunler.Columns["product_saleprice"].Caption = "Fiyat";


        }
        private void getAllFaultStatus() // arıza durumlarını çekiyor
        {
            faultStatus = new FaultManager<FaultStatus>(); 
            le_islemDurumu.Properties.DataSource = faultStatus.getAllFaultStatus(); // arıza durumunlarını lookupedit'e işliyor
            le_islemDurumu.Properties.DisplayMember = "fault_status";
            le_islemDurumu.Properties.ValueMember= "fault_statusID";

        }
  

        private void le_islemDurumu_QueryPopUp(object sender, CancelEventArgs e)
        {

            le_islemDurumu.Properties.ShowHeader = false;
            le_islemDurumu.Properties.PopulateColumns(); // sütunlar üzerinde işlem yapabilmeyi aktif halegetiriyor
            le_islemDurumu.Properties.Columns["fault_statusID"].Visible = false; // sütun gizlendi
            
        }


        private void gv_urunler_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (Convert.ToInt32(gv_urunler.GetFocusedRowCellDisplayText("product_stock")) != 0)
            {
                List<int> dememe = gv_urunler.GetSelectedRows().ToList(); // gv_urunler içerisindeki tüm satır index lerini alıyor
                decimal sumPrice = 0;
                foreach (int item in dememe)
                {
                    sumPrice += Convert.ToDecimal(gv_urunler.GetRowCellDisplayText(item, gv_urunler.Columns["product_saleprice"])); // seçilen satırdaki ücreti sumprice değişkenine aktarıyoruz
                }
                txt_ucret.EditValue = sumPrice; // texteditin değerini sumprice'a eşitliyoruz
            }
            else
            {
                XtraMessageBox.Show("Seçilen ürün stokta bulunmuyor..", "Uyarı",MessageBoxButtons.OK); // ürün stokta yoksa gelecek measjh
                gv_urunler.ClearSelection();
            }

        }

        private void btn_taskKapat_Click(object sender, EventArgs e)
        {
            if (le_islemDurumu.EditValue.ToString() != "1")
            {
                if (XtraMessageBox.Show("Task kapatılacak onaylıyor musunuz?", "Taskı Kapat", MessageBoxButtons.YesNo) != DialogResult.No)
                {

                    faults = new FaultManager<Fault>();
                    Fault updateFault = new Fault() // taskın yeni bilgilerini oluşturuyoruz
                    {
                        id = Convert.ToInt32(txt_kayitNo.Text),
                        statusID = Convert.ToInt32(le_islemDurumu.EditValue),
                        price = Convert.ToDecimal(txt_ucret.Text),
                        finishDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyy")),
                        solutionDetail = rtxt_cozum.Text
                    };
                    bool control = faults.updateById(updateFault); // yyeni bilgileri gönderip sonuç alıoyruz

                    if (control)
                    {
                        XtraMessageBox.Show("Task Kapatıldı", "Task Durum");
                        

                        SalesManager<SoldProduct> salesManager = new SalesManager<SoldProduct>();
                        foreach (SoldProduct item in saveAsSoldProduct())
                        {
                            salesManager.addSales(item);
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("Hata Meydana Geldi..");
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("İşlem durumunu seçiniz...","Uyarı",MessageBoxButtons.RetryCancel);
            }
            
            
        }

        private void le_islemDurumu_Properties_EditValueChanged(object sender, EventArgs e)
        {
         
        }
        private List<SoldProduct> saveAsSoldProduct() // kullanılan parçanın satıldı olarak veritabanına gönderilmesi
        {
            List<SoldProduct> soldProducts = new List<SoldProduct>();

            for (int i = 0; i < gv_urunler.RowCount; i++)
            {
                SoldProduct solds = new SoldProduct() { //parça nesnesi oluşturuluyor
                    productSold_customerID = customer_id,
                    productSold_productID = Convert.ToInt32(gv_urunler.GetRowCellDisplayText(i,"product_ID")),
                    productSold_totalPrice = Convert.ToInt32(gv_urunler.GetRowCellDisplayText(i,"product_saleprice")),
                    productSold_unit = 1,
                    productSold_reasonID = 2,
                    productSold_soldDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"))
                };
                soldProducts.Add(solds); // kullanılan ürün satıldı olarak veritabanına ekleniyor.
            }
            return soldProducts;
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}