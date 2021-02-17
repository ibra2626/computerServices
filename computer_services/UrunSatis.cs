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
using Entities.Concrete;
using Business.Concrete;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;

namespace computer_services
{
    public partial class UrunSatis : DevExpress.XtraEditors.XtraForm
    {
        List<SoldProduct> soldProducts = new List<SoldProduct>();
        public UrunSatis()
        {
            InitializeComponent();

            ProductManager<MainCategory> mainCategories = new ProductManager<MainCategory>();
            mainCategoryFill(mainCategories);

            CustomerManager customers = new CustomerManager();
            customersFill(customers);

        }

        private void mainCategoryFill(ProductManager<MainCategory> mainCategories)
        {
            le_mainCategory.Properties.DataSource = mainCategories.getAllMainCategory();
            int countRow = (le_mainCategory.Properties.DataSource as IList<MainCategory>).Count();
            le_mainCategory.Properties.DisplayMember = "mainCategory_name";
            le_mainCategory.Properties.ValueMember = "mainCategory_ID";
            le_mainCategory.Properties.ShowHeader = false;

            if (countRow > 0)
            {
                le_subCategory.Enabled = true;
                le_mainCategory.EditValue = 1;
            }
            else
            {
                le_subCategory.Enabled = false;
            }
        }

        private void subCategoryFill(ProductManager<SubCategory> subCategories, string mainCategoryID)
        {
            le_subCategory.Properties.DataSource = null;
            le_subCategory.Properties.DataSource = subCategories.getAllSubCategory(mainCategoryID).ToList();
            le_subCategory.Properties.DisplayMember = "subCategory_name";
            le_subCategory.Properties.ValueMember = "subCategory_ID";
            le_subCategory.Properties.ShowHeader = false;
        }

        private void productFill(ProductManager<Product> products, string subCategoryID)
        {
            gc_products.DataSource = null;
            gc_products.DataSource = products.getAllProducts(subCategoryID);
            gv_products.Columns["product_ID"].Visible = false;
            gv_products.Columns["product_name"].Caption = "Ürün İsmi";
            gv_products.Columns["brand_name"].Caption = "Marka İsmi";
            gv_products.Columns["product_saleprice"].Caption = "Satış Fiyatı";
            gv_products.Columns["product_stock"].Caption = "Stok";
            gv_products.Columns["product_subCategoryID"].Visible = false;
            gv_products.Columns["product_brandID"].Visible = false;
            gv_products.Columns["product_purchaseprice"].Visible = false;

        }

        private void customersFill(CustomerManager customers)
        {
            sLe_customers.Properties.DataSource = customers.getAll();
            sLe_customers.Properties.ValueMember = "customer_ID";
            sLe_customers.Properties.DisplayMember = "name";
            sLe_customers.Properties.View.OptionsView.ShowColumnHeaders = false;
        }
        private void le_mainCategory_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
            lookUpEdit.Properties.Columns[lookUpEdit.Properties.ValueMember.ToString()].Visible = false;
        }

        private void le_mainCategory_EditValueChanged(object sender, EventArgs e)
        {
            gc_products.DataSource = null;
            subCategoryFill(new ProductManager<SubCategory>(), le_mainCategory.EditValue.ToString());
        }

        private void le_subCategory_QueryPopUp(object sender, CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
            lookUpEdit.Properties.Columns[lookUpEdit.Properties.ValueMember.ToString()].Visible = false;
            lookUpEdit.Properties.Columns["subCategory_mainCatgID"].Visible = false;
        }

        private void le_subCategory_EditValueChanged(object sender, EventArgs e)
        {
            productFill(new ProductManager<Product>(), le_subCategory.EditValue.ToString());
            if (soldProducts.Count > 0)
            {
                foreach (SoldProduct item in soldProducts)
                {
                    for (int i = 0; i < gv_products.RowCount; i++)
                    {
                        if (item.productSold_productID == Convert.ToInt32(gv_products.GetRowCellDisplayText(i, gv_products.Columns["product_ID"])))
                        {
                            gv_products.SetRowCellValue(i, "product_stock", Convert.ToInt32(gv_products.GetRowCellDisplayText(i, gv_products.Columns["product_stock"])) - item.productSold_unit);
                        }
                    }
                }
            }
            gc_products.Refresh();
        }

