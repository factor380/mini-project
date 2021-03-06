﻿using System;
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
        XElement childRoot;
        XElement contractIdRoot;
        const string childPath = @"XmlFiles/Child.xml";
        const string motherPath = @"XmlFiles/Mother.xml";
        const string nannyPath = @"XmlFiles/Nanny.xml";
        const string contractPath = @"XmlFiles/Contract.xml";
        const string contractIdPath = @"XmlFiles/ContractId.xml";
        /// <summary>
        /// constractor
        /// </summary>
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
        /// <summary>
        /// create the file
        /// </summary>
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
        /// <summary>
        /// load the file
        /// </summary>
        private void LoadData()
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
        /// <summary>
        /// save
        /// </summary>
        /// <typeparam name="T">to all the clases</typeparam>
        /// <param name="source">what save on the file</param>
        /// <param name="path">to the corect file</param>
        public static void SaveToXML<T>(T source, string path)
        {
            FileStream file = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(source.GetType());
            xmlSerializer.Serialize(file, source);
            file.Close();
        }
        /// <summary>
        /// load
        /// </summary>
        /// <typeparam name="T">to all the clases</typeparam>
        /// <param name="path">to the corect file</param>
        /// <returns>return the details from the file</returns>
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
        /// <summary>
        /// retrun the all childs
        /// </summary>
        /// <returns>kist of childs</returns>
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
                          WhatHeNeed = c.Element("whatHeNeed").Value,
                          ListIdContractxml = c.Element("idContract").Value
                      }).ToList();
            return childs;
        }
        /// <summary>
        /// return specific child
        /// </summary>
        /// <param name="id">id of the child to return</param>
        /// <returns>thr correct child or null if not found</returns>
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
                             WhatHeNeed = c.Element("whatHeNeed").Value,
                             ListIdContractxml = c.Element("idContract").Value
                         }).FirstOrDefault();
            }
            catch
            {
                child = null;
            }
            return child;
        }
        /// <summary>
        /// add child to the file
        /// </summary>
        /// <param name="child">the child to add</param>
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
            XElement idcontract = new XElement("idContract", child.ListIdContractxml);
            childRoot.Add(new XElement("child", id, motherId, name, dateBirth, specialNeeds, whatHeNeed, idcontract));
            Mother mom = GetMother(child.MotherId);
            mom.ListIdChild.Add(child.Id);
            UpdateMother(mom);
            childRoot.Save(childPath);
        }
        /// <summary>
        /// remove child from the file
        /// </summary>
        /// <param name="id">the id of the child to delete</param>
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
        /// <summary>
        /// update specific child on the file
        /// </summary>
        /// <param name="child">the child to update</param>
        public void UpdateChild(Child child)
        {
            LoadData();
            XElement childElement = (from c in childRoot.Elements()
                                     where (c.Element("id").Value) == child.Id
                                     select c).FirstOrDefault();

            childElement.Element("name").Value = child.Name;
            childElement.Element("specialNeeds").Value = (child.SpecialNeeds).ToString();
            childElement.Element("whatHeNeed").Value = child.WhatHeNeed;
            childElement.Element("idContract").Value = child.ListIdContractxml;
            childRoot.Save(childPath);
        }
        #endregion
        #region func Mother
        /// <summary>
        /// add mother to the file
        /// </summary>
        /// <param name="mother">the mother to add</param>
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
        /// <summary>
        /// get all the mother
        /// </summary>
        /// <returns>list of the all mothers</returns>
        public List<Mother> getMotherList()
        {
            return LoadFromXML<List<Mother>>(motherPath);
        }
        /// <summary>
        /// return specific mother
        /// </summary>
        /// <param name="id">the id of mother to return</param>
        /// <returns>the mother</returns>
        public Mother GetMother(string id)
        {
            List<Mother> list = LoadFromXML<List<Mother>>(motherPath);
            return list.FirstOrDefault(m => m.Id == id);
        }
        /// <summary>
        /// remove mother from the file
        /// </summary>
        /// <param name="id">the id of the mother to delete</param>
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
        /// <summary>
        /// update specific mother on the file
        /// </summary>
        /// <param name="mother">the mother to update</param>
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
        /// <summary>
        /// return mother with the child id
        /// </summary>
        /// <param name="id">the child id</param>
        /// <returns>the mom of the child that you get</returns>
        public Mother GetMotherWithChildId(string id)
        {
            Child chi = GetChild(id);
            if (chi == null)
                throw new Exception("thare no child with this id");

            return LoadFromXML<List<Mother>>(motherPath).FirstOrDefault(m => m.ListIdChild.FirstOrDefault() == id);
        }
        #endregion
        #region func Nanny
        /// <summary>
        /// add nanny to the file
        /// </summary>
        /// <param name="nanny">the nanny to add</param>
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
        /// <summary>
        /// get the all nanny 
        /// </summary>
        /// <returns>list of the all nannies</returns>
        public List<Nanny> getNannyList()
        {
            return LoadFromXML<List<Nanny>>(nannyPath);
        }
        /// <summary>
        /// get specific nanny
        /// </summary>
        /// <param name="id">the id of nanny to return</param>
        /// <returns>return the nanny</returns>
        public Nanny GetNanny(string id)
        {
            List<Nanny> list = LoadFromXML<List<Nanny>>(nannyPath);
            return list.FirstOrDefault(n => n.Id == id);
        }
        /// <summary>
        /// remove nanny from the file
        /// </summary>
        /// <param name="id">the id of nanny to delete</param>
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
        /// <summary>
        /// update nanny on the file
        /// </summary>
        /// <param name="nanny">the nanny to update</param>
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
        /// <summary>
        /// add contract to the file
        /// </summary>
        /// <param name="contract">the contract to add</param>
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
                throw new Exception("there is no nanny with this id");
            contract.Contract_Num1 = int.Parse(LoadNumnber());//get the number from the file
            Contract.ContractNum1++;//up the run number by one
            Child chi = GetChild(contract.ChildId);
            Nanny nan = GetNanny(contract.NannyId);
            chi.listIdContract.Add(contract.Contract_Num1);
            UpdateChild(chi);
            nan.ListIdContract.Add(contract.Contract_Num1);
            UpdateNanny(nan);
            listContract.Add(contract);
            SaveToXML(listContract, contractPath);
            ChangeNumnber();//change the file and add to the run number one
        }
        /// <summary>
        /// get the all contracts
        /// </summary>
        /// <returns>return list of the all contracts</returns>
        public List<Contract> getContractList()
        {
            return LoadFromXML<List<Contract>>(contractPath);
        }
        /// <summary>
        /// retrun specific contarct
        /// </summary>
        /// <param name="Contract_number">the contarct number of the contract</param>
        /// <returns>return the contract</returns>
        public Contract GetContract(int Contract_number)
        {
            List<Contract> list = LoadFromXML<List<Contract>>(contractPath);
            return list.FirstOrDefault(c => c.Contract_Num1 == Contract_number);
        }
        /// <summary>
        /// remove contract from the file
        /// </summary>
        /// <param name="Contract_number">the contract number to delete</param>
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
        /// <summary>
        /// update the contract on the file
        /// </summary>
        /// <param name="contrcat">the contract to update</param>
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
        /// <summary>
        /// load the run number from the file
        /// </summary>
        /// <returns>the number on the file</returns>
        public string LoadNumnber()
        {
            LoadData();
            return contractIdRoot.Value;
        }
        /// <summary>
        /// change the ran number on file 
        /// </summary>
        public void ChangeNumnber()
        {
            LoadData();
            contractIdRoot.Value = Contract.ContractNum1.ToString();
            contractIdRoot.Save(contractIdPath);
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
