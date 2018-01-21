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
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Nanny nanny = bl.GetNanny(idComboBox.SelectedItem as string);
            Update.DataContext = nanny;
            checkSun.IsChecked = nanny.DayInWeek[0];
            checkMon.IsChecked = nanny.DayInWeek[1];
            checkTue.IsChecked = nanny.DayInWeek[2];
            checkWed.IsChecked = nanny.DayInWeek[3];
            checkThu.IsChecked = nanny.DayInWeek[4];
            checkFri.IsChecked = nanny.DayInWeek[5];
            /*if (nanny.DayInWeek[0])
            {
                nanny.WhenNeededWeek[0][0] = TimeSpan.Parse(startSun.Text);
                nanny.WhenNeededWeek[0][1] = TimeSpan.Parse(endSun.Text);
            }
            if (nanny.DayInWeek[1])
            {
                nanny.WhenNeededWeek[1][0] = TimeSpan.Parse(startMon.Text);
                nanny.WhenNeededWeek[1][1] = TimeSpan.Parse(endMon.Text);
            }
            if (nanny.DayInWeek[2])
            {
                nanny.WhenNeededWeek[2][0] = TimeSpan.Parse(startTue.Text);
                nanny.WhenNeededWeek[2][1] = TimeSpan.Parse(endTue.Text);
            }
            if (nanny.DayInWeek[3])
            {
                nanny.WhenNeededWeek[3][0] = TimeSpan.Parse(startWed.Text);
                nanny.WhenNeededWeek[3][1] = TimeSpan.Parse(endWed.Text);
            }
            if (nanny.DayInWeek[4])
            {
                nanny.WhenNeededWeek[4][0] = TimeSpan.Parse(startThu.Text);
                nanny.WhenNeededWeek[4][1] = TimeSpan.Parse(endThu.Text);
            }
            if (nanny.DayInWeek[5])
            {
                nanny.WhenNeededWeek[5][0] = TimeSpan.Parse(startFri.Text);
                nanny.WhenNeededWeek[5][1] = TimeSpan.Parse(endFri.Text);
            }*/
        }
    }
}
