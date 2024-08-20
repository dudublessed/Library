using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{

    class Biblioteca
    {
        private List<Item> itens;

        public Biblioteca()
        {
            itens = new List<Item>();
        }


        public void AdicionarItem()
        {

            Console.WriteLine("Você gostaria de adicionar um Livro ou uma Revista? Digite o respectivo nome.");
            string itemDecision = Console.ReadLine();

            if (itemDecision.ToLower() == "livro")
            {
                Console.WriteLine("Digite o nome do Livro: ");
                string bookTitle = Console.ReadLine();

                Console.WriteLine("Agora digite o nome do Autor do Livro: ");
                string bookAuthor = Console.ReadLine();

                Console.WriteLine("Agora digite o Ano de Publicação do Livro: ");
                int bookData;
                while (!int.TryParse(Console.ReadLine(), out bookData))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o ano de publicação.");
                }

                Console.WriteLine("Por fim, digite o ISBN (10 ou 13) do Livro: ");
                string bookISBN = Console.ReadLine();

                Item livro = new Livro(bookTitle, bookAuthor, bookData, bookISBN);
                itens.Add(livro);

                livro.MostrarInformacoes();
            }
            else if (itemDecision.ToLower() == "revista")
            {
                Console.WriteLine("Digite o nome da Revista: ");
                string magzTitle = Console.ReadLine();

                Console.WriteLine("Agora digite o nome do Autor da Revista: ");
                string magzAuthor = Console.ReadLine();

                Console.WriteLine("Agora digite o Ano de Publicação da Revista: ");
                int magzData;
                while (!int.TryParse(Console.ReadLine(), out magzData))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o ano de publicação.");
                }

                Console.WriteLine("Por fim, digite o Número de Edição da Revista: ");
                int magzNumEdition;
                while (!int.TryParse(Console.ReadLine(), out magzNumEdition))
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro para o número de edição da revista.");
                }

                Item revista = new Revista(magzTitle, magzAuthor, magzData, magzNumEdition);
                itens.Add(revista);

                revista.MostrarInformacoes();
            }
            else
            {
                Console.WriteLine("Tudo bem! Já que você não possui nenhum item e não deseja utilizar a biblioteca, o programa será encerrado. Muito obrigado por utiliza-lo!");
            }

        }


        public void ListarItens()
        {
            Console.WriteLine("");
            Console.WriteLine("Itens da sua lista: ");

            foreach (Item item in itens)
            {
              if (item is Livro livro)
                {
                    Console.WriteLine("______________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Titulo do livro: {livro.Titulo}");
                    Console.WriteLine($"Autor de {livro.Titulo}: {livro.Autor}");
                    Console.WriteLine($"Ano da publicação de {livro.Titulo}: {livro.AnoPublicacao}");
                    Console.WriteLine($"ISBN de {livro.Titulo}: {livro.ISBN}");
                    Console.WriteLine(" ");
                    Console.WriteLine("______________________________________");
                }
                else if (item is Revista revista)
                {
                    Console.WriteLine("______________________________________");
                    Console.WriteLine(" ");
                    Console.WriteLine($"Titulo da revista: {revista.Titulo}");
                    Console.WriteLine($"Autor de {revista.Titulo}: {revista.Autor}");
                    Console.WriteLine($"Ano da publicação de {revista.Titulo}: {revista.AnoPublicacao}");
                    Console.WriteLine($"Número de edição de {revista.Titulo}: {revista.NumeroEdicao}");
                    Console.WriteLine(" ");
                    Console.WriteLine("______________________________________");
                }
                else
                {
                    Console.WriteLine("Tipo desconhecido.");
                }
            }
        }


    }
}
