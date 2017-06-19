using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace DAL
{
    public class HomeDAL : IHome
    {
        // NewCommerceEntities homeObj = new NewCommerceEntities();
        NewCommerceEntities homeObj = new NewCommerceEntities();

        public List<Product> DisplayAllProducts()
        {
            var productList = homeObj.Products.SqlQuery("exec DisplayAllProducts").ToList<Product>();
            
            return productList;

        }

        public List<Product> DisplayProductsByCategory(string CategoryName)
        {

            var idParam = new SqlParameter
            {
                ParameterName = "Category",
                Value = CategoryName
            };

            var productList = homeObj.Products.SqlQuery("exec DisplayProduct_ByCategory @Category", idParam).ToList<Product>();
            return productList;

        }

        public int GetQuantity(string name)
        {
            var number = (from c in homeObj.Products
                          where c.ProductName == name
                          select c.QuantityAvailable).FirstOrDefault();

            return Convert.ToInt32(number);
        }



        public MovieList GetMovie(string movie)
        {
            var data = (from c in homeObj.MovieLists
                        where c.Title == movie
                        select c).FirstOrDefault();

            return data;
        }
    }
}
