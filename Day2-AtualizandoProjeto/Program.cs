using System;
using System.Data.Common;

class Program
{
    public static string calcularNota(decimal mediaNotaAtual)
    {
        string letraAlunoAtual = "";
        if (mediaNotaAtual >= 97) letraAlunoAtual = "A+";
        else if (mediaNotaAtual >= 93) letraAlunoAtual = "A";
        else if (mediaNotaAtual >= 90) letraAlunoAtual = "A-";
        else if (mediaNotaAtual >= 87) letraAlunoAtual = "B+";
        else if (mediaNotaAtual >= 83) letraAlunoAtual = "B";
        else if (mediaNotaAtual >= 80) letraAlunoAtual = "B-";
        else if (mediaNotaAtual >= 77) letraAlunoAtual = "C+";
        else if (mediaNotaAtual >= 73) letraAlunoAtual = "C";
        else if (mediaNotaAtual >= 70) letraAlunoAtual = "C-";
        else if (mediaNotaAtual >= 67) letraAlunoAtual = "D+";
        else if (mediaNotaAtual >= 63) letraAlunoAtual = "D";
        else if (mediaNotaAtual >= 60) letraAlunoAtual = "D-";
        else letraAlunoAtual = "F";

        return letraAlunoAtual;
    }
    public static void Main(string[] args)
    {
        // initialize variables - graded assignments 
        int totalExames = 5;

        int[] notasSophia = { 90, 86, 87, 98, 100, 94, 90 };
        int[] notasAndrew = { 92, 89, 81, 96, 90, 89 };
        int[] notasEmma = { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] notasLogan = { 90, 95, 87, 88, 96, 96 };

        string[] nomeAlunos = { "Sophia", "Andrew", "Emma", "Logan" };
        string letraAlunoAtual = "";

        int[] mediaAluno = new int[10];

        Console.WriteLine("Aluno\t\tAvaliações\tNota Geral\tNota Final\tPontos Extras\n");

        foreach (string nome in nomeAlunos)
        {
            string alunoAtual = nome;

            if (alunoAtual == "Sophia")
            {
                mediaAluno = notasSophia;
            }
            else if (alunoAtual == "Andrew")
            {
                mediaAluno = notasAndrew;
            }
            else if (alunoAtual == "Emma")
            {
                mediaAluno = notasEmma;
            }
            else if (alunoAtual == "Logan")
            {
                mediaAluno = notasLogan;
            }

            int somaExames = 0;
            int somaPontosExtras = 0;
            decimal mediaNotaAtual = 0;
            decimal mediaExames = 0;
            decimal mediaPontosExtras = 0;
            int qtdAtividades = 0;
            foreach (int notas in mediaAluno)
            {
                qtdAtividades += 1;
                if (qtdAtividades <= totalExames)
                {
                    somaExames += notas;
                }
                else
                {
                    somaPontosExtras += notas / 10;
                }
            }
            mediaNotaAtual = (decimal)(somaExames + somaPontosExtras) / totalExames;
            mediaExames = (decimal)somaExames / totalExames;
            mediaPontosExtras = (decimal)somaPontosExtras / totalExames;
            letraAlunoAtual = calcularNota(mediaNotaAtual);

            Console.WriteLine($"{alunoAtual}\t\t{mediaExames}\t\t{mediaNotaAtual}\t\t" +
              $" {letraAlunoAtual}\t\t {mediaPontosExtras} pts");
        }

        Console.WriteLine("Aperte o Enter para continuar");
        Console.ReadLine();

    }
    
}