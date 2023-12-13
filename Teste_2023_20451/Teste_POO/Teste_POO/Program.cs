/**
 * @file Program.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Programa principal para demonstrar a utilização das classes
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections;
using System.Collections.Generic;
using FEIEControlSystem;


class Program
{
    static void Main()
    {
        IIOService ioService = new ConsoleIOService();

        // Utilize ioService.WriteLine e ioService.ReadLine no lugar de Console.WriteLine e Console.ReadLine

        // Utilização da Biblioteca de Veículos
        BibliotecaVeiculos biblioteca = new BibliotecaVeiculos();

        Veiculo veiculo1 = new Veiculo { Tipo = "Carro", Cilindrada = 800, AnoAquisicao = 2020, Avariado = false };
        Veiculo veiculo2 = new Veiculo { Tipo = "Moto", Cilindrada = 600, AnoAquisicao = 2021, Avariado = true };
        Veiculo veiculo3 = new Veiculo { Tipo = "Carro", Cilindrada = 1000, AnoAquisicao = 2020, Avariado = false };

        biblioteca.AdicionarVeiculo(veiculo1);
        biblioteca.AdicionarVeiculo(veiculo2);
        biblioteca.AdicionarVeiculo(veiculo3);

        // a) Contar veículos variados
        ioService.WriteLine("Quantidade de Veículos Variados: " + biblioteca.ContarVeiculosVariados());
        ioService.WriteLine("Existem veículos do tipo Carro com cilindrada superior a 750 cc? " +
                            biblioteca.VerificarCilindradaSuperior("Carro"));

        // b) Verificar cilindrada superior
        string tipoVeiculoParaVerificar = "Carro";
        bool possuiCilindradaSuperior = biblioteca.VerificarCilindradaSuperior(tipoVeiculoParaVerificar);
        ioService.WriteLine($"b) {tipoVeiculoParaVerificar} possui cilindrada superior a 750 cc? {possuiCilindradaSuperior}");

        // c) Transformar Dictionary
        Dictionary<int, List<Veiculo>> veiculosPorAno = new Dictionary<int, List<Veiculo>>();
        veiculosPorAno.Add(2020, new List<Veiculo> { veiculo1, veiculo3 });
        veiculosPorAno.Add(2021, new List<Veiculo> { veiculo2 });

        Dictionary<int, ArrayList> resultadoTransformacao = biblioteca.TransformarDictionary(veiculosPorAno);

        ioService.WriteLine("Veículos não avariados por ano:");
        foreach (var kvp in resultadoTransformacao)
        {
            ioService.WriteLine($"Ano: {kvp.Key}");
            foreach (Veiculo veiculo in kvp.Value)
            {
                ioService.WriteLine($"  - Tipo: {veiculo.Tipo}, Cilindrada: {veiculo.Cilindrada}");
            }
        }

        // Utilização do Sistema de Controle do FEIE
        FEIEControlSystem.FEIEControlSystem feieSystem = new FEIEControlSystem.FEIEControlSystem();

        // Criar países
        Country portugal = new Country("Portugal", 1000000, 50, new DateTime(2023, 1, 1), 0);
        Country espanha = new Country("Espanha", 1500000, 30, new DateTime(2023, 1, 1), 0);

        // Adicionar países ao sistema
        feieSystem.AdicionarPais(portugal);
        feieSystem.AdicionarPais(espanha);

        // Criar financiamentos
        FEIEControlSystem.Funding financiamento2023 = new FEIEControlSystem.Funding(2023, 500000, 0, portugal);
        FEIEControlSystem.Funding financiamento2024 = new FEIEControlSystem.Funding(2024, 800000, 0, portugal);

        // Adicionar financiamentos ao sistema
        feieSystem.AdicionarFinanciamento(financiamento2023);
        feieSystem.AdicionarFinanciamento(financiamento2024);

        // Calcular percentagem a executar para o ano 2023
        decimal percentagemExecutar2023 = feieSystem.CalcularPercentagemAExecutar(2023);
        ioService.WriteLine($"Percentagem a executar em 2023: {percentagemExecutar2023}%");

        // Demonstração dos métodos da classe FEIEControlSystem
        // a. Registar o montante do FEIE executado, num determinado ano, para um determinado país.
        ioService.WriteLine("Digite o nome do país:");
        string nomePais = ioService.ReadLine();

        ioService.WriteLine("Digite o ano:");
        int ano = Convert.ToInt32(ioService.ReadLine());

        ioService.WriteLine("Digite o montante a ser registrado:");
        decimal montanteExecutado = Convert.ToDecimal(ioService.ReadLine());

        feieSystem.RegistarMontanteExecutado(nomePais, ano, montanteExecutado);

        // b. Identificar os países que estão atrasados na execução do respetivo FEIE.
        List<Country> paisesAtrasados = feieSystem.PaisesAtrasados();
        ioService.WriteLine("Países em atraso na execução do FEIE:");
        foreach (Country pais in paisesAtrasados)
        {
            ioService.WriteLine($"- {pais.Nome}");
        }

        // c. Ordenar os países pelo montante executado do respetivo FEIE.
        List<Country> paisesOrdenados = feieSystem.OrdenarPaisesPorMontanteExecutado();
        ioService.WriteLine("Países ordenados pelo montante executado:");
        foreach (Country pais in paisesOrdenados)
        {
            ioService.WriteLine($"- {pais.Nome}: Montante Executado = {pais.MontanteExecutado}");
        }

        ioService.ReadLine();
    }
}

