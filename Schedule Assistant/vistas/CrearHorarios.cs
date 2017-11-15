using System;
using SA_objetos;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Schedule_Assistant.componenetes_graficos;

namespace Schedule_Assistant.vistas
{
    
    public partial class CrearHorarios : Form
    {
        
        private botonClase ClaseSelec;
        private HoraNoDisponible[] horasNoDisponibles;

#region constructor

        public CrearHorarios()
        {
            InitializeComponent();
        }

        #endregion

#region metodos

        /// <summary> le quita el color a cada horaC de tableLayoutPanel </summary>
        public void BorrarColor()
        {
            for (int row = 0; row < tablePanelHorairo.RowCount; row++)
            {
                for (int column = 0; column < tablePanelHorairo.ColumnCount; column++)
                {
                    BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(column, row) as BotonHoraC;
                    boton.Disponible = true;
                }
            }
        }

        private void CargarBotones()
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

        /// <summary> resta uno a las horas disponibles de la clase selecionada </summary>
        private void ClaseSelecRestarHora()
        {
            ClaseSelec.Disponibles--;
            ClaseSelec.cargarTexto();

            if (ClaseSelec.Disponibles < 1)
            {
                ClaseSelec = null;
                foreach (HoraNoDisponible hora in horasNoDisponibles)
                {
                    BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(hora.Dia, hora.Hora) as BotonHoraC;
                    boton.Disponible = true;
                }
            }
        }

        #endregion

#region eventos

        private void btnClase_Click(object sender, EventArgs e)
        {
            BorrarColor();

            ClaseSelec = sender as botonClase;

            horasNoDisponibles = Conector.leerHorasNoDisponiblesDe(ClaseSelec.Clase.Profesor);
            foreach (HoraNoDisponible horaND in horasNoDisponibles)
            {
                BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(horaND.Dia - 1, horaND.Hora - 1) as BotonHoraC;
                boton.Disponible = false;
            }
        }

        private void botonHoraC_Click(object sender, EventArgs e)
        {
            BotonHoraC botonHora = sender as BotonHoraC;

            if (ClaseSelec == null)
            {
                MessageBox.Show("Es necesario agregar alguna clase", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (botonHora.asignar(ClaseSelec.Clase))
            {
                //ubicar
                TableLayoutPanelCellPosition celda = tablePanelHorairo.GetCellPosition(botonHora);

                //registrar en la base de datos
                Conector.agregarHoraClase(celda.Column+1, celda.Row+1, ClaseSelec.Clase.Id, 20, 1);
                
                //restar una hora
                ClaseSelecRestarHora();
            }

        }

        private void CrearHorarios_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                CargarBotones();
                BorrarColor();
                lblGrupo.Text = "Horario del grupo: ";
                lblGrupo.Text += Conector.UltimoGrupo();
            }
                
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {         
           //lo puse por si ocultamos el panel de opciones y se vea más completo poder regresar(? 

        }

        private void CrearHorarios_Load(object sender, EventArgs e)
        {
            for (int row = 0; row < tablePanelHorairo.RowCount; row++)
            {
                for (int column = 0; column < tablePanelHorairo.ColumnCount; column++)
                {
                    BotonHoraC boton = new BotonHoraC();
                    boton.MouseClick += botonHoraC_Click;
                    tablePanelHorairo.Controls.Add(boton, column, row);
                }
            }
        }

#endregion

    }
}