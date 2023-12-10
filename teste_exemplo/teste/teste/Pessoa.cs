using System;
using System.Runtime.Intrinsics.X86;

namespace teste
{
    public class Pessoa : QuasePessoa, IDados
    {
        double nc;
        DateTime dn;

        /// <summary>
        /// a) Complete o que entender necessário de forma a que a classe Pessoa possa ser instanciada.
        /// </summary>
        /// <param name="nc"></param>
        /// <param name="dn"></param>
        public Pessoa(double nc, DateTime dn)
        {
            this.nc = nc;
            this.dn = dn;
            this.morada = "Endereço Padrão"; // Exemplo de inicialização
        }

        public DateTime DN
        {
            get => dn;
            set => dn = value;
        }

        public long DiaDaSemana()
        {
            return (long)dn.DayOfWeek;
        }

        // Implementação do método abstrato Morada() da classe base QuasePessoa
        public override string Morada()
        {
            // Lógica para obter a morada da pessoa
            // Por exemplo:
            return "Rua XYZ, Cidade ABC";
        }

        // Implementação da propriedade NC da interface IDados
        public double NC
        {
            get => nc;
        }

        // Implementação do método GetDiasVida() da interface IDados
        public long GetDiasVida(DateTime dataAtual)
        {
            return (dataAtual - dn).Days;
        }
    }

    public abstract class QuasePessoa
    {
        protected string? morada; // Tornando anulável

        /// <summary>
        /// Devolve a morada da pessoa
        /// </summary>
        /// <returns></returns>
        public abstract string Morada();

        /// <summary>
        /// Devolve o número de dias que decorreram desde o nascimento
        /// </summary>
        /// <param name="dn"></param>
        /// <param name="dataAtual"></param>
        protected long GetDiasVida(DateTime dn, DateTime dataAtual)
        {
            return (dataAtual - dn).Days;
        }
    }

    public interface IDados
    {
        /// <summary>
        /// Devolve o dia da semana em que nasceu
        /// </summary>
        /// <returns></returns>
        long DiaDaSemana();

        /// <summary>
        /// Devolve o NC da pessoa
        /// </summary>
        double NC { get; }

        /// <summary>
        /// Devolve o número de dias que decorreram desde o nascimento
        /// </summary>
        /// <param name="dn"></param>
        /// <param name="dataAtual"></param>
        /// <returns></returns>
        long GetDiasVida(DateTime dataAtual);
    }

}

