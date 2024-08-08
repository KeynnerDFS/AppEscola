using AppEscola.RegarasDeNegocio;

Aluno[] salaDeAula = new Aluno[350];

int cont = 1;
int posição = 0;
int opção = 0;
//############################# Função para cadastrar aluno ############################

void CadastarAlunos()
{
    int opc = 1;
    while (opc != 0)
    {
        if (cont < 350)
        {
            Aluno aluno = new Aluno();
            Console.Clear();
            Console.WriteLine("%%%%%%%%%%%%%%% CADASTRAR ALUNO %%%%%%%%%%%%%%%");
            Console.WriteLine();
            Console.WriteLine("Número de Inscrição.......:"+cont);
            aluno.Id = cont;
            aluno.NumeroDeMatricula = cont * 1000;
            Console.Write("Nome................:");
            aluno.Nome = Console.ReadLine();
            Console.Write("Nota1...............:");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nota1...............:");
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
            salaDeAula[posição] = aluno;
            cont++; posição++;
            Console.Write("Deseja continuar cadastrando? S/N:");
            string resp = Console.ReadLine();
            if (resp.ToUpper() == "N") opc = 0;
          
        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VAGAS ESGOTADAS!!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }//fim do if
    }//fim do while
}//fim cadastrar aluno
void ListarAlunosMatriculados()
{
    Console.Clear();
    Console.WriteLine("@@@@@@@@@@@@@@@@@@ LISTA DOS ALUNOS CADASTRADOS @@@@@@@@@@@@@@@@");
    Console.WriteLine();
    Aluno aluno = new Aluno();
    for (int i = 0; i < posição; i++)
    {
        aluno = salaDeAula[i];
        Console.WriteLine("_____________________________________");
        Console.WriteLine("Id....................!" + aluno.Id);
        Console.WriteLine("Matrícula.............!" + aluno.NumeroDeMatricula);
        Console.WriteLine("Nome..................!" + aluno.Nome);
        Console.WriteLine("Nota1.................!" + aluno.Nota1);
        Console.WriteLine("Nota2.................!" + aluno.Nota2);
        Console.WriteLine("Média.................!" + aluno.CalcularMedia());
        if (aluno.CalcularMedia() < 60) Console.ForegroundColor = ConsoleColor.DarkRed;
        if (aluno.CalcularMedia() >= 60) Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Situação..............!" + aluno.MostrarSituação());
        Console.ForegroundColor = ConsoleColor.White;
    }


    Console.ReadKey();

}//fim de listar alunos
void ConsultarAlunos()
{
    Aluno aluno = new Aluno();
    Console.WriteLine();
    Console.Write("Pesquise o aluno pela Matricula: ");
    int escolha = Convert.ToInt32(Console.ReadLine());

   if(escolha > 0)
    {
        aluno = salaDeAula[(escolha / 1000) - 1];
        Console.WriteLine("_____________________________________");
        Console.WriteLine("Id....................!" + aluno.Id);
        Console.WriteLine("Matrícula.............!" + aluno.NumeroDeMatricula);
        Console.WriteLine("Nome..................!" + aluno.Nome);
        Console.WriteLine("Nota1.................!" + aluno.Nota1);
        Console.WriteLine("Nota2.................!" + aluno.Nota2);
        Console.WriteLine("Média.................!" + aluno.CalcularMedia());
        if (aluno.CalcularMedia() < 60) Console.ForegroundColor = ConsoleColor.DarkRed;
        if (aluno.CalcularMedia() >= 60) Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Situação..............!" + aluno.MostrarSituação());
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.ReadKey();

}//Fim de consultar aluno
void ListarAlunosAprovados()
{
    Aluno aluno = new Aluno();

    for (int i = 0; i < posição; i++)
    {
        aluno = salaDeAula[i];
        if (aluno.CalcularMedia() >= 60)
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Id....................!" + aluno.Id);
            Console.WriteLine("Matrícula.............!" + aluno.NumeroDeMatricula);
            Console.WriteLine("Nome..................!" + aluno.Nome);
            Console.WriteLine("Nota1.................!" + aluno.Nota1);
            Console.WriteLine("Nota2.................!" + aluno.Nota2);
            Console.WriteLine("Média.................!" + aluno.CalcularMedia());
            if (aluno.CalcularMedia() < 60) Console.ForegroundColor = ConsoleColor.DarkRed;
            if (aluno.CalcularMedia() >= 60) Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Situação..............!" + aluno.MostrarSituação());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    Console.ReadKey();
}
void ListarAlunosReprovados()
{
    Aluno aluno = new Aluno();

    for (int i = 0; i < posição; i++)
    {
        aluno = salaDeAula[i];
        if (aluno.CalcularMedia() < 60)
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Id....................!" + aluno.Id);
            Console.WriteLine("Matrícula.............!" + aluno.NumeroDeMatricula);
            Console.WriteLine("Nome..................!" + aluno.Nome);
            Console.WriteLine("Nota1.................!" + aluno.Nota1);
            Console.WriteLine("Nota2.................!" + aluno.Nota2);
            Console.WriteLine("Média.................!" + aluno.CalcularMedia());
            if (aluno.CalcularMedia() < 60) Console.ForegroundColor = ConsoleColor.DarkRed;
            if (aluno.CalcularMedia() >= 60) Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Situação..............!" + aluno.MostrarSituação());
            Console.ForegroundColor = ConsoleColor.White;
        }
     
    }
    Console.ReadKey();
}


while (opção!=7)
{
    Console.Clear();//Limpar tela
    Console.WriteLine("@@@@@@@@@@ MENU @@@@@@@@@@");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Listar alunos matrículados");
    Console.WriteLine("3 - Consultar aluno por Número de Matrícula");
    Console.WriteLine("4 - Listar alunos aprovados");
    Console.WriteLine("5 - Listar alunos Reprovados");
    Console.WriteLine("7 - Fechar Sistema");
    Console.Write("Opção N°......................................:");
    opção = Convert.ToInt32(Console.ReadLine());
    switch (opção)
    {
        case 1:
            {
                CadastarAlunos();
                break;
            }//fim do case 1
        case 2:
            {
                ListarAlunosMatriculados();
                break;
            }//fim do case 2
        case 3:
            {
                ConsultarAlunos();
                break;
            }//fim do case 3
        case 4:
            {
                ListarAlunosAprovados();
                break;
            }//fim do case 4
        case 5:
            {
                ListarAlunosReprovados();
                break;
            }//fim do case 5
        case 7:
            {
                Console.Clear();
                Console.WriteLine("Desaja mesmo Fechar o SISTEMA? S/N");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "N") opção = 0;
                break;
            }//fim do case 7
        default:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OPÇÃO INVÁLIDA");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                break;
            }//Fim do default
    }//fim do switch



}//fim do laço principal
