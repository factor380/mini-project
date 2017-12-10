using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace be_MiniPOrject
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
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Address { get => address; set => address = value; }
        public bool Elevator { get => elevator; set => elevator = value; }
        public int FloorInBulding { get => floorInBulding; set => floorInBulding = value; }
        public int Exp { get => exp; set => exp = value; }
        public int MaxChildren { get => maxChildren; set => maxChildren = value; }
        public int MinAgeMonth { get => minAgeMonth; set => minAgeMonth = value; }
        public int MaxAgeMonth { get => maxAgeMonth; set => maxAgeMonth = value; }
        public bool YorN_HourlyRate { get => yorN_HourlyRate; set => yorN_HourlyRate = value; }
        public float PayHour { get => payHour; set => payHour = value; }
        public int PayMonth { get => payMonth; set => payMonth = value; }
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        public float[,] WorkHours { get => workHours; set => workHours = value; }
        public bool DaysOOf { get => daysOOf; set => daysOOf = value; }
        public string Recommendations { get => recommendations; set => recommendations = value; }

        public override string ToString()
        {
            return name + ' ' + LastName + " id" + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
