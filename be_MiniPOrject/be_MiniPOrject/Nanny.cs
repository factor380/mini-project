using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nanny
    {
        private readonly int id;
        private string lastName;
        private string name;
        private readonly DateTime dateBirth;
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
        public Nanny(int id, string lastName, string name, DateTime dateBirth, string phoneNum, string address, bool elevator, int floorInBulding, int exp, int maxChildren, int minAgeMonth, int maxAgeMonth, bool perHour, float payHour, int payMonth, bool[] dayInWeek, TimeSpan[][] workHours, bool daysOOf, string recommendations)
        {
            if (id >= 100000000 && id <= 999999999)
                this.id = id;
            else
                throw new Exception("this input not make sense");
            this.lastName = lastName;
            this.name = name;
            if (dateBirth < DateTime.Now)
                this.dateBirth = dateBirth;
            else
                throw new Exception("this time is not in the past");
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

        public int Id { get => id; }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value[0] > 'Z' || value[0] < 'A')
                    throw new Exception("this input is not make sense");
                for (int i = 1; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a')
                        throw new Exception("this input is not make sense");
                lastName = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (value[0] > 'Z' || value[0] < 'A')
                    throw new Exception("this input is not make sense");
                for (int i = 1; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a')
                        throw new Exception("this input is not make sense");
                name = value;
            }
        }
        public DateTime DateBirth { get => dateBirth; }
        public string PhoneNum
        {
            get => phoneNum;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] > '9' || value[i] < '0')
                        throw new Exception("this input is not make sense");
                phoneNum = value;
            }
        }
        public string Address
        {
            get => address;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a' && value[i] != ',' && value[i] != ' ') 
                        throw new Exception("this input is not make sense");
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
                if (value > (DateTime.Now.Year - dateBirth.Year - 18))
                    throw new Exception("this input is not make sense");
                exp = value;
            }
        }
        public int MaxChildren
        {
            get => maxChildren;
            set
            {
                if (value < 1)
                    throw new Exception("this input is not make sense");
                maxChildren = value;
            }
        }
        public int MinAgeMonth
        {
            get => minAgeMonth;
            set
            {

                if (value < 3)
                    throw new Exception("this input is not make sense");
                minAgeMonth = value;
            }
        }
        public int MaxAgeMonth
        {
            get => maxAgeMonth;
            set
            {
                if (value < minAgeMonth)
                    throw new Exception("this input is not make sense");
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
                    throw new Exception("the input not make sense");
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
        public TimeSpan HowMuchHourNanWork1{ get => HowMuchHourNanWork; set => HowMuchHourNanWork = value; }
        public override string ToString()
        {
            return name + ' ' + LastName + " id " + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}