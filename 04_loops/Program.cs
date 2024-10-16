using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüsü
            //for(x,y,z)
            //x:başlangıç noktası
            //y:bitiş noktasi
            //artış miktarı

            //int i;

            //for (i = 1; i < 5; i++) //i değeri 5 olana kadar 1 1 arttır
            //{
            //    Console.WriteLine("CSharp eğitim kampı"); //
            //}
            //3 ile 50'ye kadar 3er say

            //for (int i = 3; i <= 50; i++)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //başlangıç ve bitiş bilgileri kullanıcıdan alınabilir

            //Console.Write("Lütfen ekran yazılmasını istediğiniz adedi girin: ");
            //int finishValue = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For döngüsü ile Karar Yapıları

            //1 ile 100 arası sayıların 5 bölümlerini listele   

            //for (int i=1;i<100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //ardışık sayıları toplama 1 ile 10 arası toplam

            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);


            //1-20 arası çift sayi toplamı

            //int sum = 0;

            //for(int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------");
            //Console.WriteLine("Toplam:" + sum);

            //1 ile 50 arası 7ye tam bölünen kaç sayı var


            //int count = 0;
            //for(int i = 0; i < 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}Console.WriteLine(count);


            // Soru: Bir bakteri her saatin sonunda kendini 2ye katlamaktadır,yeni oluşanlarda ikiye bölünüyor 24 saat içinde kaç bakteri olur

            //int bacteria=1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bacteria*=2;
            //    Console.WriteLine(i+" saat sonra "+bacteria + " bakteri oluşur" );
            //}


            #endregion

            #region while döngüsü
            //şart sağlandığı müddetçe geçerlidir
            // while (şart){ işlemler}

            //on defa ekran yazı yazdıralım 

            //int i = 1;
            //while (i <= 10)
            //{

            //    Console.WriteLine("merhaba");
            //    i++;
            //}





            // 1 - 10 arası 3'e tam bölünen sayılar

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}



            //1-10 arası sayıları topla

            //int i = 1;
            //int sum = 0;

            //while (i < 10)
            //{
            //    sum += i;

            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam sonucu: "+sum);

            #endregion

            #region Örnek Sınav Sorusu

            //klavyeden girilen 3 basamaklı sayının basamakları toplamnı hesapla

            Console.WriteLine("Sayıyı giriniz.");
            int number=int.Parse(Console.ReadLine());

            int ones, tens, hundreds;
            int sum;
            //159

            ones = number % 10;
            tens = number % 100/10;
            hundreds = (number / 100);
            
       

            Console.WriteLine(ones);
            Console.WriteLine(tens);
            Console.WriteLine(hundreds);
            
            Console.WriteLine(hundreds+"-"+tens+"-"+ones);

            sum=ones+tens+hundreds;

            Console.WriteLine("--------------------------");
            Console.WriteLine(sum);


             

            #endregion
            Console.Read();
        }
    }
}