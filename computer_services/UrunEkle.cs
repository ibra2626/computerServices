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
using Entities.Concrete;

namespace computer_services
{
    public partial class UrunEkle : DevExpress.XtraEditors.XtraForm
    {
        ProductManager<Brand> brands;
        ProductManager<Product> product;
        public UrunEkle()
        {
            InitializeComponent();
            fillBrand();
        }

        private void UrunEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void UrunEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btn_MarkaEkle_Click(object sender, EventArgs e)
        {

            string brand = XtraInputBox.Show("Marka ismi giriniz : ", "Marka Ekle", "");
            if (brand != null)
            {
                brands = new ProductManager<Brand>();
                Brand newBrand = new Brand() {
                    brand_name = brand
                };
                bool control = brands.addBrand(newBrand);
                if (control)
                {
                    XtraMessageBox.Show("Yeni marka eklendi...", "Marka Ekleme");
                    fillBrand();
                }
                else
                {
                    XtraMessageBox.Show("Bir hata meydana geldi!", "HATA");

                }
            }
        }
        private void fillBrand()
        {
            brands = new ProductManager<Brand>();
            le_marka.Properties.DataSource =  brands.getAllBrands().ToList();
            le_marka.Properties.ValueMember = "brand_id";
            le_marka.Properties.DisplayMember = "brand_name";
            le_marka.Properties.ShowHeader = false;
        }

        private void lookUpEdit1_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            le_marka.Properties.PopulateColumns();
            le_marka.Properties.Columns["brand_id"].Visible = false;
        }

        private void btn_Olustur_Click(object sender, EventArgs e)
        {
            product = new ProductManager<Product>();
            Product newProduct = new Product() { 
                product_brandID = Convert.ToInt32(le_marka.EditValue),
                product_name = txt_urunAd.Text,
                product_purchaseprice = Convert.ToDecimal(txt_birimAlis.EditValue),
                product_saleprice = Convert.ToDecimal(txt_birisSatis.EditValue),
                product_stock = Convert.ToInt32(numUP_stok.Value),
                product_subCategoryID = Convert.ToInt32(lbl_kategoriID.Text)
            };
            bool control = product.addProduct(newProduct);
            XtraMessageBox.Show((control) ? "Eklendi" : "Eklenemedi");
        }
    }
}