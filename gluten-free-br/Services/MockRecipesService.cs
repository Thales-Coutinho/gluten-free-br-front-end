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
                Name = "Bolo caipira",
                Text = @"Ingredientes: Copo medida de 200ml 
                        4 ovos 
                        1/2 copo de óleo 
                        1 1/2 copo de açúcar 
                        milho verde cru de duas espigas 
                        3/4 de copo de coco ralado sem açúcar 
                        1 copo de creme de arroz 
                        1 colher de sopa de fermento químico

                        Modo de preparo: 
                        Bater os ovos no liquidificador por 5 minutos. Acrescentar o óleo, o açúcar, o milho e o coco e triturar bem. Desligar o liquidificador e acrescentar o creme de arroz e o fermento apenas pulsando. Assar em forma untada e enfarinhada (farinha de arroz), em forno a 180 graus. 
                        Pode misturar na massa uma colher de sobremesa de semente de erva doce. Não bater para não triturar as sementes.",
                Image = "ImageMock.jpg"
                },
            new Recipe {
                Id = 2,
                Name = "Biscoito de castanha-do-pará",
                Text = @"Ingredientes:
                        1 e 1/2 xícara de farinha de arroz 
                        4 colheres de sopa de farinha de castanha-do-pará 
                        2 colheres de sopa de castanha do Pará picada 
                        1 xícara de chá de açúcar mascavo 
                        3 colheres de sopa (cheia) de manteiga 
                        1 ovo (médio)
                        4 colheres de sopa de uva-passa
                        1 colher de café (rasa) de sal 
                        1 colher de chá de bicarbonato de sódio

                        Modo de preparo: 
                        Misturar manualmente a farinha de arroz, a farinha de castanha-do-pará, a castanha-do-pará, a uva-passa, o sal e o bicarbonato. Reservar.
                        Em outra tigela, misturar a manteiga e o açúcar até formar um creme.
                        Adicionar o ovo e misturar até a formação de uma mistura homogênea.
                        Adicionar os ingredientes secos nessa mistura e amassar manualmente até completa homogeneização
                        Modelar os biscoitos manualmente em formato de cookie.
                        Assar em forno preaquecido a 180 °C por 10 minutos ou até dourar",
                Image= "ImageMock.jpg"
                },
            new Recipe {
                Id = 3,
                Name = "Chips de cenoura",
                Text = @"Ingredientes:
                        3 cenouras cruas descascadas e cortadas em rodelas finas
                        2 colheres (sopa) de azeite de oliva extravirgem
                        1 pitada de sal
                        ervas secas a gosto

                        Modo de preparo: 
                        Tempere as rodelas de cenoura com o azeite, o sal e
                        as ervas secas.
                        Coloque em uma assadeira antiaderente, espalhe
                        bem para não ficarem grudadas.
                        Leve ao forno baixo a 150-160 graus por cerca de
                        35 minutos, ou até que fiquem assadas e crocantes.

                        Dica:
                        Você pode substituir as cenouras por batata doce,
                        batata normal, mandioca, mandioquinha. Fica uma
                        delícia. Experimente!",
                Image= "ImageMock.jpg"
                },
            new Recipe {
                Id = 4,
                Name = "Torta de abobrinha",
                Text = @"Ingredientes:  
                        600g (aproximadamente) de abobrinha ralada no ralo grosso 
                        1 xícara (chá) de repolho picado bem fininho 
                        1 cebola média picadinha
                        1 tomate firme sem sementes picado em quadradinhos ½ xícara (chá) de azeitonas verdes picadas 
                        cheiro verde picado

                        Modo de preparo: 
                        Tempere os ingredientes com: um fio de azeite, sal, e o que você gostar.
                        4 ovos batidos ½ xícara (chá) de farinha de arroz 2 colheres (sopa) de parmesão 1 colher (chá) de fermento químico em pó (para bolo) 
                        Misture todos os ingredientes e coloque em um pirex untado e polvilhado. 
                        Espalhe queijo parmesão ralado por cima e leve ao forno até dourar levemente.",
                Image= "ImageMock.jpg"
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
