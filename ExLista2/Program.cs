//na lista eu consigo trabalhar com lista de objetos

//Aluno aluno1 = new Aluno();
//aluno1.Nome = "Elias";
//aluno1.Cpf = "222";

//Aluno aluno2 = new Aluno(11, "Maria", "223322", new DateOnly(1985, 07, 22));

//List<Aluno> alunos = new List<Aluno>();
//alunos.Add(aluno1);
//alunos.Add(aluno2);

//foreach (Aluno a in alunos)
//{
//Console.WriteLine("O nome é " + a.Nome + " " + a.Cpf);

//}


string resposta;
List<Aluno> alunos = new List<Aluno>();

while (true)
{
    Console.WriteLine("Deseja cadastrar um aluno? ");
    resposta = Console.ReadLine();
    if(resposta == "sim")
    {
        Aluno aluno1 = new Aluno();
        
        Console.WriteLine("Informe a matricula, nome, cpf e data de nascimento do aluno: ");
        
        aluno1.Matricula = Convert.ToInt32(Console.ReadLine());
        aluno1.Nome = Console.ReadLine();
        aluno1.Cpf = Console.ReadLine();
        aluno1.DataNascimento = Convert.ToDateTime(Console.ReadLine());
        alunos.Add(aluno1);


    }
    else if(resposta == "não")
    {
        break;
    }
}


foreach(Aluno aluno in alunos)
{
    Console.WriteLine("Nome: " + aluno.Nome + " " + "Cpf: " + aluno.Cpf );
}