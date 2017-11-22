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
        private int id;
        private Clase clase;
        private Boolean disponible;
        private String aula;
        
        public Clase Clase { get => clase; set => clase = value; }

        /// <summary> define si se le puede asignar una clase </summary>
        public Boolean Disponible
        {
            get => disponible;
            set
            {
                this.disponible = value;
                this.BackColor = value ? Color.Transparent : Color.IndianRed;
            }
        }

        public string Aula { get => aula; set => aula = value; }
        public int Id { get => id; set => id = value; }

        //public int Dia { get => dia; set => dia = value; }
        //public int Hora { get => hora; set => hora = value; }

        #endregion


        #region constructores

        public BotonHoraC()
        {
            this.Size = new Size(176, 75);
        }

        public BotonHoraC(Clase clase)
        {
            //si este metodo guarda en la base de datos, entonces es un pleonasmo o es reciproco
            this.asignar(clase,0,0,0);
        }

#endregion

#region metodos

        /// <summary> intenta asigarse la clase indicada, si falla se debuelve un false </summary>
        public Boolean asignar(Clase clase, int grupo, int dia, int hora)
        {
            

            if (this.disponible == false)
            {
                MessageBox.Show("Hora no disponible para esta clase", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.clase != null || this.Text != "")
            {
                ///SOBRE ESCRIBE UN HORARIO
                DialogResult dialogResult = MessageBox.Show("¿Desea cambiar la clase?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //BORRA LA REMPLAZADA
                    Conector.BorrarHorario(dia,hora, grupo);
                    this.clase = clase;

                    ToString();
                    return true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return false;
                }
                return false;
            }
            else 
            {
                this.clase = clase;

                ToString();
                return true;
            }        
        }

        public override string ToString()
        {
            string profesor = Conector.leerNombreProfesor(clase.Profesor);
            return 
            this.Text =
                clase.NombreMateria + Environment.NewLine + profesor + Environment.NewLine + Aula;

            this.AutoSize = true;
        }

        #endregion

    }
}
