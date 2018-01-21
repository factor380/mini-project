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
                if (nanny.DayInWeek[0])
                {
                    nanny.WorkHours[0][0] = this.startSun.Value.Value.TimeOfDay;
                    nanny.WorkHours[0][1] = this.endSun.Value.Value.TimeOfDay;
                }
                if (nanny.DayInWeek[1])
                {
                    nanny.WorkHours[1][0] = this.startMon.Value.Value.TimeOfDay;
                    nanny.WorkHours[1][1] = this.endMon.Value.Value.TimeOfDay;
                }
                if (nanny.DayInWeek[2])
                {
                    nanny.WorkHours[2][0] = this.startTue.Value.Value.TimeOfDay;
                    nanny.WorkHours[2][1] = this.endTue.Value.Value.TimeOfDay;
                }
                if (nanny.DayInWeek[3])
                {
                    nanny.WorkHours[3][0] = this.startWed.Value.Value.TimeOfDay;
                    nanny.WorkHours[3][1] = this.endWed.Value.Value.TimeOfDay;
                }
                if (nanny.DayInWeek[4])
                {
                    nanny.WorkHours[4][0] = this.startThu.Value.Value.TimeOfDay;
                    nanny.WorkHours[4][1] = this.endThu.Value.Value.TimeOfDay;
                }
                if (nanny.DayInWeek[5])
                {
                    nanny.WorkHours[5][0] = this.startFri.Value.Value.TimeOfDay;
                    nanny.WorkHours[5][1] = this.endFri.Value.Value.TimeOfDay;
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
