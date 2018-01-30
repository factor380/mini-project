using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi;

namespace BL
{
    public delegate bool ContrafctCondition(Contract c);


    public class BL_imp : IBL
    {
        IDAL dal = FactoryDAL.GetDAL();

        #region Nanny func
        /// <summary>
        /// add the nanny
        /// </summary>
        /// <param name="n"></param>
        public void AddNanny(Nanny n)
        {
            if (DateTime.Now.Year - n.DateBirth.Year < 18)//checking
                throw new Exception("this Nanny is under 18");
            dal.AddNanny(n);
        }
        /// <summary>
        /// remove the nanny according to id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveNanny(string id)
        {
            Contract c;
            Nanny n = GetNanny(id);
            foreach (int IdCo in n.ListIdContract)
            {
                c = dal.GetContract(IdCo);
                if (c.EndDate > DateTime.Now || c.ActiveContract == true)//checking
                    throw new Exception("Nanny have contract that she dont finish");
                RemoveContract(c.Contract_Num1);

            }
            dal.RemoveNanny(id);
        }
        /// <summary>
        /// update the nanny
        /// </summary>
        /// <param name="n"></param>
        public void UpdateNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (n.ListIdContract.Count() > nan.MaxChildren)//checking
                throw new Exception("Nanny cant have more children");
            dal.UpdateNanny(n);
        }
        /// <summary>
        /// get the nanny according to id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Nanny GetNanny(string id)
        {
            return dal.GetNanny(id);
        }
        public List<Nanny> getNannyList() => dal.getNannyList();
        #endregion

        #region Child func
        /// <summary>
        /// add the child
        /// </summary>
        /// <param name="c"></param>
        public void AddChild(Child c)
        {
            dal.AddChild(c);
        }
        /// <summary>
        /// remove child according id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveChild(string id)
        {
            Contract c;
            Child chi = GetChild(id);
            Mother m = GetMotherWithChildId(id);
            foreach (int IdCo in chi.listIdContract)
            {
                c = dal.GetContract(IdCo);
                if (c.EndDate > DateTime.Now || c.ActiveContract == true)
                    throw new Exception("Child have contract that he dont finish");
                RemoveContract(IdCo);
            }
            dal.RemoveChild(id);

        }
        /// <summary>
        /// update the child
        /// </summary>
        /// <param name="c"></param>
        public void UpdateChild(Child c)
        {
            dal.UpdateChild(c);
        }
        /// <summary>
        /// get the child according id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Child GetChild(string id)
        {
            return dal.GetChild(id);
        }
        /// <summary>
        /// get all the child
        /// </summary>
        /// <returns></returns>
        public List<Child> getChildList() => dal.getChildList();
        #endregion

        #region mother func
        /// <summary>
        /// add the mother
        /// </summary>
        /// <param name="m"></param>
        public void AddMother(Mother m)
        {
            dal.AddMother(m);
        }
        /// <summary>
        /// remove mother according to id
        /// </summary>
        /// <param name="id"></param>
        public void RemoveMother(string id)
        {
            Mother m = GetMother(id);
            foreach (string Idc in m.ListIdChild)//remove all the  mother's children
            {
                RemoveChild(Idc);
            }
            dal.RemoveMother(id);
        }

        /// <summary>
        /// update the mother
        /// </summary>
        /// <param name="m"></param>
        public void UpdateMother(Mother m)
        {
            dal.UpdateMother(m);
        }
        /// <summary>
        /// get mother according to id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mother GetMother(string id)
        {
            return dal.GetMother(id);
        }
        /// <summary>
        /// get mother according to her child id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Mother GetMotherWithChildId(string id)
        {
            return dal.GetMotherWithChildId(id);
        }
        /// <summary>
        /// get all the mothers
        /// </summary>
        /// <returns></returns>
        public List<Mother> getMotherList() => dal.getMotherList();
        #endregion

