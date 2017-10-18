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
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();
            Home home = new Home();
            home.MdiParent = this;
            home.Show();

            home.Size = pnlFondo.Size;
            home.Location = pnlFondo.Location;

        }

        private void btnAdminProfes_Click(object sender, EventArgs e)
        {
            MenúMaestro maestro = new MenúMaestro();
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
    }
}
