using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class CheckoutDAL:ICheckout
    {
        NewCommerceEntities obj = new NewCommerceEntities();


        public List<Order> ProceedTOCheckout(string Username)
        {

                var userParam = new SqlParameter
                {
                    ParameterName = "Name",
                    // Value = System.Security.Principal.WindowsIdentity.GetCurrent().Name
                    Value = Username
                };

                var order = obj.Orders.SqlQuery("exec Checkout @Name", userParam).ToList<Order>();
                return order;
        }
        public List<Order> DisplayOrder(string Username)//Function not in use
        {

                var userParam = new SqlParameter
                {
                    ParameterName = "Name",
                    Value = System.Security.Principal.WindowsIdentity.GetCurrent().Name
                    //Value=Username
                };

                var order = obj.Orders.SqlQuery("exec OrderDisplay @Name", userParam).ToList<Order>();
                return order;
        }


        public List<FinalOrder> FinalBuy(int id)
        {

                var FinalID = new SqlParameter
                {
                    ParameterName = "ID",
                    Value = id
                };

                var record = obj.FinalOrders.SqlQuery("exec FinalBuy @ID", FinalID).ToList<FinalOrder>();
                return record;
        }


        public bool deleteOrder(int id)
        {

                var receipt = (from c in obj.Orders
                               where c.OrderID == id
                               select c).First();
                //obj.Entry(receipt).State = System.Data.Entity.EntityState.Deleted;
                obj.Orders.Remove(receipt);
                obj.SaveChanges();
                return true;
        }

        public Order getOrder(int id)
        {
          
                var receipt = (from c in obj.Orders
                               where c.OrderID == id
                               select c).First();
                return receipt;
        }
    }
}
