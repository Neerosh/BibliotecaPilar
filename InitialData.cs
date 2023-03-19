using BibliotecaPilar.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPilar
{
    internal class InitialData
    {
        public InitialData() {

            using (DataContext dataContext = new DataContext())
            {
                //Criação dos usuários padrões
                if (dataContext.Users.Where(user => user.UserType == "Administrador").FirstOrDefault() == null)
                {
                    Models.User user = new Models.User()
                    {
                        Name = "Administrador",
                        Username = "admin",
                        Password = "admin",
                        UserType = "Administrador"
                    };
                    dataContext.Users.Add(user);
                }

                if (dataContext.Users.Where(user => user.UserType == "Usuário").FirstOrDefault() == null)
                {
                    Models.User user = new Models.User()
                    {
                        Name = "Usuário Padrão",
                        Username = "usuario",
                        Password = "123",
                        UserType = "Usuário"
                    };
                    dataContext.Users.Add(user);
                }

                //Criação dos Livros Iniciais
                if (dataContext.Books.FirstOrDefault() == null)
                {
                    Models.Book book = new Models.Book()
                    {
                        Name = "Roadside Picnic",
                        Author = "Arkady and Boris Strugatsky",
                        ReleaseDate = DateTime.ParseExact("01/01/1972","dd/MM/yyyy",CultureInfo.InvariantCulture),
                        Status = "Disponível",
                        Synopsis = "A obra tem como plano de fundo as chamadas \"Visitações\", visitas de seres alienígenas à Terra." +
                        " O título do livro surge à partir da teoria de um dos cientistas apresentados no livro, que tais visitas teriam sido \"acidentais\"," +
                        " como se os alienígenas tivessem apenas parado em nosso planeta para descansar um pouco de sua viagem" +
                        " (como se fizessem um piquenique na beira de uma estrada). Durante esta parada, eles teriam esquecido alguns itens no local," +
                        " os quais alterariam a natureza criando as chamadas \"Zonas\". "
                    };
                    dataContext.Books.Add(book);

                    book = new Models.Book()
                    {
                        Name = "Arthas: Rise of the Lich King",
                        Author = "Christie Golden",
                        ReleaseDate = DateTime.ParseExact("21/04/2009", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Status = "Disponível",
                        Synopsis = "Quando uma praga de morte-viva ameaçou tudo o que ele amava, Arthas foi forçado a buscar uma lâmina rúnica poderosa o bastante para salvar seu lar." +
                        " Mas o objeto dessa busca cobraria um preço pesado de seu novo mestre, dando início a uma terrível caminhada rumo à perdição." +
                        " O caminho de Arthas o levou pelos ermos árticos do norte em direção ao Trono de Gelo, onde enfim teria o mais sombrio dos destinos."
                    };
                    dataContext.Books.Add(book);

                    book = new Models.Book()
                    {
                        Name = "O Último Desejo",
                        Author = "Andrzej Sapkowski",
                        ReleaseDate = DateTime.ParseExact("04/06/1993", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        Status = "Disponível",
                        Synopsis = "Geralt de Rívia é um bruxo sagaz e habilidoso. Um assassino impiedoso e de sangue-frio treinado, desde a infância," +
                        " para caçar e eliminar monstros. Seu único objetivo: destruir as criaturas do mal que assolam o mundo." +
                        " Um mundo fantástico criado por Sapkowski com claras influências da mitologia eslava. Um mundo em que nem todos os que parecem monstros são maus nem todos os que parecem anjos são bons..."
                    };
                    dataContext.Books.Add(book);

                }

                dataContext.SaveChanges();
            };


        }
    }
}
