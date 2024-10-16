using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Double Değişkenler


            ////integer sadece tam kısımla ilgileniyor
            ////double sadece ondalıklı kesimle ilgileniyor

            ////double number;

            ////number = 4.85;
            ////Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice,orangePrice,strawberryPrice,potatoPrice,tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice =45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----- Elma Birim Fiyatı:"+ applePrice+ "TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı:"+ orangePrice + "TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı:"+ strawberryPrice + "TL");
            //Console.WriteLine("----- Patates Birim Fiyatı:"+ potatoPrice + "TL") ;
            //Console.WriteLine("----- Domates Birim Fiyatı:"+ tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, tomatoGram, potatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma     - " + "Birim Fiyat:    " + applePrice          +" - Gramaj:    " + appleGram        + " - Toplam Tutar:   " + appleTotalPrice );
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat:    " + orangePrice         +" - Gramaj:    " + orangeGram       + " - Toplam Tutar:   " + orangeTotalPrice );
            //Console.WriteLine("Alınan Ürün: Çilek    - " + "Birim Fiyat:    " + strawberryPrice     +" - Gramaj:    " + strawberryGram   + " - Toplam Tutar:   " + strawberryTotalPrice );
            //Console.WriteLine("Alınan Ürün: Patates  - " + "Birim Fiyat:    " + potatoPrice         +" - Gramaj:    " + potatoGram       + " - Toplam Tutar:   " + potatoTotalPrice );
            //Console.WriteLine("Alınan Ürün: Domates  - " + "Birim Fiyat:    " + tomatoPrice         +" - Gramaj:    " + tomatoGram       + " - Toplam Tutar:   " + tomatoTotalPrice );



            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "TL");



            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden veri girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi ");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();
            //Console.WriteLine();

            //Console.Write("T.C. Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu:" + passengerName + "/ " + passengerSurname + " /" + passengerCity + " /" + passengerDistrict + " /" + passengerAge + "/" +
            //     + passengerIdentityNumber);



            //Console.Read();
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice=20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount;
            //int chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabu sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine()); //int.parce dönüştürme metodu 

            //Console.Write("Lütfen aldığnız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Televizyon sayısını giriniz:");     
            //tvCount =int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairPrice*chairCount + tvCount*tvPrice  ;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz gereken Tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayi işlemleri

            //double exam1, exam2,exam3 , result;

            //Console.Write("Lütfen birinci sınav notunu girin:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen ikinci sınav notunu girin:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen üçüncü sınav notunu girin:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine(result);

            #endregion

            #region Klavyeden Karakter Girişi
            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");

            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);



            #endregion

            Console.Read();


        }
    }
}