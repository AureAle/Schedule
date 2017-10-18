using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class HoraNoDisponible
        
    {
        private int id;
        private DateTime hora;
        private string día;

        public int Id { get => id; set => id = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Día { get => día; set => día = value; }


    }
}
