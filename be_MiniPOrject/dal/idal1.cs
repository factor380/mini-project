using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using be_MiniPOrject;

namespace dal
{
    public interface idal
    {
        void AddNanny();
        void DelNanny();
        void updatingNanny();

        void AddMother();
        void DelMother();
        void updatingMother();
        void AddChild();
        void DelChild();
        void updatingChild();
        void AddContract();
        void DelContract();
        void updatingContract();
        List<Nanny> AcceptanceNanny();
        List<Mother> AcceptanceMother();
        List<Child> AcceptanceChild();
        List<Contract> AcceptanceContract();




    }
}

