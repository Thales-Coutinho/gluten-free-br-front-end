using gluten_free_br.Model;

namespace gluten_free_br.Interfaces
{
    public interface IRecipesService
    {
        Task<Recipe[]> GetRecipesAsync();
        Task<Recipe> GetRecipesByIdAsync(int id);
    }
}