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
    /// Interaction logic for RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        private IRecipeRepository _recipeRepository = new RecipeRepository();

        public RecipeWindow()
        {
            DataSeed dataSeed = new DataSeed();          

            InitializeComponent();

            var allRecipes = _recipeRepository.GetAllRecipes();
            lvRecipes.ItemsSource = allRecipes;
        }

        private void btnAddRecipeWindow_Click(object sender, RoutedEventArgs e)
        {
            AddRecipeWindow addRecipeWindow = new AddRecipeWindow();
            addRecipeWindow.Show();
            Close();
        }

        private void btnDetailsWindow_Click(object sender, RoutedEventArgs e)
        {
            var selectedRecipe = lvRecipes.SelectedItem as Recipe;

            DetailsWindow detailsWindow = new DetailsWindow(selectedRecipe);
            detailsWindow.Show();
            Close();
        }

        private void btnDeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = lvRecipes.SelectedItem as Recipe;

            Recipe foo = _recipeRepository.GetRecipe(selectedItem);

            _recipeRepository.Delete(selectedItem);
            var allRecipes = _recipeRepository.GetAllRecipes();
            lvRecipes.ItemsSource = allRecipes;
        }

        private void lvRecipes_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (lvRecipes.SelectedItems != null)
            {
                btnDeleteRecipe.IsEnabled = true;
                btnDetailsWindow.IsEnabled = true;
            }
        }
    }
}
