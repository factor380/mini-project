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
    /// Interaction logic for Children_according_to_Mother.xaml
    /// </summary>
    public partial class Children_according_to_Mother : Window
    {
        IBL bl;
        public Children_according_to_Mother()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();

            idMother.ItemsSource = bl.getMotherList();
            idMother.SelectedValuePath = "Id";
            idMother.DisplayMemberPath = "Data";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
                text.Text = "";
            bl = FactoryBL.GetBL();
            List<Child> listC = bl.List_Child_ByMother(bl.GetMother(((Mother)(this.idMother.SelectedItem)).Id));
            text.Text += bl.GetMother(((Mother)(this.idMother.SelectedItem)).Id).ToString() + '\n';
            foreach (Child c in listC)
            {
                text.Text += c.ToString() + '\n';
            }
            if (text.Text == "")
                text.Text += "the mother dont have children";
        }
    }
}
