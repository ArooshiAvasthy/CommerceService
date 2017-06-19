using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AutoMapper;
using DAL;
//using DAL.Interfaces;

namespace NewCommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HomeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HomeService.svc or HomeService.svc.cs at the Solution Explorer and start debugging.
    public class HomeService : IHomeService
    {
       
        IHome homeObj = new HomeDAL();
       
        public List<Producttype> DisplayAllProducts()
        {
            var movielist = homeObj.DisplayAllProducts();
      
            var itemlist = new List<Producttype>();


            if (movielist.Any())
            {
                
                Mapper.Initialize(cfg => { cfg.CreateMap<Product, Producttype>(); cfg.CreateMap<Category, Categorytype>(); });
                foreach (var item in movielist)
                {
                    Producttype userModel =Mapper.Map<Product, Producttype>(item);
                    userModel.Category.CategoryName = item.Category.CategoryName;
                    itemlist.Add(userModel);


                }
            }

            return itemlist;
        }

        public List<Producttype> DisplayProductsByCategory(string CategoryName)
        {
            var list = homeObj.DisplayProductsByCategory(CategoryName);
            List<Producttype> serviceList = new List<Producttype>();

            if (list.Any())
            {
                //Mapper initialization and creation mapping from DB to model
                // Mapper.Initialize(cfg => cfg.CreateMap<Product, NewCommerce.Models.ProductModel>().ForMember(dest => dest.Category.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName)));
                Mapper.Initialize(cfg => { cfg.CreateMap<Product, Producttype>(); cfg.CreateMap<Category, Categorytype>(); });
                foreach (var item in list)
                {
                    Producttype userModel = Mapper.Map<Product, Producttype>(item);
                    userModel.Category.CategoryName = item.Category.CategoryName;
                    serviceList.Add(userModel);


                }
            }

            return serviceList;
        }

        public int GetQuantity(string name)
        {
            int Quantity = homeObj.GetQuantity(name);
            return Quantity;
        }


        public ImdbEntityType GetMovie(string name)
        {
            MovieList movieData = homeObj.GetMovie(name);
            Mapper.Initialize(cfg => cfg.CreateMap<MovieList, ImdbEntityType>());

            ImdbEntityType obj = Mapper.Map<MovieList, ImdbEntityType>(movieData);

            return obj;
        }
    }
}
