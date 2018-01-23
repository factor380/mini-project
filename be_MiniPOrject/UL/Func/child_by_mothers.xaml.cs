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

namespace UL.Func
{
    /// <summary>
    /// Interaction logic for child_by_mothers.xaml
    /// </summary>
    public partial class child_by_mothers : Window
    {
        IBL bl;
        public child_by_mothers()
        {
                InitializeComponent();
                bl = BL.FactoryBL.GetBL();
            IEnumerable<IGrouping<string, Child>> printg = bl.List_Child_ByMother();
                foreach (var  str in printg)
                {
                    text.Text += "Mother "+ str.ToString() + '\n';
                     foreach (var c in str)
                    text.Text += c.ToString() + '\n';

            }
                if (text.Text == "")
                    text.Text += "thare no children in the program";
        }
    }
}
