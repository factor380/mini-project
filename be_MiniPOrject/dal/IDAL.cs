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
        void RemoveNanny(string id);
        void UpdateNanny(Nanny n);
        Nanny GetNanny(string id);
        List<Nanny> getNannyList();

        void AddMother(Mother m);
        void RemoveMother(string id);
        void UpdateMother(Mother m);
        Mother GetMother(string id);
        Mother GetMotherWithChildId(string id);
        List<Mother> getMotherList();

        void AddChild(Child c);
        void RemoveChild(string id);
        void UpdateChild(Child c);
        Child GetChild(string id);
        List<Child> getChildList();

        void AddContract(Contract c);
        void RemoveContract(int contract_Num);
        void UpdateContract(Contract c);
        Contract GetContract(int contract_Num);
        List<Contract> getContractList();

        IEnumerable<IGrouping<string, Child>> List_Child_ByMother();
        
    }
}

