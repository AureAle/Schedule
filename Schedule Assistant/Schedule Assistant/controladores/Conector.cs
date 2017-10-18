using System;
using System.Collections.Generic;
using System.Data.OleDb;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Conector
    {

        OleDbConnection conectar;
        OleDbCommand comando;

//************************************************ control *******************************************************

        private void ConnectTo()
        {
            //cambiar ruta
            conectar = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\xboxm\Desktop\Schedule\HorariosDB.accdb; Persist Security Info = False; ");
            comando = conectar.CreateCommand();
        }

        public Boolean verificarConexion()
        {
            try
            {
                conectar.Open();
                if (conectar.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else return false;

            }
            catch
            {
                return false;
            }
        }

        public Conector()
        {
            ConnectTo();
        }


/*
 * CRUD:
 * create
 * read
 * update
 * Delete
 */
// ****************************************** escritura *******************************************

        /// <summary> registra el maestro indicado enla base de datos </summary>
        public void InsertarProfe(Profe p)
        {
            try
            {
                comando.CommandText = "INSERT INTO Profesores (Nombre) VALUES('" + p.Nombre1 + "')";
                comando.CommandType = System.Data.CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

                // INSERT INTO Profesores (Nombre) VALUES(''); drop horariosdb; '()
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
        }

        /// <summary> registra las horas no disponibles del maestro indicado en la base de datos </summary>
        public void AgregarHorariosNoDisponibles(Profe p, HoraNoDisponible hnd)//Agregar a la base de datos
        {

            try
            {
                //revisar en la base de datos bien 
                comando.CommandText = "INSERT INTO HorasNoDisponibles (datos) VALUES('" + p.Id + "', '" + hnd.Día + "', '" + hnd.Hora + "')";
                comando.CommandType = System.Data.CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
        }      

        


//*********************************** lectura ****************************************************

        /// <summary> retorna un array de todos los profesores en la base de datos </summary>
        public Profe[] MostrarNombres()
        {
            List<Profe> profesLista = new List<Profe>();

            try
            {
                comando.CommandText = "SELECT * FROM Profesores";
                comando.CommandType = System.Data.CommandType.Text;
                conectar.Open();
                OleDbDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Profe p = new Profe();
                    p.Id = (int)lector["ID"];
                    p.Nombre1 = lector["Nombre"].ToString();
                    //p.Hora1 = lector["Horarios"].ToString();

                    profesLista.Add(p);
                }

                return profesLista.ToArray();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
        }


//****************************************** modificar *******************************************

        public void ActualizarProfesor(Profe anteriorP, Profe nuevoP)
        {
            try
            {
                comando.CommandText = "UPDATE Profesores SET Nombre='" + nuevoP.Nombre1 + "' WHERE ID= " + anteriorP.Id;
                comando.CommandType = System.Data.CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }

        }

       


//*************************************** borrar ************************************************

        /// <summary> elimina al maestro indicado de la base de datos </summary>
        public void Borrar(Profe p)
        {
            try
            {
                comando.CommandText = "DELETE FROM Profesores WHERE ID =" + p.Id;
                comando.CommandType = System.Data.CommandType.Text;
                conectar.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conectar != null)
                {
                    conectar.Close();
                }
            }
        }
    }
}