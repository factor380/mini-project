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
using Xceed.Wpf.Toolkit;

namespace UL
{
    /// <summary>
    /// Interaction logic for AddMotherWindow.xaml
    /// </summary>
    public partial class AddMotherWindow : Window
    {
        Mother mother;
        IBL bl;
        public AddMotherWindow()
        {
            InitializeComponent();
            mother = new Mother();
            this.MotherDetails.DataContext = mother;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddMother(mother);
                mother = new Mother();
                this.MotherDetails.DataContext = mother;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
