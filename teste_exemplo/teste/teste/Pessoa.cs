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
            return (long)DN.DayOfWeek + 1; // Adicionando 1 para evitar o valor 0
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

        /// <summary>
        /// Questão b) Estenda a classe Pessoa com a definição do operador “==”
        /// sabendo que duas pessoas são as mesmas caso respetivo NC e mês de nascimento sejam iguais.
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Pessoa other && Equals(other);
        }

        public bool Equals(Pessoa other)
        {
            if (other is null)
                return false;

            // Duas pessoas são iguais se NC e mês de nascimento são iguais
            return NC == other.NC && dn.Month == other.DN.Month;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NC, dn.Month);
        }

        public static bool operator ==(Pessoa pessoa1, Pessoa pessoa2)
        {
            return pessoa1 is not null && pessoa1.Equals(pessoa2);
        }

        public static bool operator !=(Pessoa pessoa1, Pessoa pessoa2)
        {
            return !(pessoa1 == pessoa2);
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

