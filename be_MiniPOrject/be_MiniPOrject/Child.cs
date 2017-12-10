using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_MiniPOrject
{
    public class Child
    {
        private int id;
        private int motherId;
        private string name;
        private DateTime dateBirth;
        private bool specialNeeds;
        private string whatHeNeed;

        public int Id { get => id; set => id = value; }
        public int MotherId { get => motherId; set => motherId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        public string WhatHeNeed { get => whatHeNeed; set => whatHeNeed = value; }

        public override string ToString()
        {
            return name + " id" + id + " mother id " + MotherId + " Date of birth " + DateBirth;
        }
    }
}
