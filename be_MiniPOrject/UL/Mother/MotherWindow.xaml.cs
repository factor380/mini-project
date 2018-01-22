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
                bl.AddMother(mother);
                mother = new Mother();
                this.MotherDetails.DataContext = mother;
                this.Close();
            }
            catch (FormatException)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show("check your input and try again");
            }
            catch (Exception ex)
            {
                Xceed.Wpf.Toolkit.MessageBox.Show(ex.Message);
            }
        }
    }
}
