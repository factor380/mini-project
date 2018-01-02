using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS
{
    public class DataSource
    {
        public static List<Child> kids;
        public static List<Mother> mothers;
        public static List<Nanny> nannys;
        public static List<Contract> contracts;

        public DataSource()
        {
            List<Child> kids = new List<Child>();
            List<Mother> mothers = new List<Mother>();
            List<Nanny> nannys = new List<Nanny>();
            List<Contract> contracts = new List<Contract>();
        }
    }
}
