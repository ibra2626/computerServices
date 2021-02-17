using Business.Concrete;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Entities.Concrete;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace computer_services
{
    public partial class Musteriler : DevExpress.XtraEditors.XtraForm
    {
        MusteriEkle musteriEkle;
        CustomerManager customerM = new CustomerManager();
        public Musteriler()
        {
            InitializeComponent();

            gridViewFill();
        }

        private void gridViewFill() // müşteri bilgileri datagridview'E yazılıyor
        {

            gc_musteriler.DataSource = customerM.getAll();
            gv_musteriler.Columns["identificationNumber"].Caption = "Müşteri T.C";
            gv_musteriler.Columns["name"].Caption = "Müşteri Adı";
            gv_musteriler.Columns["surname"].Caption = "Müşteri Soyadı";
            gv_musteriler.Columns["phoneNumber"].Caption = "Müşteri Telefonu";
            gv_musteriler.Columns["customer_ID"].Visible = false;
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            musteriEkle = new MusteriEkle();
            musteriEkle.ShowDialog();
            gridViewFill();            

        }

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if(XtraMessageBox.Show("Seçilen müşteri bilgileri ve müşteriye ait tüm işlemler silinecek.Onaylıyor musunuz?","Müşteri Silme",MessageBoxButtons.YesNo) != DialogResult.No)
            {
                Customer deletedCustomer = new Customer() // silinecek müşteri bilgileri oluşturuluyor
                {
                    customer_ID = Convert.ToInt32(gv_musteriler.GetFocusedRowCellValue("customer_ID"))
                };
                bool control = customerM.deleteDataByID(deletedCustomer); // bilgiler gönderiliyor gelen değere göre mesaj gösteriliyor.

                if (control)
                {
                    XtraMessageBox.Show("Kayıt Silindi...");
                }
                else
                {
                    XtraMessageBox.Show("Hata meydana geldi...");
                }
            }
            
            gridViewFill();

        }

        private void gv_musteriler_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            if(!(gv_musteriler.RowCount == 0))
            {
                txt_ad.Text = gv_musteriler.GetFocusedRowCellValue("name").ToString();
                txt_soyad.Text = gv_musteriler.GetFocusedRowCellValue("surname").ToString();
                txt_tc.Text = gv_musteriler.GetFocusedRowCellValue("identificationNumber").ToString();
                txt_telefon.Text = gv_musteriler.GetFocusedRowCellValue("phoneNumber").ToString();
            }
            
        }

        private void btn_guncelle_Click(object sender, EventArgs e) // güncelle butonuna basında texteditlerin enable olöaso
        {
            btn_kaydet.Enabled = true;
            textEditEnableDisable(true, tPanel_musteri);
        }
        private void textEditEnableDisable(bool enableStatus,Control tpanel)
        {
            foreach (Control item in tpanel.Controls)
            {
                if (item is TextEdit)
                {
                    item.Enabled = enableStatus;
                }
            }
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (textEditEmptyControl(tPanel_musteri))
            {
                if(XtraMessageBox.Show("Bilgiler güncellenecek. Onaylıyor musunuz?", "Müşteri Silme", MessageBoxButtons.YesNo) != DialogResult.No)
                {
                    Customer updateCustomerInfo = new Customer() // yeni müşteri bilgileri oluşturuluyor
                    {
                        customer_ID = Convert.ToInt32(gv_musteriler.GetFocusedRowCellValue("customer_ID")),
                        identificationNumber = txt_tc.Text.ToString(),
                        name = txt_ad.Text.ToString(),
                        surname = txt_soyad.Text.ToString(),
                        phoneNumber = txt_telefon.Text.ToString()

                    };

                    bool control = customerM.updateDataByID(updateCustomerInfo); // yeni müşter veri tabanına gönderiliyor ve update ediliyor.

                    if (control)
                    {
                        XtraMessageBox.Show("Kayıt güncellendi...");
                        btn_kaydet.Enabled = false;
                        textEditEnableDisable(false, tPanel_musteri);
                    }
                    else
                    {
                        XtraMessageBox.Show("T.C Zaten mevcut...");
                    }
                }
            }
            else
                XtraMessageBox.Show("Boş alan bırakmayınız...");
            

            gridViewFill();
        }

        private bool textEditEmptyControl(Control tpanel)
        {
            foreach (Control item in tpanel.Controls)
            {
                if (item is TextEdit)
                {
                    if (item.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}