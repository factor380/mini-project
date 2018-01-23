using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BE;
using BL;

namespace UL
{
    /// <summary>
    /// Interaction logic for Nannys_that_take_Holidays_Tamat.xaml
    /// </summary>
    public partial class Nannys_that_take_Holidays_Tamat : Window
    {
        IBL bl;
        public Nannys_that_take_Holidays_Tamat()
        {
            InitializeComponent();
            
            
                InitializeComponent();
                bl = BL.FactoryBL.GetBL();
                List<Nanny> listN = bl.GetAllTheNannysThatWorkWithDaysOOfTamat();
                foreach (Nanny n in listN)
                {
                    text.Text += n.ToString() + '\n';
                }
                if (text.Text == "")
                    text.Text += "all the nannies work with Ministry of Education holiday";
            
        }
    }
}
