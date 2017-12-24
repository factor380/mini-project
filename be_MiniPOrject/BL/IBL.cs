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

        void AddMother();
        void DelMother();
        void UpdatingMother();
        Mother GetMother();

        void AddChild(Child c);
        void DelChild(Child c);
        void UpdatingChild(Child c);
        Child GetChild(int id);

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
