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
            NannyInitilize();
            MotherInitilize();
            ChildInitilize();
            ContractInitilize();
        }
        static IBL bl = FactoryBL.GetBL();//singelton

        /// <summary>
        /// Initilize & addtion to list 2 nannies
        /// </summary>
        void NannyInitilize()
        {
            TimeSpan[][] secondHoursN = new TimeSpan[6][] {
                new TimeSpan[2] { TimeSpan.Parse("9:00"), TimeSpan.Parse("16:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:30"), TimeSpan.Parse("17:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:00"), TimeSpan.Parse("18:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:30"), TimeSpan.Parse("18:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:00"), TimeSpan.Parse("18:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:00"), TimeSpan.Parse("12:00") } };
            TimeSpan[][] firstTimeSpanN = new TimeSpan[6][] {
            new TimeSpan[2] { TimeSpan.Parse("9:00"), TimeSpan.Parse("16:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:30"),TimeSpan.Parse("17:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:00"), TimeSpan.Parse("18:00")}
            , new TimeSpan[2] {TimeSpan.Parse("9:30"), TimeSpan.Parse("18:00") }
            , new TimeSpan[2] {TimeSpan.Parse("9:00"), TimeSpan.Parse("18:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:00"),TimeSpan.Parse("12:00") } };
            Nanny Ayala_Zehavi = new Nanny("211358510", "zehavi", "Ayala", new DateTime(1980, 5, 19), "0523433333", "Beit Ha-Defus St 21, Jerusalem", true, 2, 3, 8, 3, 14, true, 10, 800, new bool[] { true, false, false, true, false, true }, secondHoursN, false, "");
            Nanny Moria_schneider = new Nanny("211739859", "schneider", "Moria", new DateTime(1980, 5, 19), "0523433333", "Shakhal St 15, Jerusalem", true, 2, 3, 14, 3, 8, true, 10, 800, new bool[] { false, false, true, true, false, true }, firstTimeSpanN, false, "");
            bl.AddNanny(Moria_schneider);
            bl.AddNanny(Ayala_Zehavi);
        }
        /// <summary>
        /// Initilize & addtion to list 2 Mothers
        /// </summary>
        void MotherInitilize()
        {
            TimeSpan[][] FTimeSpanMother = new TimeSpan[6][] {
            new TimeSpan[2] { TimeSpan.Parse("8:30"), TimeSpan.Parse("14:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:30"),TimeSpan.Parse("15:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:30"), TimeSpan.Parse("17:00")}
            , new TimeSpan[2] {TimeSpan.Parse("8:30"), TimeSpan.Parse("13:00") }
            , new TimeSpan[2] {TimeSpan.Parse("8:30"), TimeSpan.Parse("14:00") }
            , new TimeSpan[2] { TimeSpan.Parse("8:00"),TimeSpan.Parse("12:00") } };
            TimeSpan[][] STimeSpanMother = new TimeSpan[6][] {
            new TimeSpan[2] { TimeSpan.Parse("9:30"), TimeSpan.Parse("13:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:30"),TimeSpan.Parse("16:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:30"), TimeSpan.Parse("16:00")}
            , new TimeSpan[2] {TimeSpan.Parse("9:30"), TimeSpan.Parse("16:00") }
            , new TimeSpan[2] {TimeSpan.Parse("9:30"), TimeSpan.Parse("15:00") }
            , new TimeSpan[2] { TimeSpan.Parse("9:00"),TimeSpan.Parse("12:00") } };
            Mother Bracha_Polak = new Mother("211318175", "Polak", "Bracha", "0526874352", "HaRav Herzog St 12, Jerusalem", "Shakhal St 23,Jerusalem", new bool[] { true, false, false, true, false, true }, FTimeSpanMother, "");
            Mother Oshrat_Levi = new Mother("213840176", "Levi", "Oshrat", "0526943451", "Ha-'va'ad haleumi St 21,Jerusalem", "Shakhal St 23,Jerusalem", new bool[] { true, false, false, true, true, false }, STimeSpanMother, "");
            bl.AddMother(Bracha_Polak);
            bl.AddMother(Oshrat_Levi);
        }

        /// <summary>
        /// Initilize & addtion to list 4 Childs
        /// </summary>
        void ChildInitilize()
        {
            Child nadav = new Child("215790254", "213840176", "nadav", new DateTime(2017, 8, 26), false, "nothing");
            Child moty = new Child("215718255", "211318175", "moty", new DateTime(2017, 9, 8), false, "nothing");
            Child eti = new Child("211378252", "211318175", "eti", new DateTime(2017, 5, 29), false, "nothing");
            Child miri = new Child("212378251", "213840176", "miri", new DateTime(2017, 1, 22), false, "nothing");
            bl.AddChild(nadav);
            bl.AddChild(moty);
            bl.AddChild(miri);
            bl.AddChild(eti);
        }
        /// <summary>
        /// Initilize & addtion to list of Contracts, Note! there are children that have no nanny
        /// </summary>
        void ContractInitilize()
        {
            bl.AddContract(new Contract(Contract.ContractNum1, "211358510", "211318175", "215790254", true, true, 10, 800, false, DateTime.Today, new DateTime(2018, 5, 19)));
        }
    }
}