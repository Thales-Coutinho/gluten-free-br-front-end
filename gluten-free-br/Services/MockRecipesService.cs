using gluten_free_br.Model;
using gluten_free_br.Interfaces;

namespace gluten_free_br.Services
{
    public class MockRecipesService : IRecipesService
    {
        private Recipe[] mockRecipes =
        {
            new Recipe { Id = 1, Name = "Recipe 1", Text = "faz isso, depois aquilo, depois aquilo outro" },
            new Recipe { Id = 2, Name = "Recipe 2", Text = "faz isso, depois aquilo, depois aquilo outro" }
        };

        public Task<Recipe[]> GetRecipesAsync()
        {
            return Task.FromResult(mockRecipes);
        }

        public Task<Recipe> GetRecipesByIdAsync(int id)
        {
            var recipe = mockRecipes.FirstOrDefault(r => r.Id == id);
            return Task.FromResult(recipe);
        }
    }
}
