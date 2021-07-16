using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //sayi2'nin değerini sayi1'e eşitler.sayi1 artık 30dur.(Değişiklik yapılamdığı sürece)
            sayi2 = 65;//sayi1 hala 30dur, sayi2 artık 65 dir.(Değişiklik yapılamdığı sürece)
            Console.WriteLine(sayi1);//sonucu 30 çıkar

            int[] sayilar1 = new int[] { 10, 20, 30 };//örnek adres 101
            int[] sayilar2 = new int[] { 100, 200, 300 };//örnek adres 102
            sayilar1 = sayilar2;//referans tiplerde eşitlenen, sayilar1'in referans numarası sayilar2'nin referans numarası(adres)dır.
            sayilar2[0] = 999;//17. satırda yaptığımız şekilde sayilar1 artık sayilar2 nin adresini tutar yani 102 adresine gider.
            //sayilar2'nin 1. elemanının 999 yaptık ve 2nin adresini 1 de tuttuğu için ekran çıktısı "999" olur.
            Console.WriteLine(sayilar1[0]);
            //Sonuc 999
            //sayilar1 verileri artık tutulmaz çünkü 101 adresinin tutan(eşleşen yoktur)
        }
    }
}
