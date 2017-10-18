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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            Home home = new Home();
            home.MdiParent = this;
            home.Show();

            home.Size = pnlFondo.Size;
            home.Location = pnlFondo.Location;

        }

        private void bttnAdminProfes_Click(object sender, EventArgs e)
        {
            MenuMaestro maestro = new MenuMaestro();
            maestro.MdiParent = this;
            maestro.Show();

            maestro.Size = pnlFondo.Size;
            maestro.Location = pnlFondo.Location;
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.MdiParent = this;
            home.Show();

            home.Size = pnlFondo.Size;
            home.Location = pnlFondo.Location;
        }

        public void GenerarHorasNoDisponibles()
        {
            MenuHorasNoDisponibles hnd = new MenuHorasNoDisponibles();
            hnd.MdiParent = this;
            hnd.Show();

            hnd.Size = pnlFondo.Size;
            hnd.Location = pnlFondo.Location;
        }
    }
}
