﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using be_MiniPOrject;
namespace DAL
{
    public interface IDAL
    {
        void AddNanny();
        void DelNanny();
        void UpdatingNanny();
        Nanny GetNanny();

        void AddMother();
        void DelMother();
        void UpdatingMother();
        Mother GetMother();

        void AddChild();
        void DelChild();
        void UpdatingChild();
        Child GetChild();

        void AddContract();
        void DelContract();
        void UpdatingContract();
        Contract GetContract();

        List<Nanny> AcceptanceNanny();
        List<Mother> AcceptanceMother();
        List<Child> AcceptanceChild();
        List<Contract> AcceptanceContract();
    }
}

