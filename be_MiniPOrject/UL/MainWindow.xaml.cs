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

        private void NunnyButton_Click(object sender, RoutedEventArgs e)
        {
            Window addNunnyWindow = new AddNunnyWindow();
            addNunnyWindow.Show();
        }

        private void MotherButton_Click(object sender, RoutedEventArgs e)
        {
            Window addMotherWindow = new AddMotherWindow();
            addMotherWindow.Show();
        }

        private void ChildButton_Click(object sender, RoutedEventArgs e)
        {
            Window addChildWindow = new AddChildWindow();
            addChildWindow.Show();
        }

        private void ContractButton_Click(object sender, RoutedEventArgs e)
        {
            Window addContractWindow = new AddContractWindow();
            addContractWindow.Show();
        }
    }
}
