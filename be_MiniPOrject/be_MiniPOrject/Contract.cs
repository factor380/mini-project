using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    public class Contract
    {
        #region Fields
        [XmlIgnore]
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
        #endregion
        #region Constractors
        /// <summary>
        /// defult constractor
        /// </summary>
        public Contract()
        {
        }
        /// <summary>
        /// regular constractor
        /// </summary>
        /// <param name="contract_Num">contract_Num that you get</param>
        /// <param name="nannyId">nannyId that you get</param>
        /// <param name="motherId">motherId that you get</param>
        /// <param name="childId">childId that you get</param>
        /// <param name="met">met that you get</param>
        /// <param name="activeContract">activeContract that you get</param>
        /// <param name="payHours">payHours that you get</param>
        /// <param name="payMonth">payMonth that you get</param>
        /// <param name="horM">horM that you get</param>
        /// <param name="startDate">startDate that you get</param>
        /// <param name="endDate">endDate that you get</param>
        public Contract(int contract_Num, string nannyId, string motherId, string childId, bool met, bool activeContract, float payHours, int payMonth, bool horM, DateTime startDate, DateTime endDate)
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
        #endregion
        #region properties
        /// <summary>
        /// property to the check box to how is seen on the check box
        /// </summary>
        [XmlIgnore]
        public string Data { get => "contract number: " + Contract_Num; }
        /// <summary>
        /// property to the run number
        /// </summary>
        [XmlIgnore]
        public static int ContractNum1 { get => ContractNum; set => ContractNum = value; }
        /// <summary>
        /// property to the nannyId
        /// </summary>
        public string NannyId
        {
            get => nannyId;
            set
            {
                if (IDCheck(value))
                    nannyId = value;
            }
        }
        /// <summary>
        /// property to the childId
        /// </summary>
        public string ChildId
        {
            get => childId;
            set
            {
                if (IDCheck(value))
                    childId = value;
            }
        }
        /// <summary>
        /// property to the met
        /// </summary>
        public bool Met { get => met; set => met = value; }
        /// <summary>
        /// property to the activeContract
        /// </summary>
        public bool ActiveContract { get => activeContract; set => activeContract = value; }
        /// <summary>
        /// property to the payHours
        /// </summary>
        public float PayHours { get => payHours; set => payHours = value; }
        /// <summary>
        /// property to the payMonth
        /// </summary>
        public float PayMonth { get => payMonth; set => payMonth = value; }
        /// <summary>
        /// property to the HorM
        /// </summary>
        public bool HorM1 { get => HorM; set => HorM = value; }
        /// <summary>
        /// property to the startDate
        /// </summary>
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                startDate = value;
            }
        }
        /// <summary>
        /// property to the endDate
        /// </summary>
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
        /// <summary>
        /// property to the Contract_Num
        /// </summary>
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
        /// <summary>
        /// property to the motherId
        /// </summary>
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
        #endregion
        #region to string and static func
        /// <summary>
        /// to string to the contract
        /// </summary>
        /// <returns>return string that preven contract</returns>
        public override string ToString()
        {
            return "contract number " + Contract_Num + " Nanny id " + NannyId + " Child Id " + ChildId;
        }
        /// <summary>
        /// check if the id is good According to the Interior Ministry
        /// </summary>
        /// <param name="strID">the id to check</param>
        /// <returns>returns if the id good or not</returns>
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
        #endregion
    }
}
