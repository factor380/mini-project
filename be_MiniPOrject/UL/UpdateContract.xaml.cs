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
        public UpdateContract()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Contract c in bl.getContractList())
            {
                contract_Num1ComboBox.Items.Add(c.Contract_Num1);
            }
        }

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            //Contract contract = bl.GetContract(int.Parse(contract_Num1ComboBox.SelectedValue));
            //Update.DataContext = contract;
        }
    }
}
