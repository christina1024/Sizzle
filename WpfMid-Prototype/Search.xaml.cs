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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for ShoppingList.xaml
    /// </summary>
    public partial class Search : Page
    {
        public Search()
        {
            InitializeComponent();
        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void slValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (slValue.Value == 3)
            {
                time.Content = "> 3";
            }
            else
            {
                time.Content = slValue.Value;
            }
        }

        private void search_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            result.Visibility = Visibility.Visible;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ii2.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ii1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ei1.Visibility = Visibility.Hidden;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ei2.Visibility = Visibility.Hidden;
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            result.Visibility = Visibility.Visible;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Visibility = Visibility.Hidden;
            ii1.Visibility = Visibility.Hidden;
            ii2.Visibility = Visibility.Hidden;
            ei1.Visibility = Visibility.Hidden;
            ei2.Visibility = Visibility.Hidden;
            cb1.IsChecked = false;
            cb2.IsChecked = false;
            cb3.IsChecked = false;
            cb4.IsChecked = false;
            cb5.IsChecked = false;
            slValue.Value = 0;
            sb.Text = "";
            ac.Text = "";
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void sb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sb.Text == "Enter Keywords for Recipes")
            {
                sb.Text = "";

                sb.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void sb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sb.Text == "")
            {
                sb.Text = "Enter Keywords for Recipes";

                sb.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void ac_MouseEnter(object sender, MouseEventArgs e)
        {
            if (ac.Text == "Add Craving")
            {
                ac.Text = "";

                ac.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void ac_MouseLeave(object sender, MouseEventArgs e)
        {
            if (ac.Text == "")
            {
                ac.Text = "Add Craving";

                ac.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (ii1l.Content == "" )
            {
                ii1.Visibility = Visibility.Visible;
                ii1l.Content = ac.Text;
                ii1b.Visibility = Visibility.Visible;
            }
            else if (ii1l.Content != "" & ii2l.Content == "")
            {
                ii2.Visibility = Visibility.Visible;
                ii2l.Content = ac.Text;
                ii2b.Visibility = Visibility.Visible;
            }
            else
            {

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ei1l.Content == "")
            {
                ei1.Visibility = Visibility.Visible;
                ei1l.Content = ac.Text;
                ei1b.Visibility = Visibility.Visible;
            }
            else if (ei1l.Content != "" & ei2l.Content == "")
            {
                ei2.Visibility = Visibility.Visible;
                ei2l.Content = ac.Text;
                ei2b.Visibility = Visibility.Visible;
            }
            else
            {

            }
        }
    }
}
