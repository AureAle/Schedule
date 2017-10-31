using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    abstract class Conector
    {
        //antes de empezar hagan una copia de la DB en "repos\Schedule\Schedule Assistant\bin\Debug"
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

        // CRUD create read update y Delete

        #region escritura

        /// <summary> registra el maestro indicado enla base de datos, retorna su id </summary>
        public static void InsertarProfe(String nombre)
        {
            try
            {
                comando.CommandText = "INSERT INTO Profesores (Nombre) VALUES('"+ nombre+ "')";
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

        /// <summary> registra las horas no disponibles del maestro indicado en la base de datos </summary>
        public static void AgregarHorariosNoDisponibles(int idProfe, HoraNoDisponible hnd)//Agregar a la base de datos
        {

            try
            {
                //revisar en la base de datos bien 
                comando.CommandText = "INSERT INTO HorasNoDisponibles (profesor, hora, dia) VALUES('" + idProfe + "', '" + hnd.Hora1 + "', '" + hnd.Dia + "')";
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
        public static void AgregarMaterias(Clase clase)
        {
            try
            {
                 
                comando.CommandText = "INSERT INTO Clases (maestro, materia, creditos) VALUES('" + clase.Profesor + "', '" + clase.NombreMateria + "', '" + clase.Creditos + "')";
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
        public static Profe[] MostrarNombres()
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
                    string  nombre = lector["Nombre"].ToString();
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
        public static HoraNoDisponible[] MostrarHorasNoDisponibles(int idProfe)
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
                    hnd.Id1 = id;
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
        public static Clase[] MostrarClases(int idProfe)
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

        /// <summary>  Obtiene lista de clases registradas por id de profe </summary>
        public static Clase[] MostrarClasesTodas()
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
        public static string nombreProfesor(int idProfe)
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

        #endregion

        #region modificar

        /// <summary>
        /// Actualiza el Nombre de un Profesor
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="nombre">String</param>
        public static void ActualizarProfesor(int id, string nombre)
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
        /// <summary>
        /// Modifica los creditos de una clase
        /// </summary>
        /// <param name="id">int</param>
        /// <param name="creditos">int</param>
        public static void ActualizarClase(int id, int creditos)
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
        public static void BorrarProfe(int idProfe)
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
        public static void BorrarHoraNoDisponible(HoraNoDisponible hnd)
        {
            try
            {
                comando.CommandText = "DELETE FROM HorasNoDisponibles WHERE ID =" + hnd.Id1;
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
        public static void BorrarMateria(int idMateria)
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
        public static void BorrarClase(Clase c)
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
    }

#endregion

}