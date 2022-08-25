namespace eticaret.Models
{
    public class AnasayfaModeli
    {
        public string Baslik { get; set; }

        public DateTime Suan { get; set; }

        public string Sehir { get; set; }

        public List<Kullanici> Kullanicilar { get; set; } = new List<Kullanici>();

        public List<Araba> Arabalar { get; set; } = new List<Araba>();

        public List<Bilgisayar> Bilgisayarlar { get; set; } = new List<Bilgisayar>();
    }
}
