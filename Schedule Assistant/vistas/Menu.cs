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
    public partial class frmMenu : Form
    {
        private MenuMaestro maestro = new MenuMaestro();
        private MenuHorasNoDisponibles noDisponible =new MenuHorasNoDisponibles();
        private MenuMaterias materias =new MenuMaterias();
        private CrearHorarios horarios= new CrearHorarios();

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
             maestro.MdiParent = this;
            maestro.Size = new Size(1143, 642);
            maestro.Location = pnlFondo.Location;
            //maestro.Anchor = pnlFondo.Anchor;
            maestro.Show();

            horarios.MdiParent = this;
            horarios.Size = new Size(1143, 642);
            horarios.Location = new Point(117, 0);
           // horarios.Anchor = pnlFondo.Anchor;
            horarios.Show();

            noDisponible.MdiParent = this;
            noDisponible.Size = new Size(1143, 642);
            noDisponible.Location = pnlFondo.Location;
            //noDisponible.Anchor = pnlFondo.Anchor;
            noDisponible.Show();

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

    }
}
