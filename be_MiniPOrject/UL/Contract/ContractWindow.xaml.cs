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
    /// Interaction logic for AddContractWindow.xaml
    /// </summary>
    public partial class AddContractWindow : Window
    {
        Contract contract;
        IBL bl;
        public AddContractWindow()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            contract = new Contract();
            this.ContractDetails.DataContext = contract;
            endDateDatePicker.SelectedDate = DateTime.Today;
            startDateDatePicker.SelectedDate = DateTime.Today;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddContract(contract);
                contract = new Contract();
                this.ContractDetails.DataContext = contract;
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
