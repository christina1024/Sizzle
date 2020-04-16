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
using WpfMid_Prototype.Database;

namespace WpfMid_Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            StartMain.Content = new HomePage();

        }

        private void menuButton_MouseMove(object sender, MouseEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Visible;
        }

        private void menuButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Visible;
        }

        private void menu2_MouseLeave(object sender, MouseEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Hidden;
        }

        private void ShoppintList_Click(object sender, RoutedEventArgs e)
        {

            StartMain.Content = new ShoppingList();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

            StartMain.Content = new HomePage();
        }

        

        private void upload_Click(object sender, RoutedEventArgs e)
        {
            StartMain.Content = new UploadPage_4();
        }

        private void AdvanceSearch_Click(object sender, RoutedEventArgs e)
        {
            StartMain.Content = new Search();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            StartMain.Content = new Profile();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            menu2.Visibility = System.Windows.Visibility.Hidden;
        }
    }
}
