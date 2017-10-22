using System;
using System.Data;
using System.Data.OleDb;
using System.Collections.Generic;

namespace Schedule_Assistant
{
    abstract class Conector
    {
        //coment

        static OleDbConnection conectar = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xboxm\Desktop\Schedule-master\Schedule Assistant\HorariosDB.accdb; Persist Security Info = False; ");
        static OleDbCommand comando = conectar.CreateCommand();

//************************************************ control *******************************************************

        public Boolean verificarConexion()
        {
            try
            {
                comando = conectar.CreateCommand();

                conectar.Open();
                if (conectar.State == ConnectionState.Open)
                {
                    return true;
                }
                else return false;

            }
            catch (Exception ex)
            {
                throw new ApplicationException();
            }
        }

/*
 * CRUD:
 * create
 * read
 * update
 * Delete
 */
// ****************************************** escritura *******************************************

        /// <summary> registra el maestro indicado enla base de datos, retorna su id </summary>
        public static void InsertarProfe(String nombre)
        {
            try
            {
                comando.CommandText = "INSERT INTO Profesores (Nombre) VALUES('"+ nombre+ "')";
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

        /// <summary> registra las horas no disponibles del maestro indicado en la base de datos </summary>
        public void AgregarHorariosNoDisponibles(Profe p, HoraNoDisponible hnd)//Agregar a la base de datos
        {

            try
            {
                //revisar en la base de datos bien 
                comando.CommandText = "INSERT INTO HorasNoDisponibles (profesor, hora, dia) VALUES('" + p.Id + "', '" + hnd.Día + "', '" + hnd.Hora + "')";
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

        //AGREGAR CLASES POR PROFESOR
        public void AgregarMaterias(Profe p, String materia, int creditos)
        {
            try
            {
                 
                comando.CommandText = "INSERT INTO Clases (maestro, materia, creditos) VALUES('" + p.Id + "', '" + materia + "', '" + creditos + "')";
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

        


//*********************************** lectura ****************************************************

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

        //OBTENER HORAS NO DISPONIBLES DE UN PROFESOR
        public HoraNoDisponible[] MostrarHorasNoDisponibles(Profe p)
        {
            List<HoraNoDisponible> horasLista = new List<HoraNoDisponible>();
            //REVISAR
            try
            {
                comando.CommandText = "SELECT * FROM HorasNoDisponibles WHERE profesor= " + p.Id;
                comando.CommandType = CommandType.Text;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    int id = (int)lector["ID"];
                    int hora = (int)lector["hora"];
                    int dia = (int)lector["dia"];
                    HoraNoDisponible hnd = new HoraNoDisponible(id, hora, dia);

                    //horasLista.Add(p);
                }

                return horasLista.ToArray();
            }
            finally
            {
                if (conectar.State == ConnectionState.Open)
                    conectar.Close();
            }
        }


//****************************************** modificar *******************************************

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

       


//*************************************** borrar ************************************************

        /// <summary> elimina al maestro indicado de la base de datos </summary>
        public static void BorrarProfe(int id)
        {
            try
            {
                comando.CommandText = "DELETE FROM Profesores WHERE ID =" +id;
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

        //BORRAR HORAS NO DISPONIBLES, SOLO PIDE HND POR QUE SOLO OCUPAS EL ID DE LA HORA SELECICONADA QUE ES UN OBJETO HND
        public static void BorrarHoraNoDisponible(HoraNoDisponible hnd)
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

        public static void BorrarMateria(Clase c)
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

    
}