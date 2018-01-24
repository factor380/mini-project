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
        private string nannyId;
        private string motherId;
        private string childId;
        private bool met;//if the nanny and the mother met
        private bool activeContract;
        private float payHours;
        private float payMonth;
        private bool HorM;//the Pay per month or hour 
        private DateTime startDate;
        private DateTime endDate;
        public  Contract()
        {
        }
        public Contract(int contract_Num, string nannyId, string motherId, string childId, bool met, bool activeContract, float payHours, int payMonth, bool horM, DateTime startDate, DateTime endDate)//לשים לב שצריך לשנות את זה שיכנס לבד ב dal
        {
            Contract_Num = contract_Num;
            this.nannyId = nannyId;
            this.childId = childId;
            this.motherId = motherId;
            this.met = met;
            this.activeContract = activeContract;
            this.payHours = payHours;
            this.payMonth = payMonth;
            this.HorM = horM;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        public string Data { get => "contract number: " + Contract_Num; }
        public static int ContractNum1 { get => ContractNum; set => ContractNum = value; }
        public string NannyId
        {
            get => nannyId;
            set
            {
                if (IDCheck(value))
                    nannyId = value;
            }
        }
        public string ChildId
        {
            get => childId;
            set
            {
                if (IDCheck(value))
                    childId = value;
            }
        }
        public bool Met { get => met; set => met = value; }
        public bool ActiveContract { get => activeContract; set => activeContract = value; }
        public float PayHours { get => payHours; set => payHours = value; }
        public float PayMonth { get => payMonth; set => payMonth = value; }
        public bool HorM1 { get => HorM; set => HorM = value; }
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (DateTime.Compare(value, DateTime.Today) < 0)
                    throw new Exception("the start time couldnt be in past");
                startDate = value;
            }
        }
        public DateTime EndDate
        {
            get => endDate;
            set
            {
                if (startDate >= value)
                    throw new Exception("the end date must be large then start date");
                endDate = value;
            }
        }
        public int Contract_Num1
        {
            get => Contract_Num;
            set
            {
                if (value < 0)
                    throw new Exception("the number could be only numbers positive");
                Contract_Num = value;
            }
        }
        public string MotherId
        {
            get => motherId;
            set
            {
                for (int i = 0; i < value.Length && (value.Length == 9); i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                        throw new Exception("this id not exist and not logic");
                }
                motherId = value;
            }
        }

        public override string ToString()
        {
            return "contract number " + Contract_Num + " Nanny id " + NannyId + " Child Id " + ChildId;
        }
        static bool IDCheck(String strID)
        {
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int count = 0;
            if (strID == null)
                return false;
            strID = strID.PadLeft(9, '0');
            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(strID.Substring(i, 1)) * id_12_digits[i];
                if (num > 9)
                    num = (num / 10) + (num % 10);
                count += num;
            }
            return (count % 10 == 0);
        }
    }
}
