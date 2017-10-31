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
    class botonClase: Button
    {

#region propiedades
        private Clase clase;
        private int disponibles;

        internal Clase Clase { get => clase; }
        
        #endregion

#region constructores
        public botonClase()
        {
            this.Size = new Size(50,50);
        }

        public botonClase(Clase clase)
        {
            this.clase = clase;
            this.disponibles = clase.Creditos;

            string profesor = Conector.nombreProfesor(clase.Profesor);
            this.Text = 
                clase.NombreMateria + Environment.NewLine +
                profesor + Environment.NewLine +
                disponibles + "/" + clase.Creditos;

            this.AutoSize = true;
        }

        #endregion
    }
}
