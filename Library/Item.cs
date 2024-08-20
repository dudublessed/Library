using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Item
    {
        public string Titulo;
        public string Autor;
        public int AnoPublicacao;

        public Item(string nomeTitulo, string nomeAutor, int numAno)
        {
            Titulo = nomeTitulo;
            Autor = nomeAutor;
            AnoPublicacao = numAno;
        }

        public virtual void MostrarInformacoes()
        {
            Console.WriteLine("Título do item: " + Titulo);
            Console.WriteLine("Autor do item: " + Autor);
            Console.WriteLine("Ano de Publicação do item: " + AnoPublicacao);
        }
    }

    class Livro : Item
    {
        public string ISBN;

        public Livro(string nomeTitulo, string nomeAutor, int numAno, string isbn) : base(nomeTitulo, nomeAutor, numAno)
        {
            ISBN = isbn;
        }

        public override void MostrarInformacoes()
        {
            base.MostrarInformacoes();
            Console.WriteLine("ISBN do livro: " + ISBN);
        }
    }

    class Revista : Item
    {
        public int NumeroEdicao;

        public Revista(string nomeTitulo, string nomeAutor, int numAno, int numEdicao) : base(nomeTitulo, nomeAutor, numAno)
        {
            NumeroEdicao = numEdicao;
        }

        public override void MostrarInformacoes()
        {
            base.MostrarInformacoes();
            Console.WriteLine("Número de edição da revista: " + NumeroEdicao);
        }
    }

}
