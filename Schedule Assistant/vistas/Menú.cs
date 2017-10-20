using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using Schedule_Assistant;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    public partial class frmMenú : Form
    {
        private MenúMaestro maestro;
        private MenúHorasNoDisponibles noDisponible;
        private MenúMaterias materias;

        public frmMenú()
        {
            InitializeComponent();
        }

        
        private void btnHome_Click(object sender, EventArgs e)
        {
            noDisponible.Visible = false;
            materias.Visible = false;
        }

        private void btnAdminProfes_Click(object sender, EventArgs e)
        {
            if (maestro == null)
            {
                maestro = new MenúMaestro();
                maestro.MdiParent = this;
                maestro.Size = pnlFondo.Size;
                maestro.Location = pnlFondo.Location;
            }
                
            maestro.Show();
           
        }

        
        private void btnCrearHorarios_Click(object sender, EventArgs e)
        {



        }
    }
}
