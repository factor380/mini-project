using System;
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
        void AddMother();
        void DelMother();
        void UpdatingMother();
        void AddChild();
        void DelChild();
        void UpdatingChild();
        void AddContract();
        void DelContract();
        void UpdatingContract();
        List<Nanny> AcceptanceNanny();
        List<Mother> AcceptanceMother();
        List<Child> AcceptanceChild();
        List<Contract> AcceptanceContract();
    }
}

