using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Clase
    {
        private int id;
        private String nombre;
        private int creditos;

        public Clase( String nombre, int creditos)
        {
            this.Nombre = nombre;
            this.Creditos = creditos;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Creditos { get => creditos; set => creditos = value; }

        public override string ToString()
        {
            return nombre + "  Creditos: " + creditos;
        }
    }
}
