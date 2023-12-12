/**
 * @file ConsoleIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Implementação da interface IIOService para entrada e saída no console.
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 */

using System;

namespace teste2021
{
    #region Classes

    /// <summary>
    /// Classe que implementa a interface IIOService para operações de entrada e saída no console.
    /// </summary>
    public class ConsoleIOService : IIOService
    {
        #region Métodos

        /// <summary>
        /// Escreve uma mensagem no console. Se a mensagem for nula, exibe "Valor nulo".
        /// </summary>
        /// <param name="value">A mensagem a ser escrita.</param>
        public void WriteLine(string? value)
        {
            if (value is not null)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("Valor nulo");
            }
        }

        /// <summary>
        /// Lê uma linha do console. Retorna uma string vazia se nenhuma entrada estiver disponível.
        /// </summary>
        /// <returns>A linha lida do console.</returns>
        public string ReadLine()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        #endregion
    }

    #endregion
}
