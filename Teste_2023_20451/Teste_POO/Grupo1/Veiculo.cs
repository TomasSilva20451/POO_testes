/**
 * @file Veiculo.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Definição da classe Veiculo
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

public class Veiculo
{
    #region Atributos

    public string Tipo { get; set; }
    public int Cilindrada { get; set; }
    public int AnoAquisicao { get; set; }
    public bool Avariado { get; set; }

    #endregion

    #region Construtores

    /// <summary>
    /// Construtor padrão da classe Veiculo.
    /// </summary>
    public Veiculo()
    {
        Tipo = "Desconhecido"; // Valor padrão para Tipo
    }

    /// <summary>
    /// Construtor parametrizado da classe Veiculo.
    /// </summary>
    /// <param name="tipo">Tipo do veículo.</param>
    /// <param name="cilindrada">Cilindrada do veículo.</param>
    /// <param name="anoAquisicao">Ano de aquisição do veículo.</param>
    /// <param name="avariado">Indica se o veículo está avariado.</param>
    public Veiculo(string tipo, int cilindrada, int anoAquisicao, bool avariado)
    {
        // Atribua um valor padrão ou um valor válido ao Tipo
        Tipo = tipo ?? throw new ArgumentNullException(nameof(tipo), "O tipo do veículo não pode ser nulo.");
        Cilindrada = cilindrada;
        AnoAquisicao = anoAquisicao;
        Avariado = avariado;
    }


    #endregion

    #region Propriedades

    // Propriedades já definidas anteriormente.

    #endregion

    #region Métodos

    // Métodos da classe, se houver.

    #endregion

    #region Overrides

    // Overrides de métodos da classe base, se houver.

    #endregion

    #region Outros Métodos

    // Outros métodos da classe, se houver.

    #endregion

    #region Destrutores

    /// <summary>
    /// Destrutor da classe Veiculo.
    /// </summary>
    ~Veiculo()
    {
        // Lógica de destruição, se necessário.
    }

    #endregion
}
