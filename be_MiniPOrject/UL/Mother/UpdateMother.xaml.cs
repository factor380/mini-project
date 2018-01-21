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
                //mother.WhenNeededWeek[0][0] = this.startSun.Value.Value.TimeOfDay;
                //endSun.Value.Value.TimeOfDay = mother.WhenNeededWeek[0][1];
                startMon.TimeInterval = mother.WhenNeededWeek[1][0];
            endMon.TimeInterval = mother.WhenNeededWeek[1][1];
            startTue.TimeInterval = mother.WhenNeededWeek[2][0];
            endTue.TimeInterval = mother.WhenNeededWeek[2][1];
            startWed.TimeInterval = mother.WhenNeededWeek[3][0];
            endWed.TimeInterval = mother.WhenNeededWeek[3][1];
            startThu.TimeInterval = mother.WhenNeededWeek[4][0];
            startThu.TimeInterval = mother.WhenNeededWeek[4][1];
            startFri.TimeInterval = mother.WhenNeededWeek[5][0];
            startFri.TimeInterval = mother.WhenNeededWeek[5][1];
        }
    }
}
