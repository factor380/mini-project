using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother
    {
        private readonly string id;
        private string lastName;
        private string name;
        private string phoneNum;
        private string address;
        private string addressAround;
        private bool[] dayInWeek = new bool[6];
        private TimeSpan[][] whenNeededWeek = new TimeSpan[6][];
        private string remarks;
        public List<string> ListIdChild = new List<string>();

        public Mother(string id, string lastName, string name, string phoneNum, string address, string addressAround, bool[] dayInWeek, TimeSpan[][] whenNeededWeek, string remarks)
        {
            for (int i = 0; (i < id.Length && id.Length == 9); i++)
            {
                if (id[i] < '0' && id[i] > '9')
                    throw new Exception("this input not make sense");
            }
            this.id = id;
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

        public string Id { get => id; }
        public string LastName
        {
            get => lastName;
            set
            {
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
                for (int i = 1; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a')
                        throw new Exception("this input is not make sense");
                name = value;
            }
        }
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
                    if (value[i] > 'z' || value[i] < ' ')
                        throw new Exception("this input is not make sense");
                address = value;
            }
        }
        public string AddressAround
        {
            get => addressAround;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < ' ')
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
                if (value.GetLength(0) != 6)
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
