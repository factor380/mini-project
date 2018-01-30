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
    /// Interaction logic for UpdateChild.xaml
    /// </summary>
    public partial class UpdateChild : Window
    {
        Child child;
        IBL bl;
        public UpdateChild()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            //enter all children id to comboBox
            idComboBox.ItemsSource = bl.getChildList();
            idComboBox.SelectedValuePath = "Id";
            idComboBox.DisplayMemberPath = "Data";

        }
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.idComboBox.SelectedItem is Child)
            {
                this.child = ((Child)this.idComboBox.SelectedItem).GetCopy();
                UPDATE.DataContext = child;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.UpdateChild(child);
                this.UPDATE.DataContext = child = null;
                this.idComboBox.ItemsSource = bl.getChildList();
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
