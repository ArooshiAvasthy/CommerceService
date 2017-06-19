using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DAL;
using AutoMapper;

namespace NewCommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHomeService" in both code and config file together.
    [ServiceContract]
    public interface IHomeService
    {
        [OperationContract]
        List<Producttype> DisplayAllProducts();

        [OperationContract]
        List<Producttype> DisplayProductsByCategory(string CategoryName);

        [OperationContract]
        int GetQuantity(string name);

        [OperationContract]
        ImdbEntityType GetMovie(string name);
    }

    [DataContract]
    public class ImdbEntityType
    {
        [DataMember]
        public int MovieID { get; set; }
        [DataMember]
        public string Year { get; set; }
        [DataMember]
        public string Rated { get; set; }
        [DataMember]
        public string Released { get; set; }
        [DataMember] 
        public string Runtime { get; set; }
        [DataMember]
        public string Genre { get; set; }
        [DataMember]
        public string Director { get; set; }
        [DataMember]
        public string Writer { get; set; }
        [DataMember]
        public string Actors { get; set; }
        [DataMember]
        public string Plot { get; set; }
        [DataMember]
        public string Language { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Awards { get; set; }
        [DataMember]
        public string Poster { get; set; }
        [DataMember]
        public string Metascore { get; set; }
        [DataMember]
        public string imdbRating { get; set; }
        [DataMember]
        public string imdbVotes { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Response { get; set; }
        [DataMember]
        public string Title { get; set; }
    }

    [DataContract]
    public class Producttype
    {
        [DataMember]
        public int ProductID { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string ProductDescription { get; set; }
        [DataMember]
        public Nullable<int> CategoryID { get; set; }
        [DataMember]
        public Nullable<int> QuantityAvailable { get; set; }
        [DataMember]
        public string Price { get; set; }
        [DataMember]
        public string ImagePath { get; set; }
        [DataMember]
        public Categorytype Category { get; set; }
        [DataMember]
        public string ImagePath2 { get; set; }
        [DataMember]
        public string VideoPath { get; set; }
        
    }

    [DataContract]
    public class Categorytype
    {
        [DataMember]
        public int CategoryId { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
       
    }
}
