using System.ComponentModel.Design;
using System.Text.RegularExpressions;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Dil seçiniz/Choose Language: TR/EN");
            //string dil = (Console.ReadLine().ToUpper());
            //string msg1 = "1. Sayıyı giriniz", msg2 = "2.sayıyı giriniz", msg3 = "İşlem seçiniz", msg4 = "İşlemin sonucu", msg5 = "hatali giris yaptiniz";

            //if(dil == "EN")
            //{
            //    msg1 = "Enter first number";
            //    msg2 = "Enter Second Number";
            //    msg3 = "Select operation";
            //    msg4 = "Result";
            //    msg5 = "Incorrect operation selected";
            //}

            //if (dil == "TR")
            //{


            //    Console.WriteLine(msg1);
            //    double s1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine(msg2);
            //    double s2 = double.Parse(Console.ReadLine());
            //    Console.WriteLine(msg3);
            //    char islem = char.Parse(Console.ReadLine());

            //    if (islem == '+')
            //    {
            //        Console.WriteLine($"{msg4} : {s1 + s2}");

            //    }
            //    else if (islem == '-')
            //    {
            //        Console.WriteLine($"{msg4}: {s1 - s2}");
            //    }
            //    else if (islem == '*')
            //    {
            //        Console.WriteLine($"{msg4} : {s1 * s2}");
            //    }
            //    else if (islem == '/')
            //    {
            //        Console.WriteLine($"{msg4}  : {s1 / s2}");
            //    }
            //    else
            //    {
            //        Console.WriteLine(msg5);
            //    }


        }
        }
    }



    //Console.WriteLine("Bir sayı giriniz");
    //        int sayi = int.Parse(Console.ReadLine());

    //        if (sayi == 1)
    //        {
    //         Console.WriteLine("Bir");
    //        }
    //        else if (sayi == 2)
    //        {
    //            Console.WriteLine("İki");
    //        }
    //        else if (sayi == 3)
    //        {
    //            Console.WriteLine("Üç");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Hatalı giriş");
    //        }

    //        switch (sayi)
    //        {
    //            case 1:
    //                Console.WriteLine("Bir");
    //                break;
    //                case 2:
    //                Console.WriteLine("İki");
    //                break;
    //                case 3:
    //                Console.WriteLine("Üç");
    //                break;
    //                default:
    //                Console.WriteLine("Hatalı giriş");
    //                break;
    //        }
            
            
            //Console.WriteLine("Hava nasıl?");
            //string durum = Console.ReadLine().ToLower();
            //if (durum == "güzel")
            //{
            //    Console.WriteLine("Kaç derece?");
            //    sbyte derece = sbyte.Parse(Console.ReadLine());
            //    if (derece < 15) ;
            //    {
            //        Console.WriteLine("Soğuk evde otur");
            //    } 
            //else if (derece >= 15 && derece < 35) ;
            //    {
            //        Console.WriteLine("Hava güzel dışarı çık");
            //    }
            //    else (derece>35);
            //    {
            //        Console.WriteLine("Hava çok sıcak evde otur");
            //    }

            //}
            //else if (durum == "kötü")
            //{
            //    Console.WriteLine("Evde otur");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız");
            
            //try
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    byte sayi = byte.Parse(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("sayı ile giriş yapınız");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("0-255 arası bir değer giriniz.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Bir hata oluştu");
            //    Console.WriteLine($"Hata detayları:\nTarih Saat {DateTime.Now}\nHata mesajı: {ex.Message}\nStack Trace:{ex.StackTrace}");
            //}




            
    //    }
    //}
//exception handing




//Console.WriteLine("bir sayi giriniz");
//double s1 = double.Parse(Console.ReadLine());
//Console.WriteLine("bir sayi daha giriniz");
//double s2 = double.Parse(Console.ReadLine());
//Console.WriteLine("işlem seçiniz: +,-,*,/");
//char islem=char.Parse(Console.ReadLine());
//string msg = "İşlemin sonucu";

//if (islem=='+')
//{
// Console.WriteLine($"{msg} : {s1+s2}");

//}
//else if (islem=='-')
//{
//    Console.WriteLine($"{msg}: {s1-s2}");
//}
//else if(islem=='*')
//{
//    Console.WriteLine($"{msg} : {s1*s2}");
//}
//else if(islem == '/')
//{
//    Console.WriteLine($"{msg}  : {s1/s2}");
//}
//else
//{
//    Console.WriteLine("hatali giris yaptınız");
//}

//int s1 = 5;
//int s2 = 10;

//if (1 != 1)
//{
//    Console.WriteLine("gazi");
//}
//else;
//Console.WriteLine("üniversitesi");



//CONST SABİT DEĞER DEMEK



//Console.WriteLine("bir sayi giriniz");
//int s1 = int.Parse(Console.ReadLine());
//Console.WriteLine("bir sayi daha giriniz");
//int s2 = int.Parse(Console.ReadLine());

//if (s1 > s2)
//{
//    Console.WriteLine("sayi1 büyük");
//}
//else if (s2 > s1)
//{

//    Console.WriteLine("sayi 2 büyük");
//}
//else
//{
//    Console.WriteLine("eşittir");

//1.sayıyı giriniz
//2.sayıyı giriniz
//işlem seçiniz +
//işlemin sonucu 15

