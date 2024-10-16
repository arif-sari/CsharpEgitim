using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Making_Decision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CTRL + K + d format

            #region If

            //Console.Write("Lüften şifreyi girin: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")//karar yapılarında ; kullanılmaz
            //                       // eger hava yağmurluysa.... cümle bitmediği için noktalama konulmaz
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti giriniz :");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("veriler hatalı");
            //}


            //int number;
            //Console.WriteLine("Sayiyi giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Sayi doğru");
            //}
            //else
            //{

            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata!";

            //Console.WriteLine("Sınav1:");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav ortalaması: " + average);

            ////crtl+k+d kodları düzenleme
            //if (average>0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average>50 & average<=70) 
            //{
            //    result= "Sonuc orta ";
            //}
            //if (average>70 & average <=84 )
            //{
            //    result = "Sonuc vasat";
            //}
            //if( average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}


            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız");
            //city = Console.ReadLine();

            //if (city=="adana"|city=="bursa"|city=="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir bulunamadı");
            //}

            //Console.WriteLine("Lütfen kullanıcı adı giriniz:");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz "+ username );
            //}
            #endregion

            #region Mod işlemleri

            //int number;
            //number = 26;

            //int result =number%5;

            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1. sayıyı giriniz:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. sayıyı giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result= number1%number2;

            //Console.WriteLine("Birinci sayının ikinci sayıya bölümünden kalan: " + result);


            //Console.Read();


            //Console.WriteLine("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift sayıdır");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek sayidir.");
            //}
            #endregion

            #region Char Değişkenler ilt Karar Yapıları


            //char team;
            //Console.Write("Lütfen takım rengi girin: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasayar");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("Takım tanımsız");
            //}




            #endregion

            #region Ornek Proje Uygulaması
            //Console.WriteLine("***** Csharp Eğitim Kamp Restaurant *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("1-Anayemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3_Pizzalar");
            //Console.WriteLine("4-İçeceker");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------");

            //string menuItem;
            //Console.Write("Lütfen detayını görmek istediğiniz menu seçin:");
            //menuItem= Console.ReadLine();
            //Console.WriteLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("----------------Ana yemekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye pilav" );
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine("----------------Çorbalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("3-Tavuk");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine("----------------Pizzalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tonbalıklı");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine("----------------İçecekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine("----------------Tatlıllar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sütlç");
            //    Console.WriteLine("2-Pasta");
            //    Console.WriteLine("3-Profiterol");
            //    Console.WriteLine("4-Dondurma");

            //}



            #endregion

            #region switch case

            //Console.Write("Lütfen ay değeri giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());



            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nizsan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Gerçersiz Veri Girşi");break;


            //}





            #endregion

            #region switch hesap makinesi
            int number1, number2, result;
            char symbol;

            Console.WriteLine("Birinci sayıyı girin:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin:");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi girin:");
            symbol = char.Parse(Console.ReadLine());


            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result= number1 * number2;
                    Console.WriteLine("Çarpım: "+ result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;


            }


            #endregion


            Console.Read();


        }
    }
}