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
    /// Interaction logic for Nannies_that_fit_mom.xaml
    /// </summary>
    public partial class Nannies_that_fit_mom : Window
    {
        public Nannies_that_fit_mom()
        {
            InitializeComponent();
            IBL bl;

            bl = FactoryBL.GetBL();

            foreach (Mother m in bl.getMotherList())
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = m.Id;
                idMother.Items.Add(newItem);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IBL bl;
            bl = BL.FactoryBL.GetBL();
            List<Nanny> ListN = bl.NanniesThatAlsoFitMom(bl.GetMother((string)idMother.SelectedItem));

            foreach(Nanny v in ListN)
            {
                text.Text += v.ToString() + '\n';
            }
        }
    }
}
