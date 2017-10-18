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
    public partial class MenúMaestro : Form  

    {
        Conector c = new Conector();
        public MenúMaestro()
        {
            InitializeComponent();
            
        }

        public void LlenarListaProfesores()
        {
            lstProfesores.Items.Clear();
            lstProfesores.Items.AddRange(c.MostrarNombres());
        }

        private void lstProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            bttnEliminarProfesor.Visible = true;
            bttnModificarProfesor.Visible = true;
            bttnHorariosProfesor.Visible = true;
            bttnModificarMaterias.Visible = true;


        }

        protected void bttnHorariosProfesor_Click(object sender, EventArgs e)
        {

            //no puedo hacer que salga el form HorariosNoDisponibles porque el padre es menú 
            //y éste form maestro no tien mdi (help)
            
        }
        //terminar 
        private void bttnModificarProfesor_Click(object sender, EventArgs e)
        {
            txtNombreProfesor.Text = lstProfesores.Text;
        }

        private void bttnEliminarProfesor_Click(object sender, EventArgs e)
        {
            Profe p = new Profe();
            p = lstProfesores.SelectedItem as Profe;
            c.Borrar(p);
            LlenarListaProfesores();
        }

        private void bttnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Profe p = new Profe();
            p.Nombre1 = txtNombreProfesor.Text;
            c.InsertarProfe(p);

            LlenarListaProfesores();
            txtNombreProfesor.Clear();
        }
    }
}
