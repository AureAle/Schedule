using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Assistant
{
    public partial class MenuHorasNoDisponibles : Form
    {
        int idProfe;

        public MenuHorasNoDisponibles(int id, String Nombre)
        {
            InitializeComponent();
            this.idProfe = id;
            lblNombreProfe.Text = Nombre;
            
        }


        private void lblMaestros_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Llena la lista de horas dependiendo del dia seleccionado
        /// </summary>
        public void LlenarListaHoras()
        {
            lstListaHorariosProfesor.Items.Clear();
            int dia = cmbDia.SelectedIndex + 1;
            for (int i = 0; i < Conector.leerHorasNoDisponiblesDe(idProfe).Length; i++)
            {

                if (dia == Conector.leerHorasNoDisponiblesDe(idProfe)[i].Dia)
                {
                    lstListaHorariosProfesor.Items.Add(Conector.leerHorasNoDisponiblesDe(idProfe)[i]);

                }
            }
        }

        /// <summary>
        /// Agrega una hora, ya validada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAgregarHorario_Click(object sender, EventArgs e)
        {
            Boolean noEsta = true ;
            if(cmbDia.SelectedIndex!=-1 && cmbHora.SelectedIndex!=-1)
            {
                int hora = cmbHora.SelectedIndex + 1;
                int dia = cmbDia.SelectedIndex + 1;
                for (int i = 0; i < Conector.leerHorasNoDisponiblesDe(idProfe).Length; i++)
                {
                    if (Conector.leerHorasNoDisponiblesDe(idProfe)[i].Dia==dia && Conector.leerHorasNoDisponiblesDe(idProfe)[i].Hora1==hora)
                    {
                        noEsta = false;
                        break;
                    }
                }

                if (noEsta)
                {
                    HoraNoDisponible hnd = new HoraNoDisponible(hora, dia);
                    Conector.agregarHorariosNoDisponibles(idProfe, hnd);

                    LlenarListaHoras();
                    
                }
                else
                {
                    MessageBox.Show("este hora y dia ya se encuentra agregado con este profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Se requiere seleccionar un 'dia' y una 'hora'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarListaHoras();
        }

        /// <summary>
        /// Elimina una hora seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnEliminarHoraProfesor_Click(object sender, EventArgs e)
        {
            if(lstListaHorariosProfesor.SelectedIndex!=-1)
            {
                HoraNoDisponible hnd = lstListaHorariosProfesor.SelectedItem as HoraNoDisponible;
                Conector.borrarHoraNoDisponible(hnd);
                LlenarListaHoras();
            }
            else
            {
                MessageBox.Show("Se requiere seleccionar un horario de la lista", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
