using System;
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
        /*
        public Dal_List()
        {
            studentList = new List<Student>();
            courseList = new List<Course>();
            studentCourseList = new List<StudentCourseAdapter>();
        }*///somthing that we need to chang i dont sure how


        //private static List<Student> studentList;
        //private static List<Course> courseList;
        //private static List<StudentCourseAdapter> studentCourseList;

        //static Dal_List()
        //{
        //    studentList = new List<Student>();
        //    courseList = new List<Course>();
        //    studentCourseList = new List<StudentCourseAdapter>();
        //}

        #region Child Function

        public void AddChild(Child c)
        {
            Child chi = GetChild(c.Id);
            if (chi != null)
                throw new Exception("child with the same id already exists...");
            kids.add(c);
        }

        public Child GetChild(int id)
        {
            foreach (Child c in kids)
            {
                if (c.Id == id)
                    return c;
            }
            return null;
        }

        public void RemoveChild(int id)
        {
            Child chi = GetChild(id);
            if (chi == null)
                throw new Exception("child with the same id not found...");
            kids.Remove(chi);
        }

        public void UpdateChild(Child c)
        {
            Child chi = GetChild(c.id);
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
            nannys.Add(n);
        }

        public void RemoveNanny(int id)
        {
            Nanny nan = GetNanny(id);
            if (nan == null)
                throw new Exception("Nanny with the same id not found...");
            nannys.Remove(nan);
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
            foreach (Nanny n in nunnys)
            {
                if (n.Id == id)
                    return n;
            }
            return null;
        }
        #endregion


        #region Mother Function
        public void AddMother(Mother m)
        {
            Mother mom = GetMother(m.Id);
            if (mom != null)
                throw new Exception("Mother with the same id already exists...");
            mothers.Add(m);
        }

        public Mother GetMother(int id)
        {
                foreach (Mother m in mothers)
                {
                    if (m.Id == id)
                        return m;
                }
                return null;
        }

        public void RemoveMother(int id)
        {
            Mother mom = GetMother(id);
            if (mom == null)
                throw new Exception("Mother with the same id not found...");
            mothers.Remove(mom);
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
            Contract Con = GetContract(c.ContractNum1);//אמור ליהות המספר שמשתנה לא יודע למה לא קורא
            if (Con != null)
                throw new Exception("Contract with the same id already exists...");
            contracts.Add(c);
        }

        public Contract GetContract(int contract_Num)
        {
            foreach (Contract c in contracts)
            {
                if (c.Contract_Num1 == contract_Num)
                    return c;
            }
            return null;
        }

        public void RemoveContract(int contract_Num)
        {
            Contract Con = GetContract(contract_Num);
            if (Con == null)
                throw new Exception("Contract with the same id not found...");
            contracts.Remove(Con);
        }

        public void UpdateContract(Contract c)
        {
            Contract con = GetContract(c.ContractNum1);
            if (con == null)
                throw new Exception("Contract with the same id not found...");
            con = c;
        }
        #endregion

        #region Get List
        public List<Nanny> AcceptanceNanny() => nunnys;
        public List<Mother> AcceptanceMother() => mothers;
        public List<Child> AcceptanceChild() => kids;
        public List<Contract> AcceptanceContract() => contracts;
        #endregion
    }
}

