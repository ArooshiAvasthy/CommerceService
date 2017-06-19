using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using DAL;
using AutoMapper;

namespace NewCommerceService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCart : IServiceCart
    {
        ICart cartObj = new CartDAL();

        public List<Carttype> DisplayCart(string Username)
        {
            var list = cartObj.DisplayCart(Username);
            List<Carttype> serviceList= new List<Carttype>();

            Mapper.Initialize(cfg => { cfg.CreateMap<Cart, Carttype>(); cfg.CreateMap<Product, Producttype>(); cfg.CreateMap<Category, Categorytype>(); });
            if (list.Any())
            {
                foreach (var item in list)
                {

                    Carttype itemModel = Mapper.Map<Cart, Carttype>(item);
                    itemModel.Product.ProductName = item.Product.ProductName;
                    itemModel.ProductName = item.Product.ProductName;
                    itemModel.ImagePath = item.Product.ImagePath;
                    itemModel.ImagePath2 = item.Product.ImagePath2;
                    itemModel.VideoPath = item.Product.VideoPath;
                    serviceList.Add(itemModel);
                }
            }

            return serviceList;

        }

        public List<Carttype> AddToCart(string Title, int Quantity, string Username)
        {
            try
            {
                var list = cartObj.AddToCart(Title, Quantity, Username);
                List<Carttype> serviceList = new List<Carttype>();

                Mapper.Initialize(cfg => { cfg.CreateMap<Cart, Carttype>(); cfg.CreateMap<Product, Producttype>(); cfg.CreateMap<Category, Categorytype>(); });
                if (list.Any())
                {
                    foreach (var item in list)
                    {

                        Carttype itemModel = Mapper.Map<Cart, Carttype>(item);
                        itemModel.Product.ProductName=item.Product.ProductName;
                        itemModel.ProductName = item.Product.ProductName;
                        itemModel.ImagePath = item.Product.ImagePath;
                        itemModel.ImagePath2 = item.Product.ImagePath2;
                        itemModel.VideoPath = item.Product.VideoPath;
                        serviceList.Add(itemModel);
                    }
                }

                return serviceList;

            }

            catch (Exception ex)
            {
                throw ex;
            }
            

        }


        public void GetClearItem(int id)
        {

            cartObj.GetClearItem(id);

        }

    }
}
