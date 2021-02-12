using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList() // constructor(yapıcı) classın her yeni nesnesi oluştuğunda bu yapıcı blok çalışıcak ve bizim için bu t tipindeki Arrayi newleyecektir 
        {
            // çünkü yapıcı methodlar direk class newlenince otamatik çağırılır.
          items = new T[0];
        }
        public void Add(T item) // herhangi bir tipte eleman verebilirsin demek 
        {
            T[] tempArray = items;
            // geçici array oluşturduk newleyince eski versiyonlar kayboluyordu biz bunların kaybolmasını istemiyoruz o yüzden bir başka dizide tutuyoruz 
            items = new T[items.Length + 1]; // her add methodu çalıştırıldıgında burada dizimizin eleman sayısı bır artırılır 
            //length bir dizin uzunluğunu belirtir 
            // count bir dizinin eleman sayısını belirtir
            for (int i = 0; i <tempArray.Length; i++)// burada for tempArray'e geçici olarak verdiğimiz değerleri geri kendi items dizimize aktardığımız kısım
            {
                items[i] = tempArray[i]; // sırasıyla ödünç aldığı yerer kadar eklemeler yapıyor daha sonra zaten buyuttuğumuz kısım tek kalıyor oraya da biz ekleme yapıyoruz 
            }
            items[items.Length - 1] = item;
            // bize gönderilen değerin eklemesini yaptık eksi bir dememimizin sebebi ise altı eleman var diyelim beşinci eleman bizim için eklediğimiz altıncı eleman oluyor
            // length de bize uzunluk olarak altıyı vereceği için ama bizim eklediğimiz yer beş olması gerektiği için biz burada eksi bir diyoruz .
            Console.WriteLine(items.Length);
            Console.WriteLine(items[0]);


        }

    }
}
