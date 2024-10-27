using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud--> Create-Read-Update-Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli ***** ");
            Console.WriteLine();

            Console.WriteLine("----------------------------------");
            Console.Write("Eklemek istediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS; " +
                "initial catalog=EgitimKampiDb; integrated security=truer " );
            connection.Open();

             

        }
    }
}
