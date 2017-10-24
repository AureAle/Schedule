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

        public Clase(int id, String nombre, int creditos)
        {
            this.nombre = nombre;
            this.creditos = creditos;
        }

        public int Id { get => id; }
        public string NombreM { get => nombre; }
        public int Creditos { get => Creditos; }
    }
}
