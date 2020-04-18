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
    }
}
