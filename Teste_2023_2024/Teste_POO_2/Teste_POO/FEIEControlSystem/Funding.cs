/**
 * @file Funding.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Definição da classe Funding
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

namespace FEIEControlSystem
{
    #region Classes

    /// <summary>
    /// Representa um financiamento no contexto do sistema de controle do Fundo Europeu para Investimentos Estratégicos (FEIE).
    /// </summary>
    public class Funding
    {
        #region Atributos

        /// <summary>
        /// Ano do financiamento.
        /// </summary>
        public int Ano { get; set; }

        /// <summary>
        /// Montante recebido no ano.
        /// </summary>
        public decimal MontanteRecebido { get; set; }

        /// <summary>
        /// Montante já executado no ano.
        /// </summary>
        public decimal MontanteExecutado { get; set; }

        /// <summary>
        /// País associado ao financiamento.
        /// </summary>
        public Country? Pais { get; set; }

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe Funding.
        /// </summary>
        public Funding()
        {
            // Inicialização de atributos, se necessário.
        }

        /// <summary>
        /// Construtor parametrizado da classe Funding.
        /// </summary>
        /// <param name="ano">Ano do financiamento.</param>
        /// <param name="montanteRecebido">Montante recebido no ano.</param>
        /// <param name="montanteExecutado">Montante já executado no ano.</param>
        /// <param name="pais">País associado ao financiamento.</param>
        public Funding(int ano, decimal montanteRecebido, decimal montanteExecutado, Country pais)
        {
            // Inicialize outros membros
            Ano = ano;
            MontanteRecebido = montanteRecebido;
            MontanteExecutado = montanteExecutado;
            Pais = pais ?? throw new ArgumentNullException(nameof(pais), "O país não pode ser nulo.");
        }

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
        /// Destrutor da classe Funding.
        /// </summary>
        ~Funding()
        {
            // Lógica de destruição, se necessário.
        }

        #endregion
    }

    #endregion
}
