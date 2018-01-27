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
    /// Interaction logic for contract_under_certian_conditions.xaml
    /// </summary>
    public partial class contract_under_certian_conditions : Window
    {
        IBL bl;

        public contract_under_certian_conditions()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((string)((ComboBoxItem)(selectionCondition.SelectedItem)).Content)
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

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
                text.Text = "";
            bl = BL.FactoryBL.GetBL();
            List<Contract> listC=new List<Contract>();
            int num;
            if (int.TryParse(numHiden.Text, out num)|| numHiden.Visibility == Visibility.Hidden)
            {
                switch ((string)((ComboBoxItem)(selectionCondition.SelectedItem)).Content)
                {
                    case "met":
                        listC = bl.GetAllContractThatFulfillingTheCondition(item => item.Met == true);
                        break;

                    case "active contact":
                        listC = bl.GetAllContractThatFulfillingTheCondition(item => item.ActiveContract == true);
                        break;

                    case "hour or minute":
                        listC = bl.GetAllContractThatFulfillingTheCondition(item => item.HorM1 == true);
                        break;

                    case "pay in hour":
                        listC = bl.GetAllContractThatFulfillingTheCondition(item => item.PayHours == num);
                        break;

                    case "pay in month":
                        listC = bl.GetAllContractThatFulfillingTheCondition(item => item.PayMonth == num);
                        break;
                }
                foreach (Contract con in listC)
                {
                    text.Text += con.ToString() + '\n';

                }
            }
            else
                MessageBox.Show("check your input and try again");


        }
    }
}
