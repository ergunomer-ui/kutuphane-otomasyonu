using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullanici.Text;
            string sifre = txtSifre.Text;
            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                MessageBox.Show("Giriş Başarılı! Ana ekrana yönlendiriliyorsunuz.");
                MainForm anaForm = new MainForm();

                //Ana formu göster
                anaForm.Show();

                //Şu anki giriş ekranını gizle
                this.Hide();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
