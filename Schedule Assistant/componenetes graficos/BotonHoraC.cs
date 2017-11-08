using System;
using SA_objetos;
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
        private Boolean disponible;
        
        public Clase Clase { get => clase; set => clase = value; }

        /// <summary> define si se le puede asignar una clase </summary>
        public Boolean Disponible
        {
            get => disponible;
            set
            {
                this.disponible = value;
                this.BackColor = value ? Color.Transparent : Color.MistyRose;
            }
        }
        //public int Dia { get => dia; set => dia = value; }
        //public int Hora { get => hora; set => hora = value; }

#endregion


#region constructores

        public BotonHoraC()
        {  }

        public BotonHoraC(Clase clase)
        {
            //si este metodo guarda en la base de datos, entonces es un pleonasmo o es reciproco
            this.asignar(clase);
        }

#endregion

#region metodos

        public Boolean asignar(Clase clase)
        {
            if (this.disponible==false)
            {
                /*
                 * feedback negativo
                 * por ejemplo un beep con System.Media.SystemSounds.Beep.Play();
                 */
                return false;
            }
            if (this.clase != null)
            {
                /*
                 * feedback advertencia
                 * por ejemplo un messagebox;
                 *  y despues se sobreescribe la clase
                 *  
                 *  si se sobreescribe
                 *  return true;
                 */
                return false;
            }
            else
            {
                this.clase = clase;

                string profesor = Conector.leerNombreProfesor(clase.Profesor);
                this.Text =
                    clase.NombreMateria + Environment.NewLine + profesor;

                this.AutoSize = true;

                return true;
                //registrar en la base de datos?
            }
            
        }

#endregion

    }
}
