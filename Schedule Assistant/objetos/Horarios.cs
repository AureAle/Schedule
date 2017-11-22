using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Horarios
    {
        private int id;
        private int dia;
        private int hora;
        private int clase;
        private int aula;
        

        public Horarios(int id, int dia, int hora,  int clase,int aula)
        {
            this.id = id;
            this.dia = dia;
            this.hora = hora;
            this.aula = aula;
            this.clase = clase;
        }

        public int Id { get => id; set => id = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Hora { get => hora; set => hora = value; }
        public int Aula { get => aula; set => aula = value; }
        public int Clase { get => clase; set => clase = value; }
    }
}
