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
using BE;
using BL;
namespace UL
{
    /// <summary>
    /// Interaction logic for Button_Click_Nannies_that_fit_mom.xaml
    /// </summary>
    public partial class Nannies_that_almost_fit_mom : Window
    {
        IBL bl;
        public Nannies_that_almost_fit_mom()
        {
            InitializeComponent();
            bl = FactoryBL.GetBL();
            //enter mother do combo box
            idMother.ItemsSource = bl.getMotherList();
            idMother.SelectedValuePath = "Id";
            idMother.DisplayMemberPath = "Data";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text != "")
                text.Text = "";
            IBL bl;
            bl = BL.FactoryBL.GetBL();
            List<Nanny> ListN = bl.NanniesThatAlsoFitMom(bl.GetMother(((Mother)(this.idMother.SelectedItem)).Id));

            foreach (Nanny v in ListN)
            {
                text.Text += v.ToString() + '\n';
            }
            if (text.Text == "")
                text.Text = "thare no nannies that almost fit to the mother";
        }
    }
}

