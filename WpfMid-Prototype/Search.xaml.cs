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

        private void stars1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (light1.IsVisible) { starchanger(light1); }
            else { starchanger(unlight1); }

        }
        private void stars2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (light1.IsVisible) { starchanger(light2); }
            else { starchanger(unlight2); }
        }
        private void stars3_MouseEnter(object sender, MouseEventArgs e)
        {
            if (light1.IsVisible) { starchanger(light3); }
            else { starchanger(unlight3); }
        }
        private void stars4_MouseEnter(object sender, MouseEventArgs e)
        {
            if (light1.IsVisible) { starchanger(light4); }
            else { starchanger(unlight4); }
        }
        private void stars5_MouseEnter(object sender, MouseEventArgs e)
        {
            if (light1.IsVisible) { starchanger(light5); }
            else { starchanger(unlight5); }
        }

        private void starchanger(Image name)
        {
            Image[] starImage = { light1, light2, light3, light4, light5 };
            Image[] starImage2 = { unlight1, unlight2, unlight3, unlight4, unlight5 };
            int num = 20;
            for (int i = 0; i < 5; i++)
            {
                if (starImage[i] == name)
                {
                    for (int s = i; s >= 0; s--)
                    {
                        starImage[s].Visibility = Visibility.Visible;
                        starImage2[s].Visibility = Visibility.Hidden;
                    }
                    for (int t = i + 1; t < 5; t++)
                    {
                        starImage2[t].Visibility = Visibility.Visible;
                        starImage[t].Visibility = Visibility.Hidden;
                    }
                    num = i;
                    break;
                }
            }
            if (num > 10)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (starImage2[i] == name)
                    {
                        for (int s = i; s >= 0; s--)
                        {
                            starImage[s].Visibility = Visibility.Visible;
                            starImage2[s].Visibility = Visibility.Hidden;
                        }
                        for (int t = i + 1; t < 5; t++)
                        {
                            starImage2[t].Visibility = Visibility.Visible;
                            starImage[t].Visibility = Visibility.Hidden;
                        }
                        break;
                    }
                }
            }
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


        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            result.Visibility = Visibility.Visible;
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            result.Visibility = Visibility.Hidden;
            ii1.Visibility = Visibility.Hidden;
            ii2.Visibility = Visibility.Hidden;
            ii3.Visibility = Visibility.Hidden;
            ii4.Visibility = Visibility.Hidden;
            ii5.Visibility = Visibility.Hidden;
            ei1.Visibility = Visibility.Hidden;
            ei2.Visibility = Visibility.Hidden;
            ei3.Visibility = Visibility.Hidden;
            ei4.Visibility = Visibility.Hidden;
            ei5.Visibility = Visibility.Hidden;
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
            if (ac.Text != "" && ac.Text != "Add Craving")
            {
                StackPanel[] ii = { ii1, ii2, ii3, ii4, ii5 };
                Label[] iil = { ii1l, ii2l, ii3l, ii4l, ii5l };
                for (int i = 0; i < 5; i++)
                {
                    if (!ii[i].IsVisible)
                    {
                        iil[i].Content = ac.Text;
                        ii[i].Visibility = Visibility.Visible;
                        break;
                    }
                }
            }
            else
            {
            }
        }
        private void iireorder()
        {
            StackPanel[] ii = { ii1, ii2, ii3, ii4, ii5 };
            Label[] iil = { ii1l, ii2l, ii3l, ii4l, ii5l };

            for (int i = 0; i < 5; i++)
            {
                if (!ii[i].IsVisible)
                {
                    for (int s = i + 1; s < 5; s++)
                    {
                        if (ii[s].IsVisible)
                        {
                            ii[s].Visibility = Visibility.Hidden;
                            iil[i].Content = iil[s].Content;
                            ii[i].Visibility = Visibility.Visible;
                            break;
                        }
                    }

                }
            }
        }
        
        private void ii1c(object sender, RoutedEventArgs e)
        {
            ii1.Visibility = Visibility.Hidden;
            iireorder();
        }
        private void ii2c(object sender, RoutedEventArgs e)
        {
            ii2.Visibility = Visibility.Hidden;
            iireorder();
        }
        private void ii3c(object sender, RoutedEventArgs e)
        {
            ii3.Visibility = Visibility.Hidden;
            iireorder();
        }
        private void ii4c(object sender, RoutedEventArgs e)
        {
            ii4.Visibility = Visibility.Hidden;
            iireorder();
        }
        private void ii5c(object sender, RoutedEventArgs e)
        {
            ii5.Visibility = Visibility.Hidden;
            iireorder();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (ac.Text != "" && ac.Text != "Add Craving")
            {
                StackPanel[] ei = { ei1, ei2, ei3, ei4, ei5 };
                Label[] eil = { ei1l, ei2l, ei3l, ei4l, ei5l };
                for (int i = 0; i < 5; i++)
                {
                    if (!ei[i].IsVisible)
                    {
                        eil[i].Content = ac.Text;
                        ei[i].Visibility = Visibility.Visible;
                        break;
                    }
                }
            }
            else
            {
            }
        }
        private void eireorder()
        {
            StackPanel[] ei = { ei1, ei2, ei3, ei4, ei5 };
            Label[] eil = { ei1l, ei2l, ei3l, ei4l, ei5l };

            for (int i = 0; i < 5; i++)
            {
                if (!ei[i].IsVisible)
                {
                    for (int s = i + 1; s < 5; s++)
                    {
                        if (ei[s].IsVisible)
                        {
                            ei[s].Visibility = Visibility.Hidden;
                            eil[i].Content = eil[s].Content;
                            ei[i].Visibility = Visibility.Visible;
                            break;
                        }
                    }

                }
            }
        }

        private void ei1c(object sender, RoutedEventArgs e)
        {
            ei1.Visibility = Visibility.Hidden;
            eireorder();
        }
        private void ei2c(object sender, RoutedEventArgs e)
        {
            ei2.Visibility = Visibility.Hidden;
            eireorder();
        }
        private void ei3c(object sender, RoutedEventArgs e)
        {
            ei3.Visibility = Visibility.Hidden;
            eireorder();
        }
        private void ei4c(object sender, RoutedEventArgs e)
        {
            ei4.Visibility = Visibility.Hidden;
            eireorder();
        }
        private void ei5c(object sender, RoutedEventArgs e)
        {
            ei5.Visibility = Visibility.Hidden;
            eireorder();
        }

        private void sb_KeyDown(object sender, KeyEventArgs e)
        {
            result.Visibility = Visibility.Visible;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ViewPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }

}
