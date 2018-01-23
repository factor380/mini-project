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
    /// Interaction logic for UpdateChild.xaml
    /// </summary>
    public partial class UpdateChild : Window
    {
        IBL bl;
        public UpdateChild()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Child c in bl.getChildList())
            {
                idComboBox.Items.Add(c.Id);
            }
        }
        private void idComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Child child = bl.GetChild(idComboBox.SelectedItem as string);
            UPDATE.DataContext = child;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Child child = bl.GetChild(idComboBox.SelectedItem as string);
                bl.UpdateChild(child);
                child = new Child();
                this.UPDATE.DataContext = child;
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