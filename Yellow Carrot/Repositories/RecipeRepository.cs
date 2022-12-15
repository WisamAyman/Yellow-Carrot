using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yellow_Carrot.Interfaces;
using Yellow_Carrot.Models;

namespace Yellow_Carrot.Repositories
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly YellowCarrotDbContext _context = new YellowCarrotDbContext();

        public void Add(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void Delete(Recipe recipe)
        {
            _context.Recipes.Remove(recipe);
            _context.SaveChanges();
        }

        public void Update(Recipe recipe)
        {
            _context.Recipes.Update(recipe);
            _context.SaveChanges();
        }

        public List<Recipe> GetAllRecipes()
        {
            return _context.Recipes.ToList();
        }

        public Recipe GetRecipe(Recipe recipe)
        {
           var _recipe = _context.Recipes.Where(x => x.Id == recipe.Id).FirstOrDefault();
            if (_recipe != null)
            {
                _recipe.Ingredients = GetIngredientById(_recipe.Id);
            }

            return _recipe;
            
        }

        public List<Ingredient> GetIngredientById(int id)
        {
            return _context.Ingredients.Where(x => x.RecipeId == id).ToList();
        }
    }
}
