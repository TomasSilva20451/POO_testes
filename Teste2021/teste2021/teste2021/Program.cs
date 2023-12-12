/**
 * @file ProgramaDemonstrativo.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Programa onde demonstra a utilização dos métodos implementados nas classes da alínea c) e d)
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 * 
 */
//using ExameRecurso;
using System;
using System.Collections;
using System.Collections.Generic;
namespace teste2021;

class Program
{
    static void Main()
    {
        // Demonstração de utilização
        ArrayList pessoas = new ArrayList
        {
            new Pessoa { Nome = "João", Idade = 25, DataNascimento = new DateTime(1998, 5, 10) },
            new Pessoa { Nome = "Maria", Idade = 30, DataNascimento = new DateTime(1993, 8, 15) },
            // Adicione mais pessoas conforme necessário
        };

        // Utilizando a ClasseConcreta
        ClasseConcreta classeConcreta = new ClasseConcreta();
        bool totalElementosPar = classeConcreta.VerificaTotalElementosPar(pessoas.ToArray());
        Dictionary<DateTime, List<Pessoa>> pessoasPorDataNascimento = classeConcreta.Transforma(pessoas);

        // Utilizando a ClasseHerancaInterface
        ClasseHerancaInterface classeHerancaInterface = new ClasseHerancaInterface();
        int soma = classeHerancaInterface.SomaValoresArrayBidimensional(new int[,] { { 1, 2, 3 }, { 4, 5, 6 } });
        bool valorExiste = classeHerancaInterface.ValorExisteNaLista(2.5, new List<double> { 1.5, 2.5, 3.5 });
        string maisVelha = classeHerancaInterface.PessoaMaisVelha(
            new Pessoa { Nome = "João", Idade = 25, DataNascimento = new DateTime(1998, 5, 10) },
            new Pessoa { Nome = "Maria", Idade = 30, DataNascimento = new DateTime(1993, 8, 15) }
        );

        // Exibindo resultados
        Console.WriteLine($"Total de Elementos é Par: {totalElementosPar}");
        Console.WriteLine("Pessoas por Data de Nascimento:");
        foreach (var entry in pessoasPorDataNascimento)
        {
            Console.WriteLine($"Data: {entry.Key.ToShortDateString()}, Pessoas: {string.Join(", ", entry.Value.Select(p => p.Nome))}");
        }

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Valor existe na lista: {valorExiste}");
        Console.WriteLine($"Pessoa mais velha: {maisVelha}");
    }
}