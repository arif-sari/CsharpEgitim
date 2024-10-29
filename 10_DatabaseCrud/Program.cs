using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region CRUD
            //Crud--> Create-Read-Update-Delete            //Console.WriteLine("***** Menü Sipariş İşlem Paneli ***** ");
            //Console.WriteLine();

            //Console.WriteLine("----------------------------------");
            //#region Kategori Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true " );
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

            //SqlConnection connection = new SqlConnection("Data source = MONSTER\\TEW_SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) " +
            //"values(@ProductName,@ProductPrice,@ProductStatus)",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",procutPrice);
            //command.Parameters.AddWithValue("productStatus",true);

            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarı ile eklendi");




            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS;initial Catalog = EgitimKampiDb; integrated security=true ");

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



            //Console.Write("Silinecek ürün Id : ");  //önce kullanıcıya bir mesaj gönderelim
            //int productId = int.Parse(Console.ReadLine());  //göndereceğimiz Id tanımlaması

            ////Database tanımlama 
            //SqlConnection connection = new SqlConnection("Data Source= MONSTER\\TEW_SQLEXPRESS; initial catalog=EgitimKampiDb ; integrated security=true");
            //connection.Open();

            ////yeni command ile sorgu yapma
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId =@productId",connection);
            ////
            //command.Parameters.AddWithValue("@productId",productId); // product Id değeri nereden geliyor= productId'den
            //command.ExecuteNonQuery();  // değişiklikleri veri tabanına yansıtmalıyız

            //connection.Close();
            ////işlemi sonucunda bir mesaj göstermeliyiz

            //Console.WriteLine("Silme işlemi yapıldı");
            //#endregion 
            #endregion

            #region Ürün Güncelleme

            Console.Write("Güncellenecek ürün Id :");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün adı : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün Fiyatı :");
            decimal productPrice = decimal.Parse(Console.ReadLine());


            SqlConnection connection = new SqlConnection("Data Source = MONSTER\\TEW_SQLEXPRESS; initial catalog =EgitimKampiDb; integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);

            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme Başarılı");


            Console.Read();



            #endregion

        }
    }
}