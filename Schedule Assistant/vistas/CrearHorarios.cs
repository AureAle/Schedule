using Schedule_Assistant.componenetes_graficos;
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
    public partial class CrearHorarios : Form
    {
        public CrearHorarios()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CrearHorarios_Load(object sender, EventArgs e)
        {
            Clase[] clases = Conector.MostrarClasesTodas();
            foreach(Clase clase in clases)
            {
                botonClase boton = new botonClase(clase);
                flowLayoutPanel1.Controls.Add(boton);
            }
        }
    }
}
