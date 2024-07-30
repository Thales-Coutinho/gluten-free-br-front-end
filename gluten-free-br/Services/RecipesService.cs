using System.Net.Http.Json;
using gluten_free_br.Model;
using gluten_free_br.Interfaces;

namespace gluten_free_br.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly HttpClient _httpClient;

        public RecipesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Recipe[]> GetRecipesAsync()
        {
            string url = "http://localhost:5125/Recipe/v1";
            return await _httpClient.GetFromJsonAsync<Recipe[]>(url);
        }

        public async Task<Recipe> GetRecipesByIdAsync(int id)
        {
            string url = $"http://localhost:5125/Recipe/v1/{id}";
            return await _httpClient.GetFromJsonAsync<Recipe>(url);
        }
    }
}