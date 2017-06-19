using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Web.Script.Serialization;
using CommerceClient.HomeServiceReference;
using AutoMapper;
using CommerceClient.Models;

namespace CommerceClient.Controllers
{
    public class MoviePageController : Controller
    {
        HomeServiceClient objHome = new HomeServiceClient();
        // GET: /MoviePage/
        

        public ActionResult MovieReview(string name)
        {
            

            var movieData = objHome.GetMovie(name);
            Mapper.Initialize(cfg=>cfg.CreateMap<ImdbEntityType,ImdEntity>());
            ImdEntity obj = Mapper.Map<ImdbEntityType, ImdEntity>(movieData);

                //test
                List<SelectListItem> QuantityList = new List<SelectListItem>();

                int quantity = Convert.ToInt32(objHome.GetQuantity(name));

                for (int i = 1; i <= quantity; i++)
                {
                    QuantityList.Add(new SelectListItem { Text = i.ToString() });
                    //new SelectListItem { Text = i.ToString() });
                }
                TempData["dropdownQTy"] = QuantityList;


                return View(obj);
            }

        

        [HttpPost]
        public ActionResult CartAdd(string hdn)
        {


            var a = Request.Params["CartAdd"];
            var b = Request["CartAdd"];
            return View();

        }
	}
}