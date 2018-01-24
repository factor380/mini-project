using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Child
    {
        private string id;
        private string motherId;
        private string name;
        private DateTime dateBirth;
        private bool specialNeeds;
        private string whatHeNeed;
        public List<int> ListIdContract = new List<int>();

        public Child()
        { }
        public Child(string id, string motherId, string name, DateTime dateBirth, bool specialNeeds, string whatHeNeed)
        {
            if (IDCheck(id))
                this.id = id;
            else
                throw new Exception("this id not exist");
            if (IDCheck(motherId))
                this.motherId = motherId;
            else
                throw new Exception("this id not exist");
            this.name = name;
            this.dateBirth = dateBirth;
            this.specialNeeds = specialNeeds;
            this.whatHeNeed = whatHeNeed;
        }
        public string Data { get => name + " id: " + id; }
        public string Id
        {
            get => id;
            set
            {
                if (IDCheck(value))
                    id = value;
                else
                    throw new Exception("this id not exist");
            }
        }
        public string MotherId
        {
            get => motherId;
            set
            {
                if (IDCheck(value))
                    motherId = value;
                else
                    throw new Exception("this id not exist");
            }
        }

        public string Name
        {
            get => name;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] < '9' && value[i] > '0')
                        throw new Exception("the name couldnt contain numbers");
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
                    throw new Exception("this date birth must be on the past");
            }
        }
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        public string WhatHeNeed { get => whatHeNeed; set => whatHeNeed = value; }

        public override string ToString()
        {
            return name + " id: " + id + " mother id: " + MotherId + " Date of birth " + DateBirth.Year + '/' + DateBirth.Month + '/' + DateBirth.Day;
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
