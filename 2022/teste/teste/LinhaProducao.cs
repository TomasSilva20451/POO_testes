using System;
using System.Collections.Generic;
using teste; // Add this line

namespace teste
{

    public class LinhaProducao
    {
        public int codLinhaProducao { get; set; }
        public List<Maquina> maquinas { get; set; } = new List<Maquina>();
        public int MAXMAQ { get; set; } = 10;
        public int totMaquinas { get; set; } = 0;

        public LinhaProducao()
        {
        }

        public LinhaProducao(int codLinhaProducao)
        {
            this.codLinhaProducao = codLinhaProducao;
        }

        public void AddMaquina(Maquina maquina)
        {
            if (maquinas.Count >= MAXMAQ)
            {
                throw new Exception("O número máximo de máquinas para esta linha de produção é " + MAXMAQ);
            }

            maquinas.Add(maquina);
            totMaquinas++;
        }

        public List<Maquina> QuaisMaquinas()
        {
            return maquinas;
        }

        public List<Maquina> QuaisMaquinasEstado(int estado)
        {
            List<Maquina> maquinasEstado = new List<Maquina>();

            foreach (Maquina maquina in maquinas)
            {
                if (maquina.Estado == estado) // Update this line
                {
                    maquinasEstado.Add(maquina);
                }
            }

            return maquinasEstado;
        }



        public override string ToString()
        {
            return string.Format("LinhaProducao(codLinhaProducao={0}, maquinas={1}, MAXMAQ={2}, totMaquinas={3})", codLinhaProducao, maquinas, MAXMAQ, totMaquinas);
        }


        //Maquina(Cod=1, MaquinaTarefa=CORTAR, Estado=1, Manutencao=null)
    }

}

