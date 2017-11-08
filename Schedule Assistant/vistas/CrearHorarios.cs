using System;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Schedule_Assistant.componenetes_graficos;
using SA_objetos;

namespace Schedule_Assistant.vistas
{
    
    public partial class CrearHorarios : Form
    {
        
        private botonClase botonClaseSelec;

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

            Clase[] clases = Conector.leerTodasClases();
            foreach (Clase clase in clases)
            {
                botonClase boton = new botonClase(clase);
                boton.MouseClick += btnClase_Click;
                flowLayoutPanel1.Controls.Add(boton);
            }
        }

        //qiza sea mejor que este sea comportamiento del boton mismo.
        public void selecQuitarHora()
        {
            if (botonClaseSelec.Disponibles < 1)
            {
                botonClaseSelec.Disponibles--;
                //actualizar el boton
            }
            else
            {
                botonClaseSelec = null;
                //despintar horas no disponibles
            }
        }

        #endregion

#region eventos

        private void btnClase_Click(object sender, EventArgs e)
        {
            if(botonClaseSelec != null)
            {
                //despintar horas no disponibles
            }

            botonClaseSelec = sender as botonClase;
            //colorear las horas en las que no pueda ir el maestro
        }

        private void botonHora_Click(object sender, EventArgs e)
        {
            if (botonClaseSelec == null)
            {
                //nada
            }
            else
            {
                //idnetificar
                BotonHoraC boton = sender as BotonHoraC;
                TableLayoutPanelCellPosition celda = tableLayoutPanel1.GetCellPosition(boton);
                Clase clase = botonClaseSelec.Clase;

                Boolean aceptado = boton.asignar(clase);
                if (aceptado)
                {
                    //registrar en la base de datos
                    Conector.agregarHoraClase(celda.Column, celda.Row, clase.Id, 1, 1);


                    //restar una hora
                    selecQuitarHora();
                }

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