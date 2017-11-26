using System;
using SA_objetos;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Schedule_Assistant.componenetes_graficos
{
    class botonClase: Button
    {
#region propiedades

        private Clase clase;
        private int disponibles;

        internal Clase Clase { get => clase; }
        public int Disponibles { get => disponibles; set => disponibles = value; }

#endregion

#region constructores

        public botonClase()
        {
            this.Size = new Size(157, 50);
        }

        public botonClase(Clase clase)
        {
            this.clase = clase;
            this.disponibles = clase.Creditos- Conector.LeerTodosHorariosPorClase(clase.Id).Length; 
            //this.AutoSize = true;

            cargarTexto();
        }

#endregion

#region metodos

        public void cargarTexto()
        {
            string profesor = Conector.leerNombreProfesor(clase.Profesor);
            this.Text = 
                clase.NombreMateria + Environment.NewLine +
                profesor + Environment.NewLine +
                disponibles + "/" + clase.Creditos;
        }

#endregion

    }
}
