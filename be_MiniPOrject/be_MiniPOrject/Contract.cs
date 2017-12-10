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
        private int Contract_Num;
        private int nannyId;
        private int childId;
        private bool met;
        private bool activeContract;
        private float payHours;
        private int payMonth;
        private bool horM;//the Pay per month or hour 
        private DateTime startDate;
        private DateTime endDate;

        public static int ContractNum1 { get => ContractNum; set => ContractNum = value; }
        public int NannyId { get => nannyId; set => nannyId = value; }
        public int ChildId { get => childId; set => childId = value; }
        public bool Met { get => met; set => met = value; }
        public bool ActiveContract { get => activeContract; set => activeContract = value; }
        public float PayHours { get => payHours; set => payHours = value; }
        public int PayMonth { get => payMonth; set => payMonth = value; }
        public bool HorM { get => horM; set => horM = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int Contract_Num1 { get => Contract_Num; set => Contract_Num = value; }

        public override string ToString()
        {
            return "contract number " + ContractNum + " Nanny id" + NannyId + " Child Id " + ChildId;
        }
    }
}
