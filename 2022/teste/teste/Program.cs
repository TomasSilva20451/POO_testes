using System;
using teste; // Add this line

class Program
{
    public static void Main(string[] args)
    {
        // Cria uma empresa
        Empresa empresa = new Empresa();

        // Cria uma linha de produção
        LinhaProducao linhaProducao = new LinhaProducao();

        // Cria uma máquina
        Maquina maquina = new Maquina()
        {
            Cod = 1,
            MaquinaTarefa = Maquina.Tarefa.CORTAR, // Update this line
            Estado = 1, // Replace with the appropriate value for Estado
            Manutencao = new DateTime(2023, 12, 31)
        };


        // Adiciona a máquina à linha de produção
        linhaProducao.AddMaquina(maquina);

        // Imprime a linha de produção
        foreach (Maquina m in linhaProducao.QuaisMaquinas())
        {
            Console.WriteLine(m);
        }
    }
}
