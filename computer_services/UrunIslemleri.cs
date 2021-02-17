using Business.Concrete;
using DevExpress.Utils.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Senders;
using DevExpress.XtraLayout.Customization;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace computer_services
{
    public partial class UrunIslemleri : DevExpress.XtraEditors.XtraForm
    {
        UrunEkle urunekle;


        public UrunIslemleri()
        {
            InitializeComponent();

            le_mainCategory.EditValue = 1; // sayfa açıldığında ekrana gelecek ana katagori

            mainCategoryFill(createManager<MainCategory>(new MainCategory())); // lu_mainCategory isimli lookupedit nesnesini dolduruluyor

        }
        private ProductManager<T> createManager<T>(T entity) where T : IEntity
        {
            return new ProductManager<T>();
        }
        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            string categoryName = XtraInputBox.Show("Kategori ismi giriniz!", "Kategori Ekle", "");


            if (categoryName != null && categoryName != "")
            {
                SubCategory addedCategory = new SubCategory()
                {
                    subCategory_name = categoryName,
                    subCategory_mainCatgID = Convert.ToInt32(le_mainCategory.EditValue)
                };
                XtraMessageBox.Show((createManager<SubCategory>(new SubCategory()).addSubCategory(addedCategory)) ? "Kategori Ekledi..." : "Hata meydana geldi...!", "Bilgilendirme");
                subCategoryFill(new ProductManager<SubCategory>(), le_mainCategory.EditValue.ToString());
            };

        }


        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            if (urunekle == null || urunekle.IsDisposed)
            {
                urunekle = new UrunEkle();
                urunekle.lbl_kategoriID.Text = grdV_subCategory.GetFocusedRowCellValue("subCategory_ID").ToString();
                urunekle.lbl_kategoriIsim.Text = grdV_subCategory.GetFocusedRowCellValue("subCategory_name").ToString();
                urunekle.Show();
            }
            else
            {
                urunekle.Focus();
            }
        }

        private void le_mainCategory_Properties_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lookUpEdit = sender as LookUpEdit;
            lookUpEdit.Properties.PopulateColumns();
            lookUpEdit.Properties.Columns[le_mainCategory.Properties.ValueMember.ToString()].Visible = false;
        }

        private void mainCategoryFill(ProductManager<MainCategory> mainCategories)
        {
            le_mainCategory.Properties.DataSource = mainCategories.getAllMainCategory().ToList();
            int countRow = (le_mainCategory.Properties.DataSource as IList<MainCategory>).Count();
            le_mainCategory.Properties.DisplayMember = "mainCategory_name";
            le_mainCategory.Properties.ValueMember = "mainCategory_ID";
            le_mainCategory.Properties.ShowHeader = false;

            if (countRow > 0)
            {
                foreach (Control button in tPanel_subCategory.Controls)
                {
                    if (button is SimpleButton)
                    {
                        button.Enabled = true;
                    }
                }
            }
            else
            {
                foreach (Control button in tPanel_subCategory.Controls)
                {
                    if (button is SimpleButton)
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        private void subCategoryFill(ProductManager<SubCategory> subCategories, string mainCategoryID)
        {
            gc_subCategory.DataSource = null;
            gc_subCategory.DataSource = subCategories.getAllSubCategory(mainCategoryID);
            grdV_subCategory.Columns["subCategory_ID"].Visible = false;
            grdV_subCategory.Columns["subCategory_mainCatgID"].Visible = false;
            grdV_subCategory.Columns["subCategory_name"].Caption = "Alt Kategori";
        }

        private void le_mainCategory_Properties_EditValueChanged(object sender, EventArgs e)
        {
            subCategoryFill(new ProductManager<SubCategory>(), le_mainCategory.EditValue.ToString());

        }

        private void productFill(ProductManager<Product> products, string subCategoryID)
        {

            gc_products.DataSource = products.getAllProducts(subCategoryID);
            gv_products.Columns["product_ID"].Visible = false;
            gv_products.Columns["product_subCategoryID"].Visible = false;
            gv_products.Columns["product_brandID"].Visible = false;
            
            gv_products.Columns["product_purchaseprice"].Visible = false;
            gv_products.Columns["product_stock"].Caption = "Stok";
            gv_products.Columns["product_name"].Caption = "Ürün ismi";
            gv_products.Columns["brand_name"].Caption = "Marka İsmi";
            gv_products.Columns["product_saleprice"].Caption = "Satış Fiyatı";

        }
        private void grdV_subCategory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (grdV_subCategory.GetFocusedRowCellValue("subCategory_ID") != null)
            {
                tPanel_product.Enabled = true;
                tPanel_productMenu.Enabled = true;
                lbl_kategori.Text = grdV_subCategory.GetFocusedRowCellValue("subCategory_name").ToString();
                productFill(new ProductManager<Product>(), grdV_subCategory.GetFocusedRowCellValue("subCategory_ID").ToString());

            }
            else
            {
                lbl_kategori.Text = "";
                tPanel_product.Enabled = false;
                tPanel_productMenu.Enabled = false;
                gc_products.DataSource = null;
            }

        }

        private void btn_stokEkle_Click(object sender, EventArgs e)
        {
            if (gv_products.RowCount > 0)
            {
                StokEkle stokEkle = new StokEkle();
                stokEkle.lbl_urunID.Text = gv_products.GetFocusedRowCellValue("product_ID").ToString();
                stokEkle.lbl_urunIsmi.Text = gv_products.GetFocusedRowCellValue("product_name").ToString();
                stokEkle.lbl_oncekiStock.Text = gv_products.GetFocusedRowCellValue("product_stock").ToString();
                stokEkle.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Bir ürün seçiniz..!", "UYARI!");
            }

        }

        private void tPanel_subCategory_Click(object sender, EventArgs e)
        {

        }

        private void btn_anaKategoriEkle_Click(object sender, EventArgs e)
        {
            string categoryName = XtraInputBox.Show("Ana kategori ismi giriniz : ", "Kategori Ekle", "");

            if (categoryName != null && categoryName != "")
            {
                MainCategory addMainCategory = new MainCategory()
                {
                    mainCategory_name = categoryName
                };
                XtraMessageBox.Show((createManager<MainCategory>(new MainCategory()).addMainCategory(addMainCategory)) ? "Kategori Ekledi..." : "Hata meydana geldi...!", "Bilgilendirme");
                mainCategoryFill(createManager<MainCategory>(new MainCategory()));
            }
        }

        private void btn_kategoriSil_Click(object sender, EventArgs e)
        {

            if (grdV_subCategory.RowCount > 0)
            {
                if (XtraMessageBox.Show("Kategori silinecek onaylıyor musunuz?", "Bilgiledirme", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    SubCategory deletedSubCategory = new SubCategory()
                    {
                        subCategory_ID = Convert.ToInt32(grdV_subCategory.GetFocusedRowCellValue("subCategory_ID"))
                    };
                    bool control = createManager<SubCategory>(new SubCategory()).deleteSubCategoryByID(deletedSubCategory);
                    XtraMessageBox.Show(((control) ? "Kategori Sİlindi.." : "Hata meydana geldi!"), "Bilgilendirme");
                    subCategoryFill(new ProductManager<SubCategory>(), le_mainCategory.EditValue.ToString());
                }
            }
            else
            {
                XtraMessageBox.Show("Lüften ürün kategorisi seçiniz..!", "Hata");
            }
        }

        private void btn_urunSil_Click(object sender, EventArgs e)
        {
            if (gv_products.RowCount > 0)
            {
                if (XtraMessageBox.Show("Ürün silinecek onaylıyor musunuz?", "Bilgiledirme", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    Product deletedProduct = new Product()
                    {
                        product_ID = Convert.ToInt32(gv_products.GetFocusedRowCellValue("product_ID"))
                    };
                    bool control = createManager<Product>(new Product()).deleteProductByID(deletedProduct);
                    XtraMessageBox.Show(((control) ? "Ürün Sİlindi.." : "Hata meydana geldi!"), "Bilgilendirme");
                    productFill(new ProductManager<Product>(), grdV_subCategory.GetFocusedRowCellValue("subCategory_ID").ToString());
                }
            }
            else
            {
                XtraMessageBox.Show("Lüften ürün seçiniz..!", "Hata");
            }
        }
    }
}