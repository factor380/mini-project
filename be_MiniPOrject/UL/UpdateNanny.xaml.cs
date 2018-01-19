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

        private void Find_Click(object sender, RoutedEventArgs e)
        {
            Nanny nanny = bl.GetNanny(idComboBox.SelectionBoxItem as string);
            Update.DataContext = nanny;
            checkSun.IsChecked = nanny.DayInWeek[0];
            checkMon.IsChecked = nanny.DayInWeek[1];
            checkTue.IsChecked = nanny.DayInWeek[2];
            checkWed.IsChecked = nanny.DayInWeek[3];
            checkThu.IsChecked = nanny.DayInWeek[4];
            checkFri.IsChecked = nanny.DayInWeek[5];
            //this.startSun.Value.Value.TimeOfDay = nanny.WorkHours[0][0];
        }
    }
}
