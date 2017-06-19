using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel;
using CommerceClient.HomeServiceReference;
using AutoMapper;
using CommerceClient.Models;

namespace CommerceClient.Controllers
{
    public class HomeController : Controller
    {
     
        HomeServiceClient objHome = new HomeServiceClient();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllMoviePage()
       
        {
           // CartServiceReference.
            var movielist = objHome.DisplayAllProducts();
            var itemlist = new List<ProductModel>();

            if (movielist.Any())
            {
                //Mapper initialization and creation mapping from DB to model
                // Mapper.Initialize(cfg => cfg.CreateMap<Product, NewCommerce.Models.ProductModel>().ForMember(dest => dest.Category.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName)));
                Mapper.Initialize(cfg => { cfg.CreateMap<Producttype, ProductModel>(); cfg.CreateMap<Categorytype, CategoryModel>(); });
                foreach (var item in movielist)
                {
                    ProductModel userModel =
                      Mapper.Map<Producttype, ProductModel>(item);
                    userModel.Category.CategoryName = item.Category.CategoryName;
                    itemlist.Add(userModel);


                }
            }

            return View(itemlist);

        }

        public ActionResult DisplayProduct_ByCategory(string CategoryName)
        {
            var movielist = objHome.DisplayProductsByCategory(CategoryName);
            var itemlist = new List<ProductModel>();
            if (movielist.Any())
            {
                //Mapper initialization and creation mapping from DB to model
                // Mapper.Initialize(cfg => cfg.CreateMap<Product, NewCommerce.Models.ProductModel>().ForMember(dest => dest.Category.CategoryName, opt => opt.MapFrom(src => src.Category.CategoryName)));
                Mapper.Initialize(cfg => { cfg.CreateMap<Producttype,ProductModel>(); cfg.CreateMap<Categorytype,CategoryModel>(); });
                foreach (var item in movielist)
                {
                    ProductModel userModel =
                    Mapper.Map<Producttype,ProductModel>(item);
                    userModel.Category.CategoryName = item.Category.CategoryName;
                    itemlist.Add(userModel);
                }
            }

            return View(itemlist);
        }

    }
}