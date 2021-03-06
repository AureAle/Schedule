﻿using System;
using SA_objetos;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    abstract class Conector
    {
        static OleDbConnection conectar = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=HorariosDB.accdb");
        static OleDbCommand comando = conectar.CreateCommand();

        #region control

        public Boolean verificarConexion()
        {
            try
            {
                comando = conectar.CreateCommand();

                conectar.Open();
                if (conectar.State == ConnectionState.Open)
                    return true;

                else return false;
            }
            catch (Exception)
            {
                throw new ApplicationException("error inesperado con la base de datos");
            }
        }


        #endregion

        /* CRUD 
         * create read update y Delete
         * agregar leer modificar borrar
         */

        #region escritura

        /// <summary> registra el maestro indicado enla base de datos, retorna su id </summary>
        public static void agregarProfe(String nombre)
        {
            try
            {
                comando.CommandText = "INSERT INTO Profesores (Nombre) VALUES('" + nombre + "')";
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();
                //int id = (int)comando.ExecuteScalar();
                //System.Console.WriteLine("maestro Nº" + id + " registrado");
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> registra la clase indicada con la informacion indicada </summary>
        internal static void agregarHoraClase(int dia, int hora, int clase, int grupo, int aula)
        {
            try
            {
                comando.CommandText =
                    "INSERT INTO Horario " +
                    "(dia, hora, clase, grupo, aula) " +
                    "VALUES(" + dia + "," + hora + "," + clase + "," + grupo + "," + aula + ")";
                conectar.Open();
                comando.ExecuteNonQuery();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> registra las horas no disponibles del maestro indicado en la base de datos </summary>
        public static void agregarHorariosNoDisponibles(int idProfe, HoraNoDisponible hnd)//Agregar a la base de datos
        {

            try
            {
                //revisar en la base de datos bien 
                comando.CommandText =
                    "INSERT INTO HorasNoDisponibles " +
                    "(profesor, hora, dia)" +
                    "VALUES('" + idProfe + "', '" + hnd.Hora + "', '" + hnd.Dia + "')";
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> registra la materia indicada, relacionada al profesor indicado, en la base de datos </summary>
        public static void agregarMaterias(Clase clase)
        {
            try
            {
                comando.CommandText =
                    "INSERT INTO Clases " +
                    "(maestro, materia, creditos) " +
                    "VALUES('" + clase.Profesor + "', '" + clase.NombreMateria + "', '" + clase.Creditos + "')";
                conectar.Open();
                comando.ExecuteNonQuery();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static void agregarGrupo(string grupo)
        {
            try
            {
                comando.CommandText =
                    "INSERT INTO Grupos " +
                    "(Nombre) " +
                    "VALUES('" + grupo + "')";
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }

        }

        #endregion

        #region lectura

        /// <summary> retorna un array de todos los profesores en la base de datos </summary>
        public static Profe[] leerTodosProfes()
        {
            List<Profe> profesLista = new List<Profe>();

            try
            {
                comando.CommandText = "SELECT * FROM Profesores";
                comando.CommandType = CommandType.Text;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    string nombre = lector["Nombre"].ToString();
                    Profe p = new Profe(id, nombre);

                    profesLista.Add(p);
                }

                return profesLista.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> OBTENER HORAS NO DISPONIBLES DE UN PROFESOR </summary>
        public static HoraNoDisponible[] leerHorasNoDisponiblesDe(int idProfe)
        {
            List<HoraNoDisponible> horasLista = new List<HoraNoDisponible>();
            //REVISAR
            try
            {
                comando.CommandText = "SELECT * FROM HorasNoDisponibles WHERE profesor= " + idProfe;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    int hora = (int)lector["hora"];
                    int dia = (int)lector["dia"];
                    HoraNoDisponible hnd = new HoraNoDisponible(hora, dia);
                    hnd.Id = id;
                    horasLista.Add(hnd);
                }

                return horasLista.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary>  Obtiene lista de clases registradas por id de profe </summary>
        public static Clase[] leerClasesde(int idProfe)
        {
            List<Clase> clasesLista = new List<Clase>();
            //REVISAR
            try
            {
                comando.CommandText = "SELECT * FROM Clases WHERE maestro= " + idProfe;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    String materia = lector["materia"].ToString();
                    int creditos = (int)lector["creditos"];
                    int profesor = (int)lector["maestro"];
                    Clase c = new Clase(materia, profesor, creditos);
                    c.Id = id;
                    clasesLista.Add(c);
                }

                return clasesLista.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static Clase leerClase(int idClase)
        {
            List<Clase> clasesLista = new List<Clase>();
            //REVISAR
            try
            {
                comando.CommandText = "SELECT * FROM Clases WHERE ID= " + idClase;
                
                comando.CommandType = CommandType.Text;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();
                int profesor = (int)lector["maestro"];
                String materia = lector["materia"].ToString();
                int creditos = (int)lector["creditos"];
                    
                    Clase c = new Clase(materia, profesor, creditos);

                return c;
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary>  Obtiene lista de clases registradas por id de profe </summary>
        public static Clase[] leerTodasClases()
        {
            List<Clase> clasesLista = new List<Clase>();
            try
            {
                comando.CommandText = "SELECT * FROM Clases";
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    String materia = lector["materia"].ToString();
                    int creditos = (int)lector["creditos"];
                    int profesor = (int)lector["maestro"];
                    Clase c = new Clase(materia, profesor, creditos);
                    c.Id = id;
                    clasesLista.Add(c);
                }

                return clasesLista.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> devuelve el nombre del maestro indicado </summary>
        public static string leerNombreProfesor(int idProfe)
        {
            try
            {
                comando.CommandText = "SELECT * FROM Profesores WHERE ID = " + idProfe;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();

                return lector["Nombre"].ToString();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static string leerGrupoPorID(int idGrupo)
        {
            try
            {
                comando.CommandText = "SELECT * FROM Grupos WHERE ID=" + idGrupo;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();

                return lector["nombre"].ToString();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static Grupo[] TodosGrupo()
        {
            List<Grupo> grupo = new List<Grupo>();
            try
            {
                comando.CommandText = "SELECT * FROM Grupos";
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();
                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    String nombre=lector["nombre"].ToString();
                    Grupo g = new Grupo(id, nombre);
                    grupo.Add(g);
                }

                return grupo.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> Saber si un grupo ya existe o no </summary>
        public static Boolean GrupoYaExiste(String nombre)
        {
            try
            {
                comando.CommandText = "SELECT * FROM Grupos WHERE nombre ='" + nombre + "'";
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                return lector.Read();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static String leerAulaPorId(int idAula)
        {
            try
            {
                comando.CommandText = "SELECT * FROM Aulas WHERE ID="+idAula;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();

                return lector["nombre"].ToString(); 
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static int leerIdAula(String aula)
        {
            try
            {
                comando.CommandText = "SELECT * FROM Aulas WHERE nombre='" + aula + "'";
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();

                return (int)lector["ID"];
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static Boolean AulaNoOcupada(int idAula, int idDia, int idHora)
        {
            try
            {
                comando.CommandText = "SELECT * FROM Horario WHERE dia =" + idDia + "AND hora=" + idHora + "AND aula=" + idAula;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                return (lector.Read()) ? false : true;
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static Horarios[] LeerTodosHorarios(int idgrupo)
        {
            List<Horarios> hr = new List<Horarios>();
            try
            {
                comando.CommandText = "SELECT * FROM Horario WHERE grupo ="+idgrupo;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    int dia = (int)lector["dia"];
                    int hora = (int)lector["hora"];
                    int clase = (int)lector["clase"];
                    int aula = (int)lector["aula"];
                    Horarios h = new Horarios(id, dia, hora, clase, aula);
                    hr.Add(h);
                }

                return hr.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static Horarios[] LeerTodosHorariosPorClase(int idclase)
        {
            List<Horarios> hr = new List<Horarios>();
            try
            {
                comando.CommandText = "SELECT * FROM Horario WHERE clase =" + idclase;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    int dia = (int)lector["dia"];
                    int hora = (int)lector["hora"];
                    int clase = (int)lector["clase"];
                    int aula = (int)lector["aula"];
                    Horarios h = new Horarios(id, dia, hora, clase, aula);
                    hr.Add(h);
                }

                return hr.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        public static HoraNoDisponible[] LeerTodosHorariosMenosEste(int idgrupo, int idClase)
        {
            List<HoraNoDisponible> hr = new List<HoraNoDisponible>();
            try
            {

                comando.CommandText = "SELECT * FROM Horario WHERE NOT grupo =" + idgrupo+"AND clase="+idClase;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    
                    int dia = (int)lector["dia"];
                    int hora = (int)lector["hora"];

                    HoraNoDisponible s = new HoraNoDisponible(hora,dia);
                    hr.Add(s);
                }

                return hr.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }



        #endregion

        #region Actualizar

        /// <summary> Actualiza el Nombre de un Profesor </summary>
        public static void actualizarProfesor(int id, string nombre)
        {
            try
            {
                comando.CommandText = "UPDATE Profesores SET Nombre='" + nombre + "' WHERE ID= " + id;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> Modifica los creditos de una clase </summary>
        public static void actualizarClase(int id, int creditos)
        {
            try
            {
                comando.CommandText = "UPDATE Clases SET creditos='" + creditos + "' WHERE ID= " + id;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        #endregion

        #region borrar

        /// <summary> elimina al maestro indicado de la base de datos </summary>
        public static void borrarProfe(int idProfe)
        {
            try
            {
                comando.CommandText = "DELETE FROM Profesores WHERE ID =" + idProfe;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> BORRAR HORAS NO DISPONIBLES, SOLO PIDE HND POR QUE SOLO OCUPAS EL ID DE LA HORA SELECICONADA QUE ES UN OBJETO HND </summary>
        public static void borrarHoraNoDisponible(HoraNoDisponible hnd)
        {
            try
            {
                comando.CommandText = "DELETE FROM HorasNoDisponibles WHERE ID =" + hnd.Id;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary> BORRAR Materias </summary>
        public static void borrarMateria(int idMateria)
        {
            try
            {
                comando.CommandText = "DELETE FROM Clases WHERE ID =" + idMateria;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary>Borra la clase seleccionada</summary>
        public static void borrarClase(Clase c)
        {
            try
            {
                comando.CommandText = "DELETE FROM Clases WHERE ID =" + c.Id;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }
        /// <summary>
        /// BORRAR HORARIO PERO NO SE SABE QUE PETS
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="hora"></param>
        public static void BorrarHorario(int dia, int hora, int grupo)
        {
            try
            {
                comando.CommandText = "DELETE FROM Horario  WHERE dia =" + dia + "AND hora=" + hora + "AND grupo=" + grupo;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

    }
#endregion

}