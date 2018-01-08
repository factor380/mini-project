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


    class BL_imp : IBL
    {
        DAL.IDAL dal;
        #region Nanny func

        public void AddNanny(Nanny n)
        {
            if (DateTime.Now.Year - n.DateBirth.Year < 18)
                throw new Exception("this Nanny is under 18");
            dal.AddNanny(n);
        }

        public void RemoveNanny(int id)
        {
            Contract c;
            Nanny n = GetNanny(id);
            foreach (int IdCo in n.ListIdContract)
            {
                c = dal.GetContract(IdCo);
                if (c.EndDate > DateTime.Now&&c.ActiveContract==true)
                    throw new Exception("Nanny have contract that she dont finish");
                RemoveContract(c.Contract_Num1);
               
            }
            dal.RemoveNanny(id);
        }

        public void UpdateNanny(Nanny n)
        {
            Nanny nan = GetNanny(n.Id);
            if (n.ListIdContract.Count() > nan.MaxChildren)
                throw new Exception("Nanny cant have more children");
            dal.UpdateNanny(n);
        }

        public Nanny GetNanny(int id)
        {
            return dal.GetNanny(id);
        }
        public List<Nanny> getNannyList() => dal.getNannyList();
        #endregion

        #region Child func

        public void AddChild(Child c)
        {
            dal.AddChild(c);
        }
        public void RemoveChild(int id)
        {
            Contract c;
            Child chi = GetChild(id);
            Mother m = GetMotherWithChildId(id);
            foreach (int IdCo in chi.ListIdContract)
            {
                c = dal.GetContract(IdCo);
                if (c.EndDate > DateTime.Now&&c.ActiveContract==true)
                    throw new Exception("Child have contract that he dont finish");
                RemoveContract(IdCo);
            }
            dal.RemoveChild(id);
                
       }
        public void UpdateChild(Child c)
        {
            dal.UpdateChild(c);
        }
        public Child GetChild(int id)
        {
            return dal.GetChild(id);
        }
        public List<Child> getChildList() => dal.getChildList();
        #endregion

        #region mother func
        public void AddMother(Mother m)
        {
            dal.AddMother(m);
        }
        public void RemoveMother(int id)
        {
            Mother m = GetMother(id);
            foreach (int Idc in m.ListIdChild)
            {
                RemoveChild(Idc);
            }
            dal.RemoveMother(id);
        }
        public void UpdateMother(Mother m)
        {
            dal.UpdateMother(m);
        }
        public Mother GetMother(int id)
        {
            return dal.GetMother(id);
        }
        public Mother GetMotherWithChildId(int id)
        {
            return dal.GetMotherWithChildId(id);
        }
        public List<Mother> getMotherList() => dal.getMotherList();
        #endregion

        #region Contract func
        public void AddContract(Contract c)
        {
            Child chi = GetChild(c.ChildId);
            Nanny nan = GetNanny(c.NannyId);
            Mother mom = GetMother(c.MotherId);
            int temp = 0;//if the nanny have more children from the mother they are rebate 
            if (DateTime.Today.Month - chi.DateBirth.Month < nan.MinAgeMonth)//תוקן
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if (DateTime.Now.Month - chi.DateBirth.Month > nan.MaxAgeMonth)
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if (nan.ListIdContract.Count == nan.MaxChildren)
            {
                throw new Exception("the nanny take care of max child that she can");
            }

            foreach (int idc in nan.ListIdContract)
            {
                Contract con = GetContract(idc);
                if (con.MotherId == mom.Id)
                    temp++;
            }
            if (c.HorM1 == false)//hour
            {
                if (nan.YorN_HourlyRate == false)
                    throw new Exception("the nanny dont agree to get a hour rate");
                c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                c.PayMonth = c.PayHours * nan.HowMuchHourNanWork1;
            }
            else//month
            {
                c.PayMonth = nan.PayMonth - ((nan.PayMonth * temp * 2) / 100);
                c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
            }
            dal.AddContract(c);
        }
        public void RemoveContract(int contract_Num)
        {
            Contract c = GetContract(contract_Num);
            if (DateTime.Now > c.EndDate&&c.ActiveContract==true)
                throw new Exception("this contract dont finish");
            Nanny nan = GetNanny(c.NannyId);
            nan.ListIdContract.Remove(contract_Num);
            UpdetRateOfContract(c.NannyId, c.MotherId);
            Child chi = GetChild(c.ChildId);
            chi.ListIdContract.Remove(c.Contract_Num1);
            dal.RemoveContract(contract_Num);
        }
        public void UpdateContract(Contract c)
        {
            Child chi = GetChild(c.ChildId);
            Nanny nan = GetNanny(c.NannyId);
            Mother mom = GetMother(c.MotherId);
            int temp = 0;//if the nanny have more children from the mother they are  rebate
            if (DateTime.Today.Month - chi.DateBirth.Month < nan.MinAgeMonth)//תוקן
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            if (DateTime.Now.Month - chi.DateBirth.Month > nan.MaxAgeMonth)
            {
                throw new Exception("the nanny can't get the age of the child");
            }

            foreach (int idc in nan.ListIdContract)
            {
                Contract con = GetContract(idc);
                if (con.MotherId == mom.Id)
                    temp++;
            }
            if (c.HorM1 == false)//hour
            {
                if (nan.YorN_HourlyRate == false)
                    throw new Exception("the nanny dont agree to get a hour rate");
                c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                c.PayMonth = c.PayHours * nan.HowMuchHourNanWork1;
            }
            else//month
            {
                c.PayMonth = nan.PayMonth - ((nan.PayMonth * temp * 2) / 100);
                c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
            }
            dal.UpdateContract(c);
        }

        public Contract GetContract(int contract_Num)
        {
            return dal.GetContract(contract_Num);
        }
        public void UpdetRateOfContract(int NanId, int MomId)
        {
            Nanny nan = GetNanny(NanId);
            int temp = 0;
            foreach (int idc in nan.ListIdContract)
            {
                Contract c = GetContract(idc);
                if (c.MotherId == MomId)
                {
                    if (c.HorM1 == false)//hour
                    {
                        c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                        c.PayMonth = c.PayHours * 4 * (nan.HowMuchHourNanWork1);
                    }
                    else//month
                    {
                        c.PayMonth = nan.PayMonth - ((nan.PayMonth * temp * 2) / 100);
                        c.PayHours = nan.PayHour - ((nan.PayHour * temp * 2) / 100);
                    }
                    temp++;
                }
            }
        }
        public List<Contract> getContractList() => dal.getContractList();
        #endregion


        #region all the func gropin and maps and lists

        //the func to get the Distance between points 
        public static int CalculateDistance(string PointA, string PointB)
        {
            var drivingDirectionRequest = new DirectionsRequest
            {
                TravelMode = TravelMode.Walking,
                Origin = PointA,
                Destination = PointB,
            };
            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
            Route route = drivingDirections.Routes.First();
            Leg leg = route.Legs.First();
            return leg.Distance.Value;
        }

        List<Nanny> NanniesThatFitMom(Mother mom)
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
                        if (nan.WorkHours[0, i] > mom.WhenNeededWeek[0, i] || nan.WorkHours[1, i] < mom.WhenNeededWeek[1, i])
                        {
                            ToSeeIfAllTheDaysGood = false;
                        }
                    }
                    if (ToSeeIfAllTheDaysGood == true)
                        listToSend.Add(nan);

                }

            }
            if (listToSend == null)
                throw new Exception("there not fits nannys to the mother request");//לא בטוח שצריך
            return listToSend;

        }
        //i decide to do what almost fit in days and our
        List<Nanny> NanniesThatAlsoFitMom(Mother mom)
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
                        if (mom.DayInWeek[i] == nan.DayInWeek[i])
                        {
                            if (nan.WorkHours[0, i] <= mom.WhenNeededWeek[0, i] || nan.WorkHours[1, i] >= mom.WhenNeededWeek[1, i])
                            {
                                count++;
                            }
                        }
                    }
                    if (count == 5 - m)
                        listToSend.Add(nan);

                    if (listToSend.Count == 5)
                        break;
                }
                if (listToSend.Count == 5)
                    break;
            }
            return listToSend;

        }

        List<Nanny> NanniesThatInDistanceWithMother(Mother mom,float distance)
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
                if (distance >= CalculateDistance(nan.Address, address))//לבדוק איזה מרחק מקבלים
                    listToSend.Add(nan);
            }
            return listToSend;
        }

        List<Child> GetAllTheChildrenThetDontHaveNannys()
        {
            List<Child> listC = getChildList();
            List<Child> listToSend = new List<Child>();

            foreach(Child chi in listC)
            {
                if (chi.ListIdContract == null)
                    listToSend.Add(chi);
            }
            return listToSend;
        }

        List<Nanny> GetAllTheNannysThatWorkWithDaysOOfTamat()
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

        List<Contract> GetAllContractThatFulfillingTheCondition(ContrafctCondition con)
        {
            List<Contract> listToSend = new List<Contract>();
            foreach(Contract c in getContractList())
            {
                if (con(c))
                    listToSend.Add(c);
            }
            return listToSend;
        }

        int GetAllNumberContractThatFulfillingTheCondition(ContrafctCondition con)
        {
            List<Contract> listContract = GetAllContractThatFulfillingTheCondition(con);

            return listContract.Count;
        }

        IEnumerable<IGrouping<int, Nanny>>  GetAllNannysAccordingToAgeChild(bool age=false, bool classified=false )
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
        IEnumerable<IGrouping<int, Contract>> GetAllTheContractAccordingTodistance(bool classified = false)
        {
            List<Contract> ListC = getContractList();
            if (classified==false)
            {
                IEnumerable<IGrouping<int, Contract>> result = from con in ListC
                                                               group con by CalculateDistance(GetMother(con.MotherId).AddressAround, GetNanny(con.NannyId).Address) / 1000;//אני לא בטוח מה מחזיר בהנחה שזה רגללים או משהו כזה זה יעשה שזה יהיה בערך
                return result;
            }
            else
            {
                IEnumerable<IGrouping<int, Contract>> result = from con in ListC
                                                               orderby con.Contract_Num1
                                                               group con by CalculateDistance(GetMother(con.MotherId).AddressAround, GetNanny(con.NannyId).Address) / 1000;//אני לא בטוח מה מחזיר בהנחה שזה רגללים או משהו כזה זה יעשה שזה יהיה בערך
                return result;

            }

        }
        #endregion
    }
}