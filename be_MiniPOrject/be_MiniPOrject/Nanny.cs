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
        private bool yorN_HourlyRate;//if he Agrees to hour rate
        private float payHour;
        private int payMonth;
        private bool[] dayInWeek = new bool[6];
        private float[,] workHours = new float[2, 6];
        private bool daysOOf;
        private string recommendations;
        private float HowMuchHourNanWork;
        public List<int> ListIdContract;//List that save all the Contract ID that the nanny hava

        public Nanny(int id, string lastName, string name, DateTime dateBirth, string phoneNum, string address, bool elevator, int floorInBulding, int exp, int maxChildren, int minAgeMonth, int maxAgeMonth, bool yorN_HourlyRate, float payHour, int payMonth, bool[] dayInWeek, float[,] workHours, bool daysOOf, string recommendations)
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
            this.yorN_HourlyRate = yorN_HourlyRate;
            this.payHour = payHour;
            this.payMonth = payMonth;
            this.dayInWeek = dayInWeek;
            this.workHours = workHours;
            this.daysOOf = daysOOf;
            this.recommendations = recommendations;
            HowMuchHourNanWork=0;
            for(int i=0;i>6;++i)
                HowMuchHourNanWork+=WorkHours[2][i]-WorkHours[1][i];
        }

        public int Id { get => id; }
        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName[0] > 'Z' || lastName[0] < 'A')
                    throw new Exception("this input is not make sense");
                for (int i = 1; i < lastName.Length; i++)
                    if (lastName[i] > 'z' || lastName[i] < 'a')
                        throw new Exception("this input is not make sense");
                lastName = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (name[0] > 'Z' || name[0] < 'A')
                    throw new Exception("this input is not make sense");
                for (int i = 1; i < name.Length; i++)
                    if (name[i] > 'z' || name[i] < 'a')
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
                for (int i = 0; i < phoneNum.Length; i++)
                    if (phoneNum[i] > '9' || phoneNum[i] < '0')
                        throw new Exception("this input is not make sense");
                phoneNum = value;
            }
        }
        public string Address
        {
            get => address;
            set
            {
                for (int i = 0; i < address.Length; i++)
                    if (address[i] > 'z' || address[i] < 'a' && address[i] != ',')
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
                if (exp > (DateTime.Now.Year - dateBirth.Year - 18))
                    throw new Exception("this input is not make sense");
                exp = value;
            }
        }
        public int MaxChildren
        {
            get => maxChildren;
            set
            {
                if (maxChildren < 1)
                    throw new Exception("this input is not make sense");
                maxChildren = value;
            }
        }
        public int MinAgeMonth
        {
            get => minAgeMonth;
            set
            {

                if (minAgeMonth < 3)
                    throw new Exception("this input is not make sense");
                minAgeMonth = value;
            }
        }
        public int MaxAgeMonth
        {
            get => maxAgeMonth;
            set
            {
                if (maxAgeMonth < minAgeMonth)
                    throw new Exception("this input is not make sense");
                maxAgeMonth = value;
            }
        }
        public bool YorN_HourlyRate { get => yorN_HourlyRate; set => yorN_HourlyRate = value; }
        public float PayHour { get => payHour; set => payHour = value; }
        public int PayMonth
        {
            get => payMonth;
            set
            {
                if (PayMonth < 0)
                    throw new Exception("the input not make sense");
                payMonth = value;
            }
        }
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        public float[,] WorkHours
        {
            get => workHours;
            set
            {
                if (workHours.GetLength(0) != 6)
                    throw new Exception("the number of days not correct");
                workHours = value;
            }
        }
        public bool DaysOOf { get => daysOOf; set => daysOOf = value; }
        public string Recommendations { get => recommendations; set => recommendations = value; }
        public float HowMuchHourNanWork1{ get => HowMuchHourNanWork1; set => HowMuchHourNanWork1 = value; };
        public override string ToString()
        {
            return name + ' ' + LastName + " id" + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
