using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yellow_Carrot.Models;

namespace Yellow_Carrot.Interfaces
{
    public interface IRecipeRepository
    {
        void Add (Recipe recipe);
        void Delete (Recipe recipe);
        void Update (Recipe recipe);
        List<Recipe> GetAllRecipes ();
        Recipe GetRecipe (Recipe recipe);
    }
}
