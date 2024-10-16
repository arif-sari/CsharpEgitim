using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri

            //değişkenTürü[] diziAdı = new değişkenTürü[ElemanSayısı]

            //string[] colors = new string[5];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string[6];
            //cities[0] = "Milano";
            //cities[1] = "Budapeste";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[3] = 698;
            //numbers[7] = 748;
            ////dizi içinde olan tanımlanmamış olan değerlerde 0 gelir 
            ////dizi dışında olan değer sorgulanınca hata döner
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Roma", ",Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[3]);


            #endregion

            #region Dizideki tüm elemanları listeleleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for(int i = 0; i <= colors.Length; i++)
            ////i <= colors.Length <= ile yazınca 7 değeri ekliyor

            //{
            //    Console.WriteLine(i);
            //}

            //int[] number = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i]% 3== 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '+', '/', '-' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 24, 635, 789, 86, 100 };
            //int maxNumber=myArray[0];

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //int[] number = { 45, 85, 52, 86, 41, 10, 22, 35 };
            //Array.Sort(number); //sort diziyi küçükten büyüğe sıralıyor

            //for(int i=0;i<number.Length;i++)
            //    Console.WriteLine(number[i]);

            //int[] numbers = { 45, 85, 52, 86, 41, 10, 22, 35 };
            //Array.Reverse(numbers); // Reverse diziyi sondan başa doğru sıralıyor


            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi metotları
            //string[] customers = { "Ali", "Buse", "Aysegül", "Merve", "Çınar", "Kaya" };
            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük elemanı : " + numbers.Max() + "Dizinin en küçük elemanı : " + numbers.Min());



            #endregion

            #region Klavyeden kullanıcıdan deger alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri giriniz: ");
            //    cities[i] =Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");

            //for(int i = 0;i< cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i=0;i<numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int [] numbers = { 21, 42, 33, 54, 55, 66, 748, 82, 89, 60 };

            Console.WriteLine("Çift Sayılar :");

            for(int i = 0 ; i < numbers.Length ; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar :");

            for(int i =0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            #endregion
            Console.Read();
        }
    }
}
