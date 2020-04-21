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
using System.Text.RegularExpressions;

namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for UploadPage_3.xaml
    /// </summary>
    public partial class UploadPage_3 : Page
    {
        public UploadPage_3()
        {
            InitializeComponent();
        }
        private void NumberValidation(object sender, TextCompositionEventArgs e)
         {
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
         }

        private void add_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel[] st = { instruction2, instruction3, instruction4 };
            for(int i =0; i<3; i++)
            {
                if (!st[i].IsVisible)
                {
                    st[i].Visibility = Visibility.Visible;
                    break;
                }
            }
        }

        private void sordInstruction()
        {
            StackPanel[] st = { instruction2, instruction3, instruction4 };
            TextBox[] t = { i2, i3, i4 };
            TextBox[] timer = {timer2,timer3,timer4 };
            for(int i=0; i<3; i++)
            {
                if (!st[i].IsVisible)
                {
                    for(int x=i+1; x<3; x++)
                    {
                        if (st[x].IsVisible)
                        {
                            t[i].Text = t[x].Text;
                            t[x].Text = "";                           
                            timer[i].Text = timer[x].Text;
                            timer[x].Text= "-timer-";
                            st[i].Visibility = Visibility.Visible;
                            st[x].Visibility = Visibility.Hidden;
                        }
                        break;
                    }
                }
            }
        }

        private void delete2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            instruction2.Visibility = Visibility.Hidden;
            sordInstruction();
        }

        private void delete3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            instruction3.Visibility = Visibility.Hidden;
            sordInstruction();
        }

        private void delete4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            instruction4.Visibility = Visibility.Hidden;
            sordInstruction();
        }

        private void mouseEnter(TextBox n, string s)
        {
            if (n.Text == s)
            {
                n.Text = "";

                n.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }
        private void mouseLeave(TextBox n, string s)
        {
            if (n.Text == "")
            {
                n.Text = s;

                n.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void timer1_MouseEnter(object sender, MouseEventArgs e){mouseEnter(timer1, "-timer-");}

        private void timer1_MouseLeave(object sender, MouseEventArgs e){mouseLeave(timer1, "-timer-");}
        private void timer2_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(timer2, "-timer-"); }

        private void timer2_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(timer2, "-timer-"); }
        private void timer3_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(timer3, "-timer-"); }

        private void timer3_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(timer3, "-timer-"); }
        private void timer4_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(timer4, "-timer-"); }

        private void timer4_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(timer4, "-timer-"); }



        private void previous_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_4.xaml", UriKind.RelativeOrAbsolute));
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.RelativeOrAbsolute));
        }
    }

    
}
