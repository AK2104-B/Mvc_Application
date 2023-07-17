using Application_0._0._1.Models.GbContext;
using Application_0._0._1.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_0._0._1.Helpers.Helper
{
    public class UserHelper
    {
        public static user con(UserModel u)
        {
            user us = new user();
            us.Fname = u.Fname;
            us.Lname = u.Lname;
            us.email = u.email;
            us.pass = u.pass;
            us.img = u.img;
            return us;
        }
    }
}
