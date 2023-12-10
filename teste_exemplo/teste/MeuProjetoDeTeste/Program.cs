//MeuProjetoDeTeste/Program.cs

using System;
using System.Collections.Generic; // Adicione esta linha
using MinhaBiblioteca;


namespace MeuProjetoDeTeste
{
    class Program
    {
        static void Main()
        {
            // Adicionar alguns alunos para teste
            Escola escola = new Escola();
            escola.AdicionarAluno('A', new Aluno("Alice", "Engenharia", "Matemática", "Normal", true));
            escola.AdicionarAluno('B', new Aluno("Bob", "Engenharia", "Matemática", "Normal", false));
            escola.AdicionarAluno('C', new Aluno("Charlie", "Ciência da Computação", "Programação", "Recurso", true));
            escola.AdicionarAluno('D', new Aluno("David", "Ciência da Computação", "Programação", "Normal", true));


            // Obter alunos aprovados em "Matemática" para o curso "Engenharia" na época "Normal"
            List<Aluno> aprovados = escola.ObterAlunosAprovados("Matemática", "Engenharia", "Normal");

            // Exibir resultados
            Console.WriteLine("Alunos Aprovados:");
            foreach (var aluno in aprovados)
            {
                Console.WriteLine($"{aluno.Nome} - Curso: {aluno.Curso}, Época: {aluno.Epoca}");
            }

            // Aguardar pressionar Enter antes de fechar a console
            Console.ReadLine();
        }
    }
}
