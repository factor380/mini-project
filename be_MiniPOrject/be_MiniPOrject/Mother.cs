using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_MiniPOrject
{
    class Mother
    {
        private int id;
        private string lastName;
        private string name;
        private string phoneNum;
        private string address;
        private string addressAround;
        private bool[] dayInWeek = new bool[6];
        private float[,] whenNeededWeek = new float[6, 2];
        private string remarks;

        public int Id { get => id; set => id = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Name { get => name; set => name = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Address { get => address; set => address = value; }
        public string AddressAround { get => addressAround; set => addressAround = value; }
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        public float[,] WhenNeededWeek { get => whenNeededWeek; set => whenNeededWeek = value; }
        public string Remarks { get => remarks; set => remarks = value; }

        public override string ToString()
        {
            return name + ' ' + LastName + " id" + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
