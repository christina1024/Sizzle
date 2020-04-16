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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void popular_Click(object sender, RoutedEventArgs e)
        {
            
              
        }

        private void veggieTaco_MouseEnter(object sender, MouseEventArgs e)
        {
            veggieTaco.Background = new SolidColorBrush(Color.FromRgb(210,236,235));
        }

        private void veggieTaco_MouseLeave(object sender, MouseEventArgs e)
        {
            veggieTaco.Background = new SolidColorBrush(Color.FromRgb(236, 233, 210));
        }
    }
}
