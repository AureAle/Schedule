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

            LlenarListaProfesores();
            bttnEliminarProfesor.Visible = false;
            bttnModificarProfesor.Visible = false;
            bttnHorariosProfesor.Visible = false;
            bttnModificarMaterias.Visible = false;

            bttnGuardarNuevoNombre.Visible = false;
            
        }
        //LIMPIA Y LLENA LA LISTA DE PROFESORES
        public void LlenarListaProfesores()
        {
            lstProfesores.Items.Clear();
            lstProfesores.Items.AddRange(c.MostrarNombres());
        }
        //VALIDACION PARA CAMPO NOMBRE VACIO
        public Boolean NombreProfesorNoVacio()
        {
            if(txtNombreProfesor.Text.Length==0 || txtNombreProfesor.Text == "Escriba el nuevo Nombre")
            {
                MessageBox.Show("Se requiere el campo 'Nombre Completo'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        //MUESTRA LAS OPCIONES UNICAMENTE CUANDO SE SELECCIONA ALGUN PROFESOR
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

            //no puedo hacer que salga el form HorariosNoDisponibles porque el padre es menú 
            //y éste form maestro no tien mdi (help)
            
        }
         
        //CAMBIAR BOTONES PARA MODIFICAR PROFESOR Y ESTABLECE UN MENSAJE TIPO MARCA DE AGUA
        private void bttnModificarProfesor_Click(object sender, EventArgs e)
        {
            if(lstProfesores.SelectedIndex==-1)
            {
                MessageBox.Show("Se requiere seleccionar un Profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtNombreProfesor.Text.Length == 0)
                {
                    txtNombreProfesor.Text = "Escriba el nuevo Nombre";
                    txtNombreProfesor.ForeColor = Color.Gray;
                }
                bttnGuardarNuevoNombre.Visible = true;
                bttnAgregarProfesor.Visible = false;
            }
           
            
            
        }
        //SE ELIMINA EL PROFESOR SELECCIONADO VALIDADO
        private void bttnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (lstProfesores.SelectedIndex == -1)
            {
                MessageBox.Show("Se requiere seleccionar un Profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Profe p = new Profe();
                p = lstProfesores.SelectedItem as Profe;
                c.Borrar(p);
                LlenarListaProfesores();
            }
            
           
      
        }
        //AGREGAR UN NUEVO PROFESOR
        private void bttnAgregarProfesor_Click(object sender, EventArgs e)
        {
            //VALIDACION DE CAMPO TXTNOMBREPROFESOR NO VACIO
            if(NombreProfesorNoVacio())
            {
                Profe p = new Profe();
                p.Nombre = txtNombreProfesor.Text;
                c.InsertarProfe(p);

                LlenarListaProfesores();
                txtNombreProfesor.Clear();
            }
            
        }
        //SE MODIFICA EL PROFESOR SIEMPRE Y CUANDO NO ESTE VACIO EL CUADRO DE TEXTO
        private void bttnGuardarNuevoNombre_Click(object sender, EventArgs e)
        {
            if(NombreProfesorNoVacio())
            {
                Profe antuguoProfe = new Profe();
                Profe nuevoProfe = new Profe();
                antuguoProfe = lstProfesores.SelectedItem as Profe;
                nuevoProfe.Nombre1 = txtNombreProfesor.Text;
                c.ActualizarProfesor(antuguoProfe, nuevoProfe);
                LlenarListaProfesores();
                txtNombreProfesor.Text = "";
            }
            
        }
        //EN MODO MODIFICAR AL HACER CLICK EN EL CUADRO DE TEXTO SE VACIA
        private void txtNombreProfesor_Click(object sender, EventArgs e)
        {
            txtNombreProfesor.Text = "";
            txtNombreProfesor.ForeColor = Color.SteelBlue;
        }
        //PERMANECERA LA MARCA DE AGUA CUANDO SE SIGA EN MODO MODIFICAR PROFESOR
        private void txtNombreProfesor_Leave(object sender, EventArgs e)
        {
            if (txtNombreProfesor.Text.Length == 0 && bttnGuardarNuevoNombre.Visible==true)
            {
                txtNombreProfesor.Text = "Escriba el nuevo Nombre";
                txtNombreProfesor.ForeColor = Color.Gray;
            }
        }
        //SI HACE CLICK EN ALGUN OTRO LUGAR SE CAMBIA A MODO AGREGAR PROFESOR
        private void MenúMaestro_Click(object sender, EventArgs e)
        {
            bttnGuardarNuevoNombre.Visible = false;
            bttnAgregarProfesor.Visible = true;
            txtNombreProfesor.Text = "";
            txtNombreProfesor.ForeColor = Color.SteelBlue;
        }
    }
}
