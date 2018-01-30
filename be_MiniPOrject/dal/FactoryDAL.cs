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
        /// <summary>
        /// func to check if exist dal or not
        /// </summary>
        /// <returns>the new dal or the old dal</returns>
        public static IDAL GetDAL()
        {
            if (dal == null)
                dal = new Dal_XML_imp();
            return dal;
        }
    }
}
