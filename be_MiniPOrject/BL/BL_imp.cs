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
        void DelChild(int id)//אני חושב שיש דברים שצריך לשפר פה א
        {
            Contract c;
            Child chi = GetChild(id);
            Mother m = GetMotherWithChildId(id);
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
            m = getmother(id);
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
            Child chi = GetChild(c.ChildId);
            Nanny nan = GetNanny(c.NannyId);
            Mother mom = GetMother(c.MotherId);
            int temp = 0;//if the nanny have more children from the mother they are rebate 
            if (DateTime.Today.Year - chi.DateBirth.Year < nan.MinAgeMonth)
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if (DateTime.now - chi.DateBirth > nan.MaxAgeMonth)
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if (nan.ListIdContract.Contains == nan.MaxChildren)
            {
                throw new Exception("the nanny take care of max child that she can");
            }

            foreach (int idc in nan.ListIdContract)
            {
                Contract con = GetContract(idc);
                if (con.MotherId == mom.id)
                    tamp++;
            }
            if (c.HorM1 == false)//hour
            {
                if (nan.YorN_HourlyRate = fulse)
                    throw new Exception("the nanny dont agree to get a hour rate");
                c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                c.PayMonth = c.PayHours * 4 * nan.HowMuchHourNanWork1;
            }
            else//month
            {
                c.PayMonth = nan.PayMonth - ((nan.PayMonth * temp * 2) / 100);
                c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
            }
            dal.AddContract(c);
        }
        void RemoveContract(int contract_Num)
        {
            Contract c = GetContract(contract_Num);
            if (DateTime.Now > c.EndDate)
                throw new Exception("this contract dont finish");
            Nanny nan = GetNanny(c.NannyId);
            nan.ListIdContract.Remove(contract_Num);
            UpdetRateOfContract(c.NannyId, c.MotherId);
            dal.RemoveContract(contract_Num);
        }

        Contract GetContract(int contract_Num)
        {
            return dal.GetContract(contract_Num);
        }
        void UpdetRateOfContract(int NanId, int MomId)
        {
            Nanny nan = GetNanny(NanId);
            int temp = 0;
            foreach (int idc in nan.ListIdContract)
            {
                Contract c = GetContract(idc);
                if (c.MotherId == MomId)
                {
                    if (c.HorM1 == false)//hour
                    {
                        c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                        c.PayMonth = (c.PayHours * 4 * (nan.HowMuchHourNanWork1));
                    }
                    else//month
                    {
                        c.PayMonth = nan.PayMonth - ((nan.PayMonth * temp * 2) / 100);
                        c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                    }
                    tamp++;
                }
            }
        }

    }
}