        private void gv_products_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

        }

        private void gv_products_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gv_products.RowCount > 0)
            {
                txt_urunAd.Text = gv_products.GetFocusedRowCellValue("product_name").ToString();
                txt_urunKodu.Text = gv_products.GetFocusedRowCellValue("product_ID").ToString();
                txt_urunFiyat.Text = gv_products.GetFocusedRowCellValue("product_saleprice").ToString();
                txt_urunMarka.Text = gv_products.GetFocusedRowCellValue("brand_name").ToString();
                txt_urunStok.Text = gv_products.GetFocusedRowCellValue("product_stock").ToString();
            }

        }

        private void btn_sepeteEkle_Click(object sender, EventArgs e)
        {
            if (gv_products.RowCount > 0)
            {
                if (Convert.ToInt32(txt_adet.EditValue) != 0)
                {
                    if (stockShoppingCartControl())
                    {
                        if (sLe_customers.EditValue.ToString() != "")
                        {
                            if (shoppingCartProductControl())
                            {
                                SoldProduct soldProduct = new SoldProduct()
                                {
                                    product_name = gv_products.GetFocusedRowCellValue("product_name").ToString(),
                                    productSold_productID = Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_ID")),
                                    productSold_unit = Convert.ToInt32(txt_adet.EditValue),
                                    productSold_customerID = Convert.ToInt32(sLe_customers.EditValue),
                                    productSold_totalPrice = +Convert.ToInt32(txt_adet.EditValue) * Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_saleprice"))

                                };

                                soldProducts.Add(soldProduct);
                                gc_shoppingCart.DataSource = soldProducts.ToList();
                                gv_shoppingCart.Columns["productSold_ID"].Visible = false;
                                gv_shoppingCart.Columns["productSold_customerID"].Visible = false;
                                gv_shoppingCart.Columns["productSold_productID"].Visible = false;
                                gv_shoppingCart.Columns["productSold_reasonID"].Visible = false;
                                gv_shoppingCart.Columns["productSold_soldDate"].Visible = false;
                                gv_shoppingCart.Columns["productSold_unit"].Caption = "Adet";
                                gv_shoppingCart.Columns["product_name"].Caption = "Ürün İsmi";
                                gv_shoppingCart.Columns["productSold_totalPrice"].Caption = "Toplam Ücret";
                                gv_products.SetFocusedRowCellValue("product_stock", Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_stock")) - Convert.ToInt32(txt_adet.EditValue));
                                gc_products.Refresh();
                                txt_adet.Text = null;
                                shoppingCartTotalPrice();
                            }
                            else
                            {
                                XtraMessageBox.Show("Ürün sepette bululunuyor. Adet artırıldı.", "Bilgilendirme");
                                gc_shoppingCart.DataSource = soldProducts.ToList();
                                txt_adet.Text = null;
                                shoppingCartTotalPrice();
                            }

                        }
                        else
                        {
                            XtraMessageBox.Show("Lütfen müşteri seçiniz...", "Bilgilendirme");
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("Yeterli stok bulunmuyor...", "Bilgilendirme");
                    }
                }
                else
                {
                    XtraMessageBox.Show("Lütfen adet giriniz...", "Bilgilendirme");

                }
            }
            else
            {
                XtraMessageBox.Show("Ürün seçiniz..!", "Bilgilendirme");

            }
        }

        private void sLe_customers_Properties_EditValueChanged(object sender, EventArgs e)
        {
            foreach (SoldProduct item in soldProducts)
            {
                item.productSold_customerID = Convert.ToInt32(sLe_customers.EditValue);
            }
            gc_shoppingCart.DataSource = soldProducts.ToList();
            gv_shoppingCart.Columns["productSold_ID"].Visible = false;
            gv_shoppingCart.Columns["productSold_customerID"].Visible = false;
            gv_shoppingCart.Columns["productSold_productID"].Visible = false;
            gv_shoppingCart.Columns["productSold_reasonID"].Visible = false;
            gv_shoppingCart.Columns["productSold_soldDate"].Visible = false;
            gv_shoppingCart.Columns["productSold_unit"].Caption = "Adet";
            gv_shoppingCart.Columns["product_name"].Caption = "Ürün İsmi";
            gv_shoppingCart.Columns["productSold_totalPrice"].Caption = "Toplam Ücret";
        }
        private bool shoppingCartProductControl()// alışveriş sepetinde ücreti ve adeti artırıyor
        {
            foreach (SoldProduct item in soldProducts)
            {
                if (item.productSold_productID == Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_ID")))
                {
                    item.productSold_unit += Convert.ToInt32(txt_adet.EditValue);
                    item.productSold_totalPrice += Convert.ToInt32(txt_adet.EditValue) * Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_saleprice"));
                    gv_products.SetFocusedRowCellValue("product_stock", Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_stock")) - Convert.ToInt32(txt_adet.EditValue));
                    return false;
                }
            }
            return true;
        }

        private void btn_secileniCikart_Click(object sender, EventArgs e)
        {
            if (gv_products.RowCount > 0)
            {
                for (int i = 0; i < soldProducts.Count; i++)
                {
                    if (soldProducts[i].productSold_productID == Convert.ToInt32(gv_shoppingCart.GetFocusedRowCellValue("productSold_productID")))
                    {
                        soldProducts.Remove(soldProducts[i]);
                        gc_shoppingCart.DataSource = soldProducts.ToList();
                        gc_products.Refresh();

                    }
                }
            }
            shoppingCartTotalPrice();

        }
        private void btn_sepetiBosalt_Click(object sender, EventArgs e)
        {
            if (gv_products.RowCount > 0)
            {
                soldProducts.Clear();
                gc_shoppingCart.DataSource = soldProducts.ToList();
                productFill(new ProductManager<Product>(), le_subCategory.EditValue.ToString());
            }
            shoppingCartTotalPrice();
        }
        private bool stockShoppingCartControl() // stoğun yeterli olup olmadığı kontrol ediliyor
        {
            int productStock = Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_stock"));

            if (Convert.ToInt32(txt_adet.EditValue) <= productStock && Convert.ToInt32(txt_adet.EditValue) > 0)
            {
                return true;
            }
            return false;

        }
        private void shoppingCartTotalPrice() // alışveriş sepetinde ki ürünlerin toplam ücretini hesaplama
        {
            int totalPrice = 0;
            for (int i = 0; i < gv_shoppingCart.RowCount; i++)
            {
                totalPrice += Convert.ToInt32(gv_shoppingCart.GetRowCellDisplayText(i, "productSold_totalPrice"));
            }
            txt_toplamUcret.EditValue = totalPrice;
        }
        private void btn_satisYap_Click(object sender, EventArgs e)
        {
            if (soldProducts.Count >0)
            {
                if (XtraMessageBox.Show("Ürünlerin satışı yapılıyor onaylıyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    SalesManager<SoldProduct> addedSoldProduct = new SalesManager<SoldProduct>();
                    foreach (SoldProduct item in soldProducts)
                    {
                        item.product_name = null;
                        item.productSold_reasonID = 1;
                        item.productSold_soldDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
                        addedSoldProduct.addSales(item);
                    }
                    gc_shoppingCart.DataSource = null;
                    soldProducts.Clear();
                    txt_toplamUcret.Text = null;
                }
            }
            else
            {
                XtraMessageBox.Show("Sepet Boş!!", "Uyarı!");
            }
            
            
        }

        private void btn_musteriekle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.ShowDialog();
            customersFill(new CustomerManager());
        }
    }
}