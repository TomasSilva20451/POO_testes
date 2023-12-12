/**
 * @file IIOService.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Definição da interface IIOService
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 */

using System;

namespace teste2021
{
    #region Interfaces

    /// <summary>
    /// Interface para serviços de entrada e saída.
    /// </summary>
    public interface IIOService
    {
        void WriteLine(string message);
        string ReadLine();
    }

    #endregion
}
