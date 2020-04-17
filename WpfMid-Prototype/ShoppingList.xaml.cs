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
    public partial class ShoppingList : Page
    {
        public ShoppingList()
        {
            InitializeComponent();
        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {

        }

       

        private void textBoxNewIngredient_MouseEnter(object sender, MouseEventArgs e)
        {
            if (textBoxNewIngredient.Text == "Add New Ingredient")
            {
                textBoxNewIngredient.Text = "";

                textBoxNewIngredient.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            }
        }

        private void textBoxNewIngredient_MouseLeave(object sender, MouseEventArgs e)
        {
            if (textBoxNewIngredient.Text == "")
            {
                textBoxNewIngredient.Text = "Add New Ingredient";

                textBoxNewIngredient.Foreground = new SolidColorBrush(Color.FromRgb(147, 139, 139));
            }
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            clearAllPopup.IsOpen = true;
        }

        private void deleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            clearAllPopup.IsOpen = false;
            ingredientsPanel.Visibility = Visibility.Hidden;
            RecipeGrid.Visibility = Visibility.Hidden;
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void Canceldelete_Click(object sender, RoutedEventArgs e)
        {
            clearAllPopup.IsOpen = false;
            recipesMessage.Visibility = Visibility.Hidden;
        }

        private void eggb_Click(object sender, RoutedEventArgs e)
        {
            egg.Visibility = Visibility.Hidden;
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            savedMessage.Visibility=Visibility.Visible;
        }

        private void tomatob_Click(object sender, RoutedEventArgs e)
        {
            tomato.Visibility = Visibility.Hidden;
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void cucumberb_Click(object sender, RoutedEventArgs e)
        {
            cucumber.Visibility = Visibility.Hidden;
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            recipesMessage.Visibility = Visibility.Visible;
        }
    }
}
