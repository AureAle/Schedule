using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    class Profe
    {
//*********************** atributos *********************
        private int id;
        private String nombre;


//*********************** constructor *********************
        public Profe(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }


//*********************** geters *********************
        public int Id { get => id;}
        public string Nombre { get => nombre; }


//*********************** metodos *********************
        public override string ToString()
        { return Nombre; }



    }
}
