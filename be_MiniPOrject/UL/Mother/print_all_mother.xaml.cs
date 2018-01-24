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

namespace UL
{
    /// <summary>
    /// Interaction logic for print_all_mother.xaml
    /// </summary>
    public partial class print_all_mother : Window
    {
        IBL bl;
        public print_all_mother()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            {
                System.Windows.Data.CollectionViewSource motherViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["motherViewSource"];
                motherViewSource.Source = bl.getMotherList();
            }
        }
    }
}