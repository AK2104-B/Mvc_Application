using Application_0._0._1.Helpers.Helper;
using Application_0._0._1.Models.GbContext;
using Application_0._0._1.Models.Model;
using Application_0._0._1.Repositeries.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_0._0._1.Repositeries.Services
{
    public class UserService : UserInterface
    {
        public void Add(UserModel u)
        {
            balajiAppEntities b = new balajiAppEntities();
            user us = UserHelper.con(u);
            b.user.Add(us);
            b.SaveChanges();
        }
    }
}
