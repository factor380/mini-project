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
    ///<summary>
    /// Interaction logic for RemoveChild.xaml
    ///</summary>
public partial class RemoveChild : Window
    {
        IBL bl;
        public RemoveChild()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();

            idComboBox.ItemsSource = bl.getChildList();
            idComboBox.SelectedValuePath = "Id";
            idComboBox.DisplayMemberPath = "Data";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveChild(idComboBox.SelectedValue as string);
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