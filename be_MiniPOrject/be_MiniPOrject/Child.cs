using System;
using System.Collections.Generic;
using System.Linq;
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
            this.id = id;
            this.motherId = motherId;
            this.name = name;
            this.dateBirth = dateBirth;
            this.specialNeeds = specialNeeds;
            this.whatHeNeed = whatHeNeed;
        }

        public string Id
        {
            get => id;
            set
            {
                for (int i = 0; i < value.Length && (value.Length == 9); i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                        throw new Exception("this id not make sense");
                }
                id = value;
            }
        }
        public string MotherId
        {
            get => motherId;
            set
            {
                for (int i = 0; i < value.Length && (value.Length == 9); i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                        throw new Exception("this id not make sense");
                }
                motherId = value;
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
        public DateTime DateBirth
        {
            get => dateBirth;
            set
            {
                if (value < DateTime.Now)
                    dateBirth = value;
                else
                    throw new Exception("this time is not on past");
            }
        }
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        public string WhatHeNeed { get => whatHeNeed; set => whatHeNeed = value; }

        public override string ToString()
        {
            return name + " id " + id + " mother id " + MotherId + " Date of birth " + DateBirth.Year + '/' + DateBirth.Month + '/' + DateBirth.Day;
        }
    }
}
