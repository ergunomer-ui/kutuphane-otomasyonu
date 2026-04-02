using System;
using System.Linq;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.UI
{
    public partial class UyeForm : Form
    {
        KutuphaneContext db = new KutuphaneContext();

        public UyeForm()
        {
            InitializeComponent();
        }

        private void UyeleriListele()
        {
            // Grid'i tazele
            dgvUyeler.DataSource = db.Uyeler.ToList();
        }

        private void UyeForm_Load(object sender, EventArgs e)
        {
            UyeleriListele();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            // Üye Ekleme
            try
            {
                Uye yeniUye = new Uye
                {
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    Telefon = txtTelefon.Text,
                    Eposta = txtEposta.Text
                };
                db.Uyeler.Add(yeniUye);
                db.SaveChanges();
                UyeleriListele();
                MessageBox.Show("Üye başarıyla kaydedildi");
                FormuTemizle();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            // Üye Silme
            if (dgvUyeler.CurrentRow != null)
            {
                int id = (int)dgvUyeler.CurrentRow.Cells["Id"].Value;
                var silinecek = db.Uyeler.Find(id);
                db.Uyeler.Remove(silinecek);
                db.SaveChanges();
                UyeleriListele();
            }
        }

        private void FormuTemizle()
        {
            txtAd.Clear(); txtSoyad.Clear(); txtTelefon.Clear(); txtEposta.Clear();
        }

        private void dgvUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}