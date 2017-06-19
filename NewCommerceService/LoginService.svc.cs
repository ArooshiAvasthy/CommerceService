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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoginService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select LoginService.svc or LoginService.svc.cs at the Solution Explorer and start debugging.
    public class LoginService : ILoginService
    {
        ILogin loginObj = new LoginDAL();

        public bool validateCredentials(string Name, string Password)
        {
            try
            {
                bool response= loginObj.validateCredentials(Name,Password);
               return response;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       
        public bool AddNewUser(Usertype user)
        {
            try
            {
                Mapper.Initialize(cfg => { cfg.CreateMap<Usertype, User>(); });
                User newuser = Mapper.Map<Usertype, User>(user);
                bool response= loginObj.AddUser(newuser);
                return response;
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
