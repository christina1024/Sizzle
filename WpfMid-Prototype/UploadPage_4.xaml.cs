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
    /// Interaction logic for UploadPage_4.xaml
    /// </summary>
    public partial class UploadPage_4 : Page
    {
        public UploadPage_4()
        {
            InitializeComponent();
        }

        private void Button_Publish(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/ViewPage.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Profile.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Button_Upload3(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_3.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Button_Upload2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_2.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Button_Upload1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/UploadPage_1.xaml", UriKind.RelativeOrAbsolute));

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Follow.Content = "Following";
        }
    }
}
