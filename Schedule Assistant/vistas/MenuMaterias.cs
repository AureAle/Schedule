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
    public partial class MenuMaterias : Form
    {
        int idProfe;
        public MenuMaterias(int id, String Nombre)
        {
            InitializeComponent();
            bttnGuardarCreditos.Visible = false;
            bttnModificarCreditos.Visible = false;
            this.idProfe = id;
            lblNProfe.Text = Nombre;
            LlenarListaMaterias();
        }
        /// <summary> Limpiar y llenar lista de materias  </summary>
        public void LlenarListaMaterias()
        {
            lstListaMateriasProfesores.Items.Clear();
            lstListaMateriasProfesores.Items.AddRange(Conector.leerClasesde(idProfe));
        }

        /// <summary> Bloquea botones de eliminar y agregar, bloque textbox materias </summary>
        private void bttnModificarCreditos_Click(object sender, EventArgs e)
        {
            bttnGuardarCreditos.Visible = true;
            bttnAgregarMaterias.Enabled = false;
            bttnBorrarMateria.Enabled = false;
            txtMateria.Enabled = false;
        }
        /// <summary>  Toma el id de la materia seleccionada y los nuevos creditos para modificarlos  </summary>
        private void bttnGuardarCreditos_Click(object sender, EventArgs e)
        {
            Clase c = lstListaMateriasProfesores.SelectedItem as Clase;
            Conector.ActualizarClase(c.Id, (int)UpDwnCreditos.Value);
            LlenarListaMaterias();
        }

        /// <summary> Agrega una nueva materia validada </summary>
        private void bttnAgregarMaterias_Click(object sender, EventArgs e)
        {
            if(txtMateria.Text.Length==0)
            {
                MessageBox.Show("Se requiere llenar el campo 'Materia'", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clase clase = new Clase(txtMateria.Text, idProfe, (int)UpDwnCreditos.Value);
                Conector.AgregarMaterias(clase);
                LlenarListaMaterias();
            }
           
        }

        /// <summary>
        /// Borra la materia seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnBorrarMateria_Click(object sender, EventArgs e)
        {
            if(lstListaMateriasProfesores.SelectedIndex!=-1)
            {
                Clase c = lstListaMateriasProfesores.SelectedItem as Clase;
                Conector.BorrarClase(c);
                LlenarListaMaterias();
            }
            else
            {
                MessageBox.Show("Se requiere seleccionar una clase de la lista", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MenuMaterias_Click(object sender, EventArgs e)
        {
            bttnGuardarCreditos.Visible = false;
            bttnAgregarMaterias.Enabled = true;
            bttnBorrarMateria.Enabled = true;
            txtMateria.Enabled = true;
        }
        
        private void lstListaMateriasProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstListaMateriasProfesores.SelectedIndex!=-1)
            {
                bttnModificarCreditos.Visible = true;
            }
        }
    }
}
