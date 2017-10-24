using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Schedule_Assistant

{
    
    public partial class MenuMaestro : Form  
    {

//******************************** constructor *********************************


        public MenuMaestro()
        {
            InitializeComponent();

            LlenarListaProfesores();

            bttnEliminarProfesor.Visible = false;
            bttnModificarProfesor.Visible = false;
            bttnHorariosProfesor.Visible = false;
            bttnModificarMaterias.Visible = false;

            bttnGuardarNuevoNombre.Visible = false;
            
        }
        
        /// <summary> LIMPIA Y LLENA LA LISTA DE PROFESORES  </summary>
        private void LlenarListaProfesores()
        {
            lstProfesores.Items.Clear();
            lstProfesores.Items.AddRange(Conector.MostrarNombres());
        }


//******************************** metodos *********************************
        
        /// <summary> VALIDACION PARA CAMPO NOMBRE VACIO </summary>
        private Boolean NombreProfesorNoVacio()
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

        /// <summary> MUESTRA LAS OPCIONES UNICAMENTE CUANDO SE SELECCIONA ALGUN PROFESOR </summary>
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


//******************************** click *********************************

        protected void bttnHorariosProfesor_Click(object sender, EventArgs e)
        {
                     
           //(?) 
            
            
            


        }

        /// <summary> CAMBIAR BOTONES PARA MODIFICAR PROFESOR Y ESTABLECE UN MENSAJE TIPO MARCA DE AGUA </summary>
        private void bttnModificarProfesor_Click(object sender, EventArgs e)
        {
            if(lstProfesores.SelectedIndex==-1)
                MessageBox.Show("Se requiere seleccionar un Profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        
        /// <summary> SE ELIMINA EL PROFESOR SELECCIONADO VALIDADO </summary>
        private void bttnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (lstProfesores.SelectedIndex == -1)
            {
                MessageBox.Show("Se requiere seleccionar un Profesor", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Profe p = lstProfesores.SelectedItem as Profe;
                Conector.BorrarProfe(p.Id);
                LlenarListaProfesores();
            }
            
           
      
        }
        
        /// <summary> registra al profesor indicado en la base de datos </summary>
        private void bttnAgregarProfesor_Click(object sender, EventArgs e)
        {
            //VALIDACION DE CAMPO TXTNOMBREPROFESOR NO VACIO
            if(NombreProfesorNoVacio())
            {
                Conector.InsertarProfe(txtNombreProfesor.Text);

                LlenarListaProfesores();
                txtNombreProfesor.Clear();
            }
            
        }

        /// <summary> SE MODIFICA EL PROFESOR SIEMPRE Y CUANDO NO ESTE VACIO EL CUADRO DE TEXTO </summary>am>
        private void bttnGuardarNuevoNombre_Click(object sender, EventArgs e)
        {
            if(NombreProfesorNoVacio())
            {
                Profe profe = lstProfesores.SelectedItem as Profe;
                string nombre = txtNombreProfesor.Text;
                Conector.ActualizarProfesor(profe.Id, nombre);
                LlenarListaProfesores();
                txtNombreProfesor.Text = "";
                bttnGuardarNuevoNombre.Visible = false;
                bttnAgregarProfesor.Visible = true;
            }
            
        }
        
        /// <summary> EN MODO MODIFICAR AL HACER CLICK EN EL CUADRO DE TEXTO SE VACIA </summary>
        private void txtNombreProfesor_Click(object sender, EventArgs e)
        {
            txtNombreProfesor.Text = "";
            txtNombreProfesor.ForeColor = Color.SteelBlue;
        }
        
        /// <summary> PERMANECERA LA MARCA DE AGUA CUANDO SE SIGA EN MODO MODIFICAR PROFESOR </summary>
        private void txtNombreProfesor_Leave(object sender, EventArgs e)
        {
            if (txtNombreProfesor.Text.Length == 0 && bttnGuardarNuevoNombre.Visible==true)
            {
                txtNombreProfesor.Text = "Escriba el nuevo Nombre";
                txtNombreProfesor.ForeColor = Color.Gray;
            }
        }
        
        /// <summary> SI HACE CLICK EN ALGUN OTRO LUGAR SE CAMBIA A MODO AGREGAR PROFESOR  </summary>
        private void MenúMaestro_Click(object sender, EventArgs e)
        {
            bttnGuardarNuevoNombre.Visible = false;
            bttnAgregarProfesor.Visible = true;
            txtNombreProfesor.Text = "";
            txtNombreProfesor.ForeColor = Color.SteelBlue;
        }

        /// <summary>  </summary>
        private void bttnModificarMaterias_Click(object sender, EventArgs e)
        {

        }

    }
}
