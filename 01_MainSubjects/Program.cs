using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorisi ******");
            //Console.WriteLine("1-Corbalar");
            //Console.WriteLine("2-Ana emekler");
            //Console.WriteLine("3-Soğuk başlangıclar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorisi ******");
            #endregion

            #region  String Degiskenler
            ////string
            ////Değişken_türü değişken_adi;

            ////string name;

            ////name = "Arif";
            ////Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //String customerPhone;
            //string customerEmail,district , city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 5060";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıkoy";
            //city = "İstanbul";

            //Console.WriteLine("*****Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName +"  "+ customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi: "+ customerEmail);
            //Console.WriteLine("Adres: "+ district + "/" + city);
            //Console.WriteLine("-----------------------------------");


            //customerName = "Ayşegül";
            //customerPhone = "2132342";
            //customerEmail = "test@gmail.com";
            //district = "Sapance";
            //city = "Sakarya";

            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + "  " + customerSurname);
            //Console.WriteLine("İletişim:" + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");


            #endregion

            #region Int Değişkenler

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("----- Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("----- Kola: " + cokePrice + "TL");
            Console.WriteLine("----- Limonata: " + lemonadePrice + "TL");
            Console.WriteLine("----- Kızartma tabağı : " + friesPrice + "TL");
            Console.WriteLine("----- Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 1;
            lemonadeCount = 4;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;



            Console.WriteLine("--------------------------");
            Console.WriteLine("Hamburger tutarı: " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Pizza tutarı: " + totalPizzaPrice + "TL");
            Console.WriteLine("Kola tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("Limonata tutarı: " + totalLemonadePrice + "TL");
            Console.WriteLine("Su tutarı: " + totalWaterPrice + "TL");


            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalPizzaPrice + totalFriesPrice + totalCokePrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine();

            Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + "TL");



            #endregion



            Console.Read();
        }
    }
}