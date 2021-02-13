using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new İhtiyacKrediManager(); //İnterfacelerde onları implemente eden classların referans numarasını tutabilir 
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();//yapabildik çünkü ILoggerService de bizim için database ve file classının referansını tutuyor 
            ILoggerService fileLoggerService = new FileLoggerService();

            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { databaseLoggerService, fileLoggerService });
            //bizden liste istemişti bizde ona liste gönderdik ve bu listenin içindekilerin hepsi için loglamayı çalıştırabilsin 
            
            //yani biz burada IKrediManager döndermemiz gereken yerde diğer her ihtiyac kredisini gönderebildik
            //çünkü IKrediManager bizim için bu üç kredinin referansını tuttu 

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager }; 
            //burada banka personeli buttonlara basıp listeye kredi ekliyormuş similasyonu gibi düşün 
            // IKrediManager tipinde bir liste istiyordu bizden önbilgilendirme methodu zaten 
            //bu sayede bu method sadece bizim istediğimiz listeye eklediğimiz kredilerin hesapla fonksiyonlarını çağırabilicek 
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
