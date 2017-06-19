using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommerceClient.CartServiceReference;
using AutoMapper;
using CommerceClient.Models;

namespace CommerceClient.Controllers
{
    public class CartController : Controller
    {
        ServiceCartClient cartObj = new ServiceCartClient();
       
        public ActionResult Index()
        {
            try
            {
                if (Session["Name"] == null)
                {
                    return View("PleaseLogin");
                }
                else
                {
                    string name = Session["Name"].ToString();
                    var cartItems = cartObj.DisplayCart(name);
                    List<CartModel> serviceList = new List<CartModel>();

                        if (cartItems.Count() > 0)
                        {
                            Mapper.Initialize(cfg => { cfg.CreateMap<Carttype, CartModel>(); cfg.CreateMap<Producttype, ProductModel>(); cfg.CreateMap<Categorytype, CategoryModel>(); });
                            if (cartItems.Any())
                            {
                                foreach (var item in cartItems)
                                {
                                    CartModel itemModel = Mapper.Map<Carttype, CartModel>(item);
                                    itemModel.Product.ProductName = item.Product.ProductName;
                                    itemModel.ProductName = item.Product.ProductName;
                                    serviceList.Add(itemModel);
                                }
                            }

                            return View(serviceList);
                        }

                        else
                        {
                            return View("Proceed");
                        }             
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

         }
        
        //Post
        [HttpPost]

        public ActionResult AddToCart(ImdEntity obj, FormCollection collection)
        {
            try
            {
                string Title = obj.Title;
                string name = Session["Name"].ToString();
                var quantity = collection["dropdown"];

                if (quantity.ToString() == "")
                {
                    return View("QuantityPlease");
                }
                else
                {
                    var recentItem = cartObj.AddToCart(Title, Convert.ToInt16(quantity), name);
                    List<CartModel> serviceList = new List<CartModel>();

                    //Mapper.Initialize(cfg => { cfg.CreateMap<Carttype, CartModel>(); cfg.CreateMap<Producttype, ProductModel>(); });
                    Mapper.Initialize(cfg => { cfg.CreateMap<Carttype, CartModel>(); cfg.CreateMap<Producttype, ProductModel>(); cfg.CreateMap<Categorytype, CategoryModel>(); });
                    if (recentItem.Any())
                    {
                        foreach (var item in recentItem)
                        {
                            CartModel itemModel = Mapper.Map<Carttype, CartModel>(item);
                            itemModel.Product.ProductName = item.Product.ProductName;
                            itemModel.ProductName = item.Product.ProductName;
                            serviceList.Add(itemModel);
                        }
                    }
                    return View(serviceList);
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public FilePathResult Download(string videopath, string title, string id)
        {

            int cartId = Convert.ToInt32(id);
            string titlemain = title + ".mp4";
            string filepath = videopath;
            string contentType = "application/mp4";
            cartObj.GetClearItem(cartId);
                      
            return File(filepath, contentType, titlemain);
        }
       
	}
}