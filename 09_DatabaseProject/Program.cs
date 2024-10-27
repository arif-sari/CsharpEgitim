using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# Veri Tabanlı Ürin-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");

            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz:");
            Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS;" +
                " initial Catalog = EgitimKampiDb; integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); // SqlDataAdapter c# ile sql arasında köprü görevi görüyor
            DataTable dataTable = new DataTable(); //yeni nesne örneği oluşturuldu verileri geçici belleğe almamızı saglayacak

            //Data table girilecek alanı tanımlıyor 
            // adapter ile doldurduk
            //adapter içinde command var
            //command içinde sorgumuz var 
            //amacımz bu sorguyu ram bellek içinden kullanıcıya göstermek
            
            adapter.Fill(dataTable);
            connection.Close(); //bağlantıyı kapattık

            //verileri döngü üzerinde göstermemiz lazım

            foreach (DataRow row in dataTable.Rows) 
           
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine() ;
            }

            Console.Read();
        }
        
    }

}


