using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
using System.Xml.Linq;

namespace DAL
{
    class Dal_IMP : IDAL
    {
        #region Child Function
        /// <summary>
        /// add child 
        /// </summary>
        /// <param name="c"></param>
        public void AddChild(Child c)
        {
            Child chi = GetChild(c.Id);
            if (chi != null)
                throw new Exception("child with the same id already exists...");
            Mother mom = GetMother(c.MotherId);
            if (mom == null)
                throw new Exception("not exist mother to this child");
            mom.ListIdChild.Add(c.Id);
            DataSource.kids.Add(c);
        }
        /// <summary>
        /// get the child you locking with id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Child GetChild(string id)
        {
            Child child = null;
            child = DataSource.kids.FirstOrDefault(c => c.Id == id);
            return child;
        }
        /// <summary>
        /// remove the child with id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveChild(string id)
        {
            Child chi = GetChild(id);
            if (chi == null)
                throw new Exception("child with the same id not found...");
            GetMotherWithChildId(id).ListIdChild.Remove(id);
            DataSource.kids.Remove(chi);
        }
        /// <summary>
        /// update the child
        /// </summary>
        /// <param name="c"></param>
        public void UpdateChild(Child c)
        {
            Child chi = GetChild(c.Id);
            if (chi == null)
                throw new Exception("child with the same id not found...");
            for (int i = 0; i < DataSource.kids.Count; i++)
            {
                if (DataSource.kids[i].Id == chi.Id)
                    DataSource.kids[i] = c;
            }

        }
        /// <summary>
        /// get all the child
        /// </summary>
        /// <returns></returns>
        public List<Child> getChildList() => DataSource.kids;
        #endregion


        #region Nanny Function
        /// <summary>
        /// add nanny
        /// </summary>
        /// <param name="n"></param>
        public void AddNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (nan != null)
                throw new Exception("nanny with the same id already exists...");
            DataSource.nannys.Add(n);
        }
        /// <summary>
        /// remove the nanny acording to id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveNanny(string id)
        {
            Nanny nan = GetNanny(id);
            if (nan == null)
                throw new Exception("Nanny with the same id not found...");
            DataSource.nannys.Remove(nan);
        }
        /// <summary>
        /// update the nanny
        /// </summary>
        /// <param name="n"></param>
        public void UpdateNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (nan == null)
                throw new Exception("there no nanny with this id");
            for (int i = 0; i < DataSource.nannys.Count; i++)
            {
                if (DataSource.nannys[i].Id == nan.Id)
                    DataSource.nannys[i] = n;
            }
        }
        /// <summary>
        /// get nanny with id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Nanny GetNanny(string id)
        {
            return DataSource.nannys.FirstOrDefault(n => n.Id == id);
        }
        /// <summary>
        /// get all the nannies
        /// </summary>
        /// <returns></returns>
        public List<Nanny> getNannyList() => DataSource.nannys;
        #endregion


        #region Mother Function
        /// <summary>
        /// add mother
        /// </summary>
        /// <param name="m"></param>
        public void AddMother(Mother m)
        {
            Mother mom = GetMother(m.Id);
            if (mom != null)
                throw new Exception("Mother with the same id already exists...");
            DataSource.mothers.Add(m);
        }
        /// <summary>
        /// get mother acording to id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mother GetMother(string id)
        {
            return DataSource.mothers.FirstOrDefault(m => m.Id == id);
        }
        /// <summary>
        /// get the mother with child id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mother GetMotherWithChildId(string id)
        {
            Child chi = GetChild(id);
            if (chi == null)
                throw new Exception("thare no child with that id");

            return DataSource.mothers.FirstOrDefault(m => m.ListIdChild.FirstOrDefault() == id);
        }
        /// <summary>
        /// remove the mother acording to id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveMother(string id)
        {
            Mother mom = GetMother(id);
            if (mom == null)
                throw new Exception("Mother with the same id not found...");
            DataSource.mothers.Remove(mom);
        }
        /// <summary>
        /// update the mother
        /// </summary>
        /// <param name="m"></param>
        public void UpdateMother(Mother m)
        {
            Mother mom = GetMother(m.Id);
            if (mom == null)
                throw new Exception("Mother with the same id not found...");
            for (int i = 0; i < DataSource.mothers.Count; i++)
            {
                if (DataSource.mothers[i].Id == m.Id)
                    DataSource.mothers[i] = m;
            }
        }
        /// <summary>
        /// get all mother
        /// </summary>
        /// <returns></returns>
        public List<Mother> getMotherList() => DataSource.mothers;
        #endregion


        #region Contract Function
        /// <summary>
        /// add contract
        /// </summary>
        /// <param name="c"></param>
        public void AddContract(Contract c)
        {
            Child chi = GetChild(c.ChildId);
            if (chi == null)
                throw new Exception("there is no child with this id");
            Nanny nan = GetNanny(c.NannyId);
            if (nan == null)
                throw new Exception("there is no nanny with this id");
            Mother mom = GetMother(c.MotherId);
            if (mom == null)
                throw new Exception("there is no mother with this id");
            DataSource.contracts.Add(c);
            c.Contract_Num1 = Contract.ContractNum1;
            chi.listIdContract.Add(c.Contract_Num1);
            nan.ListIdContract.Add(c.Contract_Num1);
            Contract.ContractNum1++;
        }
        /// <summary>
        /// get three contract acording to is number
        /// </summary>
        /// <param name="contract_Num"></param>
        /// <returns></returns>
        public Contract GetContract(int contract_Num)
        {
            return DataSource.contracts.FirstOrDefault(c => c.Contract_Num1 == contract_Num);
        }
        
        /// <summary>
        /// remove contract with is namber
        /// </summary>
        /// <param name="contract_Num"></param>
        public void RemoveContract(int contract_Num)
        {
            Contract Con = GetContract(contract_Num);
            if (Con == null)
                throw new Exception("Contract with the same id not found...");
            DataSource.contracts.Remove(Con);
        }
        /// <summary>
        /// update the contract
        /// </summary>
        /// <param name="c"></param>
        public void UpdateContract(Contract c)
        {
            Contract con = GetContract(c.Contract_Num1);
            if (con == null)
                throw new Exception("Contract with the same id not found...");
            for (int i = 0; i < DataSource.contracts.Count(); i++)
            {
                if (DataSource.contracts[i].Contract_Num1 == c.Contract_Num1)
                    DataSource.contracts[i] = c;
            }
        }/// <summary>
        /// get all the contract
        /// </summary>
        /// <returns></returns>
        public List<Contract> getContractList() => DataSource.contracts;
        #endregion

        #region Get List
        /// <summary>
        /// get group child by mother id
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IGrouping<string, Child>> List_Child_ByMother()
        {
            var ChildByMother = from kid in getChildList()
                                group kid by kid.MotherId;
            return ChildByMother;
        }
        #endregion
    }
}
