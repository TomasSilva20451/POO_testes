/**
 * @file AbstractClasse.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Define uma classe abstrata com métodos abstratos.
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;

#region AbstractClasse
/// <summary>
/// Classe abstrata com métodos abstratos.
/// </summary>
public abstract class AbstractClasse
{
    #region Métodos Abstratos
    /// <summary>
    /// Verifica se um array tem ou não um total de elementos que é par.
    /// </summary>
    /// <param name="array">Array a ser verificado.</param>
    /// <returns>True se o total de elementos for par, False caso contrário.</returns>
    public abstract bool VerificaTotalElementosPar(object[] array);

    /// <summary>
    /// Transforma um ArrayList de pessoas num dicionário de Listas de pessoas.
    /// A chave do dicionário é a data de nascimento da pessoa.
    /// </summary>
    /// <param name="pessoas">ArrayList de pessoas.</param>
    /// <returns>Dicionário onde a chave é a data de nascimento e o valor é a Lista de pessoas.</returns>
    public abstract Dictionary<DateTime, List<Pessoa>> Transforma(ArrayList pessoas);
    #endregion
}
#endregion
