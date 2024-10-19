using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Foreach(1;2;3;4)

            //1.Değişken türü
            //2.Değişken adı
            //3.In
            //4.Liste,Koleksiyon,Dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //{
            //    foreach (string x in cities)
            //    {
            //        Console.WriteLine(x);

            //    }

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 42, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 42, 6578, 10394 };
            //foreach (int number in numbers )

            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 42, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //foreach döngüsü sadece dizilerde değil listelerdede çalışır, koleksiyon öğesinde çalışır 


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}






            #endregion


            #region Örnek sınav sistemi uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //Sınıftaki öğrenci sayısını kullanıcıdan al 
            Console.WriteLine("------------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var :");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");


            //Öğrenci isim ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentAverages = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResults = 0;



                //her öğrenci için 3 sınav notu al 

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResults += value; // notları topluyoruz
                }
                Console.WriteLine();
                Console.WriteLine();
                studentAverages[i] = totalExamResults / 3;

            }

            // Sınav ortalamaları


            for (int i = 0; i < studentCount; i++)
            {

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentAverages[i]}");

                //öğrencinin geçip kalma durumları 

                if (studentAverages[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti :");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı ");

                }

                Console.WriteLine("---------------------------------") ;

            }


            // Gelecek ders içerikleri

            //101 temel syntax
            //201 hackerrank
            //301 sql 
            //401 c# + sql
            //501  farklı bir veri tabanı 
            //601 tasarım deseni
            //701 api
            //


            //
            //


            // Gelecek ders içerikleri

            //101 temel syntax
            //201 hackerrank
            //301 sql 
            //401 c# + sql
            //501  farklı bir veri tabanı 
            //601 tasarım deseni
            //701 api
            //
            // Gelecek ders içerikleri

            //101 temel syntax
            //201 hackerrank
            //301 sql 
            //401 c# + sql
            //501  farklı bir veri tabanı 
            //601 tasarım deseni
            //701 api
            //


            //
            //// Gelecek ders içerikleri

            //101 temel syntax
            //201 hackerrank
            //301 sql 
            //401 c# + sql
            //501  farklı bir veri tabanı 
            //601 tasarım deseni
            //701 api
            //


            //
            //// Gelecek ders içerikleri

            //101 temel syntax
            //201 hackerrank
            //301 sql 
            //401 c# + sql
            //501  farklı bir veri tabanı 
            //601 tasarım deseni
            //701 api
            //


            //
            //

            //
            //


            #endregion
            Console.Read();

            }
        }
    }
