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
    /// Interaction logic for Children_without_nannies.xaml
    /// </summary>
    public partial class Children_without_nannies : Window
    {
        IBL bl;
        public Children_without_nannies()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            List < Child > listC= bl.GetAllTheChildrenThetDontHaveNannys();
            foreach(Child c in listC)
            {
                text.Text += c.ToString() + '\n';
            }
            if (text.Text == "")
                text.Text += "all the children have nannies";
        }
    }
}
