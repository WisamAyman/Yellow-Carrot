using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yellow_Carrot.Interfaces;
using Yellow_Carrot.Models;
using Yellow_Carrot.Repositories;

namespace Yellow_Carrot
{
    public class DataSeed
    {
        private IRecipeRepository _recipeRepository = new RecipeRepository();

        public DataSeed()
        {
            if(_recipeRepository.GetAllRecipes().Count <= 0)
            {
                List<Ingredient> ingredients = new List<Ingredient>();
                ingredients.Add(new Ingredient()
                {
                    Name = "Smör",
                    Quantity = 2,
                });

                ingredients.Add(new Ingredient()
                {
                    Name = "Socker",
                    Quantity = 3,
                });

                _recipeRepository.Add(new Recipe()
                {
                    Name = "Tårta",
                    Ingredients = ingredients,
                });

                ingredients = new List<Ingredient>();
                ingredients.Add(new Ingredient()
                {
                    Name = "Grädde",
                    Quantity = 5,
                });

                ingredients.Add(new Ingredient()
                {
                    Name = "Choklad",
                    Quantity = 2,
                });

                _recipeRepository.Add(new Recipe()
                {
                    Name = "Chokladboll",
                    Ingredients = ingredients,
                });

                ingredients = new List<Ingredient>();
                ingredients.Add(new Ingredient()
                {
                    Name = "Socker",
                    Quantity = 2,
                });

                ingredients.Add(new Ingredient()
                {
                    Name = "Deg",
                    Quantity = 3,
                });

                _recipeRepository.Add(new Recipe()
                {
                    Name = "Pannkaka",
                    Ingredients = ingredients,
                });

                ingredients = new List<Ingredient>();
                ingredients.Add(new Ingredient()
                {
                    Name = "Äpple",
                    Quantity = 2,
                });

                ingredients.Add(new Ingredient()
                {
                    Name = "Kanel",
                    Quantity = 3,
                });

                _recipeRepository.Add(new Recipe()
                {
                    Name = "Äpplekaka",
                    Ingredients = ingredients,
                });
            }
        }
    }
}
