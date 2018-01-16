using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother
    {
        private readonly int id;
        private string lastName;
        private string name;
        private string phoneNum;
        private string address;
        private string addressAround;
        private bool[] dayInWeek = new bool[6];
        private TimeSpan[][] whenNeededWeek = new TimeSpan[6][];
        private string remarks;
        public List<int> ListIdChild = new List<int>();

        public Mother(int id, string lastName, string name, string phoneNum, string address, string addressAround, bool[] dayInWeek, TimeSpan[][] whenNeededWeek, string remarks)
        {
            if (id >= 100000000 && id <= 999999999)
                this.id = id;
            else
                throw new Exception("this input not make sense");
            this.lastName = lastName;
            this.name = name;
            this.phoneNum = phoneNum;
            this.address = address;
            this.addressAround = addressAround;
            this.dayInWeek = dayInWeek;
            this.whenNeededWeek = whenNeededWeek;
            this.remarks = remarks;
        }

        public Mother() { }

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
                    if ((address[i] > 'z' || address[i] < 'a') && address[i] != ',')
                        throw new Exception("this input is not make sense");
                address = value;
            }
        }
        public string AddressAround
        {
            get => addressAround;
            set
            {
                for (int i = 0; i < addressAround.Length; i++)
                    if ((addressAround[i] > 'z' || addressAround[i] < 'a') && addressAround[i] != ',')
                        throw new Exception("this input is not make sense");
                addressAround = value;
            }
        }
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        public TimeSpan[][] WhenNeededWeek
        {
            get => whenNeededWeek;
            set
            {
                if (whenNeededWeek.GetLength(0) != 6)
                    throw new Exception("the number of days not correct");
                whenNeededWeek = value;
            }
        }
        public string Remarks { get => remarks; set => remarks = value; }
        public override string ToString()
        {
            return name + ' ' + LastName + " id " + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
