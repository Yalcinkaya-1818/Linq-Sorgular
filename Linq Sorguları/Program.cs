using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Sorguları
{
    class Program
    {
        static List<Kitap> kitaplar;
        static List<KitapTur> kitapTurleri;
        static List<Yazar> yazarlar;

        static void Main(string[] args)
        {
            KitapEkle(); KitapTurleriEkle(); YazarEkle();
            linq4();

        }
        static void linq1()//Aranan eleman varsa True yoksa False döndürme sorgusu
        {
            var result = kitaplar.Any(kitap => kitap.KitapAdi == "Kuşağı");
            Console.WriteLine("Aranan Elemanın Bulunması={0}", result);

        }
        static void linq2()//Aranan elemanın kendisini veriyor
        {
            var result = kitaplar.Find(kitap => kitap.KitapAdi == "Kuşağı");
            Console.WriteLine("Id={0} Kitap Adi={1} Kitap Sayfası={2} ", result.Id, result.KitapAdi, result.SayfaSayisi);
        }
        static void linq3()//Aranan elemanın kendisini veriyor
        {
            var result = kitaplar.Find(kitap => kitap.KitapAdi == "Kuşağı");
            Console.WriteLine("Id={0} Kitap Adi={1} Kitap Sayfası={2} ", result.Id, result.KitapAdi, result.SayfaSayisi);
        }
        static void linq4()//Aranan elemanların tamamını listelemek için kullanıyoruz
        {
                var result = kitaplar.Where(kitap => kitap.YazarId == 2);//YazarId si 2 olan tüm kitapları result a atar.
                 var result2 = from k in kitaplar  //ikinci yöntem
                               where k.YazarId == 2
                               select k;
                 foreach (var item in result)
                 {
                     Console.WriteLine("Id={0} Kitap Adi={1} Kitap Sayfası={2} ", item.Id, item.KitapAdi, item.SayfaSayisi);
                 }          
        }
        static void linq5()//Aranan elemanların tamamını sıralayarak listelemek için kullanıyoruz
        {
            var result = kitaplar.Where(kitap => kitap.YazarId == 2).OrderBy(kitap=>kitap.Id);//YazarId si 2 olan tüm kitapları id kısmı artan olacak şekilde sıralayıp result a atar.
            var result4 = from k in kitaplar  //ikinci yöntem
                          where k.YazarId == 2
                          select k;
            var result2 = kitaplar.Where(kitap => kitap.YazarId == 2).OrderByDescending(kitap => kitap.Id);//YazarId si 2 olan tüm kitapları id kısmı azalan olacak şekilde sıralayıp result a atar.
            var result3 = kitaplar.Where(kitap => kitap.YazarId == 2).OrderBy(kitap => kitap.Id).ThenBy(kitap=>kitap.TurNo);
            //YazarId si 2 olan tüm kitapları id kısmı azalan olacak şekilde daha sonra turno ya göre artan şekilde  sıralayıp result a atar.
            var result6 = from k in kitaplar  //ikinci yöntem
                          where k.YazarId == 2
                         orderby k.Id ,k.TurNo ascending
                          select k;
            //Yukarıdaki kodun bir başka yöntem ile yapımı
            foreach (var item in result)
            {
                Console.WriteLine("Id={0} Kitap Adi={1} Kitap Sayfası={2} ", item.Id, item.KitapAdi, item.SayfaSayisi);
            }
        }


        static private void KitapEkle()
        { //Kitapları Eklemek için Kitap sınıfından nesneleri türeterek listenin içerisine attık.
            kitaplar = new List<Kitap> {//
        new Kitap{Id=1,KitapAdi="Kuşağı",YazarId=1,TurNo=2,SayfaSayisi=193},
        new Kitap{Id=2,KitapAdi="Pembe İncilli Kaftan",YazarId=1,TurNo=2,SayfaSayisi=251},
        new Kitap{Id=3,KitapAdi="Efruz Bey",YazarId=1,TurNo=1,SayfaSayisi=152},
        new Kitap{Id=4,KitapAdi="Tutunamayanlar",YazarId=2,TurNo=2,SayfaSayisi=241},
        new Kitap{Id=5,KitapAdi="Korkuyu Beklerken",YazarId=2,TurNo=1,SayfaSayisi=152},
        };
        }
        static private void KitapTurleriEkle()
        {//Kitap turu eklemek için KitapTur sınıfından nesneleri türeterek listenin içerisine attık.
            kitapTurleri = new List<KitapTur>
            {
            new KitapTur{Id=1,KitapTuru="Hikaye"},
            new KitapTur{Id=1,KitapTuru="Roman"}
            };

        }
        static private void YazarEkle()
        {//Yazar eklemek için Yazar sınıfından nesneleri türeterek listenin içerisine attık.
            yazarlar = new List<Yazar>
            {
            new Yazar{Id=1,YazarAdi="Ömer Seyfettin"},
            new Yazar{Id=1,YazarAdi="Oğuz Atay"}
            };
        }
    }
}
