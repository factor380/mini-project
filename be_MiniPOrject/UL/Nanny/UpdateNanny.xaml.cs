using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Globalization;
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
        Nanny nanny;
        IBL bl;
        public UpdateNanny()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            nanny = new Nanny();
            idComboBox.ItemsSource = bl.getNannyList();
            idComboBox.SelectedValuePath = "Id";
            idComboBox.DisplayMemberPath = "Data";
        }
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.idComboBox.SelectedItem is Nanny)
            {
                this.nanny = ((Nanny)this.idComboBox.SelectedItem).GetCopy();
                Update.DataContext = nanny;
            }
            address.Text = nanny.Address;
            checkSun.IsChecked = nanny.DayInWeek[0];
            checkMon.IsChecked = nanny.DayInWeek[1];
            checkTue.IsChecked = nanny.DayInWeek[2];
            checkWed.IsChecked = nanny.DayInWeek[3];
            checkThu.IsChecked = nanny.DayInWeek[4];
            checkFri.IsChecked = nanny.DayInWeek[5];
           if (nanny.DayInWeek[0])
            {
                startSun.Value = new DateTime(nanny.WorkHours[0][0].Ticks);
                endSun.Value = new DateTime(nanny.WorkHours[0][1].Ticks);
            }
            if (nanny.DayInWeek[1])
            {
                startMon.Value = new DateTime(nanny.WorkHours[1][0].Ticks);
                endMon.Value = new DateTime(nanny.WorkHours[1][1].Ticks);
            }
            if (nanny.DayInWeek[2])
            {
                startTue.Value = new DateTime(nanny.WorkHours[2][0].Ticks);
                endTue.Value = new DateTime(nanny.WorkHours[2][1].Ticks);
            }
            if (nanny.DayInWeek[3])
            {
                startWed.Value = new DateTime(nanny.WorkHours[3][0].Ticks);
                endWed.Value = new DateTime(nanny.WorkHours[3][1].Ticks);
            }
            if (nanny.DayInWeek[4])
            {
                startThu.Value = new DateTime(nanny.WorkHours[4][0].Ticks);
                endThu.Value = new DateTime(nanny.WorkHours[4][1].Ticks);
            }
            if (nanny.DayInWeek[5])
            {
                startFri.Value = new DateTime(nanny.WorkHours[5][0].Ticks);
                endFri.Value = new DateTime(nanny.WorkHours[5][1].Ticks);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                 nanny.Address=address.Text ;
                nanny.DayInWeek[0] = checkSun.IsChecked.Value;
                nanny.DayInWeek[1] = checkMon.IsChecked.Value;
                nanny.DayInWeek[2] = checkTue.IsChecked.Value;
                nanny.DayInWeek[3] = checkWed.IsChecked.Value;
                nanny.DayInWeek[4] = checkThu.IsChecked.Value;
                nanny.DayInWeek[5] = checkFri.IsChecked.Value;
                if (nanny.DayInWeek[0])
                {
                    nanny.WorkHours[0][0] = TimeSpan.Parse(startSun.Text);
                    nanny.WorkHours[0][1] = TimeSpan.Parse(endSun.Text);
                }
                if (nanny.DayInWeek[1])
                {
                    nanny.WorkHours[1][0] = TimeSpan.Parse(startMon.Text);
                    nanny.WorkHours[1][1] = TimeSpan.Parse(endMon.Text);
                }
                if (nanny.DayInWeek[2])
                {
                    nanny.WorkHours[2][0] = TimeSpan.Parse(startTue.Text);
                    nanny.WorkHours[2][1] = TimeSpan.Parse(endTue.Text);
                }
                if (nanny.DayInWeek[3])
                {
                    nanny.WorkHours[3][0] = TimeSpan.Parse(startWed.Text);
                    nanny.WorkHours[3][1] = TimeSpan.Parse(endWed.Text);
                }
                if (nanny.DayInWeek[4])
                {
                    nanny.WorkHours[4][0] = TimeSpan.Parse(startThu.Text);
                    nanny.WorkHours[4][1] = TimeSpan.Parse(endThu.Text);
                }
                if (nanny.DayInWeek[5])
                {
                    nanny.WorkHours[5][0] = TimeSpan.Parse(startFri.Text);
                    nanny.WorkHours[5][1] = TimeSpan.Parse(endFri.Text);
                }
                bl.UpdateNanny(nanny);
                this.idComboBox.ItemsSource = bl.getNannyList();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("check your input and try again");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
