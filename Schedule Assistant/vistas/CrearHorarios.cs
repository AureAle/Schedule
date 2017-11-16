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
                    boton.BackColor = Color.Transparent;

                    boton.Disponible = true;
                }
            }
        }
        public void BorrarTexto()
        {
            for (int row = 0; row < tablePanelHorairo.RowCount; row++)
            {
                for (int column = 0; column < tablePanelHorairo.ColumnCount; column++)
                {
                    BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(column, row) as BotonHoraC;
                    boton.BackColor = Color.Transparent;

                    boton.Text = "";
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
                boton.Size = new Size(157, 50);
                boton.FlatStyle = FlatStyle.Flat;
                flowLayoutPanel1.Controls.Add(boton);

            }
        }

        /// <summary> resta uno a las horas disponibles de la clase selecionada </summary>
        private Boolean ClaseSelecRestarHora(BotonHoraC botonsito)
        {
            if (ClaseSelec.Disponibles < 1)
            {
                ClaseSelec = null;
                foreach (HoraNoDisponible hora in horasNoDisponibles)
                {
                    BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(hora.Dia, hora.Hora) as BotonHoraC;
                    boton.Disponible = true;
                }
                MessageBox.Show("Creditos insuficientes", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (botonsito.BackColor==Color.IndianRed) 
            {
                MessageBox.Show("Hora no disponible", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return false;
            }
            else
            {
                ClaseSelec.Disponibles--;
                ClaseSelec.cargarTexto();
                return true;
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
            //GENERA FORM AULAS
            aula a = new aula();
            a.ShowDialog();

            if(a.getAula()==null)//SI NO SELECCIONA AULA NO HACE NI MAIS
            {
                //NELL PASTEL
            }
            else
            {
                botonHora.Aula = a.getAula();
                //OBTIENE ID DE AULA DE LA BASE DE DATOS
                int IdAula = Conector.leerIdAula(botonHora.Aula);

                //ubicar
                TableLayoutPanelCellPosition celda = tablePanelHorairo.GetCellPosition(botonHora);
                //SI ESTA OCUPADA EL AULA POR OTRO GRUPO EN LA MISMA HORA, SE LA PELA
                if (Conector.AulaNoOcupada(IdAula, celda.Column + 1, celda.Row + 1))
                {
                    if (ClaseSelec == null)
                    {
                        MessageBox.Show("Es necesario agregar alguna clase", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (ClaseSelecRestarHora(botonHora))//SI NO TIENE CREDITOS SE LA PELA
                    {
                        if (botonHora.asignar(ClaseSelec.Clase))//SI LO ESCRIBE AL MERO PETS EN EL BOTON LO GUARDA EN LA DB
                        {
                            //registrar en la base de datos
                            Conector.agregarHoraClase(celda.Column + 1, celda.Row + 1, ClaseSelec.Clase.Id, 20, IdAula);                          
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aula Ocupada", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            

            

        }

        private void CrearHorarios_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible==true)
            {
                CargarBotones();
                BorrarColor();
                BorrarTexto();
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