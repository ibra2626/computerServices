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
using System.ComponentModel.DataAnnotations;
using DevExpress.CodeParser;

namespace computer_services
{
    public partial class MusteriEkle : DevExpress.XtraEditors.XtraForm
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void btn_Olustur_Click(object sender, EventArgs e)
        {

            if (textEditEmptyControl(tPanel_musteriEkle))
            {
                CustomerManager customerManager = new CustomerManager();

                Customer customerInfos = new Customer()
                {
                    identificationNumber = txt_MTc.Text.ToString(),
                    name = txt_MAd.Text.ToString(),
                    surname = txt_MSoyad.Text.ToString(),
                    phoneNumber = txt_MTel.Text.ToString()
                };

                bool control = customerManager.add(customerInfos);
                if (control)
                {
                    XtraMessageBox.Show("Kayıt eklendi");
                }
                else
                {
                    XtraMessageBox.Show("TC kimlik numarası zaten var...");
                }
            }
            else
                XtraMessageBox.Show("Boş Alan Bırakmayınız!");
            
        }

        private void MusteriEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
                        
        }
        private bool textEditEmptyControl(Control field)
        {
            foreach (Control item in field.Controls)
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