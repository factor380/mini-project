using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Child
    {
        private readonly string id;
        private readonly string motherId;
        private string name;
        private readonly DateTime dateBirth;
        private bool specialNeeds;
        private string whatHeNeed;
        public List<int> ListIdContract = new List<int>();

        public Child()
        { }
        public Child(string id, string motherId, string name, DateTime dateBirth, bool specialNeeds, string whatHeNeed)
        {
            for (int i = 0; i < id.Length && (id.Length == 9); i++)
            {
                if (id[i] < '0' || id[i] > '9')
                throw new Exception("this id not make sense");
            }  
                this.id = id;
            for (int i = 0; i < motherId.Length && (motherId.Length == 9); i++)
            {
                if (motherId[i] < '0' || motherId[i] > '9')
                    throw new Exception("this id not make sense");
            }
            this.motherId = motherId;
            this.name = name;
            if (dateBirth < DateTime.Now)
                this.dateBirth = dateBirth;
            else
                throw new Exception("this time is not on past");
            this.specialNeeds = specialNeeds;
            this.whatHeNeed = whatHeNeed;
        }

        public string Id { get => id; }
        public string MotherId { get => motherId; }
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
        public DateTime DateBirth { get => dateBirth; }
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        public string WhatHeNeed { get => whatHeNeed; set => whatHeNeed = value; }

        public override string ToString()
        {
            return name + " id " + id + " mother id " + MotherId + " Date of birth " + DateBirth.Year + '/' + DateBirth.Month + '/' + DateBirth.Day ;
        }
    }
}
