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

        private botonClase selecionado;

#region constructor

        public CrearHorarios()
        {
            InitializeComponent();
        }

#endregion

#region metodos

        public void CargarBotones()
        {
            flowLayoutPanel1.Controls.Clear();

            Clase[] clases = Conector.MostrarClasesTodas();
            foreach (Clase clase in clases)
            {
                botonClase boton = new botonClase(clase);
                boton.MouseClick += btnClase_Click;
                flowLayoutPanel1.Controls.Add(boton);
            }
        }

        private void CrearHorarios_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            CargarBotones();
        }

        #endregion

#region eventos

        private void btnClase_Click(object sender, EventArgs e)
        {
            selecionado = sender as botonClase;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            //selecionado.Clase.Id
            //tableLayoutPanel1.;
        }

        private void hora_Click(object sender, EventArgs e)
        {
            botonn = sender as botonClase;

            tableLayoutPanel1.GetCellPosition(boton);


        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point selectedCell = new Point(
                e.X / (tableLayoutPanel1.Width / tableLayoutPanel1.ColumnCount),
                e.Y / (tableLayoutPanel1.Height / tableLayoutPanel1.RowCount));
        }
    }

#endregion
}