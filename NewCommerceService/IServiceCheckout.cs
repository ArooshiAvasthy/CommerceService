using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NewCommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceCheckout" in both code and config file together.
    [ServiceContract]
    public interface IServiceCheckout
    {
        [OperationContract]
        List<Ordertype> ProceedTOCheckout(string Username);

        [OperationContract]
        List<Ordertype> DisplayOrder(string Username);

        [OperationContract]
        List<FinalOrdertype> FinalBuy(int id);

        [OperationContract]
        Ordertype getOrder(int id);

        [OperationContract]
        bool deleteOrder(int id);
    }

    [DataContract]
    public class Ordertype
    {
        [DataMember]
        public int OrderID { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
        [DataMember]
        public Nullable<int> SumQuantity { get; set; }
        [DataMember]
        public Nullable<int> SumPrice { get; set; }
        [DataMember]
        public string ApprovedStatus { get; set; }
    }

    [DataContract]
    public class FinalOrdertype
    {
        [DataMember]
        public int FinalOrderID { get; set; }
        [DataMember]
        public Nullable<int> UserId { get; set; }
        [DataMember]
        public Nullable<int> OrderId { get; set; }
        [DataMember]
        public Nullable<int> SumQuantity { get; set; }
        [DataMember]
        public Nullable<int> SumPrice { get; set; }
        [DataMember]
        public Nullable<System.DateTime> ShippingDate { get; set; }
    }
}
