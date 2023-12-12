/**
 * @file IExameInterface.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Define a interface IExameInterface
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 * 
 */

using System.Collections.Generic;


/// <summary>
/// Questão 1 a) b) c)
/// </summary>
#region IExameInterface
/// <summary>
/// Interface que define métodos para a resolução do exame.
/// </summary>
public interface IExameInterface
{
    #region Métodos
    /// <summary>
    /// Soma todos os valores de um array bidimensional.
    /// </summary>
    int SomaValoresArrayBidimensional(int[,] array);

    /// <summary>
    /// Verifica se determinado valor existe numa lista de valores reais.
    /// </summary>
    bool ValorExisteNaLista(double valor, List<double> lista);

    /// <summary>
    /// Compara duas pessoas e indica qual é a mais velha.
    /// </summary>
    string PessoaMaisVelha(Pessoa pessoa1, Pessoa pessoa2);
    #endregion
}
#endregion
