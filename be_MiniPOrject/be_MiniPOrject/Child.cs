using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
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
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        public string WhatHeNeed
        {
            get => whatHeNeed;
            set
            {
                for (int i = 0; i < whatHeNeed.Length; i++)
                    if (whatHeNeed[i] > 'z' || whatHeNeed[i] < 'a')
                        throw new Exception("this input is not make sense");
                whatHeNeed = value;
            }
        }

        public override string ToString()
        {
            return name + " id" + id + " mother id " + MotherId + " Date of birth " + DateBirth;
        }
    }
}
