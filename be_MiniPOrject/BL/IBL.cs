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
        void RemoveNanny(int id);
        void UpdateNanny(Nanny n);
        Nanny GetNanny(int id);
        List<Nanny> getNannyList();

        void AddMother(Mother m);
        void RemoveMother(int id);
        void UpdateMother(Mother m);
        Mother GetMother(int id);
        Mother GetMotherWithChildId(int id);
        List<Mother> getMotherList();

        void AddChild(Child c);
        void RemoveChild(int id);
        void UpdateChild(Child c);
        Child GetChild(int id);
        List<Child> getChildList();

        void AddContract(Contract c);
        void RemoveContract(int contract_Num);
        void UpdateContract(Contract c);
        Contract GetContract(int contract_Num);
        void UpdetRateOfContract(int NanId, int MomId);//Update salary after discount
        List<Contract> getContractList();

        List<Nanny> NanniesThatFitMom(Mother mom);
        List<Nanny> NanniesThatAlsoFitMom(Mother mom);
        List<Nanny> NanniesThatInDistanceWithMother(Mother mom, float distance);
        List<Child> GetAllTheChildrenThetDontHaveNannys();
        List<Nanny> GetAllTheNannysThatWorkWithDaysOOfTamat();
        List<Contract> GetAllContractThatFulfillingTheCondition(ContrafctCondition con);
        int GetAllNumberContractThatFulfillingTheCondition(ContrafctCondition con);
        IEnumerable<IGrouping<int, Nanny>> GetAllNannysAccordingToAgeChild(bool age, bool classified);
        IEnumerable<IGrouping<int, Contract>> GetAllTheContractAccordingTodistance(bool classified);

        IEnumerable<IGrouping<int, Child>> List_Child_ByMother();
    }
}
