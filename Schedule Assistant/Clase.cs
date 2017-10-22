using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Clase
    {
        int id;
        String NombreM;
        int Creditos;

        public Clase(int id, String nombre, int creditos)
        {
            this.NombreM1 = nombre;
            this.Creditos1 = creditos;
        }

        public int Id { get => id; set => id = value; }
        public string NombreM1 { get => NombreM; set => NombreM = value; }
        public int Creditos1 { get => Creditos; set => Creditos = value; }
    }
}
