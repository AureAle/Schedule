using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Grupo
    {
        int id;
        String nombre;

        public Grupo(int id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return nombre;
        }
    }
}
