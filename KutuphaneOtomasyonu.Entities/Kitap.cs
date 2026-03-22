namespace KutuphaneOtomasyonu.Entities
{
    public class Kitap
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public int SayfaSayisi { get; set; }
        public string KapakResmi { get; set; }
        public bool IsBorrowed { get; set; } // true ise ödünçte, false ise kütüphanede
    }
}