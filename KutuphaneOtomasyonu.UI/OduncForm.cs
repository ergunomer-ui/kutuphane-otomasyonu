using KutuphaneOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;

namespace KutuphaneOtomasyonu.UI
{
    public partial class OduncForm : Form
    {
        KutuphaneContext context = new KutuphaneContext();

        public OduncForm()
        {
            InitializeComponent();
        }

        private void OduncForm_Load(object sender, EventArgs e)
        {
            // Form açıldığında listeleri doldur
            cmbKitaplar.DataSource = context.Kitaplar.ToList();
            cmbKitaplar.DisplayMember = "KitapAdi";
            cmbKitaplar.ValueMember = "Id";

            cmbUyeler.DataSource = context.Uyeler.ToList();
            cmbUyeler.DisplayMember = "Ad";
            cmbUyeler.ValueMember = "Id";
        }


        //Ödünç Ver
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            using (var context = new KutuphaneContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // 1. Ödünç kaydını oluştur
                        var yeniOdunc = new OduncIslem
                        {
                            KitapId = (int)cmbKitaplar.SelectedValue,
                            UyeId = (int)cmbUyeler.SelectedValue,
                            VerilisTarihi = DateTime.Now,
                            IadeTarihi = dtpIade.Value
                        };

                        //Kitabı bul ve "Ödünçte" olarak işaretle
                        var kitap = context.Kitaplar.Find(yeniOdunc.KitapId);
                        if (kitap != null)
                        {
                            kitap.IsBorrowed = true;
                        }

                        context.OduncIslemleri.Add(yeniOdunc);
                        context.SaveChanges();
                        transaction.Commit(); //Her iki işlemi de onayla

                        MessageBox.Show("Kitap başarıyla ödünç verildi!");
                        ListeleOduncIslemleri(); //tabloyu yenile
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
            }
        }

        private void OduncForm_Load_1(object sender, EventArgs e)
        {
            using (var context = new KutuphaneContext())
            {
                // Kitapları Listele
                cmbKitaplar.DataSource = context.Kitaplar.ToList();
                cmbKitaplar.DisplayMember = "KitapAdi";
                cmbKitaplar.ValueMember = "Id";

                // Üyeleri Listele
                cmbUyeler.DataSource = context.Uyeler.ToList();
                cmbUyeler.DisplayMember = "Ad";
                cmbUyeler.ValueMember = "Id";
                ListeleOduncIslemleri();
            }
        }


        private void ListeleOduncIslemleri()
        {
            using (var context = new KutuphaneContext())
            {
                var liste = context.OduncIslemleri
                    .Include(o => o.Kitap) // Kitap tablosundaki isimleri getir
                    .Include(o => o.Uye)   // Üye tablosundaki isimleri getir
                    .Select(o => new
                    {
                        o.Id,
                        Kitap = o.Kitap.KitapAdi, // Ekranda görünecek sütun: Kitap Adı
                        Uye = o.Uye.Ad,           // Ekranda görünecek sütun: Üye Adı
                        Verilis = o.VerilisTarihi,
                        Iade = o.IadeTarihi
                    }).ToList();

                dgvOduncListesi.DataSource = liste; //Verileri tabloya bağla
            }
        }

        //İade al butonu
        private void btnIadeAl_Click(object sender, EventArgs e)
        {
            if (dgvOduncListesi.CurrentRow == null) return;

            // Seçili satırdaki veriyi al
            int seciliIslemId = Convert.ToInt32(dgvOduncListesi.CurrentRow.Cells["Id"].Value);

            using (var context = new KutuphaneContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var islem = context.OduncIslemleri.Find(seciliIslemId);
                        if (islem != null)
                        {
                            //Kitabı rafa geri ekle
                            var kitap = context.Kitaplar.Find(islem.KitapId);
                            if (kitap != null) kitap.IsBorrowed = false;

                            //Ödünç kaydını sil
                            context.OduncIslemleri.Remove(islem);

                            context.SaveChanges();
                            transaction.Commit();

                            MessageBox.Show("Kitap başarıyla iade alındı!");
                            ListeleOduncIslemleri();
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("İade alınamadı: " + ex.Message);
                    }
                }
            }
        }

        private void btnOduncIptal_Click(object sender, EventArgs e)
        {

        }

        private void dgvOduncListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbUyeler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}