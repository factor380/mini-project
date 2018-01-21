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
            Remove.DataContext = int.Parse(contract_NumTextBox.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveContract(int.Parse(contract_NumTextBox.Text));
                Remove.DataContext = null;
            }
            catch (FormatException)
            {

            }
        }
    }
}
