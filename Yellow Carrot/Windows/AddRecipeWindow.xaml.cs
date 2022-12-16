using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Yellow_Carrot.Interfaces;
using Yellow_Carrot.Models;
using Yellow_Carrot.Repositories;

namespace Yellow_Carrot.Windows
{
    /// <summary>
    /// Interaction logic for AddRecipeWindow.xaml
    /// </summary>
    public partial class AddRecipeWindow : Window
    {
        private IRecipeRepository _recipeRepository = new RecipeRepository();

        public AddRecipeWindow()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipeWindow = new RecipeWindow();
            recipeWindow.Show();
            Close();
        }

        private void btnSaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRecipeName.Text) || lvIngredients.Items.Count == 0 || lvTag.Items.Count == 0)
            {
                MessageBox.Show("Recipe, Ingredients, Tags & Quantities needs to be filled", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else 
            {

                Recipe recipe = new Recipe();
                recipe.Ingredients = new List<Ingredient>(); 
                recipe.Tags = new List<Tag>();
                recipe.Name = tbRecipeName.Text; 
                
                foreach (ListViewItem item in lvIngredients.Items)
                {
                    var item2 = item.Tag as Ingredient;               

                    Ingredient ingredient = new Ingredient(); 

                    ingredient.Name = item2.Name;
                    ingredient.Quantity = item2.Quantity;

                    recipe.Ingredients.Add(ingredient);
                }

                foreach (var item in lvTag.Items)
                {
                    Tag tag = new Tag();
                    tag.Name = item.ToString();
                    recipe.Tags.Add(tag);
                }

                _recipeRepository.Add(recipe);

                RecipeWindow recipeWindow = new RecipeWindow();
                recipeWindow.Show();
                Close();
            }
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text) || string.IsNullOrEmpty(tbIngredient.Text))
            {
                MessageBox.Show("Ingredients & Quantities needs to be filled", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            
            string addIngredient = tbIngredient.Text;
            int quantity = Convert.ToInt32(tbQuantity.Text);

            Ingredient ingredient = new Ingredient();
            ingredient.Quantity = quantity;
            ingredient.Name = addIngredient;

            ListViewItem ingredientItem = new ListViewItem();

            ingredientItem.Tag = ingredient;
            ingredientItem.Content = ingredient.Name;

            lvIngredients.Items.Add(ingredientItem);
            tbIngredient.Clear();
            tbQuantity.Clear();
        }

        private void btnDeleteIngredient_Click(object sender, RoutedEventArgs e)
        {
            lvIngredients.Items.Remove(lvIngredients.SelectedItem);
        }

        private void tbIngredient_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddIngredient.IsEnabled = tbIngredient.Text.Length > 0 ? true : false;  
        }

        private void lvIngredients_SelectionChanged(object sender, RoutedEventArgs e)
        {
            btnDeleteIngredient.IsEnabled = (lvIngredients.SelectedItems != null && lvIngredients.SelectedItems.Count > 0) ? true : false;
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddTag_Click(object sender, RoutedEventArgs e)
        {
            string addTag = tbTag.Text;

            lvTag.Items.Add(addTag);
            tbTag.Clear();
        }

        private void btnDeleteTag_Click(object sender, RoutedEventArgs e)
        {
            lvTag.Items.Remove(lvTag.SelectedItem);
        }

        private void tbTag_TextChanged(object sender, TextChangedEventArgs e)
        {
            btnAddTag.IsEnabled = tbTag.Text.Length > 0 ? true : false;
        }

        private void lvTag_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnDeleteTag.IsEnabled = (lvTag.SelectedItems != null && lvTag.SelectedItems.Count > 0) ? true : false;
        }
    }
}
