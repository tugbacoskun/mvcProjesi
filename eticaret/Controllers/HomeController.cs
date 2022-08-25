using eticaret.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eticaret.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            AnasayfaModeli model = new AnasayfaModeli();

            Kullanici kullanici1 = new Kullanici();
            kullanici1.adSoyad = "Tuğba Coşkun";
            model.Kullanicilar.Add(kullanici1);

            Kullanici kullanici2 = new Kullanici();
            kullanici2.adSoyad = "Hacı Coşkun";
            model.Kullanicilar.Add(kullanici2);


            
            model.Baslik = "kisiler";
            model.Suan = DateTime.Now;
            model.Sehir = "Izmir";

           
            Araba araba = new Araba();
            araba.Marka = "Renault";
            araba.Model = "Clio";
            araba.Yil = 2022;
            model.Arabalar.Add(araba);

            Araba araba1 = new Araba();
            araba1.Marka = "Hyundai";
            araba1.Model = "İ20";
            araba1.Yil = 2018;
            model.Arabalar.Add(araba1);

            Bilgisayar bilgisayar= new Bilgisayar();
            bilgisayar.marka = "casper";
            bilgisayar.islemci = "i7";
            bilgisayar.ekranBoyutu= 19;
            model.Bilgisayarlar.Add(bilgisayar);

            Bilgisayar bilgisayar1 = new Bilgisayar();
            bilgisayar1.marka = "monster";
            bilgisayar1.islemci = "i9";
            bilgisayar1.ekranBoyutu = 15;
            model.Bilgisayarlar.Add(bilgisayar1);

            Bilgisayar bilgisayar2 = new Bilgisayar();
            bilgisayar2.marka = "hp";
            bilgisayar2.islemci = "i5";
            bilgisayar2.ekranBoyutu = 17;
            model.Bilgisayarlar.Add(bilgisayar2);


            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}