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
using Xceed.Wpf.Toolkit;

namespace UL
{
    /// <summary>
    /// Interaction logic for AddMotherWindow.xaml
    /// </summary>
    public partial class AddMotherWindow : Window
    {
        Mother mother;
        IBL bl;
        public AddMotherWindow()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            mother = new Mother();
            this.MotherDetails.DataContext = mother;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (mother.DayInWeek[0])
                {
                    mother.WhenNeededWeek[0][0] = this.startSun.Value.Value.TimeOfDay;
                    mother.WhenNeededWeek[0][1] = this.endSun.Value.Value.TimeOfDay;
                }
                if (mother.DayInWeek[1])
                {
                    mother.WhenNeededWeek[1][0] = this.startMon.Value.Value.TimeOfDay;
                    mother.WhenNeededWeek[1][1] = this.endMon.Value.Value.TimeOfDay;
                }
                if (mother.DayInWeek[2])
                {
                    mother.WhenNeededWeek[2][0] = this.startTue.Value.Value.TimeOfDay;
                    mother.WhenNeededWeek[2][1] = this.endTue.Value.Value.TimeOfDay;
                }
                if (mother.DayInWeek[3])
                {
                    mother.WhenNeededWeek[3][0] = this.startWed.Value.Value.TimeOfDay;
                    mother.WhenNeededWeek[3][1] = this.endWed.Value.Value.TimeOfDay;
                }
                if (mother.DayInWeek[4])
                {
                    mother.WhenNeededWeek[4][0] = this.startThu.Value.Value.TimeOfDay;
                    mother.WhenNeededWeek[4][1] = this.endThu.Value.Value.TimeOfDay;
                }
                if (mother.DayInWeek[5])
                {
                    mother.WhenNeededWeek[5][0] = this.startFri.Value.Value.TimeOfDay;
                    mother.WhenNeededWeek[5][1] = this.endFri.Value.Value.TimeOfDay;
                }
                bl.AddMother(mother);
                mother = new Mother();
                this.MotherDetails.DataContext = mother;
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
