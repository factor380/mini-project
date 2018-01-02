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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BL;
using BE;

namespace UL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IBL bl;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_AddChild(object sender, RoutedEventArgs e)
        {
            Window addChildWindow = new AddChildWindow();
            addChildWindow.Show();
        }

        private void Button_Click_AddMother(object sender, RoutedEventArgs e)
        {
            Window addMotherWindow = new AddMotherWindow();
            addMotherWindow.Show();
        }

        private void Button_Click_AddNunny(object sender, RoutedEventArgs e)
        {
            Window addNunnyWindow = new AddNunnyWindow();
            addNunnyWindow.Show();
        }

        private void Button_Click_AddContract(object sender, RoutedEventArgs e)
        {
            Window addContractWindow = new AddContractWindow();
            addContractWindow.Show();
        }

        private void Button_Click_RemoveChild(object sender, RoutedEventArgs e)
        {
            Window removeChildWindow = new RemoveChild();
            removeChildWindow.Show();
        }

        private void Button_Click_RemoveMother(object sender, RoutedEventArgs e)
        {
            Window removeMotherWindow = new RemoveMother();
            removeMotherWindow.Show();
        }
        private void Button_Click_RemoveNanny(object sender, RoutedEventArgs e)
        {
            Window removeNannyWindow = new RemoveNanny();
            removeNannyWindow.Show();
        }
        private void Button_Click_RemoveContract(object sender, RoutedEventArgs e)
        {
            Window removeContractWindow = new RemoveContract();
            removeContractWindow.Show();
        }
    }
}
