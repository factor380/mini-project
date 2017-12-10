using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_MiniPOrject
{
    class Contract
    {
        static int ContractNum;
        int NannyId;
        int ChildId;
        bool met;
        bool ActiveContract;
        float PayHours;
        int PayMonth;
        bool HorM;//the Pay per month or hour 
        DateTime StartDate;
        DateTime EndDate;

        public override string ToString()
        {
            return "contract number " + ContractNum + " Nanny id" + NannyId + " Child Id " + ChildId;
        }
    }
}
