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

        [Description("clase a mostrar"), Category("Appearance")]
        public Clase Clase
        {
            get { return clase; }
            set
            {
                clase = value;
                this.Invalidate();
            }
        }


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
        }

#endregion


    }
}
