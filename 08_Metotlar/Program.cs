using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _08_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methodlar

            // bir yanın method olduğunu anlamak için olmalıdr ()
            //Console.Write / Console.Writeline bir methoddur
            //Parse bir methoddur
            //mor renk kodlar metodlardır
            //Main ifadeside methoddur 
            // 2 tür method var 

            // 01 geriye değer döndürmeyen metotlar
            // customer--> listele ekle sil güncelle tekrar çağırabilir metodlardır
            // void motodlar geri döndürmez


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}

            //Sum(); //ihtiyacımız olan yerde tekrar yazmamak için methodu çağırmamız bizim için yeterlidir.








            #endregion

            #region Geriye değer döndürmeyen string paramatreli methodlar

            //void WriteMethod(string custmerName)
            //{
            //    Console.WriteLine(custmerName);
            //}

            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard ("Ayşegül","Kaya");

            #endregion

            #region Geriye değer döndürmeyen Int parametreli methodlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4,5,6);
            #endregion

            #region Geriye değer döndüren Methodlar
            // geriye değer döndürenler artık void olarak tanımlanmıyor

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name + " " + surName;

            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye değer döndüren String Parametreli Metodlar

            //string CountryCard(string countryName, string capital,  string flagColor)
            //{
            //    string cardInfo="Ülke: "+ countryName + "Başent:" + capital +"Bayrak rengi: "+ flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x= Console.ReadLine();

            //Console.Write("BAşkenti Giriniz: ");
            //y= Console.ReadLine( );

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye değer döndüren String Parametreli Metodlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));



            #endregion

            #region Örnek  Uygulama
            string ExanResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;

                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti " + "Ortalama: " + result;

                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi " + "Ortalama: " + result;
                }

            }

            Console.WriteLine(ExanResult("Ali", 25, 41, 55));
            Console.WriteLine(ExanResult("Ayşe", 36, 88, 33));

            #endregion



            Console.Read();

        }
    }
}
