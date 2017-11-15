using System;
using System.Data;
using System.Text;
using System.Linq;
using System.Drawing;
using Schedule_Assistant;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using Schedule_Assistant.vistas;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    public partial class frmMenú : Form
    {
        private MenúMaestro maestro = new MenúMaestro();
        private MenúHorasNoDisponibles noDisponible =new MenúHorasNoDisponibles();
        private MenúMaterias materias =new MenúMaterias();
        private CrearHorarios horarios= new CrearHorarios();

        public frmMenú()
        {
            InitializeComponent();

            
            maestro.MdiParent = this;
            maestro.Size = new Size(1143, 642);
            maestro.Location = new Point(117, 0);
            maestro.Show();

            horarios.MdiParent = this;
            horarios.Size = new Size(1143, 642);
            horarios.Location = new Point(117, 0);
            horarios.Show();

            pnlFondo.Visible = true;
            maestro.Visible = false;
            noDisponible.Visible = false;
            materias.Visible = false;
            horarios.Visible = false;
        }

        
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = true;
            maestro.Visible = false;
            horarios.Visible = false;
        }

        private void btnAdminProfes_Click(object sender, EventArgs e)
        {
            maestro.Visible = true;
            horarios.Visible = false;
            pnlFondo.Visible = false;
           
        }

        
        private void btnCrearHorarios_Click(object sender, EventArgs e)
        {
            horarios.Visible = true;
            pnlFondo.Visible = false;
            maestro.Visible = false;

        }

        private void pnlFondo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
