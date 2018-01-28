using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class FactoryDAL
    {
        static IDAL dal = null;
        public static IDAL GetDAL()
        {
            if (dal == null)
                dal = new Dal_XML_imp();
            return dal;
        }
    }
}