        #region Contract func
        /// <summary>
        /// add the contract
        /// </summary>
        /// <param name="c"></param>
        public void AddContract(Contract c)
        {
            Child chi = GetChild(c.ChildId);
            Nanny nan = GetNanny(c.NannyId);
            Mother mom = GetMother(c.MotherId);
            int CalculatesSalary = 0;//if the nanny have more children from the mother they are rebate 
            if ((DateTime.Today.Year - chi.DateBirth.Year) * 12 + (DateTime.Today.Month - chi.DateBirth.Month) < nan.MinAgeMonth)//checking
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if ((DateTime.Today.Year - chi.DateBirth.Year) * 12 + (DateTime.Today.Month - chi.DateBirth.Month) > nan.MaxAgeMonth)//checking
            {
                throw new Exception("the nanny can't get the age of the child");
            }
            if (nan.ListIdContract.Count == nan.MaxChildren)//checking
            {
                throw new Exception("the nanny take care of max child that she can");
            }
            //calculates Salary
            foreach (int idc in nan.ListIdContract)
            {
                Contract con = GetContract(idc);
                if (con.MotherId == mom.Id)
                    CalculatesSalary++;
            }
            if (c.HorM1 == false)//hour
            {
                if (nan.PerHour == false)
                    throw new Exception("the nanny dont agree to get a hour rate");
                c.PayHours = c.PayHours - ((nan.PayHour * CalculatesSalary * 2) / 100);
                c.PayMonth = c.PayHours * (float)(nan.HowMuchHourNanWork1.TotalHours) * 4;
            }
            else//month
            {
                c.PayMonth = nan.PayMonth - ((nan.PayMonth * CalculatesSalary * 2) / 100);
                c.PayHours = nan.PayHour - ((nan.PayHour * CalculatesSalary * 2) / 100);
            }
            dal.AddContract(c);
        }
        /// <summary>
        /// remove the contract according to is number
        /// </summary>
        /// <param name="contract_Num"></param>
        public void RemoveContract(int contract_Num)
        {
            Contract c = GetContract(contract_Num);
            if (DateTime.Now > c.EndDate || c.ActiveContract == true)//checking
                throw new Exception("this contract dont finish");
            Nanny nan = GetNanny(c.NannyId);
            nan.ListIdContract.Remove(contract_Num);
            UpdetRateOfContract(c.NannyId, c.MotherId);
            Child chi = GetChild(c.ChildId);
            chi.listIdContract.Remove(c.Contract_Num1);
            dal.RemoveContract(contract_Num);
        }
        /// <summary>
        /// update the contract
        /// </summary>
        /// <param name="c"></param>
        public void UpdateContract(Contract c)
        {
            Child chi = GetChild(c.ChildId);
            Nanny nan = GetNanny(c.NannyId);
            Mother mom = GetMother(c.MotherId);
            if ((DateTime.Today.Year - chi.DateBirth.Year) * 12 + (DateTime.Today.Month - chi.DateBirth.Month) < nan.MinAgeMonth)//checking
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if ((DateTime.Today.Year - chi.DateBirth.Year) * 12 + (DateTime.Today.Month - chi.DateBirth.Month) > nan.MaxAgeMonth)//checking
            {
                throw new Exception("the nanny can't get the age of the child");
            }
            dal.UpdateContract(c);
        }
        /// <summary>
        /// get the contract according to is number
        /// </summary>
        /// <param name="contract_Num"></param>
        /// <returns></returns>
        public Contract GetContract(int contract_Num)
        {
            return dal.GetContract(contract_Num);
        }
        /// <summary>
        /// Calculates salary
        /// </summary>
        /// <param name="NanId"></param>
        /// <param name="MomId"></param>
        public void UpdetRateOfContract(string NanId, string MomId)
        {
            Nanny nan = GetNanny(NanId);
            int CalculatesSalary = 0;
            foreach (int idc in nan.ListIdContract)
            {
                Contract c = GetContract(idc);
                if (c.MotherId == MomId)
                {
                    if (c.HorM1 == false)//hour
                    {
                        c.PayHours = nan.PayHour - ((nan.PayHour * CalculatesSalary * 2) / 100);
                        c.PayMonth = c.PayHours * 4 * (float)(nan.HowMuchHourNanWork1.Days);
                    }
                    else//month
                    {
                        c.PayMonth = nan.PayMonth - ((nan.PayMonth * CalculatesSalary * 2) / 100);
                        c.PayHours = nan.PayHour - ((nan.PayHour * CalculatesSalary * 2) / 100);
                    }
                    CalculatesSalary++;
                }
            }
        }
        /// <summary>
        /// get all the contract
        /// </summary>
        /// <returns></returns>
        public List<Contract> getContractList() => dal.getContractList();
        #endregion


        #region all the func gropin and maps and lists

