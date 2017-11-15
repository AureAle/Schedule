using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule_Assistant.vistas
{
    public partial class grupo : Form
        
    {
        public Boolean cerro;

        public grupo()
        {
            InitializeComponent();
        }

        private Boolean GrupoNoVacio()
        {
            if (txtGrupo.Text.Length == 0 || txtGrupo.Text == "Escriba el nuevo Nombre")
            {
                MessageBox.Show("Escriba el grupo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void bttnGuardarGrupo_Click(object sender, EventArgs e)
        {
            if (Conector.GrupoYaExiste(txtGrupo.Text))
            {
                MessageBox.Show("Grupo ya existente", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (GrupoNoVacio())
            {
                Conector.agregarGrupo(txtGrupo.Text);

                this.Close();
                cerro = false;
            }
        }

        private void grupo_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerro = true;
        }
    }
}
