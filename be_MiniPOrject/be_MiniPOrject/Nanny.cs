using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_MiniPOrject
{
    public class Nanny
    {
        int id;
        string LastName;
        string name;
        DateTime DateBirth;
        string PhoneNum;
        string Address;
        bool elevator;
        int FloorInBulding;
        int exp;
        int MaxChildren;
        int MinAgeMonth;
        int MaxAgeMonth;
        bool YorN_HourlyRate;
        float PayHour;
        int PayMonth;
        bool[] DayInWeek = new bool[6];
        float[,] WorkHours=new float[6,2];
        bool DaysOOf;
        string Recommendations;
         public override string ToString()
        {
            return name + ' ' +LastName+" id"+id+" phone number "+ PhoneNum+" address "+Address;
        }
    }
}
