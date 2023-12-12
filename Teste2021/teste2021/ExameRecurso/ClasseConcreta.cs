/**
 * @file ClasseConcreta.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @brief Classe que concretiza a classe abstrata definida na alínea b)
 * @version 0.1
 * @date 2023-12-12
 * 
 * @copyright Copyright (c) 2023
 * 
 */

using System;
using System.Collections;
using System.Collections.Generic;

#region ClasseConcreta
/// <summary>
/// Classe concreta que implementa a classe abstrata da alínea b).
/// </summary>
public class ClasseConcreta : AbstractClasse
{
    #region Métodos Abstratos Implementados
    public override bool VerificaTotalElementosPar(object?[] array)
    {
        // Se o array for nulo, retorne false (ou outro valor padrão, dependendo da lógica desejada)
        if (array == null)
        {
            return false;
        }

        // Seu código aqui
        // Certifique-se de lidar adequadamente com a possibilidade de valores nulos no array.
        // Exemplo: 
        if (array.Length % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public override Dictionary<DateTime, List<Pessoa>> Transforma(ArrayList pessoas)
    {
        Dictionary<DateTime, List<Pessoa>> resultado = new Dictionary<DateTime, List<Pessoa>>();

        foreach (var pessoa in pessoas)
        {
            if (pessoa is Pessoa pessoaValida)
            {
                if (!resultado.ContainsKey(pessoaValida.DataNascimento))
                {
                    resultado[pessoaValida.DataNascimento] = new List<Pessoa>();
                }

                resultado[pessoaValida.DataNascimento].Add(pessoaValida);
            }
        }

        return resultado;
    }
    #endregion
}
#endregion
