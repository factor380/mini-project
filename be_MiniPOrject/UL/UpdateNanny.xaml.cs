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
    /// <summary>
    /// Interaction logic for UpdateNanny.xaml
    /// </summary>
    public partial class UpdateNanny : Window
    {
        IBL bl;
        public UpdateNanny()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Nanny n in bl.getNannyList())
            {
                idComboBox.Items.Add(n.Id);
            }
        }
    }
}
