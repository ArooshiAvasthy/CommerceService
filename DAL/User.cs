//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Carts = new HashSet<Cart>();
            this.FinalOrders = new HashSet<FinalOrder>();
            this.Orders = new HashSet<Order>();
        }
    
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<FinalOrder> FinalOrders { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}