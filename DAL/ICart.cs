using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public interface ICart
    {
        List<Cart> DisplayCart(string Username);
        List<Cart> AddToCart(string Title, int Quantity, string Username);
        void GetClearItem(int id);
    }
}
