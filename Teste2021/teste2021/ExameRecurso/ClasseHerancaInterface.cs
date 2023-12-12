/**
 * @file ClasseHerancaInterface.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Classe que herda da classe definida na alínea c) e implementa o interface da alínea a)
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 * 
 */

/// <summary>
/// Grupo I - alínea d)
/// </summary>
using System.Collections.Generic;

#region ClasseHerancaInterface
/// <summary>
/// Classe que herda da ClasseConcreta e implementa o interface da alínea a).
/// </summary>
public class ClasseHerancaInterface : ClasseConcreta, IExameInterface
{
    #region Implementação do Interface
    // Implemente os métodos do interface aqui
    public int SomaValoresArrayBidimensional(int[,] array)
    {
        int soma = 0;

        foreach (var valor in array)
        {
            soma += valor;
        }

        return soma;
    }

    public bool ValorExisteNaLista(double valor, List<double> lista)
    {
        return lista.Contains(valor);
    }

    public string PessoaMaisVelha(Pessoa pessoa1, Pessoa pessoa2)
    {
        if (pessoa1.Idade > pessoa2.Idade)
        {
            return $"{pessoa1.Nome} é mais velha do que {pessoa2.Nome}.";
        }
        else if (pessoa1.Idade < pessoa2.Idade)
        {
            return $"{pessoa2.Nome} é mais velha do que {pessoa1.Nome}.";
        }
        else
        {
            return $"{pessoa1.Nome} e {pessoa2.Nome} têm a mesma idade.";
        }
    }
    #endregion
}
#endregion
