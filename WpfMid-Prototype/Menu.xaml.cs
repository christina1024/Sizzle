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

namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void menuButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Visible;
        }

        private void menuButton_MouseMove(object sender, MouseEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Visible;

    }

        private void menu2_MouseLeave(object sender, MouseEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Hidden;
        }

        private void ShoppintList_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new ShoppingList();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new HomePage();
        }
    }
}