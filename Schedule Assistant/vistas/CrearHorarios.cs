﻿using System;
using SA_objetos;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Schedule_Assistant.componenetes_graficos;

using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

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
        private Horarios[] h;
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
            h = Conector.LeerTodosHorarios(gs.getID());
            for (int i=0; i< h.Length; i++)
            {
                BotonHoraC boton = tablePanelHorairo.GetControlFromPosition(h[i].Dia - 1, h[i].Hora - 1) as BotonHoraC;
                //MessageBox.Show(Conector.LeerTodosHorarios(gs.getID())[i].Clase.ToString());
                boton.Text =
                Conector.leerClase(h[i].Clase).NombreMateria + Environment.NewLine + Conector.leerNombreProfesor( Conector.leerClase(h[i].Clase).Profesor)
                + Environment.NewLine + Conector.leerAulaPorId(h[i].Aula);
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

        private void bttnExportar_Click(object sender, EventArgs e)
        {
            Excel.Application oApp;
            Excel.Worksheet oSheet;
            Excel.Workbook oBook;

            oApp = new Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Excel.Worksheet)oBook.Worksheets.get_Item(1);

            //rango de celdas
            Excel.Range rango = oSheet.Range["A1", "F9"];
            //estilo del borde 
            rango.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            rango.BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium, Excel.XlColorIndex.xlColorIndexAutomatic, Excel.XlColorIndex.xlColorIndexAutomatic);
            //estilo de fuente
            oSheet.Rows.Cells.Font.Size = 11;
            oSheet.Rows.Cells.Font.Name = "Calibri";
            //ancho de columnas 
            rango.ColumnWidth = 20;
            //text align
            //rango.HorizontalAlignment = HorizontalAlignment.Center;
            rango.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            rango.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
           
            //rango.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.AliceBlue);


            Excel.Range rangoTitulo = oSheet.Range["B1", "D1"];
            Excel.Range rangoDias = oSheet.Range["A3", "F3"];
            Excel.Range rangoGrupo = oSheet.Range["A1","F2"];
            Excel.Range rangoCampos = oSheet.Range["A4", "F9"];

            //color de Horario y grupo
            rangoTitulo.Font.Size = 14;
            rangoTitulo.Font.Bold = true;
            rangoDias.Font.Bold = true;
            rangoDias.Font.Size = 14;
            rangoDias.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.DarkBlue);
            rangoGrupo.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Silver);
            rangoDias.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.SkyBlue);
            rangoCampos.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.AliceBlue);

            

            oSheet.Cells[1, 2] = "Horario";
            oSheet.Cells[1, 3] = "del grupo:";
            
            if(editar)
            {
                oSheet.Cells[1, 4] = Conector.leerGrupoPorID(gs.getID());
                h = Conector.LeerTodosHorarios(gs.getID());
                for (int i = 0; i < h.Length; i++)
                {

                    oSheet.Cells[h[i].Hora+3, h[i].Dia+1] = Conector.leerClase(h[i].Clase).NombreMateria + Environment.NewLine + Conector.leerNombreProfesor(Conector.leerClase(h[i].Clase).Profesor)
                    + Environment.NewLine + Conector.leerAulaPorId(h[i].Aula);

                }

            }
            else
            {
                oSheet.Cells[1, 4] = Conector.TodosGrupo()[Conector.TodosGrupo().Length - 1].Nombre;
                h = Conector.LeerTodosHorarios(Conector.TodosGrupo()[Conector.TodosGrupo().Length - 1].Id);
                for (int i = 0; i < h.Length; i++)
                {

                    oSheet.Cells[h[i].Hora + 3, h[i].Dia + 1] = Conector.leerClase(h[i].Clase).NombreMateria + Environment.NewLine + 
                        Conector.leerNombreProfesor(Conector.leerClase(h[i].Clase).Profesor)
                    + Environment.NewLine + Conector.leerAulaPorId(h[i].Aula);

                }
            }
            oSheet.Cells[3, 1] = "Hora";
            oSheet.Cells[3, 2] = "Lunes";
            oSheet.Cells[3, 3] = "Martes";
            oSheet.Cells[3, 4] = "Miércoles";
            oSheet.Cells[3, 5] = "Jueves";
            oSheet.Cells[3, 6] = "Viernes";

            oSheet.Cells[4, 1] = "2:10-3:00 PM";
            oSheet.Cells[5, 1] = "3:00-3:50 PM";
            oSheet.Cells[6, 1] = "3:50-4:40 PM";
            oSheet.Cells[7, 1] = "5:10-6:00 PM";
            oSheet.Cells[8, 1] = "6:00-7:40 PM";
            oSheet.Cells[9, 1] = "7:40-8:30 PM";

            oBook.Close();
            oApp.Quit();
        }
    }
}