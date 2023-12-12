/**
 * @file ExameImplementacao.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Implementação da interface IExameInterface
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 * 
 */

using System;
using System.Collections.Generic;

/// <summary>
/// Questão 1 a) i, ii, iii
/// </summary>
#region ExameImplementacao
/// <summary>
/// Implementação da interface IExameInterface.
/// </summary>
public class ExameImplementacao : IExameInterface
{
    #region Métodos
    /// <summary>
    /// Soma todos os valores de um array bidimensional.
    /// </summary>
    public int SomaValoresArrayBidimensional(int[,] array)
    {
        int soma = 0;

        foreach (var valor in array)
        {
            soma += valor;
        }

        return soma;
    }

    /// <summary>
    /// Verifica se determinado valor existe numa lista de valores reais.
    /// </summary>
    public bool ValorExisteNaLista(double valor, List<double> lista)
    {
        return lista.Contains(valor);
    }

    /// <summary>
    /// Compara duas pessoas e indica qual é a mais velha.
    /// </summary>
    public string PessoaMaisVelha(Pessoa pessoa1, Pessoa pessoa2)
    {
        if (pessoa1.Idade > pessoa2.Idade)
        {
            return $"{pessoa1.Nome} é mais velha do que {pessoa2.Nome}.";
        }
        else if (pessoa1.Idade < pessoa2.Idade)
        {
            return $"{pessoa2.Nome} é mais velha do que {pessoa1.Nome}.";
        }
        else
        {
            return $"{pessoa1.Nome} e {pessoa2.Nome} têm a mesma idade.";
        }
    }
    #endregion
}
#endregion
