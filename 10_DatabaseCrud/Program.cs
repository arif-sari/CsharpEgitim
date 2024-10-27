using System;
using System.Collections.Generic;
using System.Data;
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
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS; " +
            //    "initial catalog=EgitimKampiDb; integrated security=true " );
            //connection.Open();

            ////sorgu yapma
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            ////ekleme sırasındaki hiyerarşik yapı
            //// (productName,price,stock) => values(@p1,@p2,@p3)
            //// @SQLde atama yapmak için özel bir karakter
            ////parantez içindeki sıralamaya göre karşılık bulur

            //connection.Close();

            //Console.WriteLine("Başarı ile eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal procutPrice;
            ////bool productStatus;

            //Console.Write("Ürün adı : ");
            //productName =Console.ReadLine();

            //Console.Write("Ürün fiyat : ");
            //procutPrice= decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = MONSTER\\TEW_SQLEXPRESS; " +
            //    "initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) " +
            //    "values(@ProductName,@ProductPrice,@ProductStatus)",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",procutPrice);
            //command.Parameters.AddWithValue("productStatus",true);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarı ile eklendi");




            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS;" +
            //    " initial Catalog = EgitimKampiDb; integrated security=true ");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select*From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            ////dataları içeri alabilmek için DataTable
            //DataTable dataTable = new DataTable();
            ////içini doldurma
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            #endregion 
            Console.Read();
        }
    }
}