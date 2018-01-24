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
using System.Threading;

namespace UL
{
    /// <summary>
    /// Interaction logic for Get_All_The_Contract_According_To_distance.xaml
    /// </summary>
    public partial class Get_All_The_Contract_According_To_distance : Window
    {
        IBL bl;
        public Get_All_The_Contract_According_To_distance()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Thread thread =new Thread( Print);
            thread.Start();
            
        }
        public void  Print()
        {
            IBL bl;
            IEnumerable<IGrouping<int, Contract>> printg;
            bl = BL.FactoryBL.GetBL();
            bool flag= ((string)((ComboBoxItem)(arranged.SelectedItem)).Content == "yes");
            if (flag)
                printg = bl.GetAllTheContractAccordingTodistance(true);
            else
                printg = bl.GetAllTheContractAccordingTodistance(false);
            Action< IEnumerable < IGrouping<int, Contract> >> action   = print1;
            Dispatcher.BeginInvoke(action,printg);
            Thread.Sleep(500);
            


        }
        public void print1(IEnumerable<IGrouping<int, Contract>> printg)
        {
            foreach (var v in printg)
            {
                text.Text += "kay" + v.Key.ToString() + '\n';
                foreach (var va in v)
                    text.Text += va.ToString() + '\n';
            }
            if (text.Text == "")
            {
                text.Text += "thare no contract";
            };
            
        }
    }
}
