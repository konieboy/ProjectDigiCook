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
    /// Interaction logic for HelperPage3.xaml
    /// </summary>
    public partial class HelperPage3 : Page
    {
        public HelperPage3()
        {
            InitializeComponent();
        }

        private DependencyObject GetDependencyObjectFromVisualTree(DependencyObject startObject, Type type)
        {
            DependencyObject parent = startObject;
            while (parent != null)
            {
                if (type.IsInstanceOfType(parent))
                    break;
                else
                    parent = VisualTreeHelper.GetParent(parent);
            }
            return parent;
        }

        private void Page_Initial(object sender, EventArgs e)
        {
        }

        private void nav_front(object sender, RoutedEventArgs e)
        {
            Page destination = GetDependencyObjectFromVisualTree(this, typeof(Page)) as Page;

            destination.NavigationService.Navigate(new Uri("./HelperPage2.xaml", UriKind.Relative));
        }

        private void nav_no(object sender, RoutedEventArgs e)
        {
            Page destination = GetDependencyObjectFromVisualTree(this, typeof(Page)) as Page;

            destination.NavigationService.Navigate(new Uri("./HelperPage4.xaml", UriKind.Relative));
        }
    }
}
