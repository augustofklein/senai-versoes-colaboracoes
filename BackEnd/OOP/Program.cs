namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var livros = new List<Livro>()
            {
                new Livro(){Id=1, Titulo="Do mil ao milhão", Preco=12},
                new Livro(){Id=2, Titulo="O Poder do Agora", Preco=12},
                new Livro(){Id=3, Titulo="Comece pelo porquê", Preco=12},
                new Livro(){Id=4, Titulo="Breves Respostas para grandes questões", Preco=12}
            };

            Console.WriteLine(livros.Count);

            livros.ForEach(livros => Console.WriteLine(livros.Titulo));

            Conta conta = new Conta();

            conta.Depositar(100);
        }
    }
}