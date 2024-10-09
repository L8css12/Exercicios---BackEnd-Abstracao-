namespace Atv___02
{
    public class Aluno
    {
        public int RM {  get; set; }

        public string Nome { get; set; }

        public DateTime Nascimento { get; set; }

        public string Email { get; set; }

        public Aluno(int rm, string nome, DateTime nascimento, string email)
        {
            RM = rm;
            Nome = nome;
            Nascimento = nascimento;
            Email = email;
        }

        public void InfAluno()
        {
            Console.WriteLine("As informações dos Alunos são: ");
        }
    }
}
