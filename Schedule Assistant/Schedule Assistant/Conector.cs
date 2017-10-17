﻿using System;
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

        private void ConnectTo()
        {
            //cambiar ruta
            conectar = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\auren\OneDrive\Documentos\PI 3ero\Schedule Assistant\HorariosDB.accdb; Persist Security Info = False; ");
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


        public List<Profe> MostrarNombres()
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
                    p.Id = Convert.ToInt32(lector["ID"].ToString());
                    p.Nombre1 = lector["Nombre"].ToString();
                    //p.Hora1 = lector["Horarios"].ToString();

                    profesLista.Add(p);
                }

                return profesLista;
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

        public void Actualizar(Profe anteriorP, Profe nuevoP)
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

        //revisar en la base de datos bien(?) 
        public void ActualizarMaterias(Profe anteriorP, Profe nuevoP)
        {
            try
            {
                //comando.CommandText = "UPDATE Profesores SET Materias='" + nuevoP.Materias1 + "' WHERE ID= " + anteriorP.Id;
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
        //creo que esto ya no va (?)
        public void AgregarHorario(Profe p)
        {
            try
            {
                //comando.CommandText = "UPDATE Profesores SET Horarios='" + p.Hora1 + "' WHERE ID=" + p.Id;
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