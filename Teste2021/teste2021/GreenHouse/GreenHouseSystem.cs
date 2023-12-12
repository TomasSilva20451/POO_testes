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
using System.Linq;

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
    /// Regista uma nova estufa no sistema.
    /// </summary>
    /// <param name="estufa">A estufa a ser registada.</param>
    public void RegistarEstufa(Estufa estufa)
    {
        if (!EstufaExiste(estufa.Codigo))
        {
            estufas.Add(estufa);
        }
        else
        {
            Console.WriteLine($"A estufa com o código {estufa.Codigo} já está registada.");
        }
    }

    /// <summary>
    /// Encontra estufas de determinado tipo que produzem acima de determinada capacidade.
    /// </summary>
    /// <param name="tipo">O tipo de estufa desejado.</param>
    /// <param name="capacidadeMinima">A capacidade mínima desejada em kg/ano.</param>
    /// <returns>Uma lista de estufas que correspondem aos critérios.</returns>
    public List<Estufa> EncontrarEstufasPorTipoECapacidade(TipoProduto tipo, double capacidadeMinima)
    {
        return estufas.Where(e => e.Tipo == tipo && e.CapacidadeProducao > capacidadeMinima).ToList();
    }

    /// <summary>
    /// Verifica se uma estufa com determinado código existe.
    /// </summary>
    /// <param name="codigo">O código da estufa a verificar.</param>
    /// <returns>True se a estufa existir; False caso contrário.</returns>
    public bool EstufaExiste(string codigo)
    {
        return estufas.Any(e => e.Codigo == codigo);
    }

    /// <summary>
    /// Obtém todas as informações associadas a uma estufa, se existir.
    /// </summary>
    /// <param name="codigo">O código da estufa desejada.</param>
    /// <returns>As informações da estufa se existir; null caso contrário.</returns>
    public Estufa? ObterInformacaoEstufa(string codigo)
    {
        return estufas.FirstOrDefault(e => e.Codigo == codigo);
    }


    /// <summary>
    /// Arquiva toda a informação registada.
    /// </summary>
    public void ArquivarInformacao()
    {
        // Implemente a lógica de arquivamento aqui
        Console.WriteLine("Informação arquivada com sucesso!");
    }
    #endregion
}
#endregion
