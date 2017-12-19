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
        #endregion


        #region Mother Function
        public void AddMother(Mother m)
        {
            Mother mom = GetMother(m.Id);
            if (mom != null)
                throw new Exception("Mother with the same id already exists...");
            mothers.Add(m);
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
            Contract Con = GetContract(c.Contract_Num);
            if (Con != null)
                throw new Exception("Contract with the same id already exists...");
            Contracts.Add(c);
        }

        public void RemoveContract(int Contract_Num)
        {
            Contract Con = GetContract(Contract_Num);
            if (Con == null)
                throw new Exception("Contract with the same id not found...");
            Contracts.Remove(Con);
        }

        public void UpdateContract(Contract c)
        {
            Contract con = GetContract(c.Contract_Num);
            if (con == null)
                throw new Exception("Contract with the same id not found...");
            con = c;
        }
        #endregion

        #region Get List
        public List<Nanny> AcceptanceNanny() => nannys;
        public List<Mother> AcceptanceMother()
        {
            return mothers;
        }
        public List<Child> AcceptanceChild()
        {
            return kids;
        }
        public List<Contract> AcceptanceContract()
        {
            return contracts;
        }
        #endregion
    }
}

