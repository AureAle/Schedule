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
    public partial class MenuMaestro : Form  

    {
        Conector c = new Conector();
        public MenuMaestro()
        {
            InitializeComponent();
            lblNuevoNombre.Visible = false;
            txtNuevoNombre.Visible = false;
            bttnGuardarNuevoNombre.Visible = false;

            bttnEliminarProfesor.Visible = false;
            bttnModificarProfesor.Visible = false;
            bttnHorariosProfesor.Visible = false;
            bttnModificarMaterias.Visible = false;

            LlenarListaProfesores();
        }

        //LIMPIA Y LLENA LA LISTA
        public void LlenarListaProfesores()
        {
            lstProfesores.Items.Clear();
            lstProfesores.Items.AddRange(c.MostrarNombres().ToArray());
        }

        //MUESTRA LOS BOTONES CUANDO UNICAMENTE SE SELECCIONO ALGO DE LA LISTA
        private void lstProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(lstProfesores.SelectedIndex!=-1)
            {
                bttnEliminarProfesor.Visible = true;
                bttnModificarProfesor.Visible = true;
                bttnHorariosProfesor.Visible = true;
                bttnModificarMaterias.Visible = true;
            }
            


        }

        protected void bttnHorariosProfesor_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.GenerarHorasNoDisponibles();

            //INTENTE LLAMAR UN METODO QUE LO HAGA DESDE OTRO LUGAR PERO PARECE QUE NO JALA
            

        }
        //terminar 
        private void bttnModificarProfesor_Click(object sender, EventArgs e)
        {
            lblNuevoNombre.Visible = true;
            txtNuevoNombre.Visible = true;
            bttnGuardarNuevoNombre.Visible = true;
            
        }

        //ELIMINA EL PROFESOR SELECCIONADO CON VALIDACION SI NINGUN PROFE SE SELECCIONO
        private void bttnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if(lstProfesores.SelectedIndex==-1)
            {
                MessageBox.Show("Es necesario seleccionar algun profesor", "ADVERTENCIA",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Profe p = new Profe();
                p = lstProfesores.SelectedItem as Profe;
                c.Borrar(p);
                LlenarListaProfesores();
            }
            
        }

        private void bttnAgregarProfesor_Click(object sender, EventArgs e)
        {
            Profe p = new Profe();
            p.Nombre1 = txtNombreProfesor.Text;
            c.InsertarProfe(p);

            LlenarListaProfesores();
            txtNombreProfesor.Clear();
        }

        //MODIFICA UN PROFESOR SELECCIONADO CON VALIDACION DE SELECCION
        private void bttnGuardarNuevoNombre_Click(object sender, EventArgs e)
        {
            if (txtNuevoNombre.Text.Length==0)
            {
                MessageBox.Show("Es necesario llenar el campo 'Nuevo Nombre'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Profe antiguoProfe = new Profe();
                Profe nuevoProfe = new Profe();

                antiguoProfe = lstProfesores.SelectedItem as Profe;
                nuevoProfe.Nombre1 = txtNuevoNombre.Text;
                c.ActualizarProfe(antiguoProfe, nuevoProfe);
                LlenarListaProfesores();
            }
            
        }
    }
}
