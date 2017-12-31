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

        void RemoveNanny(Nanny n)
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

        void UpdateNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (n.ListIdContract.Count() > nan.MaxChildren)
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
        void DelChild(int id)
        {
            Contract c;
            Child chi=GetChild(id);
            Mother m =GetMotherWithChildId(id);
            foreach (int IdCo in chi.ListIdContract)
            {
                c = dal.GetContract(IdCo);
                if (c.EndDate > DateTime.Now)
                    throw new Exception("Child have contract that he dont finish");
            }
            //the thing to the 2% שכר
            
        }
        void UpdatingChild(Child c)
        {
            dal.UpdateChild(c);
        }
        Child GetChild(int id)
        {
            return dal.GetChild(id);
        }
        #endregion

        #region mother func
        void AddMother(Mother m)
        {
            dal.AddMother(m);
        }
        void RemoveMother(int id)
        {
            m=getmother(id);
            foreach (int Idc in m.ListIdChild)
            {
                 DelChild(idc);
            }
            dal.RemoveMother(id);
        }
        void UpdateMother(Mother m)
        {
            dal.UpdateMother(m);
        }
        Mother GetMother(int id)
        {
            return dal.GetMother(id);
        }
        Mother GetMotherWithChildId(int id)
        { 
            return dal.GetMotherWithChildId(id);
        }
        #endregion
         
        #region Contract func
        void AddContract(Contract c)
        {

        }

         

    }
}