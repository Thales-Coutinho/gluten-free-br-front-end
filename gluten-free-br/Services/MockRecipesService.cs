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
                Text = @"<p><strong>Ingredientes:</strong></p>
                        <p>Copo medida de 200ml</p>
                        <p>4 ovos</p>
                        <p>1/2 copo de óleo</p>
                        <p>1 1/2 copo de açúcar</p>
                        <p>Milho verde cru de duas espigas</p>
                        <p>3/4 de copo de coco ralado sem açúcar</p>
                        <p>1 copo de creme de arroz</p>
                        <p>1 colher de sopa de fermento químico</p>

                        <p><strong>Modo de preparo:</strong></p>
                        <p>Bater os ovos no liquidificador por 5 minutos. Acrescentar o óleo, o açúcar, o milho e o coco e triturar bem. Desligar o liquidificador e acrescentar o creme de arroz e o fermento apenas pulsando. Assar em forma untada e enfarinhada (farinha de arroz), em forno a 180 graus.</p>
                        <p>Pode misturar na massa uma colher de sobremesa de semente de erva doce. Não bater para não triturar as sementes.</p>",
                Image = "BoloCaipiraMock.png"
                },
            new Recipe {
                Id = 2,
                Name = "Bala de amêndoas",
                Text = @"<p><strong>Ingredientes:</strong></p>
                        <p>1 e 1/2 xícara de farinha de arroz</p>
                        <p>4 colheres de sopa de farinha de castanha-do-pará</p>
                        <p>2 colheres de sopa de castanha do Pará picada</p>
                        <p>1 xícara de chá de açúcar mascavo</p>
                        <p>3 colheres de sopa (cheia) de manteiga</p>
                        <p>1 ovo (médio)</p>
                        <p>4 colheres de sopa de uva-passa</p>
                        <p>1 colher de café (rasa) de sal</p>
                        <p>1 colher de chá de bicarbonato de sódio</p>

                        <p><strong>Modo de preparo:</strong></p>
                        <p>Misturar manualmente a farinha de arroz, a farinha de castanha-do-pará, a castanha-do-pará, a uva-passa, o sal e o bicarbonato. Reservar.</p>
                        <p>Em outra tigela, misturar a manteiga e o açúcar até formar um creme.</p>
                        <p>Adicionar o ovo e misturar até a formação de uma mistura homogênea.</p>
                        <p>Adicionar os ingredientes secos nessa mistura e amassar manualmente até completa homogeneização.</p>
                        <p>Modelar os biscoitos manualmente em formato de cookie.</p>
                        <p>Assar em forno preaquecido a 180 °C por 10 minutos ou até dourar.</p>",
                Image= "BalaAmendoasMock.png"
                },
            new Recipe {
                Id = 3,
                Name = "Chips de cenoura",
                Text = @"<p><strong>Ingredientes:</strong></p>
                        <p>3 cenouras cruas descascadas e cortadas em rodelas finas</p>
                        <p>2 colheres (sopa) de azeite de oliva extravirgem</p>
                        <p>1 pitada de sal</p>
                        <p>Ervas secas a gosto</p>

                        <p><strong>Modo de preparo:</strong></p>
                        <p>Tempere as rodelas de cenoura com o azeite, o sal e as ervas secas.</p>
                        <p>Coloque em uma assadeira antiaderente, espalhe bem para não ficarem grudadas.</p>
                        <p>Leve ao forno baixo a 150-160 graus por cerca de 35 minutos, ou até que fiquem assadas e crocantes.</p>

                        <p><strong>Dica:</strong></p>
                        <p>Você pode substituir as cenouras por batata doce, batata normal, mandioca, mandioquinha. Fica uma delícia. Experimente!</p>",
                Image= "ChipCenouraMock.png"
                },
            new Recipe {
                Id = 4,
                Name = "Torta de abobrinha",
                Text = @"<p><strong>Ingredientes:</strong></p>
                        <p>600g (aproximadamente) de abobrinha ralada no ralo grosso</p>
                        <p>1 xícara (chá) de repolho picado bem fininho</p>
                        <p>1 cebola média picadinha</p>
                        <p>1 tomate firme sem sementes picado em quadradinhos</p>
                        <p>½ xícara (chá) de azeitonas verdes picadas</p>
                        <p>Cheiro verde picado</p>

                        <p><strong>Modo de preparo:</strong></p>
                        <p>Tempere os ingredientes com: um fio de azeite, sal, e o que você gostar.</p>
                        <p>4 ovos batidos</p>
                        <p>½ xícara (chá) de farinha de arroz</p>
                        <p>2 colheres (sopa) de parmesão</p>
                        <p>1 colher (chá) de fermento químico em pó (para bolo)</p>
                        <p>Misture todos os ingredientes e coloque em um pirex untado e polvilhado.</p>
                        <p>Espalhe queijo parmesão ralado por cima e leve ao forno até dourar levemente.</p>",
                Image= "TortaAbobrinhaMock.png"
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
