using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface IDAL
    {
        void AddNanny(Nanny n);
        void RemoveNanny(int id);
        void UpdateNanny(Nanny n);
        Nanny GetNanny(int id);

        void AddMother(Mother m);
        void RemoveMother(int id);
        void UpdateMother(Mother m);
        Mother GetMother(int id);

        void AddChild(Child c);
        void RemoveChild(int id);
        void UpdateChild(Child c);
        Child GetChild(int id);

        void AddContract(Contract c);
        void RemoveContract(int contract_Num);
        void UpdateContract(Contract c);
        Contract GetContract(int contract_Num);

        List<Nanny> AcceptanceNanny();
        List<Mother> AcceptanceMother();
        List<Child> AcceptanceChild();
        List<Contract> AcceptanceContract();
    }
}

