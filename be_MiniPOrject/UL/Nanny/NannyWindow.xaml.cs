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
    /// Interaction logic for AddNunnyWindow.xaml
    /// </summary>
    public partial class AddNunnyWindow : Window
    {
        Nanny nanny;
        IBL bl;
        public AddNunnyWindow()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            nanny = new Nanny();
            this.NannyDetails.DataContext = nanny;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
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
                bl.AddNanny(nanny);
                nanny = new Nanny();
                this.NannyDetails.DataContext = nanny;
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
