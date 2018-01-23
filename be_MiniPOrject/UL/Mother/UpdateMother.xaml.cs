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
        private void idCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mother mother = bl.GetMother(idCombobox.SelectedItem as string);
            Update.DataContext = mother;
            checkSun.IsChecked = mother.DayInWeek[0];
            checkMon.IsChecked = mother.DayInWeek[1];
            checkTue.IsChecked = mother.DayInWeek[2];
            checkWed.IsChecked = mother.DayInWeek[3];
            checkThu.IsChecked = mother.DayInWeek[4];
            checkFri.IsChecked = mother.DayInWeek[5];
            if (mother.DayInWeek[0])
            {
                startSun.Value = new DateTime(mother.WhenNeededWeek[0][0].Ticks);
                endSun.Value = new DateTime(mother.WhenNeededWeek[0][1].Ticks);
            }
            if (mother.DayInWeek[1])
            {
                startMon.Value = new DateTime(mother.WhenNeededWeek[1][0].Ticks);
                endMon.Value = new DateTime(mother.WhenNeededWeek[1][1].Ticks);
            }
            if (mother.DayInWeek[2])
            {
                startTue.Value = new DateTime(mother.WhenNeededWeek[2][0].Ticks);
                endTue.Value = new DateTime(mother.WhenNeededWeek[2][1].Ticks);
            }
            if (mother.DayInWeek[3])
            {
                startWed.Value = new DateTime(mother.WhenNeededWeek[3][0].Ticks);
                endWed.Value = new DateTime(mother.WhenNeededWeek[3][1].Ticks);
            }
            if (mother.DayInWeek[4])
            {
                startThu.Value = new DateTime(mother.WhenNeededWeek[4][0].Ticks);
                endThu.Value = new DateTime(mother.WhenNeededWeek[4][1].Ticks);
            }
            if (mother.DayInWeek[5])
            {
                startFri.Value = new DateTime(mother.WhenNeededWeek[5][0].Ticks);
                endFri.Value = new DateTime(mother.WhenNeededWeek[5][1].Ticks);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Mother mother = bl.GetMother(idCombobox.SelectedItem as string);
                mother.DayInWeek[0] = checkSun.IsChecked.Value;
                mother.DayInWeek[1] = checkMon.IsChecked.Value;
                mother.DayInWeek[2] = checkTue.IsChecked.Value;
                mother.DayInWeek[3] = checkWed.IsChecked.Value;
                mother.DayInWeek[4] = checkThu.IsChecked.Value;
                mother.DayInWeek[5] = checkFri.IsChecked.Value;
                if (mother.DayInWeek[0])
                {
                    mother.WhenNeededWeek[0][0] = TimeSpan.Parse(startSun.Text);
                    mother.WhenNeededWeek[0][1] = TimeSpan.Parse(endSun.Text);
                }
                if (mother.DayInWeek[1])
                {
                    mother.WhenNeededWeek[1][0] = TimeSpan.Parse(startMon.Text);
                    mother.WhenNeededWeek[1][1] = TimeSpan.Parse(endMon.Text);
                }
                if (mother.DayInWeek[2])
                {
                    mother.WhenNeededWeek[2][0] = TimeSpan.Parse(startTue.Text);
                    mother.WhenNeededWeek[2][1] = TimeSpan.Parse(endTue.Text);
                }
                if (mother.DayInWeek[3])
                {
                    mother.WhenNeededWeek[3][0] = TimeSpan.Parse(startWed.Text);
                    mother.WhenNeededWeek[3][1] = TimeSpan.Parse(endWed.Text);
                }
                if (mother.DayInWeek[4])
                {
                    mother.WhenNeededWeek[4][0] = TimeSpan.Parse(startThu.Text);
                    mother.WhenNeededWeek[4][1] = TimeSpan.Parse(endThu.Text);
                }
                if (mother.DayInWeek[5])
                {
                    mother.WhenNeededWeek[5][0] = TimeSpan.Parse(startFri.Text);
                    mother.WhenNeededWeek[5][1] = TimeSpan.Parse(endFri.Text);
                }
                bl.UpdateMother(mother);
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
