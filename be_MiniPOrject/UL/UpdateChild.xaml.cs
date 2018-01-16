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
    /// Interaction logic for UpdateChild.xaml
    /// </summary>
    public partial class UpdateChild : Window
    {
        IBL bl;
        public UpdateChild()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Child c in bl.getChildList())
            {
                idComboBox.Items.Add(c.Id);
            }
        }
    }
}
