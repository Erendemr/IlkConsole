using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.HelloWorldAppSube2
{
    internal class Program
    {
        static int oyuncusayi = 50;
        static void Main(string[] args)
        {
            #region Değişken Tanımlamaları
            //Değer tipi (Value Type) - STACK bölgesi
            //int sayi = 50;
            //byte number = 50;
            ////Referans tipi (Reference type) - HEAP bölgesi
            //string isim = "Ahmet";
            //Console.WriteLine(sayi);
            //Console.WriteLine(number);
            //Console.WriteLine(isim);
            //byte a;
            //a = 30;
            //Console.WriteLine(a);
            //const int number = 50;
            //Console.WriteLine(number);
            //number = 100;
            //Console.WriteLine(number);
            //byte yas=25;
            //Console.WriteLine(yas); 
            #endregion

            #region String biçimlendirme
            //string isim = "ahmet", soyad = "mehmet";

            //Console.WriteLine("merhaba " + isim + " " + soyad);
            //Console.WriteLine("merhaba {0} {1}", isim, soyad);
            //Console.WriteLine($"merhaba {isim} {soyad}");

            //Console.WriteLine("İsminizi giriniz : ");
            //string ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı giriniz : ");
            //string soyad = Console.ReadLine();
            //Console.ReadKey();

            //Console.WriteLine("Hoşgeldiniz " + ad + " " + soyad);
            //Console.ReadKey();
            #endregion

            //Console.WriteLine("İsminizi Giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Giriniz:");
            //string soyad = Console.ReadLine();
            //Console.WriteLine("Yaşınızı giriniz");
            //int yas = int.Parse(Console.ReadLine());
            //Console.WriteLine($"hoşgeldin {isim} {soyad} {yas}");

            //double maas = 5000;
            //maas += 1000;
            //Console.WriteLine(maas);
            //Console.ReadKey();

            //Console.WriteLine("bir sayi giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("bir sayi daha giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //string sonuc = sayi1 > sayi2 ? "Birinci sayı büyüktür" : "İkinci sayı büyüktür yada sayılar eşittir";

            //Console.WriteLine(sonuc);


            //string --> metin;
            //int --> sayı;
            //byte --> sayı;
            //double --> noktali sayı;
            //char --> karakter ;
            //bool --> true false;
            //string sonuc2 = "";

            //if (sayi1 > sayi2)
            //{
            //    sonuc2 = "Birinci sayı büyüktür";
            //}
            //else
            //{
            //    sonuc2 = "İkinci sayı büyüktür yada sayılar eşittir";

            //}
            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuc2);
            //Console.ReadLine();

            //string sayi = "20";
            //byte number = Convert.ToByte(sayi);
            ////byte number = byte.Parse(sayi);

            //string a = "50";
            //string b = "20";
            //string sonuc = a + b;

            //int ai = Convert.ToInt32(a);
            //int bi = Convert.ToInt32(b);
            //int sonuci = ai + bi;   

            //Console.WriteLine(sonuc);
            //Console.WriteLine(sonuci);
            //Console.ReadLine();
            //int  c= Convert.ToInt32(a); 


            string a = "70";
            string b = "50";
            string sonuc = a + b;

            int ai = int.Parse(a);
            int bi = int.Parse(b);
            int sonuci = ai + bi;

            Console.WriteLine(sonuci);
            Console.ReadLine();



        }
    }
}

#region MyRegion
//8bit = 1 Byte
//1024byte = 1 Kilobyte(KB)
//1024 KB = 1 Megabyte(MB)
//1024 MB = 1 Gigabyte(GB)
//1024 GB = 1 Terabyte(TB)

//Tip güvenliği (Type Safety): Atamak istenen değer ile o değerin atanacağı değişkenin veri tipi aynı yada uyumlu olmalıdır. Ancak atamanın yapılmasında teknik olarak bir sorun yoksa,

//Namespace: İçinde classları bulunduran yapılardır.
//{}: Blok Yapısı(Scope)
//Class: İçinde metodları bulunduran yapılardır.
//Metod: İş yapan kod bloklarıdır.
//Main Metodu: Console uygulamalarının giriş noktasıdır.
//Syntax: Kod yazım kuralları

//Derleme(Compile): C#->Build->MS-IL(exe)->Runtime->Makina Dili(0-1)

//Ctrl+B: Derleme kısayolu
//Ctrl+K+D:Kodları düzenle
//Ctrl+K+C:Yorum satırı
//Ctrl+K+U:Yorumu eski haline çevirme
//IntelliSense: Kod yazım yardımcısı
//IntelliCode: Yapay Zeka Kod yazım yardımcısı
//Solution: İçerisinde bir yada birden fazla proje bulunduran yapılardır.Projelerin disk üzerinde kayıtlı oldugu yer bilgisini tutar.

//.NET
//Microsoft tarafından geliştirilen bir yazılım geliştirme platformudur(Framework)
//.NET Bileşenleri
// 1- Programlama Dilleri C#-VB-F#
// 2- Editörler: Visual Studio-Visual Studio Code
// 3- Kütüphaneler: Namespace
// 4- Runtime

//.NET ile yapılabilecekler
// 1- Desktop Applications (Console,Windows Forms App..)
// 2- Web Applications 
// 3- Mobile Applications (Android-iOS) Xamarin Applications
// 4- Game Development : Unity
// 5- IoT: Internet Of Things : Akıllı Cihazlar
// 6- AI: Yapay Zeka 
#endregion

// Tür dönüşümleri (Type Casting):

//byte sayi = 20
//int number = sayi; //implicit type casting
//Küçük türden büyük türe yapılan dönüşümler otomatik olarak dönüştürülür.

//checked
//{
//    int sayi = 257;
//    byte number = (byte)sayi;//excplicit type casting
//    Console.WriteLine(sayi); 
//}
//RİSK!
//Büyük türden küçük türe yapılan dönüşümlerde veri kaybı ihtimali vardır.
//Veri kaybı ihtimali!

//Stringten değer tipine dönüşümler:

//string sayi = "20"; 
////byte number = Convert.ToByte(sayi);
//byte number =byte.Parse(sayi);

// 1 || 1 = 1
// 1 || 0 = 1
// 0 || 1 = 1
// 0 || 0 = 0

// 1 && 1 = 1
// 1 && 0 = 0
// 0 && 1 = 0
// 0 && 0 = 0
