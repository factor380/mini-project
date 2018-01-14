using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BL
{
    public class Init
    {
        static Random r = new Random();
        public Init()
        {
            initilizeArray();
            NannyInitilize();
            MotherInitilize();
            ChildInitilize();
            ContractInitilize();
        }
        static IBL bl = FactoryBL.GetBL();//singelton

        /// <summary>
        /// Initilize & addtion to list 20 nannies
        /// </summary>
        void NannyInitilize()
        {
            Nanny Ayala_Zehavi = new Nanny
            {

                Id = 211358510,
                LastName = "zehavi",
                Name = "Ayala",
                DateBrith = new DateTime(1980, 5, 19),
                PhoneNum = "0523433333",
                Address = "Beit Ha-Defus St 21, Jerusalem",
                Elevator = true,
                FloorInBulding = 2,
                Exp = 3,
                MaxChildren = 8,
                MinAgeMonth = 3,
                MaxAgeMonth = 14,
                PerHour = true,
                PayHour = 10,
                PayMonth = 800,
                wh = new dayInWeek(new DayWork[]
                {
                    new DayWork(new Clock(7,15),new Clock(16,20)),
                    new DayWork(new Clock(7,45), new Clock(16,30)),
                    new DayWork(new Clock(7,50),new Clock(15,10)),
                    new DayWork(new Clock(8,30),new Clock(14,30)),
                    new DayWork(new Clock(8,30),new Clock(15,45)),
                    new DayWork(new Clock(),new Clock())
                }),
                DaysOff = false,
                Recommendations = "",
            };
            Nanny Moria_schneider = new Nanny
            {
                ID = idNannyArray[1],
                name = new Name("Moria", "schneider"),
                birthday = new DateTime(1980, 5, 19),
                address = "Shakhal St 15, Jerusalem",
                elevator = true,
                floor = 2,
                Expirence = 3,
                cellPhone = 0523433333,
                MaxAge = 14,
                MinAge = 3,
                MaxChildren = 8,
                PerHour = true,
                SallaryPerHour = 10,
                SallaryPerMonths = 800,
                DaysOff = false,
                wh = new WeeklyHours(new DayWork[]
                {
                    new DayWork(new Clock(7,0),new Clock(17,30)),
                    new DayWork(new Clock(7,00), new Clock(17,30)),
                    new DayWork(new Clock(7,0),new Clock(17,45)),
                    new DayWork(new Clock(7,0),new Clock(17,30)),
                    new DayWork(new Clock(7,0),new Clock(17,30)),
                    new DayWork(new Clock(),new Clock())
                }),
                Recommendations = "",
            };
            Nanny malki_fishman = new Nanny
            {
                //v
                ID = idNannyArray[2],
                name = new Name("malki", "fishman"),
                birthday = new DateTime(1992, 4, 9),
                address = "Bar Ilan St 15, Jerusalem",
                elevator = false,
                floor = 1,
                Expirence = 5,
                cellPhone = 0525633333,
                MaxAge = 17,
                MinAge = 1,
                MaxChildren = 7,
                PerHour = false,
                SallaryPerMonths = 1200,
                DaysOff = true,
                wh = new WeeklyHours(new DayWork[]
                {
                    new DayWork(new Clock(8,00),new Clock(16,45)),
                    new DayWork(new Clock(7,0), new Clock(17,30)),
                    new DayWork(new Clock(7,45),new Clock(16,15)),
                    new DayWork(new Clock(7,30),new Clock(15,30)),
                    new DayWork(new Clock(7,30),new Clock(15,45)),
                    new DayWork(new Clock(8,0),new Clock(12,0))
                }),
                Recommendations = "",
            };
            Nanny Elisheva_Shaked = new Nanny
            {
                ID = idNannyArray[3],
                name = new Name("Elisheva", "Shaked"),
                birthday = new DateTime(1990, 5, 29),
                address = "Amram Gaon St 15, Jerusalem",
                elevator = true,
                floor = 2,
                Expirence = 3,
                cellPhone = 0523433333,
                MaxAge = 14,
                MinAge = 3,
                MaxChildren = 8,
                PerHour = true,
                SallaryPerHour = 10,
                SallaryPerMonths = 800,
                DaysOff = false,
                wh = new WeeklyHours(new DayWork[]
                {
                    new DayWork(new Clock(7,30),new Clock(15,40)),
                    new DayWork(new Clock(7,20), new Clock(15,30)),
                    new DayWork(new Clock(7,50),new Clock(15,10)),
                    new DayWork(new Clock(7,40),new Clock(16,30)),
                    new DayWork(new Clock(7,30),new Clock(15,35)),
                    new DayWork(new Clock(),new Clock())
                }),
                Recommendations = "",
            };

            bl.AddNanny(malki_fishman);
            bl.AddNanny(Moria_schneider);
            bl.AddNanny(Ayala_Zehavi);
            bl.AddNanny(Elisheva_Shaked);
        }

        /// <summary>
        /// Initilize & addtion to list 21 Mothers
        /// </summary>
        void MotherInitilize()
        {

            Mother Bracha_Polak = new Mother
            {
                Id = 211840173,
                LastName = "Polak",
                Name = "Bracha",
                PhoneNum = "0526874352",
                Address = "HaRav Herzog St 12, Jerusalem",
                AddressAround = "Shakhal St 23,Jerusalem",
                wh = new WeeklyHours(new DayWork[]
                    {
                    new DayWork(new Clock(8,30),new Clock(16,30)),
                    new DayWork(new Clock(), new Clock()),
                    new DayWork(new Clock(8,0),new Clock(12,30)),
                    new DayWork(new Clock(),new Clock()),
                    new DayWork(new Clock(8,0),new Clock(13,30)),
                    new DayWork(new Clock(),new Clock())
                    }),
                Remarks = "",
            };
            Mother Oshrat_Levi = new Mother
            {
                Id = 213840173,
                LastName = "Levi",
                Name = "Oshrat",
                PhoneNum = "0526943451",
                Address = "Ha-'va'ad haleumi St 21,Jerusalem",
                AddressAround = "Shakhal St 23,Jerusalem",
                wh = new WeeklyHours(new DayWork[]
                {
                    new DayWork(new Clock(),new Clock()),
                    new DayWork(new Clock(9,0), new Clock(17,30)),
                    new DayWork(new Clock(8,0),new Clock(12,30)),
                    new DayWork(new Clock(8,0),new Clock(16,30)),
                    new DayWork(new Clock(8,0),new Clock(13,30)),
                    new DayWork(new Clock(8,0),new Clock(12,0))
                    }),
                Remarks = "",
            };
            Mother Ayelt_Shaked = new Mother
            {
                Id = 219045633,
                LastName = "Shaked",
                Name = "Ayelt",
                PhoneNum = "0521234566",
                Address = "Shakhal St 23,Jerusalem",
                AddressAround = "Shakhal St 23,Jerusalem",
                wh = new WeeklyHours(new DayWork[]
                 {
                    new DayWork(new Clock(8,0),new Clock(14,30)),
                    new DayWork(new Clock(8,0), new Clock(13,30)),
                    new DayWork(new Clock(8,0),new Clock(12,30)),
                    new DayWork(new Clock(8,0),new Clock(15,30)),
                    new DayWork(new Clock(8,0),new Clock(16,30)),
                    new DayWork(new Clock(),new Clock())
                    }),
                Remarks = "",
            };
            Mother Gilat_Benet = new Mother
            {
                Id = 213845633,
                LastName = "Benet",
                Name = "Gilat",
                PhoneNum = "0527668451",
                Address = "HaMem Gimel St 4, Jerusalem",
                AddressAround = "Shakhal St 23,Jerusalem",
                wh = new WeeklyHours(new DayWork[]
                  {
                    new DayWork(new Clock(8,0),new Clock(14,30)),
                    new DayWork(new Clock(8,0), new Clock(15,30)),
                    new DayWork(new Clock(8,0),new Clock(12,30)),
                    new DayWork(new Clock(8,0),new Clock(16,30)),
                    new DayWork(new Clock(7,45),new Clock(13,30)),
                    new DayWork(new Clock(),new Clock())
                    }),
                Remarks = "",
            };
            bl.AddMother(Bracha_Polak);
            bl.AddMother(Ayelt_Shaked);
            bl.AddMother(Oshrat_Levi);
            bl.AddMother(Gilat_Benet);
        }

        /// <summary>
        /// Initilize & addtion to list 30 Childs
        /// </summary>
        void ChildInitilize()
        {
            Child nadav = new Child
            {
                Id = 215790256,
                IdMother = 225718256,
                Name = "nadav",
                DateBirth = new DateTime(2017, 8, 26),
                SpecialNeeds = false,
                WhatHeNeed = "nothing",
            };
            Child moty = new Child
            {
                Id = 215718256,
                IdMother = 211318176,
                Name = "moty",
                DateBirth = new DateTime(2017, 9, 8),
                SpecialNeeds = false,
                WhatHeNeed = "nothing",
            };
            Child eti = new Child
            {
                Id = 211378256,
                IdMother = 211318256,
                Name = "eti",
                DateBirth = new DateTime(2017, 5, 29),
                SpecialNeeds = false,
                WhatHeNeed = "nothing",
            };
            Child miri = new Child
            {
                Id = 212378256,
                IdMother = 211378936,
                Name = "miri",
                DateBirth = new DateTime(2017, 1, 22),
                SpecialNeeds = false,
                WhatHeNeed = "nothing",
            };
            bl.AddChild(nadav);
            bl.AddChild(moty);
            bl.AddChild(miri);
            bl.AddChild(eti);
        }

        /// <summary>
        /// find nanny that suitable with Current mom
        /// </summary>
        int FindNanny(Mother mom)
        {
            if (bl.GetNanny().Exists(x => x.wh.Possible(mom.wh)))
                return bl.GetNanny().Find(x => x.wh.Possible(mom.wh)).ID;
            throw new Exception("sorry, no Nanny Exists to your needs");
        }

        /// <summary>
        /// Initilize & addtion to list of Contracts, Note! there are children that have no nanny
        /// </summary>
        void ContractInitilize()
        {
            Contract con;
            for (int i = 0; i < 4; i++)
            {

                Mother m = bl.GetMother().Find(x => x.id == bl.GetChild().Find(y => y.id == idChildArray[i]).idMother);
                try
                {
                    int Nannyid = FindNanny(m);
                    con = new Contract
                    {
                        idChild = idChildArray[i],
                        idNanny = Nannyid,
                        NameNanny = instance.getNanny().Find(x => x.ID == Nannyid).name,
                        IntroductoryMeeting = true,//if its not, addContract will change it
                        signed = true,
                        beginDeal = DateTime.Today,
                        endDeal = new DateTime(2108, 6, 25),
                    };
                    if (bl.AddContract(con))
                    //throw the nanny that get a child to the end of list, to distribute evenly
                    {
                        Nanny n = bl.GetNanny().Find(x => x.id == con.NannyId);
                        bl.RemoveNanny(con.NannyId);
                        bl.AddNanny(n);
                    }
                }
                catch (Exception)
                {
                    //Console.WriteLine(instance.getMother().Find(x => x.ID == instance.getChild().Find(y => y.ID == idChildArray[i]).idMother).name);
                    /* don't something*/
                }
            }
        }
    }
}