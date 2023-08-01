public class Aluno
{
    public int Matricula { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }

    public DateTime DataNascimento { get; set; }    

    public Aluno()
    {

    }

    public Aluno(int matricula, string nome, string cpf, DateTime dataNascimento)
    {
        this.Matricula = matricula;
        this.Nome = nome;
        this.Cpf = cpf;
        this.DataNascimento = dataNascimento;
    }   
}

