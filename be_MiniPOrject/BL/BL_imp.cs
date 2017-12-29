using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    class BL_imp : IBL
    {
        DAL.IDAL dal;
        #region Nanny func

        public void AddNanny(Nanny n)
        {
            if (DateTime.Now.Year - n.DateBirth.Year < 18)
                throw new Exception("this Nanny is under 18");
            dal.AddNanny(n);
        }

        void DelNanny(Nanny n)
        {
            Contract c;
            foreach (int IdCo in n.ListIdContract)
            {
                c = dal.GetContract(IdCo);
                if (c.EndDate > DateTime.Now)
                    throw new Exception("Nanny have contract that she dont finish");
            }
            dal.RemoveNanny(n.Id);
        }

        void UpdatingNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (n.ListIdContract1.Count() > nan.MaxChildren)
                throw new Exception("Nanny cant have more children");
            dal.UpdateNanny(n);
        }

        Nanny GetNanny(int id)
        {
            return dal.GetNanny(id);
        }
        #endregion

        #region Child func

        void AddChild(Child c)
        {
            dal.AddChild(c);
        }
        void DelChild(Child c)
        {

        }
        void UpdatingChild();
        Child GetChild();
    }
}
