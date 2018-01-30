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
    /// Interaction logic for number_of_under_certian_conditions.xaml
    /// </summary>
    public partial class number_of_under_certian_conditions : Window
    {
        IBL bl;
        public number_of_under_certian_conditions()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((string)((ComboBoxItem)(selectionCondition.SelectedItem)).Content)//if you need to enter number
            {
                case "pay in hour":
                    numHiden.Visibility = Visibility.Visible;

                    break;

                case "pay in month":
                    numHiden.Visibility = Visibility.Visible;
                    break;

                default:
                    numHiden.Visibility = Visibility.Hidden;
                    break;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
                text.Text = "";
            bl = BL.FactoryBL.GetBL();
            List<Contract> listC = new List<Contract>();
            int num;
            int print = 0;
            if (int.TryParse(numHiden.Text, out num) || numHiden.Visibility == Visibility.Hidden)//check what to print 
            {
                switch ((string)((ComboBoxItem)(selectionCondition.SelectedItem)).Content)
                {
                    case "met":
                        print = bl.GetAllNumberContractThatFulfillingTheCondition(item => item.Met == true);
                        break;

                    case "active contact":
                        print = bl.GetAllNumberContractThatFulfillingTheCondition(item => item.ActiveContract == true);
                        break;

                    case "hour or minute":
                        print = bl.GetAllNumberContractThatFulfillingTheCondition(item => item.HorM1 == true);
                        break;

                    case "pay in hour":
                        print = bl.GetAllNumberContractThatFulfillingTheCondition(item => item.PayHours == num);
                        break;

                    case "pay in month":
                        print = bl.GetAllNumberContractThatFulfillingTheCondition(item => item.PayMonth == num);
                        break;
                }
                text.Text += print.ToString();
            }
            else
                MessageBox.Show("check your input and try again");



        }
    }
}

