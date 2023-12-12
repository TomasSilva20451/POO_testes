/**
 * @file Produto.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Classe que representa um produto produzido pela estufa.
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */
using System;

#region Produto
public class Produto
{
    #region Atributos
    /// <summary>
    /// Obtém ou define o nome do produto.
    /// </summary>
    public string Nome { get; set; }

    /// <summary>
    /// Obtém ou define a quantidade produzida em kg.
    /// </summary>
    public double QuantidadeProduzida { get; set; }
    #endregion

    #region Construtores
    /// <summary>
    /// Construtor da classe Produto.
    /// </summary>
    /// <param name="nome">O nome do produto.</param>
    /// <param name="quantidadeProduzida">A quantidade produzida em kg.</param>
    public Produto(string nome, double quantidadeProduzida)
    {
        Nome = nome;
        QuantidadeProduzida = quantidadeProduzida;
    }
    #endregion
}
#endregion
