using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MAKÜ_Dot_aAıştırmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   İki tam sayı tanımlayın ve bu iki sayının toplamını ekrana yazdırın

            //int x = 5;
            //int y = 5;
            //Console.WriteLine(x + y);

            #endregion

            #region  Bir tam sayı ve bir ondalıklı sayı tanımlayın ve bu iki sayıyı çarparak sonucu ekrana yazdırın. 

            //int x = 4;
            //double y=4.8;
            //Console.WriteLine(x * y);

            #endregion

            #region  Bir karakter ve bir string tanımlayın, karakteri string’in sonuna ekleyip ekrana yazdırın.  

            //char x= 'V';
            //string y = "rumeysa";
            //Console.WriteLine(y + x);

            #endregion

            #region  Bir tam sayının çift olup olmadığını kontrol edin ve sonucu boolean değişkeninde saklayıp yazdırın


            //int x = 24;
            //bool çiftMi = (x % 2 == 0);
            //Console.WriteLine("çift mi:" + çiftMi);

            #endregion

            #region  Sabit bir pi değeri tanımlayın ve yarıçapı 5 olan bir çemberin alanını hesaplayıp yazdırın.

            //const double pi = 3.141;
            //int r = 5;
            //Console.WriteLine(pi*r*r);

            #endregion

            #region  Kullanıcıdan bir sayı alıp, bu sayıyı tam sayıya çevirin ve 2 ile çarpıp sonucu yazdırın. 

            //Console.Write("bir sayı giriniz:");
            //int x =int.Parse(Console.ReadLine());
            //Console.WriteLine(x*2);

            #endregion

            #region  Bir tam sayıyı string’e çevirin ve sonucu yazdırın.     .ToString

            //  int x = 5;
            //string sayi= x.ToString();
            //  Console.WriteLine(sayi);


            #endregion

            #region  Bir ondalıklı sayıyı tam sayıya çevirin ve ekrana yazdırın (int) ile

            //double r = 25.45;
            //int y = (int)r;
            //Console.WriteLine(y);


            #endregion

            #region  Bir float tipi değişkeni double’a dönüştürüp sonucu yazdırın. float olduğunu belirtmen lazım sonuna f koy (double) ile
            //float x = 25.65f;
            //double y = (double)x;
            //Console.WriteLine(y);

            #endregion

            #region  Bir karakterin ASCII karşılığını bulun ve ekrana yazdırın.  anlamadımmmm???????

            //char karakter = 'A';
            //int asciiDegeri = (int)karakter;
            //Console.WriteLine("ASCII değeri: " + asciiDegeri);

            #endregion

            #region  Kullanıcıdan bir sayı alın ve bu sayının pozitif olup olmadığını kontrol edin.

            // Console.Write("lütfen bir sayı giriniz:");
            //int x = int.Parse(Console.ReadLine());
            // if (x > 0)
            // {
            //     Console.WriteLine("pozitif");

            // }
            // else if (x == 0)
            // {
            //     Console.WriteLine("nötr");

            // }
            // else
            // {
            //     Console.WriteLine("negatif");

            // }







            #endregion

            #region  Kullanıcının yaşına göre "Çocuk", "Genç", "Yetişkin" gibi kategorilere ayıran bir program yazın.  

            //Console.Write("yaşınızı giriniz:");
            //int age=int.Parse(Console.ReadLine());
            //if (age <= 15)
            //{
            //    Console.WriteLine("çocuk");
            //}
            //else if (age > 15 && age < 25)
            //{
            //    Console.WriteLine("genç");
            //}

            //else
            //{
            //    Console.WriteLine("yetişkin");
            //}


            #endregion

            #region  kullanıcıdan bir gün numarası alın ve o güne karşılık gelen ismi yazdırın.  

            //Console.Write("bir gün sayısı girin:");
            //int dayNumber = int.Parse(Console.ReadLine());
            //switch (dayNumber)
            //{

            //    case 1: Console.WriteLine("Pazartesi"); break;
            //    case 2: Console.WriteLine("Salı"); break;
            //    case 3: Console.WriteLine("Çarşamba"); break;
            //    case 4: Console.WriteLine("Perşembe"); break;
            //    case 5: Console.WriteLine("Cuma"); break;
            //    case 6: Console.WriteLine("Cumartesi"); break;
            //    case 7: Console.WriteLine("Pazar"); break;
            //    default:
            //        Console.WriteLine("Geçersiz gün numarası!"); break;


            //}




            #endregion

            #region Ternary Operator (Tek Satırlık If)  Soru: Kullanıcının girdiği sayının pozitif mi negatif mi olduğunu tek satırlık bir ifadeyle kontrol edin.  
            //anlamadım
            #endregion

            #region  Kullanıcıdan iki sayı alıp her iki sayı da pozitifse bu sayıların toplamını ekrana yazdırın, değilse uyarı verin.
            //int number1,number2;

            //Console.Write("lütfen 1. sayıyı giriniz:");

            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı giriniz:");

            //number2 = int.Parse(Console.ReadLine());

            //if (number1 > 0 )
            //{
            //    if (number2 > 0)
            //    {
            //        Console.WriteLine("toplamları:" +( number1 + number2));

            //    }
            //    else
            //    {
            //        Console.WriteLine("ikinci sayı pozitif değil");
            //    }
            //}

            //else
            //{
            //    Console.WriteLine("birinci sayı pozitif değil"); 
            //}






            #endregion

            #region For Döngüsü ile 1’den 10’a Kadar Sayıları Yazdırın 

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}


            #endregion

            #region While Döngüsü ile Kullanıcı "0" Girene Kadar Sayı İsteyin  

            //int number;
            //do
            //{
            //    Console.Write("bir sayı giriniz:");
            //   number= int.Parse(Console.ReadLine());

            //} while (number != 0);

            #endregion

            #region  İç İçe For Döngüsü ile Çarpım Tablosu  ?????
            #endregion

            #region Foreach Döngüsü ile Dizi Elemanlarını Yazdırın  
            //string[] name = { "rumeysa", "mert", "nisa", "hakan", "medine", "şerife", "nazan", "kenan", "murat" };
            //foreach (string s in name) {Console.WriteLine(s); }


            #endregion

            #region Sonsuz Döngü 
            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("sonsuz döngü");
            //}

            //ya da

            //while (true) { Console.WriteLine("bu döngü sonsuz döngü"); }



            #endregion

            #region Kullanıcıdan Alınan Değerlerle Dizi Oluşturma
            //Console.Write("dizi için kaç değer gireceksiniz:");
            //int number=int.Parse(Console.ReadLine());

            //int[] volues = new int[number];

            //for (int i = 0; i < volues.Length; i++)
            //{
            //    Console.Write("lütfen dizi için " + (i+1) + ". değeri giriniz:");
            //    volues[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int volue in volues)
            //{
            //    Console.WriteLine(volue);
            //}



            #endregion

            #region Dizideki En Büyük Elemanı Bulma
            //Console.Write("kaç değer gireceksiniz:");
            //int number = int.Parse(Console.ReadLine());
            //int[] numbers = new int[number];

            //int enB=0;
            //int enK=0;

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    Console.Write("lütfen dizi için " + (i + 1) + ". değeri giriniz:");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //   enB=numbers[0];
            //   enK = numbers[0];
            //    if (numbers[i]<enK)
            //    {
            //      enK = numbers[i];
            //    }

            //    if (numbers[i] > enB)
            //    {
            //       enB =numbers[i] ;
            //    }


            //}

            //foreach(int a in numbers) {Console.WriteLine(a);}
            //Console.WriteLine("en küçük sayı: " + enK + " en büyük sayı: " + enB); 



            #endregion

            #region Dizi Elemanlarının Toplamını Bulma
            //int[] number = { 5, 8, 9, 631, 151, 35315, 6, 4 };
            //int sum=0;
            //for (int i = 0; i < 8; i++)
            //{
            //    sum += number[i];
            //}
            //Console.WriteLine(sum);


            #endregion

            






















            Console.ReadLine();






























        }
        
    }
}
