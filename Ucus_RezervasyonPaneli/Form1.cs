using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucus_RezervasyonPaneli
{
    public partial class UcusRezervasyonPaneli : Form
    {
        public UcusRezervasyonPaneli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Add("Adınız-Soyadınız: " + " " + txtAdSoyad.Text + "TC Kimlik Numaranız: " + " " + maskedTxtBoxTCNo.Text + " " + " Telefon numaranız: " + " " + maskedTxtBoxTelefonNo.Text + " " + "Sefer Bilgileriniz:" + "" + comboBoxNereden.Text + "-" + comboBoxNereye.Text + "Uçuş tarih ve saatiniz: " + dtPickerTarih.Text + comboBoxSaat.Text);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBoxNereye.Text;
            comboBoxNereye.Text = comboBoxNereden.Text;
            comboBoxNereden.Text = label9.Text;
        }
    }
}
