/**
 * @file FEIEControlSystem.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Definição da classe FEIEControlSystem
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace FEIEControlSystem
{
    #region Classes

    /// <summary>
    /// Representa o sistema de controle do Fundo Europeu para Investimentos Estratégicos (FEIE).
    /// </summary>
    public class FEIEControlSystem
    {
        #region Atributos

        private List<Country> countries;
        private List<Funding> fundings;

        #endregion

        #region Construtores

        /// <summary>
        /// Construtor padrão da classe FEIEControlSystem.
        /// </summary>
        public FEIEControlSystem()
        {
            countries = new List<Country>();
            fundings = new List<Funding>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Registar o montante do FEIE executado, num determinado ano, para um determinado país.
        /// </summary>
        /// <param name="nomePais">Nome do país.</param>
        /// <param name="ano">Ano do registro.</param>
        /// <param name="montanteExecutado">Montante a ser registrado.</param>
        public void RegistarMontanteExecutado(string nomePais, int ano, decimal montanteExecutado)
        {
            Country pais = countries.FirstOrDefault(p => p.Nome == nomePais);

            if (pais != null)
            {
                Funding financiamento = fundings.FirstOrDefault(f => f.Ano == ano && f.Pais == pais);

                if (financiamento != null)
                {
                    financiamento.MontanteExecutado = montanteExecutado;
                }
                else
                {
                    AdicionarFinanciamento(new Funding(ano, 0, montanteExecutado, pais ?? throw new InvalidOperationException("O país não pode ser nulo.")));
                }
            }
            else
            {
                IIOServices ioService = new ConsoleIOServices();
                if (ioService != null)
                {
                    ioService.WriteLine($"País '{nomePais}' não encontrado.");
                    string userInput = ioService.ReadLine();
                }
            }
        }

        // Método para calcular a percentagem a executar num determinado ano
        public decimal CalcularPercentagemAExecutar(int ano)
        {
            // Lógica de cálculo da percentagem aqui
            return 0.0m; // Substitua pela lógica real
        }

        /// <summary>
        /// Identificar os países que estão atrasados na execução do respetivo FEIE.
        /// </summary>
        /// <returns>Lista de países em atraso.</returns>
        public List<Country> PaisesAtrasados()
        {
            return countries.Where(p => p != null && !p.ExecucaoNoPrazo()).ToList();
        }

        /// <summary>
        /// Ordenar os países pelo montante executado do respetivo FEIE.
        /// </summary>
        /// <returns>Lista de países ordenados pelo montante executado.</returns>
        public List<Country> OrdenarPaisesPorMontanteExecutado()
        {
            return countries.Where(p => p != null).OrderByDescending(p => p.MontanteExecutado).ToList();
        }

        /// <summary>
        /// Adicionar um financiamento à lista de financiamentos.
        /// </summary>
        /// <param name="financiamento">Financiamento a ser adicionado.</param>
        public void AdicionarFinanciamento(Funding financiamento)
        {
            fundings.Add(financiamento);
        }

        /// <summary>
        /// Adicionar um país à lista de países.
        /// </summary>
        /// <param name="country">País a ser adicionado.</param>
        public void AdicionarPais(Country country)
        {
            countries.Add(country);
        }

        /// <summary>
        /// Implementa um método capaz de gravar num ficheiro toda a informação sobre FEIE de um determinado país.
        /// </summary>
        /// <param name="nomePais">Nome do país.</param>
        /// <param name="caminhoArquivo">Caminho do arquivo onde as informações serão gravadas.</param>
        public void GravarInformacoesFEIEEmArquivo(string nomePais, string caminhoArquivo)
        {
            Country pais = countries.FirstOrDefault(p => p.Nome == nomePais);

            if (pais != null)
            {
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    // Escreve as informações no arquivo
                    writer.WriteLine($"Informações sobre o FEIE para o país {pais.Nome}:");
                    writer.WriteLine($"Valor Total a Receber: {pais.ValorTotalAReceber}");
                    writer.WriteLine($"Percentagem a Executar por Ano: {pais.PercentagemAExecutarAno}%");
                    writer.WriteLine($"Data de Início da Execução: {pais.DataInicioExecucao}");
                    writer.WriteLine($"Montante Executado: {pais.MontanteExecutado}");
                    // Adicione mais informações conforme necessário

                    // Feche o StreamWriter para garantir que os dados sejam gravados no arquivo
                    writer.Close();
                }
            }
            else
            {
                IIOServices ioService = new ConsoleIOServices();
                ioService.WriteLine($"País '{nomePais}' não encontrado.");
            }
        }
        #endregion
    }

    #endregion
}
