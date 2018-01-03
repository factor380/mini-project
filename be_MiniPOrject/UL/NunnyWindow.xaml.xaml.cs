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
    /// Interaction logic for AddNunnyWindow.xaml
    /// </summary>
    public partial class AddNunnyWindow : Window
    {
        Nanny nanny;
        IBL bl;
        public AddNunnyWindow()
        {
            InitializeComponent();
            nanny = new Nanny();
            this.NannyDetails.DataContext = nanny;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddNanny(nanny);
                nanny = new Nanny();
                this.NannyDetails.DataContext = nanny;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
