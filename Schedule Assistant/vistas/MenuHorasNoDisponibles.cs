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

        public MenuHorasNoDisponibles(int idProfe, String Nombre)
        {
            InitializeComponent();
            this.idProfe = idProfe;
            lblNombreProfe.Text = Nombre;
        }

        private void lblMaestros_Click(object sender, EventArgs e)
        {

        }

        /// <summary> Llena la lista de horas dependiendo del dia seleccionado </summary>
        public void LlenarListaHoras()
        {
            lstListaHorariosProfesor.Items.Clear();
            int dia = cmbDia.SelectedIndex + 1;
            HoraNoDisponible[] horaND = Conector.leerHorasNoDisponiblesDe(idProfe);
            for (int i = 0; i < horaND.Length; i++)
            {
                if (dia == horaND[i].Dia)
                {
                    lstListaHorariosProfesor.Items.Add(horaND[i]);
                }
            }
        }

        /// <summary> Agrega una hora, ya validada </summary>
        private void bttnAgregarHorario_Click(object sender, EventArgs e)
        {
            Boolean noEsta = true ;

            if (cmbDia.SelectedIndex == -1 && cmbHora.SelectedIndex == -1)
            {
                MessageBox.Show("Se requiere seleccionar un 'dia' y una 'hora'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int hora = cmbHora.SelectedIndex + 1;
                int dia = cmbDia.SelectedIndex + 1;
                HoraNoDisponible[] horasND = Conector.leerHorasNoDisponiblesDe(idProfe);

                for (int i = 0; i < horasND.Length; i++)
                {
                    if (horasND[i].Dia == dia && horasND[i].Hora == hora)
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
        }

        private void cmbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            
        }

        private void cmbDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarListaHoras();
        }

        /// <summary> Elimina una hora seleccionada </summary>
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

        private void MenuHorasNoDisponibles_Load(object sender, EventArgs e)
        {

        }
    }
}
