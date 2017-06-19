using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public interface ICheckout
    {
        List<Order> ProceedTOCheckout(string Username);
        List<Order> DisplayOrder(string Username);
        List<FinalOrder> FinalBuy(int id);
        bool deleteOrder(int id);
        Order getOrder(int id);

    }
}
