using gluten_free_br.Model;
using gluten_free_br.Interfaces;

namespace gluten_free_br.Services
{
    public class MockRecipesService : IRecipesService
    {
        private Recipe[] mockRecipes =
        {
            new Recipe {
                Id = 1,
                Name = "Receita 1",
                Text = "Quer um bolo para o lanche da tarde, mas não consegue se decidir sobre qual você deve fazer? O bolo comum é uma boa pedida. A massa branca e fofinha é deliciosa e acompanhada com uma xícara de café é imbatível. Por ter um sabor neutro, esse bolo pode ser combinado com diversas coberturas e recheios sem ter nenhum tipo de oposição negativa. Ele também pode ser feito como base para bolos de aniversários, inclusive por confeiteiros. Basta dividir a massa, colocar os recheios entre as camadas e confeitá-lo como você quiser. Essa receita também pode servir de base para outras, já que é só adicionar um ingrediente para mudar o sabor do bolo. Para fazer um bolo de chocolate, basta adicionar um pouco de chocolate em pó à massa e bater antes de assar. Muito versátil, a receita de bolo simples é deliciosa e vai deixar o seu café da tarde ainda mais gostoso."
                },
            new Recipe {
                Id = 2,
                Name = "Receita 2",
                Text = "Quer um bolo para o lanche da tarde, mas não consegue se decidir sobre qual você deve fazer? O bolo comum é uma boa pedida. A massa branca e fofinha é deliciosa e acompanhada com uma xícara de café é imbatível. Por ter um sabor neutro, esse bolo pode ser combinado com diversas coberturas e recheios sem ter nenhum tipo de oposição negativa. Ele também pode ser feito como base para bolos de aniversários, inclusive por confeiteiros. Basta dividir a massa, colocar os recheios entre as camadas e confeitá-lo como você quiser. Essa receita também pode servir de base para outras, já que é só adicionar um ingrediente para mudar o sabor do bolo. Para fazer um bolo de chocolate, basta adicionar um pouco de chocolate em pó à massa e bater antes de assar. Muito versátil, a receita de bolo simples é deliciosa e vai deixar o seu café da tarde ainda mais gostoso."
                }
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
