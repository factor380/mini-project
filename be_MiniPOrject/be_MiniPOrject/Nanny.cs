using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Nanny
    {
        private readonly int id;
        private string lastName;
        private string name;
        private readonly DateTime dateBirth;
        private string phoneNum;
        private string address;
        private bool elevator;
        private int floorInBulding;
        private int exp;
        private int maxChildren;
        private int minAgeMonth;
        private int maxAgeMonth;
        private bool perHour;//if he Agrees to hour rate
        private float payHour;
        private int payMonth;
        private bool[] dayInWeek = new bool[6];
        private TimeSpan[][] workHours = new TimeSpan[6][];
        private bool daysOOf;//if false the holidey Ministry of Education if true in tamat
        private string recommendations;
        private TimeSpan HowMuchHourNanWork;
        public List<int> ListIdContract;//List that save all the Contract ID that the nanny hava

        public Nanny()
        {
            for (int i = 0; i < 6; i++)
            {
                workHours[i] = new TimeSpan[2];
            }
        }
        public Nanny(int id, string lastName, string name, DateTime dateBirth, string phoneNum, string address, bool elevator, int floorInBulding, int exp, int maxChildren, int minAgeMonth, int maxAgeMonth, bool perHour, float payHour, int payMonth, bool[] dayInWeek, TimeSpan[][] workHours, bool daysOOf, string recommendations)
        {
            if (id >= 100000000 && id <= 999999999)
                this.id = id;
            else
                throw new Exception("this input not make sense");
            this.lastName = lastName;
            this.name = name;
            if (dateBirth < DateTime.Now)
                this.dateBirth = dateBirth;
            else
                throw new Exception("this time is not in the past");
            this.phoneNum = phoneNum;
            this.address = address;
            this.elevator = elevator;
            this.floorInBulding = floorInBulding;
            this.exp = exp;
            this.maxChildren = maxChildren;
            this.minAgeMonth = minAgeMonth;
            this.maxAgeMonth = maxAgeMonth;
            this.perHour = perHour;
            this.payHour = payHour;
            this.payMonth = payMonth;
            this.dayInWeek = dayInWeek;
            this.workHours = workHours;
            this.daysOOf = daysOOf;
            this.recommendations = recommendations;
            HowMuchHourNanWork = TimeSpan.Parse("00:00");
            for (int i = 0; i < 6; ++i)
            {
                if (DayInWeek[i])
                HowMuchHourNanWork += WorkHours[i][1] - WorkHours[i][0];
            }
        }

        public int Id { get => id; }
        public string LastName
        {
            get => lastName;
            set
            {
                if (value[0] > 'Z' || value[0] < 'A')
                    throw new Exception("this input is not make sense");
                for (int i = 1; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a')
                        throw new Exception("this input is not make sense");
                lastName = value;
            }
        }
        public string Name
        {
            get => name;
            set
            {
                if (value[0] > 'Z' || value[0] < 'A')
                    throw new Exception("this input is not make sense");
                for (int i = 1; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a')
                        throw new Exception("this input is not make sense");
                name = value;
            }
        }
        public DateTime DateBirth { get => dateBirth; }
        public string PhoneNum
        {
            get => phoneNum;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] > '9' || value[i] < '0')
                        throw new Exception("this input is not make sense");
                phoneNum = value;
            }
        }
        public string Address
        {
            get => address;
            set
            {
                for (int i = 0; i < value.Length; i++)
                    if (value[i] > 'z' || value[i] < 'a' && value[i] != ',' && value[i] != ' ') 
                        throw new Exception("this input is not make sense");
                address = value;
            }
        }
        public bool Elevator { get => elevator; set => elevator = value; }
        public int FloorInBulding { get => floorInBulding; set => floorInBulding = value; }
        public int Exp
        {
            get => exp;
            set
            {
                if (value > (DateTime.Now.Year - dateBirth.Year - 18))
                    throw new Exception("this input is not make sense");
                exp = value;
            }
        }
        public int MaxChildren
        {
            get => maxChildren;
            set
            {
                if (value < 1)
                    throw new Exception("this input is not make sense");
                maxChildren = value;
            }
        }
        public int MinAgeMonth
        {
            get => minAgeMonth;
            set
            {

                if (value < 3)
                    throw new Exception("this input is not make sense");
                minAgeMonth = value;
            }
        }
        public int MaxAgeMonth
        {
            get => maxAgeMonth;
            set
            {
                if (value < minAgeMonth)
                    throw new Exception("this input is not make sense");
                maxAgeMonth = value;
            }
        }
        public bool PerHour { get => perHour; set => perHour = value; }
        public float PayHour { get => payHour; set => payHour = value; }
        public int PayMonth
        {
            get => payMonth;
            set
            {
                if (value < 0)
                    throw new Exception("the input not make sense");
                payMonth = value;
            }
        }
        public bool[] DayInWeek { get => dayInWeek; set => dayInWeek = value; }
        public TimeSpan[][] WorkHours
        {
            get => workHours;
            set
            {
                if (value.GetLength(0) != 6)
                    throw new Exception("the number of days not correct");
                workHours = value;
            }
        }
        public bool DaysOOf { get => daysOOf; set => daysOOf = value; }
        public string Recommendations { get => recommendations; set => recommendations = value; }
        public float HowMuchHourNanWork1{ get => HowMuchHourNanWork1; set => HowMuchHourNanWork1 = value; }
        public override string ToString()
        {
            return name + ' ' + LastName + " id " + id + " phone number " + PhoneNum + " address " + Address;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;


namespace pl
{

    class Program
    {
        //instance of bl
        private static IBL bl;
        /// <summary>
        /// main function for operating the program
        /// runs a loop with choices to manage the different parts of the program
        /// in addition, it gets an instance of bl and makes bli the  instance
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Init init = new Init();
            bool wantsToLeave = false;
            bl = FactoryBL.GetBL();
            do
            {

                Console.WriteLine("choose option:\n" +
                    "1)manage mothers\n" +
                    "2)manage nannies\n" +
                    "3)manage children\n" +
                    "4)manage contracts\n" +
                    "0)exit program");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        manageMothers();
                        break;
                    case 2:
                        manageNannies();
                        break;
                    case 3:
                        manageChildren();
                        break;
                    case 4:
                        manageContracts();
                        break;
                    case 0:
                        wantsToLeave = true;
                        break;
                    default:
                        Console.WriteLine("error while entering data, please try again\n");
                        break;
                }
            } while (!wantsToLeave);
        }
        /// <summary>
        /// function for managing mothers
        /// allows to add,update,remove, print all, print one, find all children of mother,
        /// find closest and best fits(nannies),
        /// runs a loop in order to allow repeating in case of bad input
        /// </summary>
        private static void manageMothers()
        {
            //boolean parameter to know if there is a need to continue the loop
            bool loop;
            do
            {
                loop = false;
                Console.WriteLine("1) add mother\n" +
                    "2) remove mother by id\n" +
                    "3) update mother\n" +
                    "4) print all mothers\n" +
                    "5) find children of mother by id\n" +
                    "6) find the 5 closest fits for the mother\n" +
                    "7) find the best fit for the mother\n" +
                    "8) find all the nannies within a certain range of the mother\n" +
                    "9) print a specific mother");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addMother();
                        break;
                    case 2:
                        //removing a mother
                        Console.WriteLine("please input id number to remove");
                        int id = Int32.Parse(Console.ReadLine());
                        try
                        {
                            bl.RemoveMother(id);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        updateMother();
                        break;
                    case 4:
                        printMothers();
                        break;
                    case 5:
                        //finding all children of a mother
                        Console.WriteLine("enter id of mother that you want to know all her children:");
                        int idOfMother = Int32.Parse(Console.ReadLine()); ;
                        bl.List_Child_ByMother(bl.GetMother(idOfMother));
                        break;
                    case 6:
                        //finding 5 closest fits to the mother's needs
                        closestFit();
                        break;
                    case 7:
                        //finding the best fits for the mother
                        bestFit();
                        break;
                    case 8:
                        //find all the nannies within a certain range of the mother
                        InRange();
                        break;
                    case 9:
                        //print a specific mother
                        printMother();
                        break;
                    default:
                        //there was an error while entering the data, so we repeat the loop
                        loop = true;
                        Console.WriteLine("error while entering data, please try again\n");
                        break;
                }
            } while (loop);
        }
        /// <summary>
        /// function for updating a mother
        /// asks for an id, finds the mother with that id
        /// then asks which fields the user wants to change
        /// </summary>
        private static void updateMother()
        {
            Console.WriteLine("id of the mother to update:");
            int id = Int32.Parse(Console.ReadLine());
            int choice;
            BE.Mother mother = bl.GetMother(id);
            do
            {
                Console.WriteLine("which field do you want to change:\n" +
                    "1)first name\n" +
                    "2)last name\n" +
                    "3)phone number\n" +
                    "4)home address\n" +
                    "5)address mother is looking for nanny\n" +
                    "6)work days\n" +
                    "7)work hours\n" +
                    "8)comments\n" +
                    "9)exit and update");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //updating first name
                        Console.WriteLine("enter new first name:");
                        try
                        {
                            mother.Name = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 2:
                        //updating last name
                        Console.WriteLine("enter new last name:");
                        try
                        {
                            mother.LastName = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 3:
                        //updating the phone number
                        Console.WriteLine("enter new phone number:");
                        try
                        {
                            mother.PhoneNum = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 4:
                        //updating the home address
                        Console.WriteLine("enter new home address:");
                        try
                        {
                            mother.Address = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 5:
                        //updating the address the mother is looking for
                        Console.WriteLine("enter new address the mother is looking for:");
                        try
                        {
                            mother.AddressAround = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 6:
                        //updating the days the mother works at
                        Console.WriteLine("enter yes if the mother is working in this day and no if not");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(i);
                            string help = Console.ReadLine();
                            if (help == "yes")
                                mother.DayInWeek[i] = true;
                            if (help == "no")
                                mother.DayInWeek[i] = false;
                            else
                            {
                                Console.WriteLine("error while entering data, please try again");
                                return;
                            }

                        }
                        break;
                    case 7:
                        //updates the times the mother is looking for
                        Console.WriteLine("please enter mother's starting  hour and minute and finishing  hour and minute in each day");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(i);
                            mother.WhenNeededWeek[0][i] = TimeSpan.Parse(Console.ReadLine());

                            Console.WriteLine("now finishing hour and minute");
                            mother.WhenNeededWeek[1][i] = TimeSpan.Parse(Console.ReadLine());

                        }
                        break;
                    case 8:
                        //updating the comments 
                        Console.WriteLine("do you want to add or replace the comments?(yes or no)");
                        bool choiceOfComments = (Console.ReadLine()) == "yes";
                        if (choiceOfComments)
                            mother.Remarks += '\n' + Console.ReadLine();
                        else
                            mother.Remarks = Console.ReadLine();
                        break;
                    case 9:
                        //exiting
                        break;
                    default:
                        Console.WriteLine("invalid input, please try again");
                        break;
                }
            } while (choice != 9);
            //adds the updated mother to the data
            bl.UpdateMother(mother);
        }
        /// <summary>
        /// function for managing the nannies
        /// allows to add,update, remove, print all,print all nannies that work with TMT,
        /// grouping the nannies by age,and printing a single nanny
        /// </summary>
        private static void manageNannies()
        {
            bool loop;
            do
            {
                loop = false;
                Console.WriteLine("1) add nanny\n" +
                    "2) remone nanny by id\n" +
                    "3) update nanny\n" +
                    "4)print all nannies\n" +
                    "5) print all nannies by accepted children age group\n" +
                    "6) print a specific nanny");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addNanny();
                        break;
                    case 2:
                        //removing a nanny
                        Console.WriteLine("please input id number to remove");
                        int id = Int32.Parse(Console.ReadLine());
                        try
                        {
                            bl.RemoveNanny(id);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        //updating a nanny
                        updateNanny();
                        break;
                    case 4:
                        //printing all nannies
                        printNannies();
                        break;

                    case 5:
                        //groups nannies by age
                        NannyByAge();
                        break;
                    case 6:
                        //prints a specific nanny
                        printNanny();
                        break;
                    default:
                        loop = true;
                        Console.WriteLine("error while entering data, please try again\n");
                        break;
                }
            } while (loop);
        }
        /// <summary>
        /// function for adding a nanny
        /// all inputs are in a do while loop to allow re-entering of data, because the nanny is big and prone to errors while inputing 
        /// </summary>
        private static void addNanny()
        {
            bool repeat = false;
            string id;
            DateTime birthDate = new DateTime();
            BE.Nanny nanny;
            //id of the nanny
            do
            {
                Console.WriteLine("enter nanny id:");
                id = Console.ReadLine();
            } while (repeat);
            //birth date of the nanny
            do
            {
                repeat = false;
                Console.WriteLine("enter birth date(years,months,day):");

                birthDate = DateTime.Parse(Console.ReadLine());
            } while (repeat);

            //first name of the nanny

            Console.WriteLine("please enter first name:");
            string Name = Console.ReadLine();


            //last name of the nanny

            repeat = false;
            Console.WriteLine("please enter last name");

            string LastName = Console.ReadLine();


            //phone number of nanny


            Console.WriteLine("please enter phone number:");


            string PhoneNum = Console.ReadLine();



            //home address of the nanny


            string Address = Console.ReadLine();



            //is there an elevator in the building of the nanny
            bool elevator = false;
            do
            {

                Console.WriteLine("is there an elevator in the building?(yes or no)");

                switch (Console.ReadLine())
                {
                    case "yes":
                        elevator = true;
                        break;
                    case "no":
                        elevator = false;
                        break;
                    default:
                        repeat = true;
                        Console.WriteLine("invalid data, please try again");
                        break;
                }
            } while (repeat);
            //the floor the nanny lives at

            Console.WriteLine("please enter floor in the building:");

            int FloorInBulding = Int32.Parse(Console.ReadLine());



            //the years of expreince of the nanny

            Console.WriteLine("please enter years of exprience:");

            int Exp = Int32.Parse(Console.ReadLine());



            //maximum amount of children nanny can have

            Console.WriteLine("please enter maximum amount of children possible for the nanny:");

            int MaxChildren = Int32.Parse(Console.ReadLine());



            //the maximum age the nanny can accept

            Console.WriteLine("please enter max age of children acccepted:");

            int MaxAgeMonth = Int32.Parse(Console.ReadLine());



            //the minimum age of the children the nanny can accept

            Console.WriteLine("please enter minimum age of children acccepted:");

            int MinAgeMonth = Int32.Parse(Console.ReadLine());


            //whether the nanny is paid per hour

            Console.WriteLine("is the nanny paid per hour?(yes or no)");
            bool PerHour = false;
            switch (Console.ReadLine())
            {
                case "yes":

                    PerHour = true;
                    break;
                case "no":
                    PerHour = false;
                    break;
                default:
                    repeat = true;
                    Console.WriteLine("invalid data, please try again");
                    break;
            }

            //we take both monthly and hourly because the nanny can be updated afterwards and change whether she works with hourly or monthly
            //hourly salary for the nanny

            Console.WriteLine("please enter hourly wage:");

            float PayHour = float.Parse(Console.ReadLine());


            //monthly salary for the nanny


            Console.WriteLine("please enter monthly salary:");

            int PayMonth = Int32.Parse(Console.ReadLine());


            //the days the nanny works
            bool[] DayInWeek = new bool[6];
            do
            {
                repeat = false;
                Console.WriteLine("enter yes if the nanny is working in this day and no if not\n");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(i);
                    string help = Console.ReadLine();
                    if (help == "yes")
                        DayInWeek[i] = true;
                    if (help == "no")
                        DayInWeek[i] = false;
                    else
                    {
                        repeat = true;
                        Console.WriteLine("error while entering data, please try again\n");
                    }
                }
            } while (repeat);
            //the times of the day the nanny works
            TimeSpan[][] WorkHours = new TimeSpan[6][];
            for (int i = 0; i < 6; i++)
            {
                WorkHours[i] = new TimeSpan[2];
            }
            do
            {
                repeat = false;
                Console.WriteLine("please enter nanny's starting work hour and minute and finishing work hour and minute in each day\n");
                for (int i = 0; i < 6; i++)
                {
                    try
                    {
                        Console.WriteLine(i);
                        WorkHours[i][0] = TimeSpan.Parse(Console.ReadLine());

                        Console.WriteLine("now finishing hour and minute");
                        WorkHours[i][1] = TimeSpan.Parse(Console.ReadLine());

                    }
                    //if the input wasn't good, the user puts in the day again
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        i--;
                    }
                }
            } while (repeat);
            String Recommendations;

            //recomendations of the nanny

            repeat = false;
            Console.WriteLine("please enter recomendations:");

            Recommendations = Console.ReadLine();


            Console.WriteLine("please enter holiday yes to education no tmt:");
            bool hol = true;
            switch (Console.ReadLine())
            {
                case "yes":

                    hol = true;
                    break;
                case "no":
                    hol = false;
                    break;
                default:
                    repeat = true;
                    Console.WriteLine("invalid data, please try again");
                    break;
            }

            nanny = new Nanny(Convert.ToInt32(id), LastName, Name, birthDate, PhoneNum, Address, elevator, FloorInBulding, Exp, MaxChildren, MinAgeMonth, MaxAgeMonth, PerHour, PayHour, PayMonth, DayInWeek, WorkHours, hol, Recommendations);
        }
        /// <summary>
        /// function for updating nanny
        /// asks for an id, finds the nanny with that id
        /// then asks which fields the user wants to change
        /// </summary>
        private static void updateNanny()
        {

            Console.WriteLine("id of the nanny to update:\n");
            string id = Console.ReadLine();
            int choice;
            //finds the nanny with the id
            BE.Nanny nanny = bl.GetNanny(Convert.ToInt32(id));
            do
            {
                Console.WriteLine("which field do you want to change:\n" +
                    "1)first name\n" +
                    "2)last name\n" +
                    "3)phone number\n" +
                    "4)home address\n" +
                    "5)is there a elevator\n" +
                    "6)work days\n" +
                    "7)work hours\n" +
                    "8)recomendations\n" +
                    "9)what floor the nanny lives at\n" +
                    "10)years of experience\n" +
                    "11)maximum amount of children\n" +
                    "12)minimum age of child\n" +
                    "13)maximum age of children\n" +
                    "14)if she is payed per hour\n" +
                    "15)change her pay per hour16" +
                    ")change nanny pay per month\n" +
                    "17)change if nanny works with TMT\n" +
                    "0)exit and update");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //updating first name
                        Console.WriteLine("enter new first name:\n");
                        try
                        {
                            nanny.Name = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 2:
                        //updating last name
                        Console.WriteLine("enter new last name:\n");
                        try
                        {
                            nanny.LastName = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 3:
                        //updating phone number
                        Console.WriteLine("enter new phone number:\n");
                        try
                        {
                            nanny.PhoneNum = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 4:
                        //updating address
                        Console.WriteLine("enter new address:\n");
                        try
                        {
                            nanny.Address = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 5:
                        //updating whether the building has a elevator
                        Console.WriteLine("is there an elevator?(yes or no)");
                        try
                        {
                            switch (Console.ReadLine())
                            {
                                case "yes":
                                    nanny.Elevator = true;
                                    break;
                                case "no":
                                    nanny.Elevator = false;
                                    break;
                                default:
                                    Console.WriteLine("invalid data, please try again");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 6:
                        //updates the days the nanny works
                        Console.WriteLine("enter yes if the nanny is working in this day and no if not\n");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(i);
                            string help = Console.ReadLine();
                            if (help == "yes")
                                nanny.DayInWeek[i] = true;
                            if (help == "no")
                                nanny.DayInWeek[i] = false;
                            else
                            {
                                Console.WriteLine("error while entering data, please try again\n");
                                return;
                            }
                        }
                        break;
                    case 7:
                        //updates the hours the nanny works at 
                        Console.WriteLine("please enter nanny's starting work hour and minute and finishing work hour and minute in each day\n");
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine(getDay(i));
                            nanny.WorkHours[i][0] = TimeSpan.Parse(Console.ReadLine());

                            Console.WriteLine("now finishing hour and minute");
                            nanny.WorkHours[i][1] = TimeSpan.Parse(Console.ReadLine());

                        }
                        break;
                    case 8:
                        //updating the recomendations
                        Console.WriteLine("do you want to add or replace the recomendations?(yes or no)\n");
                        bool choiceOfComments = (Console.ReadLine()) == "yes";
                        if (choiceOfComments)
                            nanny.Recommendations += '\n' + Console.ReadLine();
                        else
                            nanny.Recommendations = Console.ReadLine();
                        break;
                    case 9:
                        //updating the floor the nanny lives in
                        Console.WriteLine("what floor does the nanny live at(in numbers):");
                        try
                        {
                            nanny.FloorInBulding = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 10:
                        //updating the years of experience the nanny has
                        Console.WriteLine("enter years of experience:");
                        try
                        {
                            nanny.Exp = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 11:
                        //updating the maximum amount of children the nanny can have
                        Console.WriteLine("enter new maximum children for the nanny");
                        try
                        {
                            nanny.MaxAgeMonth = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 12:
                        //updating the minimum amount of children the nanny can have
                        Console.WriteLine("enter minimum age of children:");
                        try
                        {
                            nanny.MinAgeMonth = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 13:
                        //updating the maximum age of children the nanny can have
                        Console.WriteLine("enter maximum age of children:");
                        try
                        {
                            nanny.MaxAgeMonth = Int32.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 14:
                        //updating whether the nanny is paid per hour
                        Console.WriteLine("is the nanny paid per hour?(yes or no)");
                        try
                        {
                            switch (Console.ReadLine())
                            {
                                case "yes":
                                    nanny.PerHour = true;
                                    break;
                                case "no":
                                    nanny.PerHour = false;
                                    break;
                                default:
                                    Console.WriteLine("invalid data, please try again");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 15:
                        Console.WriteLine("new pay per hour:");
                        try
                        {
                            nanny.PayHour = float.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 16:
                        Console.WriteLine("new pay per month:");
                        try
                        {
                            nanny.PayMonth = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    default:
                        Console.WriteLine("invalid input, please try again\n");
                        break;
                }
            } while (choice != 0);
            bl.UpdateNanny(nanny);
        }

        private static void manageChildren()
        {
            bool loop;
            do
            {
                loop = false;
                Console.WriteLine("1) add child\n2) remone child by id\n3) update child\n4)print all children\n5) find all children without nannies\n6) print a specific child");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addChild();
                        break;
                    case 2:
                        Console.WriteLine("please input id number to remove\n");
                        int id = Int32.Parse(Console.ReadLine());
                        try
                        {
                            bl.RemoveChild(id);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        updateChild();
                        break;
                    case 4:
                        printChildren();
                        break;
                    case 5:
                        noNanny();
                        break;
                    case 6:
                        printChild();
                        break;
                    default:
                        loop = true;
                        Console.WriteLine("error while entering data, please try again\n");
                        break;
                }
            } while (loop);
        }

        private static void updateChild()
        {
            Console.WriteLine("id of the child to update:\n");
            string id = Console.ReadLine();
            int choice;
            BE.Child child = bl.GetChild(Convert.ToInt32(id));
            do
            {
                Console.WriteLine("which field do you want to change:\n1)first name\n2)special needs\n3)exit and update");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter new first name:\n");
                        try
                        {
                            child.Name = Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.Write(e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Does the child have special needs? (y/n)");
                        string s = Console.ReadLine();
                        switch (s)
                        {
                            case "y":
                                Console.WriteLine("Please describe the child's special needs\n");
                                string needs = Console.ReadLine();
                                child.SpecialNeeds = true;
                                child.WhatHeNeed = needs;
                                break;
                            case "n":
                                child.SpecialNeeds = false;
                                break;
                            default:
                                Console.WriteLine("Invalid input.");
                                break;
                        }
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("invalid input, please try again\n");
                        break;
                }
            } while (choice != 3);
            bl.UpdateChild(child);
        }

        private static void manageContracts()
        {
            bool loop = false;
            do
            {
                loop = false;
                Console.WriteLine("1) add contract\n2) remone contract by number of contract\n3) update contract\n4)print all contracts\n5) get the distance between the mother and the nanny in a certain contract\n6) group contracts by the distance between the mother and the nanny\n7) print a specific contract\n");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addContract();
                        break;
                    case 2:
                        Console.WriteLine("please input number of contract to remove\n");
                        int num = Int32.Parse(Console.ReadLine());
                        try
                        {
                            bl.RemoveContract(num);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        updateContract();
                        break;
                    case 4:
                        printContracts();
                        break;
                    case 5:
                        distanceByContract();
                        break;
                    case 6:
                        contractByDistance();
                        break;
                    case 7:
                        printContract();
                        break;
                    default:
                        loop = true;
                        Console.WriteLine("error while entering data, please try again\n");
                        break;
                }
            } while (loop);
        }

        private static void updateContract()
        {

            Console.WriteLine("number of the contract to update:\n");
            string numberOfContracts = Console.ReadLine();
            int choice;
            string help;
            BE.Contract contract = bl.GetContract(Convert.ToInt32(numberOfContracts));
            do
            {
                Console.WriteLine("which field do you want to change:\n1)was there an intro meeting\n2)is the pay per hour\n3)date of start\n4)date of end\n5)exit and update");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {


                    case 1:
                        Console.WriteLine("is the pay per hour?(yes or no)\n");
                        help = Console.ReadLine();
                        try
                        {
                            if (help == "yes" || help == "Yes")
                                contract.HorM1 = true;
                            else
                                contract.HorM1 = false;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("enter date of start of contract:(year,month,day)\n");
                        try
                        {
                            contract.StartDate = DateTime.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        Console.WriteLine("enter date od end of contract:(year,month,day)\n");
                        try
                        {
                            contract.EndDate = DateTime.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("invalid input, please try again\n");
                        break;

                }
            } while (choice != 5);
            bl.UpdateContract(contract);
        }

        private static void addContract()
        {
            string nannyID, MotherID, ChildID;
            bool introMeeting, signContract;
            DateTime start, end;
            Console.WriteLine("enter nanny id:\n");
            nannyID = Console.ReadLine();
            Console.WriteLine("enter mother id:\n");
            MotherID = Console.ReadLine();
            Console.WriteLine("enter child id:\n");
            ChildID = Console.ReadLine();
            Console.WriteLine("enter date of start of contract:(year,month,day)\n");
            string help = Console.ReadLine();
            start = DateTime.Parse(help);
            Console.WriteLine("enter date of finish of contract:(year,month,day)\n");
            end = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("was there a first meeting?(yes or no)\n");
            help = Console.ReadLine();
            if (help == "yes" || help == "Yes")
                introMeeting = true;
            else
                introMeeting = false;
            Console.WriteLine("is the contract signed?(yes or no)\n");
            help = Console.ReadLine();
            if (help == "yes" || help == "Yes")
                signContract = true;
            else
                signContract = false;
            bl.AddContract(new BE.Contract(Contract.ContractNum1, Convert.ToInt32(nannyID), Convert.ToInt32(MotherID), Convert.ToInt32(ChildID), introMeeting, signContract, 0, 0, false, start, end));

        }

        private static void addMother()
        {
            string id, lastName, firstName, phoneNum, address, lookAddress, comments;
            bool[] workDays = new bool[6];
            TimeSpan[][] workHours = new TimeSpan[6][];
            for (int i = 0; i < 6; i++)
            {
                workHours[i] = new TimeSpan[2];
            }
            Console.WriteLine("please enter mother's id");
            id = Console.ReadLine();
            Console.WriteLine("please enter mother's last name");
            lastName = Console.ReadLine();
            Console.WriteLine("please enter mother's first name");
            firstName = Console.ReadLine();
            Console.WriteLine("please enter mother's phone number");
            phoneNum = Console.ReadLine();
            Console.WriteLine("please enter mother's address");
            address = Console.ReadLine();
            Console.WriteLine("please enter the address the mother is looking for nanny");
            lookAddress = Console.ReadLine();
            Console.WriteLine("enter any comments in one line");
            comments = Console.ReadLine();
            Console.WriteLine("enter yes if the mother is working in this day and no if not");
            string help;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(getDay(i));
                help = Console.ReadLine();
                if (help == "yes")
                    workDays[i] = true;
                else if (help == "no")
                    workDays[i] = false;
                else
                {
                    Console.WriteLine("error while entering data, please try again");
                    return;
                }
            }
            Console.WriteLine("please enter mother's starting work hour and minute and finishing work hour and minute in each day");
            for (int i = 0; i < workDays.Length; i++)
            {
                if (workDays[i])
                {
                    Console.WriteLine(getDay(i));
                    workHours[i][0] = TimeSpan.Parse(Console.ReadLine());
                    Console.WriteLine("now finishing hour and minute");
                    workHours[i][1] = TimeSpan.Parse(Console.ReadLine());
                }
            }
            try
            {
                bl.AddMother(new BE.Mother(Convert.ToInt32(id), lastName, firstName, phoneNum, address, lookAddress, workDays, workHours, comments));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static string getDay(int numOfDay)
        {
            switch (numOfDay)
            {
                case 0:
                    return "sunday:";
                case 1:
                    return "monday:";
                case 2:
                    return "tuesday:";
                case 3:
                    return "wednesday:";
                case 4:
                    return "thursday:";
                case 5:
                    return "friday:";
                default:
                    return "/0";
            }
        }

        private static void addChild()
        {
            bool loop = true;
            string childId, motherId;
            DateTime birthDate;
            BE.Child ch = new BE.Child();
            while (loop) //Initial child constructor
            {
                loop = false;

                Console.WriteLine("Please enter the child's ID, the mother's ID and the date of birth (year, month, day): ");
                childId = Console.ReadLine();
                motherId = Console.ReadLine();
                string year = Console.ReadLine();
                string month = Console.ReadLine();
                string day = Console.ReadLine();
                try
                {
                    birthDate = new DateTime(Int32.Parse(year), Int32.Parse(month), Int32.Parse(day));
                    ch = new BE.Child(Convert.ToInt32(childId), Convert.ToInt32(motherId), "chack", birthDate, false, "nothing");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please try again.\n");
                    loop = true;
                }
            }
            loop = true;
            while (loop) //Update name
            {
                loop = false;
                Console.WriteLine("Please enter the child's first name: ");
                string fName = Console.ReadLine();
                try
                {
                    ch.Name = fName;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    loop = true;
                }
            }
            loop = true;
            while (loop) //Special needs
            {
                Console.WriteLine("Does the child have special needs? (y\n)");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "y":
                        loop = false;
                        Console.WriteLine("Please describe the child's special needs: ");
                        string needs = Console.ReadLine();
                        ch.SpecialNeeds = true;
                        ch.WhatHeNeed = needs;
                        break;
                    case "n":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
            try
            {
                bl.AddChild(ch);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine("Child was added succesfully.\n");
        }

        private static void printMothers()
        {
            Console.WriteLine("The mothers in the Database currently:\n");
            foreach (BE.Mother mom in bl.getMotherList())
            {
                Console.WriteLine(mom);
                Console.WriteLine("\n");
            }
        }

        private static void printChildren()
        {
            Console.WriteLine("The children in the Database currently:\n");
            foreach (BE.Child ch in bl.getChildList())
            {
                Console.WriteLine(ch);
                Console.WriteLine("\n");
            }
        }

        private static void printNannies()
        {
            Console.WriteLine("The nannies in the Database currently:\n");
            foreach (BE.Nanny nan in bl.getNannyList())
            {
                Console.WriteLine(nan);
                Console.WriteLine("\n");
            }
        }

        private static void printContracts()
        {
            Console.WriteLine("The contracts in the Database currently:\n");
            foreach (BE.Contract ct in bl.getContractList())
            {
                Console.WriteLine(ct);
                Console.WriteLine("\n");
            }
        }

        private static void printMother()
        {
            Console.WriteLine("Enter the ID of the mother: ");
            string id = Console.ReadLine();
            BE.Mother mom = bl.GetMother(Convert.ToInt32(id));
            if (mom == null)
                Console.WriteLine("Mother not found");
            else
            {
                Console.WriteLine(mom);
            }
        }

        private static void printChild()
        {
            Console.WriteLine("Enter the ID of the child: ");
            int id = Int32.Parse(Console.ReadLine());
            BE.Child ch = bl.GetChild(id);
            if (ch == null)
                Console.WriteLine("Child not found");
            else
            {
                Console.WriteLine(ch);
                Console.WriteLine("\n");
            }
        }

        private static void printNanny()
        {
            Console.WriteLine("Enter the ID of the nanny: ");
            int id = Int32.Parse(Console.ReadLine());
            BE.Nanny nan = bl.GetNanny(id);
            if (nan == null)
                Console.WriteLine("Nanny not found");
            else
            {
                Console.WriteLine(nan);
                Console.WriteLine("\n");
            }
        }

        private static void printContract()
        {
            Console.WriteLine("Enter the contract number: ");
            int num = Int32.Parse(Console.ReadLine());
            BE.Contract ct = bl.GetContract(num);
            if (ct == null)
                Console.WriteLine("Contract not found");
            else
            {
                Console.WriteLine(ct);
                Console.WriteLine("\n");
            }
        }

        private static void distanceByContract()
        {
            Console.WriteLine("Enter the number of the contract: ");
            int num = Int32.Parse(Console.ReadLine());
            BE.Contract ct = bl.GetContract(num);
            if (ct == null)
                Console.WriteLine("Contract not found\n");
            else
                Console.WriteLine("The distance between the nanny and the mother in the contract is %", BL_imp.CalculateDistance(bl.GetNanny(ct.NannyId).Address, bl.GetMother(ct.MotherId).AddressAround));
        }

        private static void contractByDistance()
        {
            Console.WriteLine("Do you want the list sorted? (y/n): ");
            string s = "";
            while (s != "y" && s != "n")
            {
                s = Console.ReadLine();
                switch (s)
                {
                    case "y":
                        Console.WriteLine(bl.GetAllTheContractAccordingTodistance(true));
                        break;
                    case "n":
                        Console.WriteLine(bl.GetAllTheContractAccordingTodistance(false));
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.\n");
                        break;
                }
            }
        }

        private static void closestFit()
        {
            Console.WriteLine("Enter the mother's ID: ");
            int id = Int32.Parse(Console.ReadLine());
            BE.Mother mom = bl.GetMother(id);
            if (mom == null)
                Console.WriteLine("Mother not found");
            else
            {
                List<Nanny> nannies = bl.NanniesThatAlsoFitMom(mom);
                foreach (Nanny n in nannies)
                {
                    Console.WriteLine(n);
                }
            }
        }

        private static void bestFit()
        {
            Console.WriteLine("Enter the mother's ID: ");
            int id = Int32.Parse(Console.ReadLine());
            BE.Mother mom = bl.GetMother(id);
            if (mom == null)
                Console.WriteLine("Mother not found");
            else
            {
                List<Nanny> nannies = bl.NanniesThatFitMom(mom);
                foreach (Nanny n in nannies)
                {
                    Console.WriteLine(n);
                }
            }
        }

        private static void InRange()
        {
            Console.WriteLine("Enter the mother's ID: ");
            int id = Int32.Parse(Console.ReadLine());
            BE.Mother mom = bl.GetMother(id);
            if (mom == null)
                Console.WriteLine("Mother not found");
            else
            {
                Console.WriteLine("Enter the range you wish to search in: ");
                int r = -1;
                while (r < 0)
                {
                    r = Int32.Parse(Console.ReadLine());
                    if (r < 0)
                        Console.WriteLine("Invalid range.");
                    else
                        Console.WriteLine(bl.NanniesThatInDistanceWithMother(mom, r));
                }
            }
        }

        private static void noNanny()
        {
            foreach (BE.Child ch in bl.GetAllTheChildrenThetDontHaveNannys())
                Console.WriteLine(ch);
        }

        private static void NannyByAge()
        {
            Console.WriteLine("Do you want to group by Max or Min age? (max/min): ");
            string group = "";
            string sort = "";
            while (group != "max" && group != "min")
            {
                group = Console.ReadLine();
                switch (group)
                {
                    case "min":
                        Console.WriteLine("Do you want the list sorted? (y/n): ");
                        while (sort != "y" && sort != "n")
                        {
                            sort = Console.ReadLine();
                            switch (sort)
                            {
                                case "y":
                                    bl.GetAllNannysAccordingToAgeChild(false, true).ToString();
                                    break;
                                case "n":
                                    bl.GetAllNannysAccordingToAgeChild(false, false).ToString();
                                    break;
                                default:
                                    Console.WriteLine("Invalid input. Please try again.\n");
                                    break;
                            }
                        }
                        break;
                    case "max":
                        Console.WriteLine("Do you want the list sorted? (y/n): ");
                        while (sort != "y" && sort != "n")
                        {
                            sort = Console.ReadLine();
                            switch (sort)
                            {
                                case "y":
                                    bl.GetAllNannysAccordingToAgeChild(true, true).ToString();
                                    break;
                                case "n":
                                    bl.GetAllNannysAccordingToAgeChild(true, false).ToString();
                                    break;
                                default:
                                    Console.WriteLine("Invalid input. Please try again.\n");
                                    break;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.\n");
                        break;
                }
            }
        }
    }
}

