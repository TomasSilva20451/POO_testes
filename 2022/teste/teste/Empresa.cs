using System;
using System.Collections.Generic;
using teste;

namespace teste
{
    public class Empresa
    {
        private List<LinhaProducao> _linhasProducao = new List<LinhaProducao>();
        private string _nomeEmpresa = string.Empty;// Initialize with a default value
        private List<string> _nomeLinhas = new List<string>();
        private int _totLinhasProducao = 0;

        public List<LinhaProducao> LinhasProducao
        {
            get
            {
                return _linhasProducao;
            }

            set
            {
                _linhasProducao = value;
            }
        }

        public string NomeEmpresa
        {
            get
            {
                return _nomeEmpresa;
            }

            set
            {
                _nomeEmpresa = value;
            }
        }

        public List<string> NomeLinhas
        {
            get
            {
                return _nomeLinhas;
            }

            set
            {
                _nomeLinhas = value;
            }
        }

        public int TotLinhasProducao
        {
            get
            {
                return _totLinhasProducao;
            }

            set
            {
                _totLinhasProducao = value;
            }
        }

        public Empresa()
        {
        }

        public Empresa(string nomeEmpresa)
        {
            NomeEmpresa = nomeEmpresa;
        }
    }
}
