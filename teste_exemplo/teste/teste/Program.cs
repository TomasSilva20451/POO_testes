using System;
using teste; // adicionar o namespace do projeto

/**
 * @file Program.cs
 * @author a20451@alunos.ipca.pt
 * @brief Programa Principal
 * @version 0.1
 * @date 12-12-2023
 * 
 * @copyright Copyright (c) 2023
 * 
**/

class Program
{
    static int Main(string[] args)
    {
        // Chame as funções necessárias para executar o teste de POO
        // Exemplo:
        Library.TestFunction();
        // Questão a)
        Pessoa pessoaA = new Pessoa(123456789, new DateTime(1990, 1, 1));

        // Questão b)
        Pessoa pessoa1 = new Pessoa(123, new DateTime(2000, 5, 15));
        Pessoa pessoa2 = new Pessoa(123, new DateTime(2001, 5, 15));

        bool saoIguais = pessoa1 == pessoa2; // Retorna true se as pessoas são iguais

        // Questão c)
        Pessoa pessoaC = new Pessoa(123456789, new DateTime(2021, 12, 12));
        

        long dia = pessoaC.DiaDaSemana();
        Console.WriteLine("Nasceu no dia {0}\n", dia);
        Console.WriteLine("Vive há {0} dias\n", pessoaC.GetDiasVida(DateTime.Now));

        // Retornar um código de saída (pode ser 0 se não há erros)
        return 0;

        // Não usar Console.WriteLine() aqui, conforme solicitado no enunciado.
    }
}
