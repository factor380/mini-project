using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    public class Nanny
    {
        #region Fields
        private string id;
        private string lastName;
        private string name;
        private DateTime dateBirth;
        private string phoneNum;
        private string address;
        private bool elevator;
        private int floorInBulding;
        private int exp;
        private int maxChildren;
        private int minAgeMonth;
        private int maxAgeMonth;
        private bool perHour;//if he Agrees to hour rate then is true
        private float payHour;
        private int payMonth;
        private bool[] dayInWeek = new bool[6];
        private TimeSpan[][] workHours = new TimeSpan[6][];
        private bool daysOOf;//if false the holidey Ministry of Education if true in tamat
        private string recommendations;
        [XmlIgnore]
        private TimeSpan HowMuchHourNanWork;
        public List<int> ListIdContract = new List<int>();//List that save all the Contract ID that the nanny have
        #endregion
        #region constractors
        /// <summary>
        /// defult constractor
        /// </summary>
        public Nanny()
        {
            for (int i = 0; i < 6; i++)
            {
                workHours[i] = new TimeSpan[2];
            }
        }
        /// <summary>
        /// regular constractor
        /// </summary>
        /// <param name="id">id that you get</param>
        /// <param name="lastName">lastName that you get</param>
        /// <param name="name">name that you get</param>
        /// <param name="dateBirth">dateBirth that you get</param>
        /// <param name="phoneNum">phoneNum that you get</param>
        /// <param name="address">address that you get</param>
        /// <param name="elevator">elevator that you get</param>
        /// <param name="floorInBulding">floorInBulding that you get</param>
        /// <param name="exp">exp that you get</param>
        /// <param name="maxChildren">maxChildren that you get</param>
        /// <param name="minAgeMonth">minAgeMonth that you get</param>
        /// <param name="maxAgeMonth">maxAgeMonth that you get</param>
        /// <param name="perHour">perHour that you get</param>
        /// <param name="payHour">payHour that you get</param>
        /// <param name="payMonth">payMonth that you get</param>
        /// <param name="dayInWeek">dayInWeek that you get</param>
        /// <param name="workHours">workHours that you get</param>
        /// <param name="daysOOf">daysOOf that you get</param>
        /// <param name="recommendations">recommendations that you get</param>
        public Nanny(string id, string lastName, string name, DateTime dateBirth, string phoneNum, string address, bool elevator, int floorInBulding, int exp, int maxChildren, int minAgeMonth, int maxAgeMonth, bool perHour, float payHour, int payMonth, bool[] dayInWeek, TimeSpan[][] workHours, bool daysOOf, string recommendations)
        {
            if (IDCheck(id))
                this.id = id;
            else
                throw new Exception("this id not exist");
            this.lastName = lastName;
            this.name = name;
            this.dateBirth = dateBirth;
            this.phoneNum = phoneNum;
            this.address = address;
            this.elevator = elevator;
            this.floorInBulding = floorInBulding;
            this.exp = exp;
            this.maxChildren = maxChildren;
            this.minAgeMonth = minAgeMonth;
            this.maxAgeMonth = maxAgeMonth;
            this.perHour = perHour;
            this.payHour = payHour;
            this.payMonth = payMonth;
            this.dayInWeek = dayInWeek;
            this.workHours = workHours;
            this.daysOOf = daysOOf;
            this.recommendations = recommendations;
            HowMuchHourNanWork = TimeSpan.Parse("00:00");
            for (int i = 0; i < 6; ++i)
            {
                if (DayInWeek[i])
                    HowMuchHourNanWork += WorkHours[i][1] - WorkHours[i][0];
            }
        }
        #endregion
        #region properties
        /// <summary>
        /// property to the check box to how is seen on the check box
        /// </summary>
        [XmlIgnore]
        public string Data { get => name + ' ' + lastName + " id: " + id; }
        /// <summary>
        /// property to the print on the WPF to print the hour work on the day
        /// </summary>
        [XmlIgnore]
        public string TimeAndDays
        {
            get
            {
                string days = "";
                DateTime now = DateTime.Today;
                now = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 21);//start on sunday to run on all the week
                for (int i = 0; i < 6; i++, now = now.AddDays(1))
                    if (DayInWeek[i])
                        days += now.ToString("dddd") + " : " + " work hours: " + WorkHours[i][0].ToString() + " - " + WorkHours[i][1].ToString() + " | ";
                return days;
            }
        }
        /// <summary>
        /// property to prevent the work on day on the xml file
        /// </summary>
        public string WorkHoursxml
        {
            get
            {
                if (WorkHours == null)
                    return null;
                string result = "";
                if (WorkHours != null)
                {
                    int sizeA = WorkHours.GetLength(0);
                    result += "" + sizeA + "," + 2;//the size of the metrix
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < 2; j++)
                            result += "," + WorkHours[i][j];
                }
                return result;//return string that insert to the xml file
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    int sizeA = int.Parse(values[0]);
                    int sizeB = int.Parse(values[1]);
                    WorkHours = new TimeSpan[sizeA][];
                    for (int i = 0; i < 6; i++)
                    {
                        WorkHours[i] = new TimeSpan[sizeB];
                    }
                    int index = 2;
                    for (int i = 0; i < sizeA; i++)
                        for (int j = 0; j < sizeB; j++)
                            WorkHours[i][j] = TimeSpan.Parse(values[index++]);
                }
            }
        }
        /// <summary>
        /// property to prevent if she work on specific day on week, on the xml file
        /// </summary>
        public string DayInWeekxml
        {
            get
            {
                if (DayInWeek == null)
                    return null;
                string result = "";
                if (DayInWeek != null)
                {
                    int sizeA = DayInWeek.GetLength(0);
                    result += "" + sizeA;
                    for (int i = 0; i < sizeA; i++)
                        result += "," + DayInWeek[i].ToString();
                }
                return result;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    int sizeA = int.Parse(values[0]);
                    DayInWeek = new bool[sizeA];
                    int index = 1;
                    for (int i = 0; i < sizeA; i++)
                        DayInWeek[i] = bool.Parse(values[index++]);
                }
            }
        }
        /// <summary>
        /// property to the id
        /// </summary>
        public string Id
        {
            get => id;
            set
            {
                if (IDCheck(value))
                    id = value;
            }
        }
        /// <summary>
        /// property to the last name
        /// </summary>
        public string LastName
        {
            get => lastName;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] > 0 && value[i] < 9)
                        throw new Exception("the last name couldnt contain numbers");
                }
                lastName = value;
            }
        }
        /// <summary>
        /// property to the name
        /// </summary>
        public string Name
        {
            get => name;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] > 0 && value[i] < 9)
                        throw new Exception("the name couldnt contain numbers");
                }
                name = value;
            }
        }
        /// <summary>
        /// property to the dateBirth
        /// </summary>
        public DateTime DateBirth
        {
            get => dateBirth.Date;
            set
            {
                if (value < DateTime.Now)
                    dateBirth = value.Date;
                else
                    throw new Exception("this time is not in the past");
            }
        }
        /// <summary>
        /// property to the phoneNum
        /// </summary>
        public string PhoneNum
        {
            get => phoneNum;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] > '9' || value[i] < '0')
                        throw new Exception("the number must contain only numbers");
                phoneNum = value;
            }
        }
        /// <summary>
        /// property to the address
        /// </summary>
        public string Address
        {
            get => address;
            set
            {
                address = value;
            }
        }
        /// <summary>
        /// property to the elevator
        /// </summary>
        public bool Elevator { get => elevator; set => elevator = value; }
        /// <summary>
        /// property to the floorInBulding
        /// </summary>
        public int FloorInBulding { get => floorInBulding; set => floorInBulding = value; }
        /// <summary>
        /// property to the exp
        /// </summary>
        public int Exp
        {
            get => exp;
            set
            {
                if (value <= 0)
                    throw new Exception("the exp must be large the 0");
                exp = value;
            }
        }
        /// <summary>
        /// property to the maxChildren
        /// </summary>
        public int MaxChildren
        {
            get => maxChildren;
            set
            {
                if (value < 1)
                    throw new Exception("the max children must be large then 0");
                maxChildren = value;
            }
        }
        /// <summary>
        /// property to the minChildren
        /// </summary>
        public int MinAgeMonth
        {
            get => minAgeMonth;
            set
            {

                if (value < 3)
                    throw new Exception("the min age must be large then 3");
                minAgeMonth = value;
            }
        }
        /// <summary>
        /// property to the maxAgeMonth
        /// </summary>
        public int MaxAgeMonth
        {
            get => maxAgeMonth;
            set
            {
                if (value < minAgeMonth)
                    throw new Exception("the max age must be large then min age");
                maxAgeMonth = value;
            }
        }
        /// <summary>
        /// property to the perHour
        /// </summary>
        public bool PerHour { get => perHour; set => perHour = value; }
        /// <summary>
        /// property to the payHour
        /// </summary>
        public float PayHour { get => payHour; set => payHour = value; }
        /// <summary>
        /// property to the payMonth
        /// </summary>
        public int PayMonth
        {
            get => payMonth;
            set
            {
                if (value < 0)
                    throw new Exception("the pay month must be large then 0");
                payMonth = value;
            }
        }
        /// <summary>
        /// property to the dayInWeek
        /// </summary>
        [XmlIgnore]
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        /// <summary>
        /// property to the WorkHours
        /// </summary>
        [XmlIgnore]
        public TimeSpan[][] WorkHours
        {
            get => workHours;
            set
            {
                if (value.GetLength(0) != 6)
                    throw new Exception("the number of days not correct");
                workHours = value;
            }
        }
        /// <summary>
        /// property to the daysOOf
        /// </summary>
        public bool DaysOOf { get => daysOOf; set => daysOOf = value; }
        /// <summary>
        /// property to the recommendations
        /// </summary>
        public string Recommendations { get => recommendations; set => recommendations = value; }
        /// <summary>
        /// property to how much she work on one week 
        /// </summary>
        [XmlIgnore]
        public TimeSpan HowMuchHourNanWork1 { get => HowMuchHourNanWork; set => HowMuchHourNanWork = value; }
        #endregion
        #region tostring and sastic func
        /// <summary>
        /// to string to the nanny
        /// </summary>
        /// <returns> return the string to prevent nanny</returns>
        public override string ToString()
        {
            return name + ' ' + LastName + " id: " + id + " phone number: " + PhoneNum + " address: " + Address;
        }
        /// <summary>
        /// check if the id is good of ministry of the interior
        /// </summary>
        /// <param name="strID">the id to check</param>
        /// <returns>return if the id good or not</returns>
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