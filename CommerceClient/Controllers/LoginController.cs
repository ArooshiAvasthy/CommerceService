using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CommerceClient.LoginServiceReference;
using AutoMapper;
using CommerceClient.Models;
using System.Web.Security;

namespace CommerceClient.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        LoginServiceClient loginObj = new LoginServiceClient();

        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string Name, string Password)
        {
            //PutAsjsonAsync username and password and verify
            Session["UserName"] = Name;
            Session["Password"] = Password;
            Session["Login"] = null;
            Session["Name"] = null;

            return RedirectToAction("Authorization");
        }

        public ActionResult Authorization()
         {
            
            bool response = loginObj.validateCredentials(Session["UserName"].ToString(), Session["Password"].ToString());

            if (response)
            {
                return RedirectToAction("SetSession");
            }
            else
            {
                
                return RedirectToAction("InvalidCredentials");
            }
        }

        public ActionResult InvalidCredentials()
        {
            return View();
        }

        //[WebMethod(EnableSession = true)]
        public ActionResult SetSession()
        {
            Session["Login"] = "Success";
            Session["Name"] = Session["UserName"];

            return RedirectToAction("Index","Home");
        }

        public ActionResult Logout()
        {
            Session["UserName"] = null;
            Session["Password"] = null;
            Session["Login"] = null;
            Session["Name"] = null;

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(UserModel usermodel)
        {

            try
            {
                
                Mapper.Initialize(cfg => { cfg.CreateMap<UserModel,Usertype>(); });
                Usertype user = Mapper.Map<UserModel, Usertype>(usermodel);
                
                bool response=loginObj.AddNewUser(user);
                if (response)
                    return RedirectToAction("SignUp","Login");
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