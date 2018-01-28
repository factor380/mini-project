using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace DAL
{
    public class Dal_XML_imp : IDAL
    {
        int contractnumber = 0;
        XElement childRoot;
        XElement contractIdRoot;
        const string childPath = "C:/Users/User/Desktop/mini project/be_MiniPOrject/DAL/XmlFiles/Child.xml";
        const string motherPath = "C:/Users/User/Desktop/mini project/be_MiniPOrject/DAL/XmlFiles/Mother.xml";
        const string nannyPath = "C:/Users/User/Desktop/mini project/be_MiniPOrject/DAL/XmlFiles/Nanny.xml";
        const string contractPath = "C:/Users/User/Desktop/mini project/be_MiniPOrject/DAL/XmlFiles/Contract.xml";
        const string contractIdPath = "C:/Users/User/Desktop/mini project/be_MiniPOrject/DAL/XmlFiles/ContractId.xml";
        public Dal_XML_imp()
        {
            if (!File.Exists(nannyPath))
                SaveToXML(new List<Nanny>(), nannyPath);
            if (!File.Exists(motherPath))
                SaveToXML(new List<Mother>(), motherPath);
            if (!File.Exists(contractPath))
                SaveToXML(new List<Contract>(), contractPath);
            if (!File.Exists(childPath))
                CreateFiles();
            else
                LoadData();
            if (!File.Exists(contractIdPath))
                CreateFiles();
            else
                LoadData();
        }

        private void CreateFiles()
        {
            if (!File.Exists(childPath))
            {
                childRoot = new XElement("children");
                childRoot.Save(childPath);
            }
            if (!File.Exists(contractIdPath))
            {
                contractIdRoot = new XElement("ContractsID", 1);
                contractIdRoot.Save(contractIdPath);
            }
        }
        private void LoadData(string fileName = childPath)
        {
            try
            {
                if (File.Exists(childPath))
                    childRoot = XElement.Load(childPath);
                if (File.Exists(contractIdPath))
                    contractIdRoot = XElement.Load(contractIdPath);
            }
            catch
            {
                throw new Exception("Files upload problem");
            }
        }
        #region XML load and save
        public static void SaveToXML<T>(T source, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
            xmlSerializer.Serialize(file, source);
            file.Close();
        }
        public T LoadFromXML<T>(string path)
        {
            FileStream file = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            T result = (T)xmlSerializer.Deserialize(file);
            file.Close();
            return result;
        }
        #endregion

        #region func Child
        public List<Child> getChildList()
        {
            LoadData();
            List<Child> childs = new List<Child>();
            childs = (from c in childRoot.Elements()
                      select new Child()
                      {
                          Id = c.Element("id").Value,
                          MotherId = c.Element("motherId").Value,
                          Name = c.Element("name").Value,
                          DateBirth = DateTime.Parse(c.Element("birthday").Value),
                          SpecialNeeds = Boolean.Parse(c.Element("specialNeeds").Value),
                          WhatHeNeed = c.Element("whatHeNeed").Value
                      }).ToList();
            return childs;
        }
        public Child GetChild(string id)
        {
            LoadData();
            Child child;
            try
            {
                child = (from c in childRoot.Elements()
                         where (c.Element("id").Value) == id
                         select new Child
                         {
                             Id = c.Element("id").Value,
                             MotherId = c.Element("motherId").Value,
                             Name = c.Element("name").Value,
                             DateBirth = DateTime.Parse(c.Element("birthday").Value),
                             SpecialNeeds = Boolean.Parse(c.Element("specialNeeds").Value),
                             WhatHeNeed = c.Element("whatHeNeed").Value
                         }).FirstOrDefault();
            }
            catch
            {
                child = null;
            }
            return child;
        }
        public void AddChild(Child child)
        {
            LoadData();
            if (GetChild(child.Id) != null)
                throw new Exception("child with the same id already exists...");
            if (GetMother(child.MotherId) == null)
                throw new Exception("not exist mother to this child");
            XElement id = new XElement("id", child.Id);
            XElement motherId = new XElement("motherId", child.MotherId);
            XElement name = new XElement("name", child.Name);
            XElement dateBirth = new XElement("birthday", child.DateBirth);
            XElement specialNeeds = new XElement("specialNeeds", child.SpecialNeeds);
            XElement whatHeNeed = new XElement("whatHeNeed", child.WhatHeNeed);
            childRoot.Add(new XElement("child", id, motherId, name, dateBirth, specialNeeds, whatHeNeed));
            childRoot.Save(childPath);
        }
        public void RemoveChild(string id)
        {
            LoadData();
            XElement childElement;
            try
            {
                childElement = (from c in childRoot.Elements()
                                where (c.Element("id").Value) == id
                                select c).FirstOrDefault();
                childElement.Remove();
                childRoot.Save(childPath);
            }
            catch
            {
                throw new Exception("child with the same id not found...");
            }
        }
        public void UpdateChild(Child child)
        {
            LoadData();
            XElement childElement = (from c in childRoot.Elements()
                                     where (c.Element("id").Value) == child.Id
                                     select c).FirstOrDefault();

            childElement.Element("name").Value = child.Name;
            childElement.Element("special Needs").Value = (child.SpecialNeeds).ToString();
            childElement.Element("what He Need").Value = child.WhatHeNeed;

            childRoot.Save(childPath);
        }
        #endregion
        #region func Mother
        public void AddMother(Mother mother)
        {
            List<Mother> list = LoadFromXML<List<Mother>>(motherPath);
            if (list != null)
            {
                foreach (Mother item in list)
                {
                    if (item.Id == mother.Id)
                        throw new Exception("there is already mother with this id");
                }
            }
            list.Add(mother);
            SaveToXML(list, motherPath);
        }
        public List<Mother> getMotherList()
        {
            return LoadFromXML<List<Mother>>(motherPath);
        }
        public Mother GetMother(string id)
        {
            List<Mother> list = LoadFromXML<List<Mother>>(motherPath);
            return list.FirstOrDefault(m => m.Id == id);
        }
        public void RemoveMother(string id)
        {
            List<Mother> list = LoadFromXML<List<Mother>>(motherPath);
            bool flag = true;
            Mother deletmother = GetMother(id);
            foreach (Mother item in list)
            {
                if (item.Id == id)
                {
                    flag = false;
                    deletmother = item;
                }
            }
            if (flag)
                throw new Exception("this mother is not exist");
            else
                list.Remove(deletmother);
            SaveToXML<List<Mother>>(list, motherPath);
        }
        public void UpdateMother(Mother mother)
        {
            List<Mother> list = LoadFromXML<List<Mother>>(motherPath);
            bool flag = true;
            foreach (Mother item in list)
            {
                if (item.Id == mother.Id)
                    flag = false;
            }
            if (flag)
                throw new Exception("this mother is not exist");
            RemoveMother(mother.Id);
            AddMother(mother);
        }
        public Mother GetMotherWithChildId(string id)
        {
            Child chi = GetChild(id);
            if (chi == null)
                throw new Exception("thare no child with this id");

            return LoadFromXML<List<Mother>>(motherPath).FirstOrDefault(m => m.ListIdChild.FirstOrDefault() == id);
        }
        #endregion
        #region func Nanny
        public void AddNanny(Nanny nanny)
        {
            List<Nanny> list = LoadFromXML<List<Nanny>>(nannyPath);
            if (list != null)
            {
                foreach (Nanny item in list)
                {
                    if (item.Id == nanny.Id)
                        throw new Exception("there is already nanny with this id");
                }
            }
            list.Add(nanny);
            SaveToXML(list, nannyPath);
        }
        public List<Nanny> getNannyList()
        {
            return LoadFromXML<List<Nanny>>(nannyPath);
        }
        public Nanny GetNanny(string id)
        {
            List<Nanny> list = LoadFromXML<List<Nanny>>(nannyPath);
            return list.FirstOrDefault(n => n.Id == id);
        }
        public void RemoveNanny(string id)
        {
            List<Nanny> list = LoadFromXML<List<Nanny>>(nannyPath);
            bool flag = true;
            Nanny deletnanny = GetNanny(id);
            foreach (Nanny item in list)
            {
                if (item.Id == id)
                {
                    flag = false;
                    deletnanny = item;
                }
            }
            if (flag)
                throw new Exception("this nanny is not exist");
            else
                list.Remove(deletnanny);
            SaveToXML<List<Nanny>>(list, nannyPath);
        }
        public void UpdateNanny(Nanny nanny)
        {
            List<Nanny> list = LoadFromXML<List<Nanny>>(nannyPath);
            bool flag = true;
            foreach (Nanny item in list)
            {
                if (item.Id == nanny.Id)
                    flag = false;
            }
            if (flag)
                throw new Exception("this nanny is not exist");
            RemoveNanny(nanny.Id);
            AddNanny(nanny);
        }
        #endregion
        #region func Contract
        public void AddContract(Contract contract)
        {
            List<Nanny> listNanny = LoadFromXML<List<Nanny>>(nannyPath);
            List<Mother> listMother = LoadFromXML<List<Mother>>(motherPath);
            List<Contract> listContract = LoadFromXML<List<Contract>>(contractPath);
            List<Child> listChild = getChildList();
            bool flag = true;
            if (listChild == null || listNanny == null || listMother == null)
                throw new Exception("Missing Details");
            foreach (Child item in listChild)
            {
                if (item.Id == contract.ChildId)
                    contract.MotherId = item.MotherId;
            }
            foreach (Mother item in listMother)
            {
                if (item.Id == contract.MotherId)
                    flag = false;
            }
            if (flag)
                throw new Exception("there is no mother with rhis id");
            flag = true;
            foreach (Nanny item in listNanny)
            {
                if (item.Id == contract.NannyId)
                    flag = false;
            }
            if (flag)
                throw new Exception("there is no nanny with rhis id");
            contract.Contract_Num1 = Contract.ContractNum1;
            contractnumber = contract.Contract_Num1;
            Child chi = GetChild(contract.ChildId);
            Nanny nan = GetNanny(contract.NannyId);
            chi.ListIdContract.Add(contract.Contract_Num1);
            nan.ListIdContract.Add(contract.Contract_Num1);
            contractnumber++;
            Contract.ContractNum1 = contractnumber;
            listContract.Add(contract);
            SaveToXML(listContract, contractPath);
        }
        public List<Contract> getContractList()
        {
            return LoadFromXML<List<Contract>>(contractPath);
        }
        public Contract GetContract(int Contract_number)
        {
            List<Contract> list = LoadFromXML<List<Contract>>(contractPath);
            return list.FirstOrDefault(c => c.Contract_Num1 == Contract_number);
        }
        public void RemoveContract(int Contract_number)
        {
            List<Contract> list = LoadFromXML<List<Contract>>(contractPath);
            bool flag = true;
            Contract deletcontract = GetContract(Contract_number);
            foreach (Contract item in list)
            {
                if (item.Contract_Num1 == Contract_number)
                {
                    flag = false;
                    deletcontract = item;
                }
            }
            if (flag)
                throw new Exception("Contract not found");
            else
                list.Remove(deletcontract);
            SaveToXML<List<Contract>>(list, contractPath);
        }
        public void UpdateContract(Contract contrcat)
        {
            List<Contract> list = LoadFromXML<List<Contract>>(contractPath);
            bool flag = true;
            foreach (Contract item in list)
            {
                if (item.Contract_Num1 == contrcat.Contract_Num1)
                    flag = false;
            }
            if (flag)
                throw new Exception("Contrcat not found");
            RemoveContract(contrcat.Contract_Num1);
            AddContract(contrcat);
        }
        #endregion
        #region list
        public IEnumerable<IGrouping<string, Child>> List_Child_ByMother()
        {
            var ChildByMother = from kid in getChildList()
                                group kid by kid.MotherId;
            return ChildByMother;
        }
        #endregion
    }
}
