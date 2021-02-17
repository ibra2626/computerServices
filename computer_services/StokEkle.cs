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
    public partial class StokEkle : DevExpress.XtraEditors.XtraForm
    {
        ProductManager<Product> productManager;
        public StokEkle()
        {
            InitializeComponent();
        }

        private void btn_stokEkle_Click(object sender, EventArgs e)
        {
            if (numUP_stok.Value != 0 && txt_alis.Text != null && txt_satis.Text != null)
            {
                productManager = new ProductManager<Product>();
                Product newStock = new Product() { 
                product_ID = Convert.ToInt32(lbl_urunID.Text),
                product_stock = Convert.ToInt32(numUP_stok.Value) + Convert.ToInt32(lbl_oncekiStock.Text),
                product_purchaseprice = Convert.ToDecimal(txt_alis.EditValue),
                product_saleprice = Convert.ToDecimal(txt_satis.EditValue)
                };
                XtraMessageBox.Show((productManager.updateStock(newStock)) ? "Stok Eklendi" : "Hata Meydana Geldi");
            }
            
        }

    }
}