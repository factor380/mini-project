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
        #region nanny func
        void AddNanny(Nanny n);
        void RemoveNanny(string id);
        void UpdateNanny(Nanny n);
        Nanny GetNanny(string id);
        List<Nanny> getNannyList();
        #endregion
        #region mother func
        void AddMother(Mother m);
        void RemoveMother(string id);
        void UpdateMother(Mother m);
        Mother GetMother(string id);
        Mother GetMotherWithChildId(string id);
        List<Mother> getMotherList();
        #endregion
        #region child func
        void AddChild(Child c);
        void RemoveChild(string id);
        void UpdateChild(Child c);
        Child GetChild(string id);
        List<Child> getChildList();
        #endregion
        #region contract func
        void AddContract(Contract c);
        void RemoveContract(int contract_Num);
        void UpdateContract(Contract c);
        Contract GetContract(int contract_Num);
        List<Contract> getContractList();
        #endregion
        IEnumerable<IGrouping<string, Child>> List_Child_ByMother();

    }
}

