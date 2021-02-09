using System;

namespace Metotla
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Elmasi";

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------------------");

            }

            Console.WriteLine("------------METOTLAR--------------");

            //instance class-sınıf orneği-sınıf nesnesi newleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //encapsullation üzerinde durdu tek tek değişken yaptık ekle2 ye gönderdik yeni değişken istiyince her birine tek tek yazdık


            

        }
    }
}
//  Dont repeat yourself

