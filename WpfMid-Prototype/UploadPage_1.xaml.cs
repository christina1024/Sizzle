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
    /// Interaction logic for UploadPage_1.xaml
    /// </summary>
    public partial class UploadPage_1 : Page
    {
        public UploadPage_1()
        {
            InitializeComponent();
        }

        private void stars1_MouseEnter(object sender, MouseEventArgs e)
        {
            if (light1.IsVisible) {starchanger(light1); }
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
            Image[] starImage = { light1, light2, light3, light4, light5};
            Image[] starImage2 = { unlight1, unlight2, unlight3, unlight4, unlight5};
            int num=20;
            for(int i=0; i<5; i++)
            {
                if (starImage[i] == name)
                {
                    for(int s=i; s>=0; s--) {
                        starImage[s].Visibility = Visibility.Visible;
                        starImage2[s].Visibility = Visibility.Hidden;                      
                    }
                    for (int t = i+1; t < 5; t++) {
                        starImage2[t].Visibility = Visibility.Visible;
                        starImage[t].Visibility = Visibility.Hidden;
                    }
                    num = i;
                    break;
                }
            }
            if(num > 10)
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
                        for (int t = i+1; t < 5; t++)
                        {
                            starImage2[t].Visibility = Visibility.Visible;
                            starImage[t].Visibility = Visibility.Hidden;
                        }                       
                        break;
                    }
                }
            }
        }

        private void NumberValidation(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void portionUp_Click(object sender, RoutedEventArgs e)
        {
            int num = 1;
            Int32.TryParse(portion.Text, out num);
            int num2 = num + 1;
            portion.Text =num2.ToString();

        }

        private void portionDown_Click(object sender, RoutedEventArgs e)
        {
            int num = 1;
            Int32.TryParse(portion.Text, out num);
            if(num > 0)
            {
                int num2 = num - 1;
                portion.Text = num2.ToString();
            }

        }

        private void addConstraint_Click(object sender, RoutedEventArgs e)
        {
            cMessage1.Visibility = Visibility.Hidden;
            cMessage2.Visibility = Visibility.Hidden;
            StackPanel[] s = { c1, c2, c3, c4 };
            Label[] t = { t1, t2, t3, t4 };
            if(constraintbox.Text != "--Select Constraint--")
            {
                for(int i=0; i<4; i++)
                {
                    string temp = t[i].Content.ToString();
                    if(constraintbox.Text == temp) 
                    {
                        cMessage2.Visibility = Visibility.Visible;
                        break;
                    }
                }
                if(!cMessage2.IsVisible)
                {
                    for(int x=0; x< 4; x++)
                    {
                        if (!s[x].IsVisible)
                        {
                            t[x].Content = constraintbox.Text;
                            s[x].Visibility = Visibility.Visible;
                            break;
                        }
                    }
                }
            }
            else
            {
                cMessage1.Visibility = Visibility.Visible;
            }
        }

        private void sordConstraint()
        {
            StackPanel[] s = { c1, c2, c3, c4 };
            Label[] t = { t1, t2, t3, t4 };
            for(int i=0; i< 4; i++)
            {
                if (!s[i].IsVisible)
                {
                    for(int n=i+1; n< 4; n++)
                    {
                        if (s[n].IsVisible)
                        {
                            s[n].Visibility = Visibility.Hidden;
                            t[i].Content = t[n].Content;
                           // t[n].Content = "";
                            s[i].Visibility = Visibility.Visible;
                            break;
                        }
                    }
                }
            }
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
           
            c1.Visibility = Visibility.Hidden;
            sordConstraint();
        }
        private void b2_Click(object sender, RoutedEventArgs e)
        {
            
            c2.Visibility = Visibility.Hidden;
            sordConstraint();
        }
        private void b3_Click(object sender, RoutedEventArgs e)
        {
            
            c3.Visibility = Visibility.Hidden;
            sordConstraint();
        }
        private void b4_Click(object sender, RoutedEventArgs e)
        {
           
            c4.Visibility = Visibility.Hidden;
            sordConstraint();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_2.xaml", UriKind.RelativeOrAbsolute));
            
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/HomePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void deleteImage_Click(object sender, RoutedEventArgs e)
        {
            taco.Visibility = Visibility.Hidden;
            imageSub.Visibility = Visibility.Visible;
            deleteImage.Content = "upload";
        }
    }
}
