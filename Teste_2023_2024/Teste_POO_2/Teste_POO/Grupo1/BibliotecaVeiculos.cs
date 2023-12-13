/**
 * @file BibliotecaVeiculos.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Definição da classe BibliotecaVeiculos
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections;
using System.Collections.Generic;

public class BibliotecaVeiculos
{
    #region Atributos

    private ArrayList veiculos;

    #endregion

    #region Construtores

    /// <summary>
    /// Construtor padrão da classe BibliotecaVeiculos.
    /// </summary>
    public BibliotecaVeiculos()
    {
        veiculos = new ArrayList();
    }

    #endregion

    #region Propriedades

    // Não há propriedades na classe BibliotecaVeiculos.

    #endregion

    #region Métodos

    /// <summary>
    /// Adiciona um veículo à biblioteca.
    /// </summary>
    /// <param name="veiculo">Veículo a ser adicionado.</param>
    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }

    /// <summary>
    /// a) Método que calcula quantas Veículos variados existem numa coleção do tipo ArrayList.
    /// </summary>
    /// <returns>Número de veículos variados.</returns>
    public int ContarVeiculosVariados()
    {
        HashSet<string> tipos = new HashSet<string>();

        foreach (Veiculo veiculo in veiculos)
        {
            tipos.Add(veiculo.Tipo);
        }

        return tipos.Count;
    }

    /// <summary>
    /// b)Método que verifica se determinado conjunto de veículos de um determinado tipo, possui algum
    /// veículo com cilindrada superior a 750 cc.
    /// Verifica se há algum veículo do tipo especificado com cilindrada superior a 750 cc.
    /// </summary>
    /// <param name="tipoVeiculo">Tipo do veículo.</param>
    /// <returns>True se houver veículo com cilindrada superior a 750 cc; False, caso contrário.</returns>
    public bool VerificarCilindradaSuperior(string tipoVeiculo)
    {
        foreach (Veiculo veiculo in veiculos)
        {
            if (veiculo.Tipo == tipoVeiculo && veiculo.Cilindrada > 750)
            {
                return true;
            }
        }

        return false;
    }

    /// <summary>
    /// c) Método que transforma os valores que entram no parâmetro do tipo Dictionary<int,List<Veiculo>>,
    /// num Dictionary<int,ArrayList>, em que int corresponde ao ano de aquisição do veiculo, e só devem
    /// ser considerados os veículos que não estão avariados.
    /// </summary>
    /// <param name="veiculosPorAno">Dicionário de veículos por ano.</param>
    /// <returns>Novo dicionário com veículos não avariados por ano.</returns>
    public Dictionary<int, ArrayList> TransformarDictionary(Dictionary<int, List<Veiculo>> veiculosPorAno)
    {
        Dictionary<int, ArrayList> resultado = new Dictionary<int, ArrayList>();

        foreach (var kvp in veiculosPorAno)
        {
            int ano = kvp.Key;
            List<Veiculo> veiculosDoAno = kvp.Value;

            ArrayList veiculosNaoAvariados = new ArrayList();

            foreach (Veiculo veiculo in veiculosDoAno)
            {
                if (!veiculo.Avariado)
                {
                    veiculosNaoAvariados.Add(veiculo);
                }
            }

            resultado.Add(ano, veiculosNaoAvariados);
        }

        return resultado;
    }

    #endregion

    #region Overrides

    // Não há overrides na classe BibliotecaVeiculos.

    #endregion

    #region Outros Métodos

    // Não há outros métodos na classe BibliotecaVeiculos.

    #endregion

    #region Destrutores

    /// <summary>
    /// Destrutor da classe BibliotecaVeiculos.
    /// </summary>
    ~BibliotecaVeiculos()
    {
        // Lógica de destruição, se necessário.
    }

    #endregion
}
