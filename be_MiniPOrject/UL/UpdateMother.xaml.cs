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
    /// Interaction logic for UpdateMother.xaml
    /// </summary>
    public partial class UpdateMother : Window
    {
        IBL bl;
        public UpdateMother()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Mother m in bl.getMotherList())
            {
                idCombobox.Items.Add(m.Id);
            }
        }
    }
}
