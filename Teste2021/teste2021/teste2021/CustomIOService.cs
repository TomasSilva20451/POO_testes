/**
 * @file CustomIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Implementação personalizada da interface IIOService para operações de entrada e saída.
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
    /// Classe que implementa a interface IIOService para operações de entrada e saída personalizadas.
    /// </summary>
    public class CustomIOService : IIOService
    {
        #region Métodos

        /// <summary>
        /// Escreve uma mensagem de maneira personalizada, como gravar em um arquivo.
        /// </summary>
        /// <param name="message">A mensagem a ser escrita.</param>
        public void WriteLine(string message)
        {
            // Implementação personalizada, como gravar em um arquivo
            // Por exemplo: File.WriteAllText("arquivo.txt", message);
        }

        /// <summary>
        /// Lê uma linha de maneira personalizada, como ler de um arquivo.
        /// </summary>
        /// <returns>A linha lida de maneira personalizada.</returns>
        public string ReadLine()
        {
            // Implementação personalizada, como ler de um arquivo
            // Por exemplo: return File.ReadAllText("arquivo.txt");
            return "Simulando leitura de um arquivo";
        }

        #endregion
    }

    #endregion
}
