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
    /// Interaction logic for RemoveContract.xaml
    /// </summary>
    public partial class RemoveContract : Window
    {
        IBL bl;
        public RemoveContract()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            foreach (Contract c in bl.getContractList())
            {
                contract_Num1ComboBox.Items.Add(c.Contract_Num1);
            }
            Remove.DataContext = (int)(contract_Num1ComboBox.SelectionBoxItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.RemoveContract((int)(contract_Num1ComboBox.SelectionBoxItem));
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
