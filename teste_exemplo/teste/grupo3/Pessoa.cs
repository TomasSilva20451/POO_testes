using System;
using System.Collections.Generic;
using System.IO;

public class Pessoa
{
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Localidade { get; set; }
    public List<DateTime> Visitas { get; set; }

    public Pessoa(string nome, DateTime dataNascimento, string localidade)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Localidade = localidade;
        Visitas = new List<DateTime>();
    }
}

public class Museu
{
    private List<Pessoa> pessoas;

    public Museu()
    {
        pessoas = new List<Pessoa>();
    }

    public void VisitaMuseu(Pessoa pessoa, DateTime dataVisita)
    {
        if (!pessoa.Visitas.Exists(v => v.Year == dataVisita.Year))
        {
            pessoa.Visitas.Add(dataVisita);
            Console.WriteLine($"{pessoa.Nome} visitou o museu em {dataVisita.ToShortDateString()}");
        }
        else
        {
            Console.WriteLine($"{pessoa.Nome} já visitou o museu este ano.");
        }
    }

    public bool PodeVisitar(Pessoa pessoa)
    {
        return !pessoa.Visitas.Exists(v => v.Year == DateTime.Now.Year);
    }

    public void GuardarEmFicheiro(string caminhoFicheiro)
    {
        using (StreamWriter sw = new StreamWriter(caminhoFicheiro))
        {
            foreach (var pessoa in pessoas)
            {
                sw.WriteLine($"{pessoa.Nome},{pessoa.DataNascimento.ToShortDateString()},{pessoa.Localidade}");
            }
        }
    }
}


