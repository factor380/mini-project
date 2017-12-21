using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BE
{
    public class Nanny
    {
        private int id;
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
        private bool yorN_HourlyRate;
        private float payHour;
        private int payMonth;
        private bool[] dayInWeek = new bool[6];
        private float[,] workHours = new float[6, 2];
        private bool daysOOf;
        private string recommendations;

        public int Id { get => id; set => id = value; }
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
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
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
        public int FloorInBulding
        {
            get => floorInBulding;
            set
            {
                if (floorInBulding < 0)
                    throw new Exception("this input is not make sense");
                floorInBulding = value;
            }
        }
        public int Exp
        {
            get => exp;
            set
            {
                if (exp < 0)
                    throw new Exception("this input is not make sense");
                exp = value;
            }
        }
        public int MaxChildren
        {
            get => maxChildren;
            set
            {
                if (maxChildren < 0)
                    throw new Exception("this input is not make sense");
                maxChildren = value;
            }
        }
        public int MinAgeMonth
        {
            get => minAgeMonth;
            set
            {

                if (minAgeMonth < 0)
                    throw new Exception("this input is not make sense");
                minAgeMonth = value;
            }
        }
        public int MaxAgeMonth
        {
            get => maxAgeMonth;
            set
            {
                if (maxAgeMonth < 0 || maxAgeMonth < minAgeMonth)
                    throw new Exception("this input is not make sense");
                maxAgeMonth = value;
            }
        }
        public bool YorN_HourlyRate { get => yorN_HourlyRate; set => yorN_HourlyRate = value; }
        public float PayHour { get => payHour; set => payHour = value; }
        public int PayMonth { get => payMonth; set => payMonth = value; }
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        public float[,] WorkHours { get => workHours; set => workHours = value; }
        public bool DaysOOf { get => daysOOf; set => daysOOf = value; }
        public string Recommendations
        {
            get => recommendations;
            set
            {
                for (int i = 1; i < recommendations.Length; i++)
                    if (recommendations[i] > 'z' || recommendations[i] < 'a' && recommendations[i] != ' ')
                        throw new Exception("this input is not make sense");
                recommendations = value;
            }
        }

        public override string ToString()
        {
            return name + ' ' + LastName + " id" + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
