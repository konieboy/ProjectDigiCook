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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    /// 

    public partial class NoResults : Page
    {

        public NoResults()
        {
            InitializeComponent();

            //this.Title = "DigiCook";

            //// Set window to center of the computer screen at startup
            //this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //// Turn off resizing
            //this.ResizeMode = ResizeMode.NoResize;
        }

     

        private void View_Checklist_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("./Checklist.xaml", UriKind.Relative));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            searchBar.setText();
        }


        private void spaghetti_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("./Spaghetti" + GlobalVars.skillLevel.ToString() + ".xaml" , UriKind.Relative));
        }
    }
}
