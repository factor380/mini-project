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
    /// Interaction logic for contracts_that_almost_done.xaml
    /// </summary>
    public partial class contracts_that_almost_done : Window
    {
        IBL bl;
        public contracts_that_almost_done()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            IEnumerable<Contract> listC = bl.List_Contract_that_have_only_week_left();
            foreach(var con in listC)
            {
                text.Text += con.ToString() + '\n';
            }
            if (text.Text == "" && bl.getContractList().Count != 0)
                text.Text += "all the contract have more than week to finish";
            else if(bl.getContractList().Count == 0)
                text.Text += "thare is no contract";

        }
    }
}
