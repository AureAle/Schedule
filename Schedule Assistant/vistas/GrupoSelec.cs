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
    public partial class GrupoSelec : Form
    {
        public Boolean cerro=false;
        public int idGrupo;

        public GrupoSelec()
        {
            InitializeComponent();
           
        }

        private void bttnAceptarGrupo_Click(object sender, EventArgs e)
        {
            if(lstGrupos.SelectedIndex!=-1)
            {
                Grupo grp = lstGrupos.SelectedItem as Grupo;
                idGrupo = grp.Id;
                MessageBox.Show(idGrupo.ToString()); 
                this.Close();
                cerro = false; 
            }
            else
            {
                MessageBox.Show("Es necesario seleccionar un grupo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void GrupoSelec_FormClosing(object sender, FormClosingEventArgs e)
        {
            cerro = true;
        }

        public int getID()
        {
            return idGrupo;
        }

        private void GrupoSelec_Load(object sender, EventArgs e)
        {
            lstGrupos.Items.Clear();
            lstGrupos.Items.AddRange(Conector.TodosGrupo());
        }
    }
}
