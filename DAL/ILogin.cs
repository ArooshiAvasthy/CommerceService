using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public interface ILogin
    {
        bool validateCredentials(string Name, string Password);
        bool AddUser(User user);
    }
}
