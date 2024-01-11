namespace denemev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Eren");
            //}
            //Console.WriteLine("İsminizi giriniz");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere isminiz yazılsın");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine($"{ i + 1}.{isim}");
            //}
            //Console.WriteLine("Bir sayı aralığı belirleyin");
            //Console.WriteLine("İlk sayı?");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("İkinci sayı");
            //int sayi2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek mi çift mi?");
            //string cevap = Console.ReadLine().ToLower();

            //if (sayi1 > sayi2)
            //{
            //    int temp = sayi1;
            //    sayi1 = sayi2;
            //    sayi2 = temp;
            //}
            //int sonuc = 0;


            //for (int i = sayi1; i < sayi2; i++)
            //{
            //    //if (i%2 ==0 && cevap== "çift")
            //    //{
            //    //    Console.WriteLine(i);
            //    //    sonuc += i;
            //    //}
            //    //else if (i%2 ==1 && cevap=="tek")
            //    //{
            //    //    Console.WriteLine(i);
            //    //    sonuc += i ;
            //    //}
            //    if (i%2 == (cevap == "tek"? 1 :0 ))
            //    {
            //        Console.WriteLine(i);
            //        sonuc += i  ;
            //    }
            //}

            //Console.WriteLine($"sayıların toplamı: {sonuc}");



            //bir sayı giriniz=11
            //girdiğiniz sayı asal=cevap olarak

            //Console.WriteLine("Bir sayı giriniz");

            //int sayi=int.Parse(Console.ReadLine());



            //if (sayi > 2 && sayi % 2 ==0)
            //{
            //    Console.WriteLine("Asal değildir");
            //}
            //else if (sayi<2)
            //{
            //    Console.WriteLine("En küçük asal sayı 2'dir.");
            //}
            //else
            //{  
            //    int sayac = 0;
            //    for (int i = 2; i < (sayi / 2); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac == 0 ? "Asal" : "Asal değildir");
            //}

            //for (; ;)
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz");
            //    string user= Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz");
            //    string pass = Console.ReadLine();
            //    if (user == "admin" && pass== "123")
            //    {
            //        Console.WriteLine("Giriş Başarılı");
            //        break;
            //    }
            //}

            //bir sayı giriniz:5
            //devam etmek istiyor musunuz:E
            //bir sayı giriniz:5
            //devam etmek istiyor musunuz:H
            //girilen en büyük sayı= ..

            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;

            //for (; ; )
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    sayac++;
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;

            //    if (sayi > max)
            //    {
            //        max = sayi;                   
            //    }
            //    Console.WriteLine("devam etmek istiyor musunuz");
            //    string cevap = Console.ReadLine();
            //    if (cevap == "h")
            //    {
            //        break;
            //    }
            //    else if (cevap == "e")
            //    {
            //        continue;                   
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yapıldı");
            //    }


            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max} toplamı: {toplam} Aritmetik ortalaması:{toplam/sayac}");


            //  İÇ İÇE FORM DÖNGÜLERİ==

            //for (int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 4; j++)
            //    {
            //        Console.Write($"{i},{j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter row count");
            //int row=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column count");
            //int calumn=int.Parse(Console.ReadLine());

            //for (int i = 0;i < row; i++)
            //{
            //    for(int j = 0;j < calumn; j++)
            //    {
            //       Console.Write((i + j)%2 == 0 ? "*" : " ");
            //    }
            //    Console.WriteLine();
            //}

            //abcd=4*dcba
            //abcd?

            //for (int a = 1; a < 10; a++)
            //{
            //    for(int b = 0; b < 10 ; b++)
            //    {
            //        for( int c = 0; c < 10 ; c++)
            //        {
            //            for (int d = 0; d < 10; d++)
            //            {
            //                if ((1000 * a + 100 * b + 10 * c * d == 4 * (1000 * d + 100 * c + 10 * b * a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                }
            //            }
            //        }
            //    }
            //}

            //for (int i = 1; i < 50; i++)
            //{
            //    for(int j = 1; j < 50; j++)
            //    {
            //        for(int k = 1; k < 50; k++)
            //        {
            //            if (i*i+j*j ==k*k )
            //            {
            //                Console.WriteLine($"{i}-{j}-{k}");
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine("Enter starting number");
            //int start=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number");
            //int end=int.Parse(Console.ReadLine());

            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i/2); j++)
            //    {
            //        if (i % j== 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(count==0 ? $"{i}-Is prime"  :  $"{i}-Is not prime");
            //}

            //int max = int.MinValue;
            //double toplam = 0;
            //double count = 0;
            //string cevap;

            //do {
            //    {
            //        Console.WriteLine("Enter a number");
            //        count++;
            //        int number = int.Parse(Console.ReadLine());
            //        toplam += number;
            //        if (number > max)
            //        {
            //            max = number;
            //        }
            //        Console.WriteLine("devam etmek istiyor musunuz");
            //         cevap = Console.ReadLine();

            //    }

            //} while (cevap!="h");


            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Random rnd = new Random();
            //        int number = rnd.Next(33, 127);
            //        Console.Write((char)number);
            //    }
            //    Console.WriteLine();
            //}


            Random rnd = new Random();
            int number = 0;
            int puan = 0;
            int denemeHakki = 0;

            Console.WriteLine("Please choose the level 1-5 : ");
            int level = int.Parse(Console.ReadLine());

            if(level == 1)
            {
                number = rnd.Next(10);
                Console.WriteLine("Between 1-10");
                while (denemeHakki < 5)
                {
                    Console.WriteLine("Guess the number");
                    int unumber = int.Parse(Console.ReadLine());
                    if (unumber == number)
                    {
                        Console.WriteLine("You won");
                        denemeHakki++;
                        puan += 20;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        denemeHakki++;
                    }
                }
            }
            else if(level == 2)
            {
                number = rnd.Next(30);
                Console.WriteLine("Between 1-30");
                while (denemeHakki < 10)
                {
                    Console.WriteLine("Guess the number");
                    int unumber = int.Parse(Console.ReadLine());
                    if (unumber == number)
                    {
                        Console.WriteLine("You won");
                        denemeHakki++;
                        puan += 30;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        denemeHakki++;
                    }
                }
            }
            else if (level == 3)
            {
                number = rnd.Next(50);
                Console.WriteLine("Between 1-50");
                while (denemeHakki < 15)
                {
                    Console.WriteLine("Guess the number");
                    int unumber = int.Parse(Console.ReadLine());
                    if (unumber == number)
                    {
                        Console.WriteLine("You won");
                        denemeHakki++;
                        puan += 30;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        denemeHakki++;
                    }
                }
            }
            else if (level == 4)
            {
                number = rnd.Next(80);
                Console.WriteLine("Between 1-80");
                while (denemeHakki < 20)
                {
                    Console.WriteLine("Guess the number");
                    int unumber = int.Parse(Console.ReadLine());
                    if (unumber == number)
                    {
                        Console.WriteLine("You won");
                        denemeHakki++;
                        puan += 40;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        denemeHakki++;
                    }
                }
            }
            else if (level == 5)
            {
                number = rnd.Next(100);
                Console.WriteLine("Between 1-100");
                while (denemeHakki < 20)
                {
                    Console.WriteLine("Guess the number");
                    int unumber = int.Parse(Console.ReadLine());
                    if (unumber == number)
                    {
                        Console.WriteLine("You won");
                        denemeHakki++;
                        puan += 50;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                        denemeHakki++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Please choose the 1,2,3,4,5 levels");
                return;
            }

            Console.WriteLine("Game over");
            Console.WriteLine("Your point : " + puan.ToString());

            //ÖDEV
            //SEVİYE VE PUAN SİSTEMİ HAK VERME











            //taban değeri giriniz
            //üs değeri giriniz
            //işlemin sonucu:8

            // Console.WriteLine("Taban değeri giriniz");
            // int tab = int.Parse(Console.ReadLine());
            // Console.WriteLine("Üs değeri giriniz");
            // int üs = int.Parse(Console.ReadLine());
            // int sonuc = 1;

            //for (int i = 0; i < üs; i++)
            // {
            //     sonuc = sonuc * tab;
            // }
            // Console.WriteLine(sonuc);

            //bir sayı giriniz:5
            //girilen sayının faktoriyeli=120

            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    sonuc = sonuc * i;
            //}
            //Console.WriteLine(sonuc);

        }

    }
}
