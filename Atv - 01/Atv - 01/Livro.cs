namespace Atv___01
{
    public class Livro
    {
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editora { get; set; }

        public int Lancamento { get; set; }

        //Adicionar o Construtor
        public Livro(string titulo, string autor, string editora, int lancamento)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Lancamento = lancamento;
        }

        public void Livros()
        {
            Console.WriteLine("Os tres livros são: ");
        }
    }
}
