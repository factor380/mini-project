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
    /// Interaction logic for contract_acoording_to_the_age_of_the_children.xaml
    /// </summary>
    public partial class Nannys_acoording_to_the_age_of_the_children : Window
    {
        public Nannys_acoording_to_the_age_of_the_children()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IBL bl;
            bl = FactoryBL.GetBL();
            IEnumerable<IGrouping<int, Nanny>> printg;
            if ((string)((ComboBoxItem)(age.SelectedItem)).Content == "MAX")
            {
                if ((string)((ComboBoxItem)(age.SelectedItem)).Content == "yes")
                    printg = bl.GetAllNannysAccordingToAgeChild(true, true);
                else
                    printg = bl.GetAllNannysAccordingToAgeChild(true, false);
            }
            else
            {
                if ((string)((ComboBoxItem)(age.SelectedItem)).Content == "yes")
                    printg = bl.GetAllNannysAccordingToAgeChild(false, true);
                else
                    printg = bl.GetAllNannysAccordingToAgeChild(false, false);
            }

            foreach(var v in printg)
            {
                text.Text+="age "+v.Key.ToString() +'\n';
                foreach (var va in v)
                    text.Text += va.ToString() + '\n';

                text.Text += '\n';
            }
            if(text.Text=="")
                text.Text="thare no nannys";
        }
    }
}
