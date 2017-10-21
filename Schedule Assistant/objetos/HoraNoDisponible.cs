using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    class HoraNoDisponible
    {
        
//*********************** atributos *********************
        private int id;
        private int hora;
        private int dia;
        private int idprofesor;


//*********************** constructor *********************
        public HoraNoDisponible(int id, int hora, int día, int idprofesor)
        {
            this.id = id;
            this.hora = hora;
            this.dia = día;
            this.idprofesor = idprofesor;
        }


//*********************** geters *********************
        public int Id { get => id; }
        public int Hora { get => hora; }
        public int Día { get => dia; }
        public int Idprofesor { get => idprofesor;  }


//*********************** metodos *********************




    }
}
