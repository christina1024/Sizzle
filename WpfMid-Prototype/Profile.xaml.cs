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
using System.Windows.Media.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for ShoppingList.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string focontent = (e.Source as Button).Content.ToString();
            if (focontent == "Follow")
            {
                fo.Content = "Following";
            }
            else
            {
                fo.Content = "Follow";
            }
        }

        private void prc(object sender, RoutedEventArgs e)
        {
            prb.Background = Brushes.LightCyan;
            srb.Background = Brushes.LightSeaGreen;
            re1.Visibility = Visibility.Visible;
            re2.Visibility = Visibility.Visible;
        }

        private void src(object sender, RoutedEventArgs e)
        {
            srb.Background = Brushes.LightCyan;
            prb.Background = Brushes.LightSeaGreen;
            re2.Visibility = Visibility.Hidden;
        }

        private void image3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ViewPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
