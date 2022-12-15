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

        public DetailsWindow(Recipe selectedRecipe)
        {
            InitializeComponent();

            var recipe = _recipeRepository.GetRecipe(selectedRecipe);
            tbRecipeName.Text = recipe.Name;

            if (recipe.Ingredients != null)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    lvIngredients.Items.Add(ingredient);
                }

            }
            if (recipe.Tags != null)
            {
                foreach (var tag in recipe.Tags)
                {
                    lvIngredients.Items.Add(tag);
                }
            }
        }

        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {
            btnSaveRecipe.IsEnabled = true;
            btnDeleteIngredient.IsEnabled = true;
            btnDeleteTag.IsEnabled = true;
            btnAddIngredient.IsEnabled = true;
            btnAddTag.IsEnabled = true;
            lvTag.IsEnabled = true;
            lvIngredients.IsEnabled = true;
            tbTag.IsEnabled = true;
            tbIngredient.IsEnabled = true;
            tbRecipeName.IsEnabled = true;
        }
    }
}
