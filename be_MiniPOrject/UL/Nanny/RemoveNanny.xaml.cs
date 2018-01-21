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
    /// Interaction logic for RemoveNanny.xaml
    /// </summary>
    public partial class RemoveNanny : Window
    {
        IBL bl;
        public RemoveNanny()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            this.Remove.DataContext = idTextBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveNanny(idTextBox.Text);
                Remove.DataContext = null;
            }
            catch (FormatException)
            {

            }
        }
    }
}
