using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace be_MiniPOrject
{
    class Child
    {
        int id;
        int MotherId;
        string name;
        DateTime DateBirth;
        bool SpecialNeeds;
        string WhatHeNeed;

        public override string ToString()
        {
            return name + " id" + id + " mother id " + MotherId + " Date of birth " + DateBirth;
        }
    }
}
