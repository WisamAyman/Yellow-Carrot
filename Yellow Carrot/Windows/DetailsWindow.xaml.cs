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
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        private IRecipeRepository _recipeRepository = new RecipeRepository();
        private Recipe _recipe;

        public DetailsWindow(Recipe selectedRecipe)
        {
            InitializeComponent();

            var recipe = _recipeRepository.GetRecipe(selectedRecipe);
            _recipe = recipe;
            tbRecipeName.Text = recipe.Name;

            if (recipe.Ingredients != null)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    ListViewItem listViewItem = new ListViewItem();

                    listViewItem.Tag = ingredient;
                    listViewItem.Content = ingredient.Name;

                    lvIngredients.Items.Add(listViewItem);
                }

            }
            if (recipe.Tags != null)
            {
                foreach (var tag in recipe.Tags)
                {
                    ListViewItem listViewTagItem = new ListViewItem();

                    listViewTagItem.Tag = tag;
                    listViewTagItem.Content = tag.Name;

                    lvTag.Items.Add(listViewTagItem);
                }
            }
        }

        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {
            btnSaveRecipe.IsEnabled = !btnSaveRecipe.IsEnabled;
            btnDeleteIngredient.IsEnabled = !btnDeleteIngredient.IsEnabled;
            btnDeleteTag.IsEnabled = !btnDeleteTag.IsEnabled;
            btnAddIngredient.IsEnabled = !btnAddIngredient.IsEnabled;
            btnAddTag.IsEnabled = !btnAddTag.IsEnabled;
            lvTag.IsEnabled = !lvTag.IsEnabled;
            lvIngredients.IsEnabled = !lvIngredients.IsEnabled;
            tbTag.IsEnabled = !tbTag.IsEnabled;
            tbIngredient.IsEnabled = !tbIngredient.IsEnabled;
            tbRecipeName.IsEnabled = !tbRecipeName.IsEnabled;
            tbQuantity.IsEnabled = !tbQuantity.IsEnabled;

            btnUnlock.Content = tbRecipeName.IsEnabled ? "Lock" : "Unlock";
        }

        private void btnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbQuantity.Text) || string.IsNullOrEmpty(tbIngredient.Text))
            {
                MessageBox.Show("Ingredients & Quantities needs to be filled", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if(lvIngredients.SelectedItem != null)
            {
                ListViewItem foo = lvIngredients.SelectedItem as ListViewItem;
                Ingredient bar = foo.Tag as Ingredient;

                string updateIngredient = tbIngredient.Text;
                int updateQuantity = Convert.ToInt32(tbQuantity.Text);
                lvIngredients.Items.Remove(foo);
                bar.Quantity = updateQuantity;
                bar.Name = updateIngredient;

                ListViewItem updatedItem = new ListViewItem();
                updatedItem.Tag = bar;
                updatedItem.Content = bar.Name;

                lvIngredients.Items.Add(updatedItem);
                tbIngredient.Clear();
                tbQuantity.Clear();
                lvIngredients.SelectedIndex = -1;
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
            if(btnDeleteIngredient.IsEnabled)
            {
                ListViewItem foo = lvIngredients.SelectedItem as ListViewItem;
                Ingredient bar = foo.Tag as Ingredient;

                tbQuantity.Text = bar.Quantity.ToString();
                tbIngredient.Text = bar.Name;
                btnAddIngredient.Content = "Update";
            } else
            {
                btnAddIngredient.Content = "Add";
                tbQuantity.Text = "";
                tbIngredient.Text = "";
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnAddTag_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem foo = new ListViewItem();
            if (lvTag.SelectedItem != null)
            {
                foo = lvTag.SelectedItem as ListViewItem;
                Tag bar = foo.Tag as Tag;

                bar.Name = tbTag.Text;
                lvTag.Items.Remove(foo);
                ListViewItem updatedItem = new ListViewItem();
                updatedItem.Tag = bar;
                updatedItem.Content = bar.Name;

                lvTag.Items.Add(updatedItem);
                tbTag.Clear();
                lvTag.SelectedIndex = -1;
                return;
            }
            foo.Tag = new Tag() { Name = tbTag.Text };
            foo.Content = tbTag.Text;

            lvTag.Items.Add(foo);
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

            if (btnDeleteTag.IsEnabled)
            {
                ListViewItem foo = lvTag.SelectedItem as ListViewItem;
                Tag bar = foo.Tag as Tag;

                tbTag.Text = bar.Name;
                btnAddTag.Content = "Update";
            }
            else
            {
                btnAddTag.Content = "Add";
                tbTag.Text = "";
            }
        }

        private void btnUpdateRecipe_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbRecipeName.Text) || lvIngredients.Items.Count == 0 || lvTag.Items.Count == 0)
            {
                MessageBox.Show("Recipe, Ingredients, Tags & Quantities needs to be filled", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                _recipe.Ingredients = new List<Ingredient>(); // ny lista, inte null!
                _recipe.Tags = new List<Tag>();
                _recipe.Name = tbRecipeName.Text; // lägg receptnamnet på vår "Recipe"-klass
                // Inte riktigt färdig här än 
                foreach (ListViewItem item in lvIngredients.Items)
                {
                    var item2 = item.Tag as Ingredient;    //object?             

                    Ingredient ingredient = new Ingredient(); // new Ingredient klass

                    ingredient.Name = item2.Name;
                    ingredient.Quantity = item2.Quantity;
                    ingredient.Id = item2.Id;
                    ingredient.RecipeId = item2.RecipeId;

                    _recipe.Ingredients.Add(ingredient);
                }

                foreach (ListViewItem item in lvTag.Items)
                {
                    var foo = item.Tag as Tag;

                    Tag tag = new Tag();
                    tag.Name = foo.Name;
                    tag.Id = foo.Id;
                    tag.RecipeId = foo.RecipeId;

                    _recipe.Tags.Add(tag);
                }

                _recipeRepository.Update(_recipe);

                RecipeWindow recipeWindow = new RecipeWindow();
                recipeWindow.Show();
                Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            RecipeWindow recipeWindow = new RecipeWindow();
            recipeWindow.Show();
            Close();
        }
    }
}
