using Atv___02;

Aluno aluno1 = new Aluno (2222, "Lucas B.M", new (2007,10,10), "miorimlucas@outlook.com");
Aluno aluno2 = new Aluno(2444, "Teodoro", new (2006, 11, 11), "miorimlucas@outlook.com");
Aluno aluno3 = new Aluno(2265, "Gabriel", new (2005, 12, 10), "miorimlucas@outlook.com");




aluno1.InfAluno();

Console.WriteLine($"O RM do primeiro aluno é: {aluno1.RM}, O nome dele é: {aluno1.Nome}, A data de nascimento é: {aluno1.Nascimento} e seu email é: {aluno1.Email}");
Console.WriteLine($"O RM do primeiro aluno é: {aluno2.RM}, O nome dele é: {aluno2.Nome}, A data de nascimento é: {aluno2.Nascimento} e seu email é: {aluno2.Email}");
Console.WriteLine($"O RM do primeiro aluno é: {aluno3.RM}, O nome dele é: {aluno3.Nome}, A data de nascimento é: {aluno3.Nascimento} e seu email é: {aluno3.Email}");

Console.ReadKey();