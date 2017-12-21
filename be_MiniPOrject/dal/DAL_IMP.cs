﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using be_MiniPOrject;
using DS;
namespace dal
{
    class Dal_IMP
    {
        #region Child Function

        public void AddChild(Child c)
        {
            Child chi = GetChild(c.Id);
            if (chi != null)
                throw new Exception("child with the same id already exists...");
            DataSource.kids.Add(c);

        }

        public Child GetChild(int id)
        {
            return DataSource.kids.FirstOrDefault(c => c.Id == id);
        }

        public void RemoveChild(int id)
        {
            Child chi = GetChild(id);
            if (chi == null)
                throw new Exception("child with the same id not found...");
            DataSource.kids.Remove(chi);
        }

        public void UpdateChild(Child c)
        {
            Child chi = GetChild(c.Id);
            if (chi == null)
                throw new Exception("child with the same id not found...");
            chi = c;
        }
        #endregion


        #region Nanny Function
        public void AddNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (nan != null)
                throw new Exception("nanny with the same id already exists...");
            DataSource.nannys.Add(n);
        }

        public void RemoveNanny(int id)
        {
            Nanny nan = GetNanny(id);
            if (nan == null)
                throw new Exception("Nanny with the same id not found...");
            DataSource.nannys.Remove(nan);
        }

        public void UpdateNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (nan != null)
                throw new Exception("nanny with the same id already exists...");
            nan = n;
        }
        public Nanny GetNanny(int id)
        {
            return DataSource.nannys.FirstOrDefault(n => n.Id == id);
        }
        #endregion


        #region Mother Function
        public void AddMother(Mother m)
        {
            Mother mom = GetMother(m.Id);
            if (mom != null)
                throw new Exception("Mother with the same id already exists...");
            DataSource.mothers.Add(m);
        }

        public Mother GetMother(int id)
        {
            return DataSource.mothers.FirstOrDefault(m => m.Id == id);
        }

        public void RemoveMother(int id)
        {
            Mother mom = GetMother(id);
            if (mom == null)
                throw new Exception("Mother with the same id not found...");
            DataSource.mothers.Remove(mom);
        }

        public void UpdateMother(Mother m)
        {
            Mother mom = GetMother(m.Id);
            if (mom == null)
                throw new Exception("Mother with the same id not found...");
            mom = m;
        }
        #endregion


        #region Contract Function
        public void AddContract(Contract c)
        {
            Contract Con = GetContract(c.Contract_Num1);//אמור ליהות המספר שמשתנה לא יודע למה לא קורא
            if (Con != null)
                throw new Exception("Contract with the same id already exists...");
            DataSource.contracts.Add(c);
            Contract.ContractNum1++;
        }

        public Contract GetContract(int contract_Num)
        {
            return DataSource.contracts.FirstOrDefault(c => c.Contract_Num1 == contract_Num);
        }

        public void RemoveContract(int contract_Num)
        {
            Contract Con = GetContract(contract_Num);
            if (Con == null)
                throw new Exception("Contract with the same id not found...");
            DataSource.contracts.Remove(Con);
        }

        public void UpdateContract(Contract c)
        {
            Contract con = GetContract(c.Contract_Num1);
            if (con == null)
                throw new Exception("Contract with the same id not found...");
            con = c;
        }
        #endregion

        #region Get List
        public List<Nanny> AcceptanceNanny() => DataSource.nannys;
        public List<Mother> AcceptanceMother() => DataSource.mothers;
        public List<Child> AcceptanceChild() => DataSource.kids;
        public List<Contract> AcceptanceContract() => DataSource.contracts;
        #endregion
    }
}



