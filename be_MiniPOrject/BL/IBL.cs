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
        IEnumerable<Contract> List_Contract_that_have_only_week_left();
        List<Child> getChildList();

        void AddContract(Contract c);
        void RemoveContract(int contract_Num);
        void UpdateContract(Contract c);
        Contract GetContract(int contract_Num);
        void UpdetRateOfContract(string NanId, string MomId);//Update salary after discount
        List<Contract> getContractList();

        List<Child> List_Child_ByMother(Mother mom);
        List<Nanny> NanniesThatFitMom(Mother mom);
        List<Nanny> NanniesThatAlsoFitMom(Mother mom);
        List<Nanny> NanniesThatInDistanceWithMother(Mother mom, float distance);
        List<Child> GetAllTheChildrenThetDontHaveNannys();
        List<Nanny> GetAllTheNannysThatWorkWithDaysOOfTamat();
        List<Contract> GetAllContractThatFulfillingTheCondition(ContrafctCondition con);
        int GetAllNumberContractThatFulfillingTheCondition(ContrafctCondition con);
        IEnumerable<IGrouping<int, Nanny>> GetAllNannysAccordingToAgeChild(bool age, bool classified);
        IEnumerable<IGrouping<int, Contract>> GetAllTheContractAccordingTodistance(bool classified);

        IEnumerable<IGrouping<string, Child>> List_Child_ByMother();
 
    }
}
