using System;

namespace teste
{
    public class Maquina
    {
        public int Cod { get; set; }
        public int Estado { get; set; }
        public DateTime Manutencao { get; set; }

        // Define the Tarefa enum
        public enum Tarefa
        {
            CORTAR,
            // Add other tasks as needed
        }

        private Tarefa tarefa; // make it private

        public Tarefa MaquinaTarefa
        {
            get { return tarefa; }
            set { tarefa = value; }
        }

        // Add a property for a list of Maquina objects
        public List<Maquina> Maquinas { get; set; }

        public Maquina()
        {
            // Initialize the list in the constructor
            this.Maquinas = new List<Maquina>();
        }

        public bool Equals(Maquina outraMaquina)
        {
            if (outraMaquina == null)
            {
                return false;
            }

            return (Cod == outraMaquina.Cod && MaquinaTarefa == outraMaquina.MaquinaTarefa && Estado == outraMaquina.Estado);
        }


        public List<Maquina> QuaisMaquinasTarefaEstado(Tarefa tarefa, int estado)
        {
            List<Maquina> maquinasEstado = new List<Maquina>();

            foreach (Maquina maquina in this.Maquinas)
            {
                if (maquina.MaquinaTarefa == tarefa && maquina.Estado == estado)
                {
                    maquinasEstado.Add(maquina);
                }
            }

            return maquinasEstado;
        }


        public override string ToString()
        {
            return string.Format("Maquina(Cod={0}, MaquinaTarefa={1}, Estado={2}, Manutencao={3})", Cod, MaquinaTarefa, Estado, Manutencao);
        }

    }
}
