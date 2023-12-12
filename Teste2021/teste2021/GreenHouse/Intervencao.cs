/**
 * @file Intervencao.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Classe que representa uma intervenção realizada numa estufa.
 * @version 0.1
 * @date 2023-12-12
 * @copyright Copyright (c) 2023
 */

#region Intervencao
public class Intervencao
{
    #region Atributos
    /// <summary>
    /// Obtém ou define a descrição da intervenção.
    /// </summary>
    public string Descricao { get; set; }
    #endregion

    #region Construtores
    /// <summary>
    /// Construtor da classe Intervencao.
    /// </summary>
    /// <param name="descricao">A descrição da intervenção.</param>
    public Intervencao(string descricao)
    {
        Descricao = descricao;
    }
    #endregion
}
#endregion
