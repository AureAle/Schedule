using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Profe
    {
        int id;
        String Nombre;
        String Hora;
        String Materias;


        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Id { get => id; set => id = value; }
        //public String Hora1 { get => Hora; set => Hora = value; }
        //public string Materias1 { get => Materias; set => Materias = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
