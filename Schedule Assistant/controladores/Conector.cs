using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;
using SA_objetos;

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

        internal static void agregarHoraClase(int dia, int hora, int clase, int grupo, int aula)
        {
            try
            {
                comando.CommandText =
                    "INSERT INTO Horario " +"(dia, hora, clase, grupo, aula) " +
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
        public static void agregarMaterias(Clase clase)
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

        public static void agregarGrupo(string grupo)
        {
            try
            {
                comando.CommandText = "INSERT INTO Grupos (Nombre) VALUES('" + grupo + "')";
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

        public static string UltimoGrupo()
        {
            List<String> grupo = new List<String>();
            try
            {
                comando.CommandText = "SELECT * FROM Grupos";
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();
                while (lector.Read())
                {
                    grupo.Add(lector["nombre"].ToString());
                }
                String u=grupo.ToArray()[grupo.ToArray().Length-1];

                return u;
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }

        /// <summary>
        /// Saber si un grupo ya existe o no
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public static Boolean GrupoUnico(String nombre)
        {
            bool unico=true;
            try
            {
                comando.CommandText = "SELECT * FROM Grupos " ;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();
                lector.Read();
                while (lector.Read())
                {
                    if (lector["nombre"].ToString() == nombre)
                    {
                        unico= false;
                        break;
                    }                       
                    else{
                        unico= true;
                    }
                }
                return unico;
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
    }

#endregion

}