using System;
using System.Linq;
using System.Collections.Generic;

namespace DAL
{
    public class CompanyDAL
    {
        public static List<Company> GetAll()
        {
            using(ClockShopEntities ctx=new ClockShopEntities())
            {
                return ctx.Companies.ToList();
            }
        }
    }
}