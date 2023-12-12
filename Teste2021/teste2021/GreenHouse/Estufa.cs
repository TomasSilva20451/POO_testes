/**
 * @file Estufa.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Classe que representa uma estufa.
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */
using System;
using System.Collections.Generic;

#region Estufa
public class Estufa
{
    #region Atributos
    /// <summary>
    /// Obtém ou define o código identificador da estufa.
    /// </summary>
    public string Codigo { get; set; }

    /// <summary>
    /// Obtém ou define o tipo de produto que a estufa produz.
    /// </summary>
    public TipoProduto Tipo { get; set; }

    /// <summary>
    /// Obtém ou define a capacidade de produção da estufa em kg/ano.
    /// </summary>
    public double CapacidadeProducao { get; set; }

    /// <summary>
    /// Lista de produtos produzidos na estufa.
    /// </summary>
    public List<Produto> ProdutosProduzidos { get; set; }
    #endregion

    #region Construtores
    /// <summary>
    /// Construtor da classe Estufa.
    /// </summary>
    /// <param name="codigo">O código identificador da estufa.</param>
    /// <param name="tipo">O tipo de produto que a estufa produz.</param>
    /// <param name="capacidadeProducao">A capacidade de produção da estufa em kg/ano.</param>
    public Estufa(string codigo, TipoProduto tipo, double capacidadeProducao)
    {
        Codigo = codigo;
        Tipo = tipo;
        CapacidadeProducao = capacidadeProducao;
        ProdutosProduzidos = new List<Produto>();
    }
    #endregion

    #region Métodos
    /// <summary>
    /// Adiciona um produto produzido na estufa.
    /// </summary>
    /// <param name="produto">O produto a ser adicionado.</param>
    public void AdicionarProduto(Produto produto)
    {
        ProdutosProduzidos.Add(produto);
    }
    #endregion
}
#endregion
