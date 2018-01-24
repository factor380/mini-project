using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nanny
    {
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
        private bool perHour;//if he Agrees to hour rate
        private float payHour;
        private int payMonth;
        private bool[] dayInWeek = new bool[6];
        private TimeSpan[][] workHours = new TimeSpan[6][];
        private bool daysOOf;//if false the holidey Ministry of Education if true in tamat
        private string recommendations;
        private TimeSpan HowMuchHourNanWork;
        public List<int> ListIdContract = new List<int>();//List that save all the Contract ID that the nanny hava

        public Nanny()
        {
            for (int i = 0; i < 6; i++)
            {
                workHours[i] = new TimeSpan[2];
            }
        }
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
        public string Data { get => name + ' ' + lastName + " id: " + id; }
        public string TimeAndDays
        {
            get
            {
                string days = "";
                DateTime now = DateTime.Today;
                now = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 21);
                for (int i = 0; i < 6; i++, now = now.AddDays(1))
                    if (DayInWeek[i])
                        days += now.ToString("dddd")+ " : " + " work hours: " + WorkHours[i][0].ToString() + " - " + WorkHours[i][1].ToString() + " | ";
                return days;
            }
        }
        public string Id
        {
            get => id;
            set
            {
                if(IDCheck(value))
                id = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] < '9' || value[i] > '0')
                        throw new Exception("the last neme coldnt contain number");
                lastName = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] < '9' || value[i] > '0')
                        throw new Exception("the neme coldnt contain number");
                name = value;
            }
        }
        public DateTime DateBirth
        {
            get => dateBirth;
            set
            {
                if (value < DateTime.Now)
                    dateBirth = value;
                else
                    throw new Exception("this time is not in the past");
            }
        }
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
        public string Address
        {
            get => address;
            set
            {
                address = value;
            }
        }
        public bool Elevator { get => elevator; set => elevator = value; }
        public int FloorInBulding { get => floorInBulding; set => floorInBulding = value; }
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
        public bool PerHour { get => perHour; set => perHour = value; }
        public float PayHour { get => payHour; set => payHour = value; }
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
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
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
        public bool DaysOOf { get => daysOOf; set => daysOOf = value; }
        public string Recommendations { get => recommendations; set => recommendations = value; }
        public TimeSpan HowMuchHourNanWork1 { get => HowMuchHourNanWork; set => HowMuchHourNanWork = value; }
        public override string ToString()
        {
            return name + ' ' + LastName + " id: " + id + " phone number: " + PhoneNum + " address: " + Address;
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