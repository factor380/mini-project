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
    /// Interaction logic for Get_All_The_Contract_According_To_distance.xaml
    /// </summary>
    public partial class Get_All_The_Contract_According_To_distance : Window
    {
        public Get_All_The_Contract_According_To_distance()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IBL bl;
            IEnumerable<IGrouping<int, Contract>> printg;
            bl = BL.FactoryBL.GetBL();

            if ((string)arranged.SelectedItem == "yes")
                printg = bl.GetAllTheContractAccordingTodistance(true);
            else
                printg = bl.GetAllTheContractAccordingTodistance(false);

            foreach (var v in printg)
            {
                text.Text += "kay" + v.Key.ToString() + '\n';
                foreach (var va in v)
                    text.Text += va.ToString() + '\n';
            }
            if(text.Text=="")
            {
                text.Text += "thare no contract";
            }
        }
    }
}
