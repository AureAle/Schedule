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
       // private int idprofesor;


//*********************** constructor *********************
        public HoraNoDisponible( int hora, int día)
        {
            
            this.Hora1 = hora;
            this.Dia = día;
           // this.idprofesor = idprofesor;
        }


//*********************** geters *********************
        
        public int Id1 { get => id; set => id = value; }
        public int Hora1 { get => hora; set => hora = value; }
        public int Dia { get => dia; set => dia = value; }
        //public int Idprofesor { get => idprofesor;  }


        //*********************** metodos *********************
        public override string ToString()
        {
            if (hora == 1)
            {
                return "2:10-3:00";
            }
            else if (hora == 2)
            {
                return "3:00-3:50";
            }
            else if (hora == 3)
            {
                return "3:50-4:40";
            }
            else if (hora == 4)
            {
                return "5:10-6:00";
            }
            else if (hora == 5)
            {
                return "6:00-6:50";
            }
            else if (hora == 6)
            {
                return "6:50-7:40";
            }
            else
            {
                return "7:40-8:30";
            }
        }



    }
}
