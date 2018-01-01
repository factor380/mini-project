using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Child
    {
        private readonly int id;
        private readonly int motherId;
        private string name;
        private readonly DateTime dateBirth;
        private bool specialNeeds;
        private string whatHeNeed;
        public List<int> ListIdContract;

        public Child()
        { }
        public Child(int id, int motherId, string name, DateTime dateBirth, bool specialNeeds, string whatHeNeed)
        {
            if (id >= 100000000 && id <= 999999999)
                this.id = id;
            else
                throw new Exception("this input not make sense");
            if (motherId >= 100000000 && motherId <= 999999999)
                this.motherId = motherId;
            else
                throw new Exception("this input not make sense");
            this.name = name;
            if (dateBirth < DateTime.Now)
                this.dateBirth = dateBirth;
            else
                throw new Exception("this time is not on past");
            this.specialNeeds = specialNeeds;
            this.whatHeNeed = whatHeNeed;
        }

        public int Id { get => id; }
        public int MotherId { get => motherId; }
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
        public DateTime DateBirth { get => dateBirth; }
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        public string WhatHeNeed { get => whatHeNeed; set => whatHeNeed = value; }

        public override string ToString()
        {
            return name + " id" + id + " mother id " + MotherId + " Date of birth " + DateBirth;
        }
    }
}
