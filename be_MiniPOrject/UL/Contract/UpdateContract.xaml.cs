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
    /// Interaction logic for UpdateContract.xaml
    /// </summary>
    public partial class UpdateContract : Window
    {
        IBL bl;
        Contract contract;
        public UpdateContract()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            contract = new Contract();
            contract_Num1ComboBox.ItemsSource = bl.getContractList();
            contract_Num1ComboBox.SelectedValuePath = "Contract_Num1";
            contract_Num1ComboBox.DisplayMemberPath = "Data";
        }
        private void contract_Num1ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.contract_Num1ComboBox.SelectedItem is Contract)
            {
                this.contract = ((Contract)this.contract_Num1ComboBox.SelectedItem).GetCopy();
                Update.DataContext = contract;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.UpdateContract(contract);
                this.Update.DataContext = contract = null;
                this.contract_Num1ComboBox.ItemsSource = bl.getChildList();
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
