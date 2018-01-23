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
    /// Interaction logic for RemoveMother.xaml
    /// </summary>
    public partial class RemoveMother : Window
    {
        IBL bl;
        public RemoveMother()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Mother m in bl.getMotherList())
            {
                idCombobox.Items.Add(m.Id);
            }
            this.Remove.DataContext = idCombobox.SelectedItem as string;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveMother(idCombobox.SelectedItem as string);
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
