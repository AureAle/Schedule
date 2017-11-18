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
        public MenuMaestro maestro = new MenuMaestro();
        public CrearHorarios horarios= new CrearHorarios();

        public frmMenu()
        {
            InitializeComponent();

            btnAdminProfes.PerformClick();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            maestro.MdiParent = this;
            maestro.Show();

            horarios.MdiParent = this;
            horarios.Show();

            pnlFondo.Visible = true;
            maestro.Visible = false;
            horarios.Visible = false;

        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = true;
            maestro.Visible = false;
            horarios.Visible = false;
            horarios.editar = false;
            horarios.crear = false;

        }

        private void btnAdminProfes_Click(object sender, EventArgs e)
        {
            maestro.Visible = true;
            horarios.Visible = false;
            pnlFondo.Visible = false;
            horarios.editar = false;
            horarios.crear = false;
        }
        
        private void btnCrearHorarios_Click(object sender, EventArgs e)
        {
            horarios.crear = true;
            horarios.editar = false;
            horarios.Visible = true;
            if (horarios.CerroCrear)
            {
                pnlFondo.Visible = true;
                maestro.Visible = false;
                horarios.Visible = false;
            }
            else
            {
                pnlFondo.Visible = false;
                maestro.Visible = false;
                horarios.Visible = true;
            }

        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                pnlOpciones.Visible = !pnlOpciones.Visible;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
               
                horarios.editar = true;
                horarios.crear = false;
                horarios.Visible = true;
            if (horarios.Cerro)
            {
                pnlFondo.Visible = true;
                maestro.Visible = false;
                horarios.Visible = false;
            }
            else
            {
                pnlFondo.Visible = false;
                maestro.Visible = false;
                horarios.Visible = true;
            }
            
            
        }
    }
}
