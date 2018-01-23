﻿using System;
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
    /// Interaction logic for RemoveNanny.xaml
    /// </summary>
    public partial class RemoveNanny : Window
    {
        IBL bl;
        public RemoveNanny()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Nanny n in bl.getNannyList())
            {
                idComboBox.Items.Add(n.Id);
            }
            this.Remove.DataContext = idComboBox.SelectedItem as string;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveNanny(idComboBox.SelectedItem as string);
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