/**
 * @file Country.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Definição da classe Country
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;

namespace FEIEControlSystem
{
    #region Classes

    /// <summary>
    /// Representa um país no contexto do sistema de controle do Fundo Europeu para Investimentos Estratégicos (FEIE).
    /// </summary>
    public class Country
    {
        #region Atributos

        /// <summary>
        /// Nome do país.
        /// </summary>
        public string? Nome { get; set; }

        /// <summary>
        /// Valor total a receber pelo país.
        /// </summary>
        public decimal ValorTotalAReceber { get; set; }

        /// <summary>
        /// Percentagem a executar em cada ano.
        /// </summary>
        public decimal PercentagemAExecutarAno { get; set; }

        /// <summary>
        /// Data de início da execução.
        /// </summary>
        public DateTime DataInicioExecucao { get; set; }

        /// <summary>
        /// Montante já executado.
        /// </summary>
        public decimal MontanteExecutado { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Country.
        /// </summary>
        public Country()
        {
            // Inicialização de atributos, se necessário.
        }

        /// <summary>
        /// Construtor parametrizado da classe Country.
        /// </summary>
        /// <param name="nome">Nome do país.</param>
        /// <param name="valorTotalAReceber">Valor total a receber pelo país.</param>
        /// <param name="percentagemAExecutarAno">Percentagem a executar em cada ano.</param>
        /// <param name="dataInicioExecucao">Data de início da execução.</param>
        /// <param name="montanteExecutado">Montante já executado.</param>
        public Country(string nome, decimal valorTotalAReceber, decimal percentagemAExecutarAno, DateTime dataInicioExecucao, decimal montanteExecutado)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome), "O nome do país não pode ser nulo.");
            ValorTotalAReceber = valorTotalAReceber;
            PercentagemAExecutarAno = percentagemAExecutarAno;
            DataInicioExecucao = dataInicioExecucao;
            MontanteExecutado = montanteExecutado;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Verifica se a execução está dentro do prazo.
        /// </summary>
        /// <returns>True se estiver dentro do prazo, False caso contrário.</returns>
        public bool ExecucaoNoPrazo()
        {
            // Vamos assumir que o prazo é de um ano a partir da data de início da execução
            DateTime prazo = DataInicioExecucao.AddYears(1);

            // Verifique se a data atual é anterior ao prazo
            return DateTime.Now < prazo;
        }

        #endregion

        #region Overrides

        // Overrides de métodos da classe base, se houver.

        #endregion

        #region Outros Métodos

        // Outros métodos da classe, se houver.

        #endregion

        #region Destrutores

        /// <summary>
        /// Destrutor da classe Country.
        /// </summary>
        ~Country()
        {
            // Lógica de destruição, se necessário.
        }

        #endregion
    }

    #endregion
}
