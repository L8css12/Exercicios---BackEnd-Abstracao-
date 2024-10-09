// Instanciar a classe e os nomes

using Atv___01;

Livro livro1 = new Livro("Romeu E Julieta", "William", "kkkkk", 1595);

Livro livro2 = new Livro("O Pequeno Príncipe", "Antoine", "llllll", 1943);

Livro livro3 = new Livro("A cabana", "William P.", "iiiii", 2007);

livro1.Livros();

Console.WriteLine($"\n O Titulo do primeiro livro é: {livro1.Titulo}, O Autor é: {livro1.Autor}, A editora é: {livro1.Editora} e o seu ano de lançamento é: {livro1.Lancamento}");
Console.WriteLine($"\n O Titulo do segundo livro é: {livro2.Titulo}, O autor é: {livro2.Autor}, A editora é: {livro2.Editora}, e o seu ano de lançamento é: {livro2.Lancamento}");
Console.WriteLine($"\n O Titulo do segundo livro é: {livro3.Titulo}, O autor é: {livro3.Autor}, A editora é: {livro3.Editora}, e o seu ano de lançamento é: {livro3.Lancamento}");


Console.ReadKey();