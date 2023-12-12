/**
 * @file GreenHouseSystem.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Classe que representa o sistema GreenHouse.
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */
using System;
using System.Collections.Generic;

#region GreenHouseSystem
public class GreenHouseSystem
{
    #region Atributos
    /// <summary>
    /// Lista de estufas geridas pelo sistema.
    /// </summary>
    private List<Estufa> estufas;
    #endregion

    #region Construtores
    /// <summary>
    /// Construtor da classe GreenHouseSystem.
    /// </summary>
    public GreenHouseSystem()
    {
        estufas = new List<Estufa>();
    }
    #endregion

    #region Métodos
    /// <summary>
    /// Adiciona uma estufa ao sistema.
    /// </summary>
    /// <param name="estufa">A estufa a ser adicionada.</param>
    public void AdicionarEstufa(Estufa estufa)
    {
        estufas.Add(estufa);
    }

    /// <summary>
    /// Obtém a lista de estufas geridas pelo sistema.
    /// </summary>
    /// <returns>A lista de estufas.</returns>
    public List<Estufa> ObterEstufas()
    {
        return estufas;
    }

    /// <summary>
    /// Calcula a produção total por tipo de produto.
    /// </summary>
    /// <returns>Um dicionário onde a chave é o tipo de produto e o valor é a produção total.</returns>
    public Dictionary<TipoProduto, double> CalcularProducaoTotalPorTipo()
    {
        Dictionary<TipoProduto, double> producaoPorTipo = new Dictionary<TipoProduto, double>();

        foreach (var estufa in estufas)
        {
            foreach (var produto in estufa.ProdutosProduzidos)
            {
                if (!producaoPorTipo.ContainsKey(estufa.Tipo))
                {
                    producaoPorTipo[estufa.Tipo] = 0.0;
                }

                producaoPorTipo[estufa.Tipo] += produto.QuantidadeProduzida;
            }
        }

        return producaoPorTipo;
    }
    #endregion
}
#endregion