        /// <summary>
        /// the func to get the Distance between points
        /// </summary>
        /// <param name="PointA"></param>
        /// <param name="PointB"></param>
        /// <returns></returns>        
        public static int CalculateDistance(string PointA, string PointB)
        {
            var drivingDirectionRequest = new DirectionsRequest
            {
                TravelMode = TravelMode.Walking,
                Origin = PointA,
                Destination = PointB,
            };
            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);// לפעמים הפונקציה לא מצליחה לעבוד לא יודע למה ואז שמים ברייק פוינט וזה מסתדר לא יודע למה  
            Route route = drivingDirections.Routes.First();
            Leg leg = route.Legs.First();
            return leg.Distance.Value;
        }
        /// <summary>
        /// the func the return nannies that fit to some mother
        /// </summary>
        /// <param name="mom"></param>
        /// <returns></returns>
        public List<Nanny> NanniesThatFitMom(Mother mom)
        {
            List<Nanny> listN = getNannyList();
            List<Nanny> listToSend = new List<Nanny>();
            bool ToSeeIfAllTheDaysGood = false;
            foreach (Nanny nan in listN)
            {
                if (nan.DayInWeek == mom.DayInWeek)
                {
                    ToSeeIfAllTheDaysGood = true;
                    for (int i = 0; i < 6; ++i)
                    {
                        if (nan.WorkHours[i][0] > mom.WhenNeededWeek[i][0] && nan.WorkHours[i][1] < mom.WhenNeededWeek[i][1])//Checking if the hours are good
                        {
                            ToSeeIfAllTheDaysGood = false;
                        }

                    }
                    if (ToSeeIfAllTheDaysGood == true)
                        listToSend.Add(nan);

                }

            }

            return listToSend;

        }/// <summary>
         /// the func the return nannies that almost fit to some mother
         /// </summary>
         /// <param name="mom"></param>
         /// <returns></returns>
        public List<Nanny> NanniesThatAlsoFitMom(Mother mom) //i decide to do what almost fit in days and our
        {
            List<Nanny> listN = getNannyList();
            List<Nanny> listToSend = new List<Nanny>();

            int count = 0;//to count the days that fit
            for (int m = 0; m < 5; m++)
            {
                foreach (Nanny nan in listN)
                {
                    for (int i = 0; i < 6; ++i)
                    {
                        if (mom.DayInWeek[i] == nan.DayInWeek[i])//Checking if the hours almost good
                        {
                            if (nan.WorkHours[i][0] <= mom.WhenNeededWeek[i][0] && nan.WorkHours[i][1] >= mom.WhenNeededWeek[i][1])
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 5 - m)
                        listToSend.Add(nan);

                    if (listToSend.Count == 5)
                        break;
                    count = 0;
                }
                if (listToSend.Count == 5)
                    break;
            }
            return listToSend;

        }
        /// <summary>
        /// return list of nannies that in the distance that mother want
        /// </summary>
        /// <param name="mom"></param>
        /// <param name="distance"></param>
        /// <returns></returns>
        public List<Nanny> NanniesThatInDistanceWithMother(Mother mom, float distance)
        {
            List<Nanny> listN = getNannyList();
            List<Nanny> listToSend = new List<Nanny>();
            string address;
            if (mom.AddressAround == null)
                address = mom.Address;
            else
                address = mom.AddressAround;
            foreach (Nanny nan in listN)
            {
                if (distance >= CalculateDistance(nan.Address, address))
                    listToSend.Add(nan);
            }
            return listToSend;
        }
        /// <summary>
        /// return list of child that dont have nanny
        /// </summary>
        /// <returns></returns>
        public List<Child> GetAllTheChildrenThetDontHaveNannys()
        {
            List<Child> listC = getChildList();
            List<Child> listToSend = new List<Child>();

            foreach (Child chi in listC)
            {
                if (chi.listIdContract.Count == 0)
                    listToSend.Add(chi);
            }
            return listToSend;
        }
        /// <summary>
        /// return all the nannies that take holiday of tamat
        /// </summary>
        /// <returns></returns>
        public List<Nanny> GetAllTheNannysThatWorkWithDaysOOfTamat()
        {
            List<Nanny> listN = getNannyList();
            List<Nanny> listToSend = new List<Nanny>();

            foreach (Nanny nan in listN)
            {
                if (nan.DaysOOf == true)
                    listToSend.Add(nan);
            }

            return listToSend;
        }
        /// <summary>
        /// //the func that return all the contract that fit to Certain conditions
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public List<Contract> GetAllContractThatFulfillingTheCondition(ContrafctCondition con)
        {
            List<Contract> listToSend = new List<Contract>();
            foreach (Contract c in getContractList())
            {
                if (con(c))
                    listToSend.Add(c);
            }
            return listToSend;
        }
        /// <summary>
        /// //the func that return number of all the contract that fit Certain conditions
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public int GetAllNumberContractThatFulfillingTheCondition(ContrafctCondition con)
        {
            List<Contract> listContract = GetAllContractThatFulfillingTheCondition(con);

            return listContract.Count;
        }
        /// <summary>
        /// return group of nannyies according to the age min or max 
        /// </summary>
        /// <param name="age"></param>
        /// <param name="classified"></param>
        /// <returns></returns>
        public IEnumerable<IGrouping<int, Nanny>> GetAllNannysAccordingToAgeChild(bool age = false, bool classified = false)
        {
            List<Nanny> ListN = getNannyList();
            if (age == false)
            {
                if (classified == false)
                {
                    IEnumerable<IGrouping<int, Nanny>> result = from nan in ListN
                                                                group nan by nan.MinAgeMonth;
                    return result;
                }
                else
                {
                    IEnumerable<IGrouping<int, Nanny>> result = from nan in ListN
                                                                orderby nan.Name
                                                                group nan by nan.MinAgeMonth;
                    return result;
                }

            }
            else
            {
                if (classified == false)
                {
                    IEnumerable<IGrouping<int, Nanny>> result = from nan in ListN
                                                                group nan by nan.MaxAgeMonth;
                    return result;
                }
                else
                {
                    IEnumerable<IGrouping<int, Nanny>> result = from nan in ListN
                                                                orderby nan.Name
                                                                group nan by nan.MaxAgeMonth;
                    return result;
                }
            }


        }
        /// <summary>
        /// return group of contract according to the distance /1000
        /// </summary>
        /// <param name="classified"></param>
        /// <returns></returns>
        public IEnumerable<IGrouping<int, Contract>> GetAllTheContractAccordingTodistance(bool classified = false)
        {
            List<Contract> ListC = getContractList();
            if (classified == false)
            {
                IEnumerable<IGrouping<int, Contract>> result = from con in ListC
                                                               group con by CalculateDistance(GetMother(con.MotherId).AddressAround, GetNanny(con.NannyId).Address) / 1000;
                return result;
            }
            else
            {
                IEnumerable<IGrouping<int, Contract>> result = from con in ListC
                                                               orderby con.Contract_Num1
                                                               group con by CalculateDistance(GetMother(con.MotherId).AddressAround, GetNanny(con.NannyId).Address) / 1000;
                return result;

            }
        }
        /// <summary>
        /// return group of child acording to her mother
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IGrouping<string, Child>> List_Child_ByMother()
        {
            return dal.List_Child_ByMother();
        }
        public List<Child> List_Child_ByMother(Mother mom)
        {
            List<Child> childofMother = new List<Child>();
            foreach (string id in mom.ListIdChild)
            {
                childofMother.Add(GetChild(id));
            }
            return childofMother;
        }

        /// <summary>
        /// return list of contract that almost finish
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Contract> List_Contract_that_have_only_week_left()
        {
            IEnumerable<Contract> ConL = getContractList();
            IEnumerable<Contract> ListToSend = from Contract item in ConL
                                               where ((item.EndDate - DateTime.Now).TotalDays < 7)
                                               select item;
            return ListToSend;
        }
        /// <summary>
        /// get all the contract that nanny have
        /// </summary>
        /// <param name="nan"></param>
        /// <returns></returns>
        public List<Contract> GetContractOfNanny(Nanny nan)
        {

            return (from item in nan.ListIdContract
                    let contract = GetContract(item)
                    select (contract)).ToList();
        }
        /// <summary>
        /// get the most expert nannys
        /// </summary>
        /// <returns></returns>
        public Nanny GetTheMostExpNannies()
        {
            Nanny toSend = getNannyList().First();
            foreach (Nanny item in getNannyList())
            {
                if (item.Exp > toSend.Exp)
                    toSend = item;
            }
            return toSend;
        }
        /// <summary>
        /// get the most cheap nannyies according to hour
        /// </summary>
        /// <returns></returns>
        public Nanny GetTheMostCheepH()
        {
            Nanny toSend = getNannyList().First();
            foreach (Nanny item in getNannyList())
            {
                if (item.PayHour < toSend.PayHour)
                    toSend = item;
            }
            return toSend;
        }
        /// <summary>
        /// get the most cheap nannyies according to Month
        /// </summary>
        /// <returns></returns>
        public Nanny GetTheMostCheepM()
        {
            Nanny toSend = getNannyList().First();
            foreach (Nanny item in getNannyList())
            {
                if (item.PayMonth < toSend.PayMonth)
                    toSend = item;
            }
            return toSend;
        }


        #endregion
    }
}