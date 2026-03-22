using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using KutuphaneOtomasyonu.Entities;

namespace KutuphaneOtomasyonu.UI
{
    public partial class MainForm : Form
    {
        //Veritabanı bağlantısı
        KutuphaneContext db = new KutuphaneContext();
        string resimYolu = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            VerileriYenile(); //Veritabanındaki kitapları tabloya getirir
        }

        //Kitap Ekle
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kitap yeni = new Kitap
                {
                    KitapAdi = txtKitapAdi.Text,
                    Yazar = txtYazar.Text,
                    SayfaSayisi = int.Parse(txtSayfa.Text),
                    KapakResmi = resimYolu
                };

                db.Kitaplar.Add(yeni); // Listeye ekle
                db.SaveChanges();      // Veritabanını kaydet

                VerileriYenile();      // Tabloyu güncelle
                Temizle();             // Kutuları boşalt
                MessageBox.Show("Kitap Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        //Seçili Kitabı Sil
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKitaplar.SelectedRows.Count > 0)
            {
                //Seçili kitabı bul
                Kitap secili = (Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem;

                db.Kitaplar.Remove(secili); //Veritabanından silme listesine al
                db.SaveChanges();           //Silmeyi Onayla

                VerileriYenile();           //Tabloyu güncelle
            }
        }

        //Yardımcı Metodlar
        private void VerileriYenile()
        {
            // Veritabanınından verilerei çekerek güncel tutar
            using (var db = new KutuphaneContext())
            {
                var liste = db.Kitaplar.Select(k => new
                {
                    k.Id,
                    k.KitapAdi,
                    k.Yazar,
                    k.SayfaSayisi,
                    // IsBorrowed true ise çarpı, false ise onay işareti basıyoruz
                    Durum = k.IsBorrowed ? "❌ Ödünç Verildi" : "✅ Rafta"
                }).ToList();

                dgvKitaplar.DataSource = null;
                dgvKitaplar.DataSource = liste;
            }
        }

        private void Temizle()
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            txtSayfa.Clear();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (db == null) return;

            string arananMetin = txtArama.Text.ToLower();

            var sonuc = db.Kitaplar
                .Where(k => k.KitapAdi.ToLower().Contains(arananMetin) ||
                            k.Yazar.ToLower().Contains(arananMetin))
                .Select(k => new {
                    k.Id,
                    k.KitapAdi,
                    k.Yazar,
                    k.SayfaSayisi,
                    Durum = k.IsBorrowed ? "❌ Ödünç Verildi" : "✅ Rafta"
                })
                .ToList();

            dgvKitaplar.DataSource = sonuc;
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbKapak.ImageLocation = ofd.FileName;
                resimYolu = ofd.FileName; //Dosya yolunu sakla
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeForm frm = new UyeForm();
            frm.Show(); //formu ekrana getir
        }

        // Ödünç işlemleri formu kapandığında ana ekranın güncellenmesi için:
        private void btnOduncIslemleri_Click(object sender, EventArgs e)
        {
            OduncForm frm = new OduncForm();
            frm.ShowDialog(); // Form kapanana kadar bekler
            VerileriYenile(); // Kapanınca listeyi hemen günceller
        }
    }
}