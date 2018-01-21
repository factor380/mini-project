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
    /// Interaction logic for AddChildWindow.xaml
    /// </summary>
    public partial class AddChildWindow : Window
    {
        Child child;
        IBL bl;
        public AddChildWindow()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            child = new Child();
            this.ChildDetails.DataContext = child;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.AddChild(child);
                child = new Child();
                this.ChildDetails.DataContext = child;
                this.Close();
            }
            catch(FormatException)
            {

            }
        }
    }
}
