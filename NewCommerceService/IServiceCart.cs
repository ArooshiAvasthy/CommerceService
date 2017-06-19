using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NewCommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServiceCart
    {
        [OperationContract]
        List<Carttype> DisplayCart(string Username);

        [OperationContract]
        List<Carttype> AddToCart(string Title, int Quantity, string Username);
        [OperationContract]
        void GetClearItem(int id);
    }

        [DataContract]
        public class Carttype
        {
            [DataMember]
            public int CartID { get; set; }
            [DataMember]
            public int UserId { get; set; }
            [DataMember]
            public int ProductID { get; set; }
            [DataMember]
            public int Quantity { get; set; }
            [DataMember]
            public int Price { get; set; }
            [DataMember]
            public string PaidStatus { get; set; }
            [DataMember]
            public int OrderId { get; set; }
            [DataMember]
            public string ProductName { get; set; }
            [DataMember]
            public Producttype Product { get; set; }
            [DataMember]
            public string ImagePath { get; set; }
            [DataMember]
            public string ImagePath2 { get; set; }
            [DataMember]
            public string VideoPath { get; set; }
           

        }
    
}
