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
    /// Interaction logic for nannies_close_to_mother.xaml
    /// </summary>
    public partial class nannies_close_to_mother : Window
    {
        IBL bl;
        public nannies_close_to_mother()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            
            foreach (Mother m in bl.getMotherList())
            {
                ComboBoxItem newItem = new ComboBoxItem();
                newItem.Content = m.Id;
                idMother.Items.Add(newItem);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Nanny> listN = new List<Nanny>();
            int dis=0;
            if(int.TryParse(distance.Text,out dis))
            {
                listN = bl.NanniesThatInDistanceWithMother(bl.GetMother((string)((ComboBoxItem)(idMother.SelectedItem)).Content), dis);//צריך להיות פה איפה שהוא תהליכון
                foreach(Nanny n in listN)
                {
                    text.Text += n.ToString() + '\n';
                }
            }
            else
                MessageBox.Show("check your input and try again");
        }
    }
}
