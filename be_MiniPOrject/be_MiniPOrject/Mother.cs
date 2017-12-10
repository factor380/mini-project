using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_MiniPOrject
{
    class Mother
    {
        int id;
        string LastName;
        string name;
        string PhoneNum;
        string Address;
        string AddressAround;
        bool[] DayInWeek = new bool[6];
        float[,] WhenNeededWeek = new float[6, 2];
        string Remarks;
        public override string ToString()
        {
            return name + ' ' + LastName + " id" + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
