using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommerceClient.CheckoutServiceReference;
using AutoMapper;
using CommerceClient.Models;

namespace CommerceClient.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/
        ServiceCheckoutClient obj = new ServiceCheckoutClient();

        public ActionResult Checkout()
        {
            string usrName = Session["UserName"].ToString();
            var orderlist = obj.ProceedTOCheckout(usrName);
            var itemlist = new List<CheckoutModel>();

            if (orderlist.Any())
            {
                //Mapper initialization and creation
                Mapper.Initialize(cfg => cfg.CreateMap<Ordertype, CheckoutModel>());
                foreach (var item in orderlist)
                {
                    CheckoutModel userModel = Mapper.Map<Ordertype,CheckoutModel>(item);
                    itemlist.Add(userModel);

                }
            }

            return View(itemlist);
        }
        //
        // GET: /Checkout/Details/5

        //
        // GET: /Checkout/Edit/5

        public ActionResult FinalBuy(int id)
        {
            try
            {
                var receipt = obj.FinalBuy(id);


                var itemlist = new List<ReceiptModel>();

                if (receipt.Any())
                {
                    //Mapper initialization and creation
                    Mapper.Initialize(cfg => cfg.CreateMap<FinalOrdertype, ReceiptModel>());
                    foreach (var item in receipt)
                    {
                        ReceiptModel userModel =
                        Mapper.Map<FinalOrdertype, ReceiptModel>(item);
                        itemlist.Add(userModel);

                    }
                }


                return View(itemlist);
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Checkout/Edit/5


        //
        // GET: /Checkout/Delete/5

        public ActionResult Delete(int id)
        {
            var delRecord = obj.getOrder(id);
            Mapper.Initialize(cfg => cfg.CreateMap<Ordertype,CheckoutModel>());

            CheckoutModel userModel =
            Mapper.Map<Ordertype, CheckoutModel>(delRecord);

            //  return View(delRecord);
            return View(userModel);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                bool response=obj.deleteOrder(id);
                if (response)
                {
                    return RedirectToAction("Checkout", "Checkout");
                }
                else
                    return View("Error");
            }
            catch
            {
                return View();
            }
        }
	}
}