//MinhaBiblioteca/Aluno.cs

using System;
using System.Collections.Generic;

namespace MinhaBiblioteca
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public string UnidadeCurricular { get; set; }
        public string Epoca { get; set; }
        public bool Aprovado { get; set; }

        // Construtor que inicializa as propriedades obrigatórias
        public Aluno(string nome, string curso, string unidadeCurricular, string epoca, bool aprovado)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Curso = curso ?? throw new ArgumentNullException(nameof(curso));
            UnidadeCurricular = unidadeCurricular ?? throw new ArgumentNullException(nameof(unidadeCurricular));
            Epoca = epoca ?? throw new ArgumentNullException(nameof(epoca));
            Aprovado = aprovado;
        }
    }


    public class Escola
    {
        private Dictionary<char, Aluno> alunos = new Dictionary<char, Aluno>();

        public void AdicionarAluno(char chave, Aluno aluno)
        {
            alunos[chave] = aluno;
        }

        public List<Aluno> ObterAlunosAprovados(string unidadeCurricular, string curso, string epoca)
        {
            List<Aluno> aprovados = new List<Aluno>();

            foreach (var aluno in alunos.Values)
            {
                if (aluno.UnidadeCurricular == unidadeCurricular &&
                    aluno.Curso == curso &&
                    aluno.Epoca == epoca &&
                    aluno.Aprovado)
                {
                    aprovados.Add(aluno);
                }
            }

            return aprovados;
        }
    }
}
