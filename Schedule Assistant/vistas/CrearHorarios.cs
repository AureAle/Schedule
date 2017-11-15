using System;
using SA_objetos;
using System.Text;
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
        private Point[] horasNoDisponibles;

#region constructor

        public CrearHorarios()
        {
            InitializeComponent();
        }

#endregion

#region metodos

        public void BorrarColor()
        {
            for(int row = 0; row < tablePanelHorairo.RowCount; row++)
            {
                for (int column = 0; column < tablePanelHorairo.ColumnCount; column++)
                {
                    this.tablePanelHorairo.GetControlFromPosition(column, row).BackColor = Color.Transparent;

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

        private void horaSelecRestarHora()
        {
            if (ClaseSelec.Disponibles >= 1)
            {
                ClaseSelec.Disponibles--;
                ClaseSelec.cargarTexto();
            }
            else
            {
                ClaseSelec = null;
                //foreach(Point hora in horasNoDisponibles)
                //{
                //    Control control = tablePanelHorairo.GetControlFromPosition(hora.X, hora.Y);
                //    BotonHoraC boton = control as BotonHoraC;
                //    boton.Disponible = true;

                //}
            }
        }

#endregion

#region eventos

        private void btnClase_Click(object sender, EventArgs e)
        {
            if(ClaseSelec != null)
            {
                //nada
            }

            ClaseSelec = sender as botonClase;
            BorrarColor();
            for(int i= 0; i< Conector.leerHorasNoDisponiblesDe(ClaseSelec.Clase.Profesor).Length; i++)
            {
                this.tablePanelHorairo.GetControlFromPosition(Conector.leerHorasNoDisponiblesDe(ClaseSelec.Clase.Profesor)[i].Dia-1,
                    Conector.leerHorasNoDisponiblesDe(ClaseSelec.Clase.Profesor)[i].Hora - 1).BackColor = Color.IndianRed;
            }
            //colorear las horas en las que no pueda ir el maestro
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
                horaSelecRestarHora();
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
            //lenar tabla
           // lblGrupo.Text += Conector.leerGrupo();
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