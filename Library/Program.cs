using System;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo a Biblioteca Online!");

            Biblioteca biblioteca = new Biblioteca();

            bool want = true;
            bool tnaw = false;


            do
            {
                Console.WriteLine("Gostaria de adicionar um item a sua biblioteca? Digite 'Sim' ou 'Não'");
                string addDecision = Console.ReadLine();

                if (addDecision.ToLower() == "sim")
                {
                    Console.WriteLine("Perfeito!");

                    biblioteca.AdicionarItem();



                    Console.WriteLine("Deseja adicionar outro item a sua biblioteca? Digite 'Sim' ou 'Não' ");
                    string progressDecision = Console.ReadLine();
                    if (progressDecision.ToLower() == "sim")
                    {
                        Console.WriteLine("Perfeito!");

                        biblioteca.AdicionarItem();
                    }
                    else if (progressDecision.ToLower() == "não")
                    {
                        want = false;
                        tnaw = true;

                    }

                }
                else if (addDecision.ToLower() == "não")
                {
                    Console.WriteLine("Tudo bem! Já que você não possui nenhum item e não deseja utilizar a biblioteca, o programa será encerrado. Muito obrigado por utiliza-lo!");
                    return;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite 'Sim' ou 'Não'. ");
                    
                }
            } while (want == true);


            do
            {
                Console.WriteLine("Gostaria de ver os itens em sua biblioteca? Digite 'Sim' ou 'Não'.");
                string viewDecision = Console.ReadLine();

                if (viewDecision.ToLower() == "sim")
                {
                    Console.WriteLine("Perfeito!");

                    biblioteca.ListarItens();

                    Console.WriteLine(" ");
                    Console.WriteLine("Muito obrigado por utilizar o nosso programa!");

                    tnaw = false;
                }
                else if (viewDecision.ToLower() == "não")
                {
                    Console.WriteLine("Tudo bem! Já que não deseja visualizar a sua biblioteca e nem adicionar outro item o programa será encerrado. Muito obrigado por utiliza-lo!");
                    tnaw = false;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite 'Sim' ou 'Não'. ");

                }
            } while (tnaw == true);
 

        }
    }

}


