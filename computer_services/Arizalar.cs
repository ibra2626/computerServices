using Business.Concrete;
using DevExpress.DataAccess.Native.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Entities.Concrete;
using Ninject.Infrastructure.Introspection;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace computer_services
{
    public partial class Arizalar : DevExpress.XtraEditors.XtraForm
    {
        ArizaKaydi arizakaydi;
        MusteriEkle musteriEkle;
        FaultManager<Fault> faults = new FaultManager<Fault>();

        public Arizalar()
        {
            InitializeComponent();

            getAllFaultInfos();
            fillFaultProduct();
            getAllCustomerAndFill();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void getAllFaultInfos()
        {
            gc_faults.DataSource = faults.getAll(); // bilgileri gridviewe işleme


            /* Kullanılmayacak sütunların gizlenmesi*/
            grdV_faults.Columns["id"].Visible = false;
            grdV_faults.Columns["customer_ID"].Visible = false;
            grdV_faults.Columns["solutionDetail"].Visible = false;
            grdV_faults.Columns["price"].Visible = false;
            grdV_faults.Columns["model"].Visible = false;
            grdV_faults.Columns["component"].Visible = false;
            grdV_faults.Columns["statusID"].Visible = false;
            grdV_faults.Columns["faultProduct_ID"].Visible = false;
            grdV_faults.Columns["phoneNumber"].Visible = false;

            /*Sütun isimlendirmeleri*/

            grdV_faults.Columns["identificationNumber"].Caption= "T.C No";
            grdV_faults.Columns["name"].Caption= "Müşteri Ad";
            grdV_faults.Columns["surname"].Caption= "Müşteri Soyad";
            grdV_faults.Columns["faultProduct_reason"].Caption= "Arızalı Ürün";
            grdV_faults.Columns["detail"].Caption= "Arıza Detayı";
            grdV_faults.Columns["startDate"].Caption= "Başlangıç Tarihi";
            grdV_faults.Columns["finishDate"].Caption= "Arıza Bitiş Tarihi";
            grdV_faults.Columns["fault_status"].Caption= "Arıza Durumu";





        }
        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            musteriEkle = new MusteriEkle(); // müşteri ekleme paneli
            musteriEkle.ShowDialog();
            getAllCustomerAndFill();
        }
        public void getAllCustomerAndFill() // müşteri bilgilerini lookupedit nesnesine ekleme
        {
            CustomerManager customers = new CustomerManager(); // customerManager oluşturuldu
            sLe_customers.Properties.DataSource = customers.getAll(); // bilgiler çekildi ve işlendi.
            sLe_customers.Properties.ValueMember = "customer_ID";
            sLe_customers.Properties.DisplayMember = "name";

        }


        public void fillFaultProduct() // ürün listeler
        {
            FaultManager<FaultProducts> faultsProduct = new FaultManager<FaultProducts>();

            le_arizaliParca.Properties.DataSource = faultsProduct.getFaultProduct(); // ürünleri listeler
            le_arizaliParca.Properties.ValueMember = "faultProduct_ID";
            le_arizaliParca.Properties.DisplayMember = "faultProduct_reason";
            le_arizaliParca.EditValue = 1;
        }


        private void btn_arizaOlustur_Click(object sender, EventArgs e)
        {

            if (textEditEmptyControl(tPanel_arizaKaydiOlustur)) // textEditEmptyCOntrol() tablepanel içerisinde alanlar boş ise true döner
            {
                XtraMessageBox.Show("Lütfen alanları boş bırakmayınız...");
            }
            else
            {
                FaultManager<FaultAdded> faultsAdded = new FaultManager<FaultAdded>();

                FaultAdded faultInfos = new FaultAdded() // yeni arıza için nesne oluşturuluyor ve dolduruluyor.
                {
                    customer_ID = Convert.ToInt32(sLe_customers.EditValue),
                    faultProduct_ID = Convert.ToInt32(le_arizaliParca.EditValue),
                    model = txt_model.Text,
                    component = txt_ekParca.Text,
                    detail = rtxt_arizaDetayi.Text,
                    statusID = 1,
                    startDate = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"))
                };
                bool control = faultsAdded.add(faultInfos); // nesne veritabanına eklendi.Döneme değer true veya false

                if (control) // dönene değere göre uyarı mesajı
                {
                    MessageBox.Show("Arıza kaydı oluşturuldu...");
                    getAllFaultInfos();
                    controlsClear(tPanel_arizaKaydiOlustur); // tüm textboxların içeriği temizlendi.
                }
                else
                {
                    MessageBox.Show("Kayıt oluşturulamadı..Hata...");

                }
            }
        }
        private void controlsClear(Control tPanel) // kendisine gönderilen tablepanel içindeki textedit,richedit vb nesnelerin içeriğimi temizler
        {
            foreach (Control item in tPanel.Controls)
            {
                if (item is TextEdit || item is RichTextBox || item is SearchLookUpEdit)
                {
                    item.Text = "";
                }
            }
        }
        private bool textEditEmptyControl(Control tPanel) // textedit nesnelerinin boş olup olmadığı kontrol ediliyor
        {
            foreach (Control item in tPanel.Controls)
            {
                if (item is TextEdit || item is SearchLookUpEdit)
                {
                    if (item.Text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void sLeView_customers_RowCountChanged(object sender, EventArgs e)
        {
        }

        private void grdV_faults_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) //gridview faults nesnesinde satıra focus olunduğu zaman
        {
            /* bir satıra focus olunursa textedit nesneleri satırda ki bilgiler ile dolduruluyor */
            if (grdV_faults.RowCount != 0)
            {
                txt_adSoyad.Text = grdV_faults.GetFocusedRowCellValue("name").ToString() + " " + grdV_faults.GetFocusedRowCellValue("surname").ToString();
                txt_islemDurumu.Text = grdV_faults.GetFocusedRowCellValue("fault_status").ToString();
                txt_musteriTel.Text = grdV_faults.GetFocusedRowCellValue("phoneNumber").ToString();
                rtxt_arizaDetay.Text = grdV_faults.GetFocusedRowCellValue("detail").ToString();
            }

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            controlsClear(tPanel_arizaKaydiOlustur);
        }

        private void grdV_faults_DoubleClick(object sender, EventArgs e)
        {

        }

        private void grdV_faults_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void grdV_faults_DoubleClick_1(object sender, EventArgs e)// bir satıra 2 kere tıklayınca tıklanılan satırdaki bilgiler arizakaydi formuna gönderiliyor.
        {

            if (arizakaydi == null || arizakaydi.IsDisposed)
            {
                arizakaydi = new ArizaKaydi();
                /*arizakaydi formuna bilgiler gönderiliyor.*/
                arizakaydi.customer_id = Convert.ToInt32(grdV_faults.GetFocusedRowCellValue("customer_ID"));
                arizakaydi.txt_tc.Text = grdV_faults.GetFocusedRowCellValue("identificationNumber").ToString();
                arizakaydi.txt_musteriAd.Text = grdV_faults.GetFocusedRowCellValue("name").ToString();
                arizakaydi.txt_musteriSoyad.Text = grdV_faults.GetFocusedRowCellValue("surname").ToString();
                arizakaydi.txt_cep.Text = grdV_faults.GetFocusedRowCellValue("phoneNumber").ToString();
                arizakaydi.txt_kayitNo.Text = grdV_faults.GetFocusedRowCellValue("id").ToString();
                arizakaydi.rtxt_arizaDetayi.Text = grdV_faults.GetFocusedRowCellValue("detail").ToString();
                arizakaydi.txt_arizaliParca.Text = grdV_faults.GetFocusedRowCellValue("faultProduct_reason").ToString();
                arizakaydi.txt_model.Text = grdV_faults.GetFocusedRowCellValue("model").ToString();
                arizakaydi.le_islemDurumu.EditValue = grdV_faults.GetFocusedRowCellValue("statusID").ToString();
                if (grdV_faults.GetFocusedRowCellValue("price") != null)
                {
                    arizakaydi.txt_ucret.EditValue = grdV_faults.GetFocusedRowCellValue("price");
                }
                if (grdV_faults.GetFocusedRowCellValue("solutionDetail") != null)
                {
                    arizakaydi.rtxt_cozum.Text = grdV_faults.GetFocusedRowCellValue("solutionDetail").ToString();
                }
                if (Convert.ToInt32(grdV_faults.GetFocusedRowCellValue("statusID")) != 1)
                {
                    arizakaydi.btn_taskKapat.Enabled = false;
                    arizakaydi.lbl_durum.Text = "Task Kapalı";
                    arizakaydi.lbl_durum.ForeColor = Color.Red;
                    arizakaydi.lbl_durum.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                }
                else
                {
                    arizakaydi.lbl_durum.Text = "Task Açık";
                    arizakaydi.lbl_durum.ForeColor = Color.Green;
                    arizakaydi.lbl_durum.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                }
                arizakaydi.Show(); // arızakaydi formu açılıyor
                getAllFaultInfos();
            }
            else
            {
                arizakaydi.Focus();
            }

        }

        private void rbtn_bekliyor_CheckedChanged(object sender, EventArgs e)
        {
            grdV_faults.Columns["statusID"].FilterInfo = new ColumnFilterInfo("[statusID] = '1'"); // durumu ""bekliyor" olan arızalar
        }

        private void rbtn_cozuldu_CheckedChanged(object sender, EventArgs e)
        {
            grdV_faults.Columns["statusID"].FilterInfo = new ColumnFilterInfo("[statusID] = '2'");// durumu ""çözüldü" olan arızalar
        }

        private void rbtn_cozulemedi_CheckedChanged(object sender, EventArgs e)
        {
            grdV_faults.Columns["statusID"].FilterInfo = new ColumnFilterInfo("[statusID] = '3'");// durumu ""çözülemedi" olan arızalar

        }

        private void rbtn_tumu_CheckedChanged(object sender, EventArgs e)
        {
            grdV_faults.Columns["statusID"].ClearFilter(); // tüm arızalar

        }

        private void le_arizaliParca_Properties_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void sLe_customers_Properties_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            sLe_customers.Properties.View.OptionsView.ShowColumnHeaders = false;
        }
    }

}