using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public interface IBL
    {
        void AddNanny(Nanny n);
        void DelNanny(Nanny n);
        void UpdatingNanny(Nanny n);
        Nanny GetNanny(int id);

        void AddMother(Mother m);
        void DelMother(Mother m);
        void UpdatingMother(Mother m);
        Mother GetMother(int id);

        void AddChild(Child c);
        void DelChild(Child c);
        void UpdatingChild(Child c);
        Child GetChild(int id);

        void AddContract(Contract c);
        void DelContract(Contract c);
        void UpdatingContract(Contract c);
        Contract GetContract(int Contract_number);

        List<Nanny> AcceptanceNanny();
        List<Mother> AcceptanceMother();
        List<Child> AcceptanceChild();
        List<Contract> AcceptanceContract();
    }
}
