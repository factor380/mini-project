using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    class BL_imp
    {
        #region Nanny func

        public void AddNanny(Nanny n)
        {
            if ( DateTime.Now-n.DateBirth<18)
                throw new Exception("this Nanny is under 18");
            DAL.AddNanny(n);
        }

        void DelNanny(Nanny n)
        {
            Contract c;
                foreach(int IdCo in n.ListIdContract)
                {
                c=DAL.GetContract(IdCo);
                if (c.EndDate>DateTime.now)
                    throw new Exception("Nanny have contract that she dont finish");
                }
                dal.DelNanny(n);
        }

         void UpdatingNanny(Nanny n)
         {
             Nanny nan = GetNanny(n.Id);
            if (n.ListIdContract1.Count()>nan.MaxChildren)
                throw new Exception("Nanny cant have more children");
            dal.UpdatingNanny(n);
         }

        Nanny GetNanny(int id)
            {
            DAL.GetNanny(id);
            }
         #endregion    

        #region Child func

        void AddChild(Child c)
        {
            DAL.AddChild(c);
        }
        void DelChild(Child c)
        {

        }
        void UpdatingChild();
        Child GetChild();

  


    }
}
