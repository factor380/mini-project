using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother
    {
        private int id;
        private string lastName;
        private string name;
        private string phoneNum;
        private string address;
        private string addressAround;
        private bool[] dayInWeek = new bool[6];
        private float[,] whenNeededWeek = new float[6, 2];//למה הגדרת את זה כלא שלם זה צריך ליהות ימים על זמן
        private string remarks;

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
        public float[,] WhenNeededWeek { get => whenNeededWeek; set => whenNeededWeek = value; }//לבדוק שגיאות
        public string Remarks
        {
            get => remarks;
            set
            {
                for (int i = 0; i < remarks.Length; i++)
                    if ((remarks[i] > 'z' || remarks[i] < 'a'))
                        throw new Exception("this input is not make sense");
                remarks = value;
            }
        }
        public override string ToString()
        {
            return name + ' ' + LastName + " id" + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
