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
        GrupoSelec gs = new GrupoSelec();
        grupo grupo = new grupo();
        public Boolean CerroCrear = false;
        public Boolean Cerro=false;
        private botonClase ClaseSelec;
        private HoraNoDisponible[] horasNoDisponibles;
        private Clase[] clap;
        private HoraNoDisponible[] profeOcupado;
        public Boolean editar = false;
        public Boolean crear = false;

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

        public void CargarHorarios()
        {
            //MessageBox.Show(Conector.LeerTodosHorarios(gs.getID()).Length.ToString());
            for(int i=0; i< Conector.LeerTodosHorarios(gs.getID()).Length; i++)
            {
                BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(Conector.LeerTodosHorarios(gs.getID())[i].Dia - 1, Conector.LeerTodosHorarios(gs.getID())[i].Hora - 1) as BotonHoraC;
                //MessageBox.Show(Conector.LeerTodosHorarios(gs.getID())[i].Clase.ToString());
                boton.Text =
                Conector.leerClase(Conector.LeerTodosHorarios(gs.getID())[i].Clase).NombreMateria + Environment.NewLine + Conector.leerNombreProfesor( Conector.leerClase(Conector.LeerTodosHorarios(gs.getID())[i].Clase).Profesor)
                + Environment.NewLine + Conector.leerAulaPorId(Conector.LeerTodosHorarios(gs.getID())[i].Aula);
            }
        }

        /// <summary>
        /// Carga los botones del tipo clase en el panel
        /// </summary>
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
            if (botonsito.BackColor == Color.IndianRed  )
            {
                MessageBox.Show("Hora no disponible", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            else if(botonsito.BackColor==Color.DimGray)
            {
                MessageBox.Show("Profesor ocupado", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (ClaseSelec.Disponibles < 1)
            {
                ClaseSelec = null;
                foreach (HoraNoDisponible hora in horasNoDisponibles)
                {
                    BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(hora.Dia, hora.Hora) as BotonHoraC;
                    boton.Disponible = true;
                }
                MessageBox.Show("Créditos insuficientes", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            clap = Conector.leerClasesde(ClaseSelec.Clase.Profesor);
            foreach (Clase c in clap)
            {
                if (editar)
                {
                    profeOcupado= Conector.LeerTodosHorariosMenosEste(gs.getID(), c.Id);
                    foreach (HoraNoDisponible hnd in profeOcupado)
                    {
                        BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(hnd.Dia - 1, hnd.Hora - 1) as BotonHoraC;
                        boton.BackColor = Color.DimGray;
                    }
                }
                else
                {
                    profeOcupado = Conector.LeerTodosHorariosMenosEste(Conector.TodosGrupo().Length - 1, c.Id);
                    foreach (HoraNoDisponible hnd in profeOcupado)
                    {
                        BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(hnd.Dia - 1, hnd.Hora - 1) as BotonHoraC;
                        boton.BackColor = Color.DimGray;
                    }
                }
            }


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
            if (ClaseSelec == null)
            {
                MessageBox.Show("Es necesario agregar alguna clase", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ClaseSelecRestarHora(botonHora))
                {
                    aula a = new aula();
                    a.ShowDialog();
                    //SE MODIFICÓ EL ORDEN EN QUE SE PREGUNTAN LAS COSAS, AHORA PREGUNTA PRIMERO EL COLOR, ANTES DE MOSTAR-
                    //-EL DIÁLOGO PARA SELECCIONAR EL AULA
                    if (a.getAula() == null)//SI NO SELECCIONA AULA NO HACE NI MAIS Y LE DEVUELVE EL CRÉDITO
                    {
                        ClaseSelec.Disponibles++;
                        ClaseSelec.cargarTexto();
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
                            if(editar)
                            {
                                if (botonHora.asignar(ClaseSelec.Clase, gs.getID(), celda.Column + 1, celda.Row + 1))
                                {
                                    Conector.agregarHoraClase(celda.Column + 1, celda.Row + 1, ClaseSelec.Clase.Id, gs.getID(), IdAula);
                                }
                                else
                                {
                                    ClaseSelec.Disponibles++;
                                    ClaseSelec.cargarTexto();
                                }
                            }
                            else
                            {
                                if (botonHora.asignar(ClaseSelec.Clase, Conector.TodosGrupo()[Conector.TodosGrupo().Length - 1].Id, celda.Column + 1, celda.Row + 1))
                                {
                                    Conector.agregarHoraClase(celda.Column + 1, celda.Row + 1, ClaseSelec.Clase.Id, Conector.TodosGrupo()[Conector.TodosGrupo().Length - 1].Id, IdAula);
                                }
                                else
                                {
                                    ClaseSelec.Disponibles++;
                                    ClaseSelec.cargarTexto();
                                }
                            }
                            CargarBotones();
                        }
                        else
                        {
                            MessageBox.Show("Aula Ocupada", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            ClaseSelec.Disponibles++;
                            ClaseSelec.cargarTexto();
                        }
                    }
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

                if(editar)
                {
                    gs.ShowDialog();
                    if(gs.cerro)
                    {
                        Cerro = gs.cerro;
                        editar = false;
                    }
                    else
                    {
                        lblGrupo.Text += Conector.leerGrupoPorID(gs.getID());
                        CargarHorarios();
                    }
                }
                else if(crear)
                {
                    grupo.ShowDialog();
                    if (grupo.cerro)
                    {
                        CerroCrear = grupo.cerro;
                        crear = false;
                    }
                    else
                    {
                        lblGrupo.Text += Conector.TodosGrupo()[Conector.TodosGrupo().Length - 1].Nombre;
                    }
                }


            }
                
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