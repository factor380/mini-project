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
using System.Threading;

namespace UL
{
    /// <summary>
    /// Interaction logic for nannies_close_to_mother.xaml
    /// </summary>
    public partial class nannies_close_to_mother : Window
    {
        IBL bl;
        int dis = 0;
        public nannies_close_to_mother()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();

            idMother.ItemsSource = bl.getMotherList();//enter the id
            idMother.SelectedValuePath = "Id";
            idMother.DisplayMemberPath = "Data";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
                text.Text = "";
            Thread thread =new Thread( print);
            if (int.TryParse(distance.Text, out dis))
                thread.Start(((Mother)(this.idMother.SelectedItem)));
            else
                MessageBox.Show("check your input and try again");
        }
        public void print(object mom)
        {
            Action<string> action= print1;
            Action action1 = print2;
            List<Nanny> listN = new List<Nanny>();
            listN = bl.NanniesThatInDistanceWithMother(mom as Mother, dis);
            foreach (Nanny n in listN)
            {
                Dispatcher.BeginInvoke(action, n.ToString() + '\n') ;
            }

            Dispatcher.BeginInvoke(action1);



        }
        public void print1(string str)
        {
            text.Text += str;   
        }

        public void print2()
        {
            if (text.Text == "")
            {
                text.Text += "thare not nanny that close to mother";
            }
        }
    }
}
