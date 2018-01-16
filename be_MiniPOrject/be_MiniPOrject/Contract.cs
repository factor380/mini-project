using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        static int ContractNum = 1;
        private int Contract_Num;
        private readonly int nannyId;
        private readonly int motherId;
        private readonly int childId;
        private readonly bool met;//if the nanny and the children met
        private bool activeContract;
        private float payHours;
        private float payMonth;
        private bool HorM;//the Pay per month or hour 
        private DateTime startDate;
        private DateTime endDate;
        public  Contract()
        {
        }
        public Contract(int contract_Num, int nannyId, int motherId, int childId, bool met, bool activeContract, float payHours, int payMonth, bool horM, DateTime startDate, DateTime endDate)//לשים לב שצריך לשנות את זה שיכנס לבד ב dal
        {
            Contract_Num = contract_Num;
            if (nannyId >= 100000000 && nannyId <= 999999999)
                this.nannyId = nannyId;
            else
                throw new Exception("this input not make sense");
            if (nannyId >= 100000000 && nannyId <= 999999999)
                this.childId = childId;
            else
                throw new Exception("this input not make sense");
            if (nannyId >= 100000000 && nannyId <= 999999999)
                this.motherId = motherId;
            else
                throw new Exception("this input not make sense");
            this.met = met;
            this.activeContract = activeContract;
            this.payHours = payHours;
            this.payMonth = payMonth;
            this.HorM = HorM;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public static int ContractNum1 { get => ContractNum; set => ContractNum = value; }
        public int NannyId { get => nannyId; }
        public int ChildId { get => childId; }
        public bool Met { get => met; }
        public bool ActiveContract { get => activeContract; set => activeContract = value; }
        public float PayHours { get => payHours; set => payHours = value; }
        public float PayMonth { get => payMonth; set => payMonth = value; }
        public bool HorM1 { get => HorM; set => HorM = value; }
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (DateTime.Compare(startDate, DateTime.Now) <= 0)
                    throw new Exception("the time is not in the future");
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get => endDate;
            set
            {
                if (startDate > endDate)
                    throw new Exception("this time not make sense");
                endDate = value;
            }
        }
        public int Contract_Num1
        {
            get => Contract_Num;
            set
            {
                if (Contract_Num < 10000000 || Contract_Num > 99999999)
                    throw new Exception("this input not make sense");
                Contract_Num = value;
            }
        }
        public int MotherId { get => motherId; }

        public override string ToString()
        {
            return "contract number " + ContractNum + " Nanny id" + NannyId + " Child Id " + ChildId;
        }
    }
}
