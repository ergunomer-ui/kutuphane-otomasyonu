using KutuphaneOtomasyonu.Entities;

public class OduncIslem
{
    public int Id { get; set; }
    public int KitapId { get; set; } // Hangi kitap?
    public int UyeId { get; set; }   // Hangi üye?
    public DateTime VerilisTarihi { get; set; }
    public DateTime IadeTarihi { get; set; }

    // Navigation Properties: Bu kısımlar sayesinde "Kitap.KitapAdi" diyerek verilere ulaşacağız.
    public virtual Kitap Kitap { get; set; }
    public virtual Uye Uye { get; set; }
}