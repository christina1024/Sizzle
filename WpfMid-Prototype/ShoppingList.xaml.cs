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
            if (textBoxNewIngredient.Text != "" && textBoxNewIngredient.Text != "Add New Ingredient")
            {
                StackPanel[] a = { a1, a2, a3, a4, a5, a6 };
                Label[] t = { t1, t2, t3, t4, t5, t6 };
                for (int i = 0; i < 6; i++)
                {
                    if (!a[i].IsVisible)
                    {
                        t[i].Content = textBoxNewIngredient.Text;
                        a[i].Visibility = Visibility.Visible;
                        errorMessage.Visibility = Visibility.Hidden;
                        break;
                    }
                }
            }
            else
            {
                errorMessage.Visibility = Visibility.Visible;
            }
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
                errorMessage.Visibility = Visibility.Hidden;
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
            if (recipesMessage.IsVisible)
            {
                clearAllPopup.IsOpen = false;
                recipesMessage.Visibility = Visibility.Hidden;
            }
            else
            {
                printAllPopup.IsOpen = false;
            }

        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            a1.Visibility = Visibility.Hidden;
            reorder();
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            savedMessage.Visibility = Visibility.Visible;
        }

        private void reorder()
        {
            StackPanel[] a = { a1, a2, a3, a4, a5, a6 };
            Label[] t = { t1, t2, t3, t4, t5, t6 };

            for (int i = 0; i < 6; i++)
            {
                if (!a[i].IsVisible)
                {
                    for (int s = i + 1; s < 6; s++)
                    {
                        if (a[s].IsVisible)
                        {
                            a[s].Visibility = Visibility.Hidden;
                            t[i].Content = t[s].Content;
                            a[i].Visibility = Visibility.Visible;
                            break;
                        }
                    }

                }
            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            a2.Visibility = Visibility.Hidden;
            reorder();
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            a3.Visibility = Visibility.Hidden;
            reorder();
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            a4.Visibility = Visibility.Hidden;
            reorder();
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            a5.Visibility = Visibility.Hidden;
            reorder();
            savedMessage.Visibility = Visibility.Hidden;
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            a6.Visibility = Visibility.Hidden;
            reorder();
            savedMessage.Visibility = Visibility.Hidden;
        }

        int buttonIndicator = 0;
        private void chocolateButton_Click(object sender, RoutedEventArgs e)
        {
            recipesMessage.Visibility = Visibility.Visible;
            buttonIndicator = 1;
        }
        private void veggieButton_Click(object sender, RoutedEventArgs e)
        {
            recipesMessage.Visibility = Visibility.Visible;
            buttonIndicator = 2;
        }

        private void deleteRecipeR_Click(object sender, RoutedEventArgs e)
        {
            if (buttonIndicator == 1)
            {chocolate.Visibility = Visibility.Hidden;
                recipesMessage.Visibility = Visibility.Hidden;
                if (chocolate2.Content.Equals("Chocolate Cake")) 
                {
                    
                    
                    if (t1.Content.Equals("Egg"))
                    {                    
                        a1.Visibility = Visibility.Hidden;
                        reorder();                  
                    }
                    if (veggieTaco.IsVisible)
                    {
                        chocolate.Visibility = Visibility.Visible;
                        chocolate2.Content = veggieTaco2.Content;
                        veggieTaco.Visibility = Visibility.Hidden;
                    }
                }

                
            }
            else
            {
                recipesMessage.Visibility = Visibility.Hidden;
                veggieTaco.Visibility = Visibility.Hidden;
            }
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            printAllPopup.IsOpen = true;
        }
    }
}
