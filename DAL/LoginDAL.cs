using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class LoginDAL:ILogin
    {
        

        public bool validateCredentials(string Name, string Password)
        {
            try
            {
               // return false;
                using (NewCommerceEntities obj = new NewCommerceEntities())
                {
                    var record = (from c in obj.Users
                                  where c.Name == Name && c.Password == Password
                                  select c).ToList<User>();

                    if (record.Count() == 0)
                        return false;
                    else
                        return true;
                }
            }

          catch(Exception ex)
            {
                throw ex;
            }
        }


        public bool AddUser(User user)
        {
            using (NewCommerceEntities obj = new NewCommerceEntities())
            {
                obj.Users.Add(user);
                obj.SaveChanges();
                return true;
            }
        }
    }
}
