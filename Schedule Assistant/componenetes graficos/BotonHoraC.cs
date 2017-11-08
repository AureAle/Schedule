using System;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Schedule_Assistant.componenetes_graficos
{
    class BotonHoraC: Button
    {

#region propiedades

        private Clase clase;
        private int dia;
        private int hora;

        internal Clase Clase { get => clase; }
        //public int Dia { get => dia; set => dia = value; }
        //public int Hora { get => hora; set => hora = value; }

#endregion


#region constructores

        public BotonHoraC()
        {
            this.Size = new Size(50, 50);
        }

        public BotonHoraC(Clase clase)
        {
            this.clase = clase;

            string profesor = Conector.leerNombreProfesor(clase.Profesor);
            this.Text =
                clase.NombreMateria + Environment.NewLine + profesor;

            this.AutoSize = true;
        }

#endregion

    }
}
