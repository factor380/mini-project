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
using UL.Func;

namespace UL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // Init init = new Init();
        }

        private void Button_Click_AddChild(object sender, RoutedEventArgs e)
        {
            Window addChildWindow = new AddChildWindow();
            addChildWindow.ShowDialog();
        }

        private void Button_Click_AddMother(object sender, RoutedEventArgs e)
        {
            Window addMotherWindow = new AddMotherWindow();
            addMotherWindow.ShowDialog();
        }

        private void Button_Click_AddNunny(object sender, RoutedEventArgs e)
        {
            Window addNunnyWindow = new AddNunnyWindow();
            addNunnyWindow.ShowDialog();
        }

        private void Button_Click_AddContract(object sender, RoutedEventArgs e)
        {
            Window addContractWindow = new AddContractWindow();
            addContractWindow.ShowDialog();
        }

        private void Button_Click_RemoveChild(object sender, RoutedEventArgs e)
        {
            Window removeChildWindow = new RemoveChild();
            removeChildWindow.ShowDialog();
        }

        private void Button_Click_RemoveMother(object sender, RoutedEventArgs e)
        {
            Window removeMotherWindow = new RemoveMother();
            removeMotherWindow.ShowDialog();
        }
        private void Button_Click_RemoveNanny(object sender, RoutedEventArgs e)
        {
            Window removeNannyWindow = new RemoveNanny();
            removeNannyWindow.ShowDialog();
        }
        private void Button_Click_RemoveContract(object sender, RoutedEventArgs e)
        {
            Window removeContractWindow = new RemoveContract();
            removeContractWindow.ShowDialog();
        }

        private void Button_Click_UpdateChild(object sender, RoutedEventArgs e)
        {
            Window UpdateChildWindow = new UpdateChild();
            UpdateChildWindow.ShowDialog();
        }

        private void Button_Click_UpdateMother(object sender, RoutedEventArgs e)
        {
            Window UpdateMotherWindow = new UpdateMother();
            UpdateMotherWindow.ShowDialog();
        }

        private void Button_Click_UpdateNanny(object sender, RoutedEventArgs e)
        {
            Window UpdateNannyWindow = new UpdateNanny();
            UpdateNannyWindow.ShowDialog();
        }

        private void Button_Click_UpdateContract(object sender, RoutedEventArgs e)
        {
            Window UpdateContractWindow = new UpdateContract();
            UpdateContractWindow.ShowDialog();
        }

        private void Button_Click_number_of_under_certian_conditions(object sender, RoutedEventArgs e)
        {
            number_of_under_certian_conditions secondWindow = new number_of_under_certian_conditions();
            secondWindow.ShowDialog();
        }

        private void Button_Click_Nannies_that_fit_mom(object sender, RoutedEventArgs e)
        {
            Nannies_that_fit_mom secondWindow = new Nannies_that_fit_mom();
            secondWindow.ShowDialog();
        }

        private void Button_Click_contract_under_certian_conditions(object sender, RoutedEventArgs e)
        {
            contract_under_certian_conditions secondWindow = new contract_under_certian_conditions();
            secondWindow.ShowDialog();
        }

        private void Button_Click_Nannys_acoording_to_the_age_of_the_children(object sender, RoutedEventArgs e)
        {
            Nannys_acoording_to_the_age_of_the_children secondWindow = new Nannys_acoording_to_the_age_of_the_children();
            secondWindow.ShowDialog();
        }

        private void Button_Click_nannies_close_to_mother(object sender, RoutedEventArgs e)
        {
            nannies_close_to_mother secondWindow = new nannies_close_to_mother();
            secondWindow.ShowDialog(); 
        }

        private void Button_Click_Get_All_The_Contract_According_To_distance(object sender, RoutedEventArgs e)
        {
            Get_All_The_Contract_According_To_distance secondWindow = new Get_All_The_Contract_According_To_distance();
            secondWindow.ShowDialog();
        }

        private void Button_Click_Children_without_nannies(object sender, RoutedEventArgs e)
        {
            Children_without_nannies secondWindow = new Children_without_nannies();
            secondWindow.ShowDialog();
        }

        private void Button_Click_Nannys_that_take_Holidays_Tamat(object sender, RoutedEventArgs e)
        {
            Nannys_that_take_Holidays_Tamat secondWindow = new Nannys_that_take_Holidays_Tamat();
            secondWindow.ShowDialog();
        }

        private void Button_Click_child_by_mothers(object sender, RoutedEventArgs e)
        {
            child_by_mothers secondWindow = new child_by_mothers();
            secondWindow.ShowDialog();
        }

        private void Button_Click_Children_according_to_Mother(object sender, RoutedEventArgs e)
        {
            Children_according_to_Mother secondWindow = new Children_according_to_Mother();
            secondWindow.ShowDialog();
        }

        private void Button_Click_contracts_that_almost_done(object sender, RoutedEventArgs e)
        {
            contracts_that_almost_done secondWindow = new contracts_that_almost_done();
            secondWindow.ShowDialog();
        }

        private void Button_Click_Nannies_that_almost_fit_mom(object sender, RoutedEventArgs e)
        {
            Nannies_that_almost_fit_mom secondWindow = new Nannies_that_almost_fit_mom();
            secondWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window printChildWindow = new print_all_child();
            printChildWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window printMotherWindow = new print_all_mother();
            printMotherWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window printNannyWindow = new print_all_nanny();
            printNannyWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window printContractWindow = new print_all_contract();
            printContractWindow.Show();
        }
    }
}
