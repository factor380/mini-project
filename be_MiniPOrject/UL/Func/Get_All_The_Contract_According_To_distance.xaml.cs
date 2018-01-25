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
            if (text.Text != "")
                text.Text = "";
            Thread thread =new Thread( Print);
            thread.Start(((string)((ComboBoxItem)(arranged.SelectedItem)).Content == "yes"));
            
        }
        public void  Print(object flag)
        {
            IBL bl;
            IEnumerable<IGrouping<int, Contract>> printg;
            bl = BL.FactoryBL.GetBL();
            
            if ((bool)flag)
                printg = bl.GetAllTheContractAccordingTodistance(true);
            else
                printg = bl.GetAllTheContractAccordingTodistance(false);
            Action<string> action1 = print1;
            Action action2 = print2;
            foreach (var v in printg)
            {
                Dispatcher.BeginInvoke(action1, "distance " + v.Key.ToString() + '\n');
                
                foreach (var va in v)
                    Dispatcher.BeginInvoke(action1, va.ToString() + '\n');
            }
            Dispatcher.BeginInvoke(action2);
      
            


        }
        public void print1(string printToText)
        {
                text.Text +=printToText;
        }

        public void print2()
        {
            if (text.Text == "")
            {
                text.Text += "thare no contract";
            }
        }
    }
}
