using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BE
{
    public class Child
    {
        #region Fields
        private string id;
        private string motherId;
        private string name;
        private DateTime dateBirth;
        private bool specialNeeds;
        private string whatHeNeed;
        public List<int> listIdContract;
        #endregion
        #region conntractors
        /// <summary>
        /// defult constractor
        /// </summary>
        public Child()
        {
            listIdContract = new List<int>();
        }
        /// <summary>
        /// regular constractor
        /// </summary>
        /// <param name="id">id that you get</param>
        /// <param name="motherId">motherId that you get</param>
        /// <param name="name">name that you get</param>
        /// <param name="dateBirth">dateBirth that you get</param>
        /// <param name="specialNeeds">specialNeeds that you get</param>
        /// <param name="whatHeNeed">whatHeNeed that you get</param>
        public Child(string id, string motherId, string name, DateTime dateBirth, bool specialNeeds, string whatHeNeed)
        {
            if (IDCheck(id))
                this.id = id;
            else
                throw new Exception("this id not exist");
            if (IDCheck(motherId))
                this.motherId = motherId;
            else
                throw new Exception("this id not exist");
            this.name = name;
            this.dateBirth = dateBirth;
            this.specialNeeds = specialNeeds;
            this.whatHeNeed = whatHeNeed;
        }
        #endregion
        #region properties
        /// <summary>
        /// property to the check box to how is seen on the check box
        /// </summary>
        [XmlIgnore]
        public string Data { get => name + " id: " + id; }
        /// <summary>
        /// property to the id
        /// </summary>
        public string Id
        {
            get => id;
            set
            {
                if (IDCheck(value))
                    id = value;
                else
                    throw new Exception("this id not exist");
            }
        }
        /// <summary>
        /// property to the motherId
        /// </summary>
        public string MotherId
        {
            get => motherId;
            set
            {
                if (IDCheck(value))
                    motherId = value;
                else
                    throw new Exception("this id not exist");
            }
        }
        /// <summary>
        /// property to the name
        /// </summary>
        public string Name
        {
            get => name;
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] > 0 && value[i] < 9)
                        throw new Exception("the name couldnt contain numbers");
                }
                name = value;
            }
        }
        /// <summary>
        /// property to the dateBirth
        /// </summary>
        public DateTime DateBirth
        {
            get => dateBirth.Date;
            set
            {
                if (value < DateTime.Now)
                    dateBirth = value.Date;
                else
                    throw new Exception("this date birth must be on the past");
            }
        }
        /// <summary>
        /// property to the specialNeeds
        /// </summary>
        public bool SpecialNeeds { get => specialNeeds; set => specialNeeds = value; }
        /// <summary>
        /// property to the whatHeNeed
        /// </summary>
        public string WhatHeNeed { get => whatHeNeed; set => whatHeNeed = value; }
        /// <summary>
        /// property to prevent the listIdContract on the xml file
        /// </summary>
        public string ListIdContractxml
        {
            get
            {
                if (listIdContract == null)
                    return null;
                string result = "";
                if (listIdContract != null)
                {
                    int sizeA = listIdContract.Count();
                    result += "" + sizeA;
                    for (int i = 0; i < sizeA; i++)
                        result += "," + listIdContract[i].ToString();
                }
                return result;
            }
            set
            {
                if (value != null && value.Length > 0)
                {
                    string[] values = value.Split(',');
                    int sizeA = int.Parse(values[0]);
                    listIdContract = new List<int>(sizeA);
                    int index = 1;
                    for (int i = 0; i < sizeA; i++)
                        listIdContract.Add(int.Parse(values[index++]));
                }
            }
        }
        #endregion
        #region to string and static func
        /// <summary>
        /// to string to prevent child
        /// </summary>
        /// <returns>return string that prevent child</returns>
        public override string ToString()
        {
            return name + " id: " + id + " mother id: " + MotherId + " Date of birth " + DateBirth.Year + '/' + DateBirth.Month + '/' + DateBirth.Day;
        }
        /// <summary>
        /// check if the id is good According to the Interior Ministry
        /// </summary>
        /// <param name="strID">the id to check</param>
        /// <returns>returns if the id good or not</returns>
        static bool IDCheck(String strID)
        {
            int[] id_12_digits = { 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int count = 0;
            if (strID == null)
                return false;
            strID = strID.PadLeft(9, '0');
            for (int i = 0; i < 9; i++)
            {
                int num = Int32.Parse(strID.Substring(i, 1)) * id_12_digits[i];
                if (num > 9)
                    num = (num / 10) + (num % 10);
                count += num;
            }
            return (count % 10 == 0);
        }
        #endregion
    }
}
