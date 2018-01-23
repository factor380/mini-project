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
        Nanny nanny;
        IBL bl;
        public UpdateNanny()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Nanny n in bl.getNannyList())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = "id: " + n.Id + " name: " + n.Name + " last name: " + n.LastName;
                idComboBox.Items.Add(item);
            }
        }
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string id = (string)((ComboBoxItem)idComboBox.SelectedItem).Content;
            nanny = bl.GetNanny(id.Substring(4, 9));
            Update.DataContext = nanny;
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
                Nanny nanny = bl.GetNanny(idComboBox.SelectedItem as string);
                bl.UpdateNanny(nanny);
                nanny = new Nanny();
                this.Update.DataContext = nanny;
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
