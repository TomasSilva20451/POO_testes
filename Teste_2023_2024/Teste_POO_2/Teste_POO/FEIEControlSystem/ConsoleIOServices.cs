/**
 * @file ConsoleIOServices.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Implementação da interface IIOService para interação com o console
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class ConsoleIOServices : IIOServices
{
    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public string ReadLine()
    {
        return Console.ReadLine() ?? string.Empty;
    }
}
