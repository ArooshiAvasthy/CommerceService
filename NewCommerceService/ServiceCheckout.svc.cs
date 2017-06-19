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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceCheckout" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceCheckout.svc or ServiceCheckout.svc.cs at the Solution Explorer and start debugging.
    public class ServiceCheckout : IServiceCheckout
    {
        ICheckout checkOBj = new CheckoutDAL();

        public List<Ordertype> ProceedTOCheckout(string Username)
        {
            var list = checkOBj.ProceedTOCheckout(Username);
            List<Ordertype> serviceList = new List<Ordertype>();

            Mapper.Initialize(cfg => { cfg.CreateMap<Order, Ordertype>(); });

            if (list != null)
            {
                foreach (var item in list)
                {

                    Ordertype itemModel = Mapper.Map<Order,Ordertype>(item);
                    serviceList.Add(itemModel);
                }
            }

            return serviceList;
        }

        public List<Ordertype> DisplayOrder(string Username)
        {

            var list = checkOBj.DisplayOrder(Username);
            List<Ordertype> serviceList = new List<Ordertype>();

            Mapper.Initialize(cfg => { cfg.CreateMap<Order, Ordertype>(); });

            if (list != null)
            {
                foreach (var item in list)
                {

                    Ordertype itemModel = Mapper.Map<Order, Ordertype>(item);
                    serviceList.Add(itemModel);
                }
            }

            return serviceList;
        }

        public List<FinalOrdertype> FinalBuy(int id)
        {

            var list = checkOBj.FinalBuy(id);
            List<FinalOrdertype> serviceList = new List<FinalOrdertype>();

            Mapper.Initialize(cfg => { cfg.CreateMap<FinalOrder, FinalOrdertype>(); });

            if (list != null)
            {
                foreach (var item in list)
                {

                    FinalOrdertype itemModel = Mapper.Map<FinalOrder, FinalOrdertype>(item);
                    serviceList.Add(itemModel);
                }
            }

            return serviceList;
        }

        public Ordertype getOrder(int id)
        {
            var list = checkOBj.getOrder(id);
    
            Mapper.Initialize(cfg => cfg.CreateMap<Order,Ordertype>());

            Ordertype userModel =
            Mapper.Map<Order, Ordertype>(list);

            //  return View(delRecord);
            return userModel;
        }

        public bool deleteOrder(int id)
        {
            bool response=checkOBj.deleteOrder(id);
            return response;
        }
    }
}
