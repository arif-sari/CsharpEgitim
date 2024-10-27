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
            Console.WriteLine( "1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");

            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz:");
            Console.ReadLine();

            Console.WriteLine("----------------------------------------------------------------");

            SqlConnection connnection= new SqlConnection("Data Source=MONSTER\\TEW_SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true ");
            connnection.Open();

            SqlCommand command = new SqlCommand(" Select*From TblCategory",connnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable datatable = new DataTable(); //data table verileri geçici belleğe almamıza yarıyor
            adapter.Fill(datatable);
            
            connnection.Close();

            foreach (DataRow row in datatable.Rows)
            {
               foreach(var item in row.ItemArray)
                {
                    Console.Write (item.ToString());
                }
               Console.WriteLine();

            }
          



            Console.Read();
        }
    }
}
