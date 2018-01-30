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
using BL;
using BE;

namespace UL
{
    /// <summary>
    /// Interaction logic for RemoveContract.xaml
    /// </summary>
    public partial class RemoveContract : Window
    {
        IBL bl;
        public RemoveContract()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            //enter all the contract number to comboBox
            contract_Num1ComboBox.ItemsSource = bl.getContractList();
            contract_Num1ComboBox.SelectedValuePath = "Contract_Num1";
            contract_Num1ComboBox.DisplayMemberPath = "Data";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveContract((int)(contract_Num1ComboBox.SelectedValue));
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("check your input and try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
