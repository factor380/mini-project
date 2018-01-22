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

namespace UL
{
    /// <summary>
    /// Interaction logic for number_of_under_certian_conditions.xaml
    /// </summary>
    public partial class number_of_under_certian_conditions : Window
    {
        public number_of_under_certian_conditions()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (selectionCondition.SelectedItem)
            {
                case "pay in hour":
                    numHiden.Visibility= Visible;//להבין מה העניין

                    break;

                case "pay in month":
                    numHiden.Visibility = Visible;//להבין מה העניין
                    break;

                default:
                    break;






            }
        }
    }
}
