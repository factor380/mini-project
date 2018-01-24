using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother
    {
        private string id;
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
            if (IDCheck(id))
                this.id = id;
            else
                throw new Exception("this id not exist");
            this.lastName = lastName;
            this.name = name;
            this.phoneNum = phoneNum;
            this.address = address;
            this.addressAround = addressAround;
            this.dayInWeek = dayInWeek;
            this.whenNeededWeek = whenNeededWeek;
            this.remarks = remarks;
        }

        public Mother()
        {
            for (int i = 0; i < 6; i++)
            {
                whenNeededWeek[i] = new TimeSpan[2];
            }
        }

        public string Id
        {
            get => id;
            set
            {
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
                        throw new Exception("the last name coldnt contain numbers");
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
                        throw new Exception("the name coldnt contain numbers");
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
                        throw new Exception("the phone number must contain only numbers");
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
        public string AddressAround
        {
            get => addressAround;
            set
            {
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
