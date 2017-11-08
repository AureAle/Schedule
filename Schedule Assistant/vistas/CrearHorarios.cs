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
        
        private botonClase claseSelec;

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

            Clase[] clases = Conector.leetTodasClases();
            foreach (Clase clase in clases)
            {
                botonClase boton = new botonClase(clase);
                boton.MouseClick += btnClase_Click;
                flowLayoutPanel1.Controls.Add(boton);
            }
        }

        public void selecQuitarHora()
        {
            if (claseSelec.Disponibles < 1)
                claseSelec.Disponibles--;
            else
            {
                claseSelec = null;
                //despintar horas no disponibles
            }
        }

        #endregion

#region eventos

        private void btnClase_Click(object sender, EventArgs e)
        {
            if(claseSelec != null)
            {
                //despintar horas no disponibles
            }

            claseSelec = sender as botonClase;
            //colorear las horas en las que no pueda ir el maestro
        }

        private void hora_Click(object sender, EventArgs e)
        {
            if (claseSelec != null)
            {
                //idnetificar
                botonClase boton = sender as botonClase;
                TableLayoutPanelCellPosition celda = tableLayoutPanel1.GetCellPosition(boton);

                Clase clase = boton.Clase;

                //ejecutar
                Conector.agregarHoraClase(celda.Column, celda.Row, clase.Id, 1, 1);

                //almacenar

                //restar una hora
            }

        }

        private void CrearHorarios_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
                CargarBotones();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {         
           //lo puse por si ocultamos el panel de opciones y se vea más completo poder regresar(? 

        }
    }

#endregion
}