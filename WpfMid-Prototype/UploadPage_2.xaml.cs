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
    /// Interaction logic for UploadPage_2.xaml
    /// </summary>
    public partial class UploadPage_2 : Page
    {
        public UploadPage_2()
        {
            InitializeComponent();
        }

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9/]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void mouseEnter(TextBox n, string s) {
            if (n.Text == s)
            {
                n.Text = "";

                n.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
                message1.Visibility = Visibility.Hidden;
            }
        }
        private void mouseLeave(TextBox n, string s) {
            if (n.Text == "")
            {
                n.Text = s;

                n.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void sordIngredient()
        {
            StackPanel[] st = { ingredient1, ingredient2, ingredient3, ingredient4 };
            TextBox[] i = { i1, i2, i3, i4 };
            TextBox[] s = { s1, s2, s3, s4 };
            TextBox[] q = { q1, q2, q3, q4 };
            ComboBox[] b = { b1, b2, b3, b4 };
            for (int n = 0; n < 4; n++)
            {
                if (!st[n].IsVisible)
                {
                    for (int x = n + 1; x < 4; x++)
                    {
                        if (st[x].IsVisible)
                        {
                            st[x].Visibility = Visibility.Hidden;
                            i[n].Text = i[x].Text;
                            s[n].Text = s[x].Text;
                            q[n].Text = q[x].Text;
                            b[n].Text = b[x].Text;

                            i[x].Text = "Ingredient";
                            s[x].Text = "Substitution";
                            q[x].Text = "Quantity";
                            b[x].Text = "--Select Size--";
                            st[n].Visibility = Visibility.Visible;
                            break;
                        }
                    }
                }
            }
        }

        #region ingredient1Event
        private void i1_MouseEnter(object sender, MouseEventArgs e){mouseEnter(i1, "Ingredient");}

        private void s1_MouseEnter(object sender, MouseEventArgs e){ mouseEnter(s1, "Substitution");}

        private void q1_MouseEnter(object sender, MouseEventArgs e){ mouseEnter(q1, "Quantity");}

        private void i1_MouseLeave(object sender, MouseEventArgs e)
        {
            mouseLeave(i1, "Ingredient");
            if(i1.Text != "Ingredient")
            {
                ingredient2.IsEnabled = true;
            }
        }

        private void s1_MouseLeave(object sender, MouseEventArgs e){mouseLeave(s1, "Substitution");}

        private void q1_MouseLeave(object sender, MouseEventArgs e){ mouseLeave(q1, "Quantity");}

        #endregion

        #region ingredient2Event
        private void i2_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(i2, "Ingredient"); }

        private void s2_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(s2, "Substitution"); }

        private void q2_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(q2, "Quantity"); }

        private void i2_MouseLeave(object sender, MouseEventArgs e)
        {
            mouseLeave(i2, "Ingredient");
            if (i2.Text != "Ingredient")
            {
                ingredient3.IsEnabled = true;
            }
        }

        private void s2_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(s2, "Substitution"); }

        private void q2_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(q2, "Quantity"); }
        private void image2_MouseDown(object sender, MouseButtonEventArgs e)
            {
                ingredient2.Visibility = Visibility.Hidden;
                sordIngredient();
            }
        #endregion

        #region ingredient3Event
        private void i3_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(i3, "Ingredient"); }

        private void s3_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(s3, "Substitution"); }

        private void q3_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(q3, "Quantity"); }

        private void i3_MouseLeave(object sender, MouseEventArgs e)
        {
            mouseLeave(i3, "Ingredient");
            if (i3.Text != "Ingredient")
            {
                ingredient4.IsEnabled = true;
            }
        }

        private void s3_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(s3, "Substitution"); }

        private void q3_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(q3, "Quantity"); }

        private void image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ingredient3.Visibility = Visibility.Hidden;
            sordIngredient();
        }

        #endregion

        #region ingredient4Event
        private void i4_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(i4, "Ingredient"); }

        private void s4_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(s4, "Substitution"); }

        private void q4_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(q4, "Quantity"); }

        private void i4_MouseLeave(object sender, MouseEventArgs e)
        {
            mouseLeave(i4, "Ingredient");
        }

        private void s4_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(s4, "Substitution"); }

        private void q4_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(q4, "Quantity"); }
        private void image4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ingredient4.Visibility = Visibility.Hidden;
            sordIngredient();
        }
        #endregion

            

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel[] st = { ingredient1, ingredient2, ingredient3, ingredient4 };
            for (int i=0; i< 4; i++)
            {
                if (!st[i].IsVisible) 
                {
                    st[i].Visibility = Visibility.Visible;
                    break;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_1.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_3.xaml", UriKind.RelativeOrAbsolute));
        }

        private void a1_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(a1, "Appliances"); }

        private void a1_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(a1, "Appliances"); }

        private void a2_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(a2, "Appliances"); }

        private void a2_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(a2, "Appliances"); }

        private void a3_MouseEnter(object sender, MouseEventArgs e) { mouseEnter(a3, "Appliances"); }

        private void a3_MouseLeave(object sender, MouseEventArgs e) { mouseLeave(a3, "Appliances"); }

        private void abutton1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (appliance3.IsVisible)
            {
                a2.Text = a3.Text;
                a3.Text = "Appliances";
                appliance3.Visibility = Visibility.Hidden;
            }
            else {
                a2.Text = "Appliances";
                appliance2.Visibility = Visibility.Hidden;
            }
            
        }

        private void abutton2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            a3.Text = "Appliances";
            appliance3.Visibility = Visibility.Hidden;
        }

        private void addAppliance_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(!appliance2.IsVisible) {
                appliance2.Visibility = Visibility.Visible;
            }
            else
            {
                if (!appliance3.IsVisible) {
                    appliance3.Visibility = Visibility.Visible;
                }
            }
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ingredient2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (! ingredient2.IsEnabled) {
                message1.Visibility = Visibility.Visible;
            }
        }

        private void i1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            message1.Visibility = Visibility.Hidden;
        }
    }
}
