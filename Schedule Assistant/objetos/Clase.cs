using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Assistant
{
    class Clase
    {

#region propiedades
        private int id;
        private String nombre;
        private int creditos;

        
        public int Id { get => id; set => id = value; }
        /// <summary> nombre de la materia </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        /// <summary> devuelve las horas que se da dicha materia a la semana </summary>
        public int Creditos { get => creditos; set => creditos = value; }

        #endregion

        #region contructor
        public Clase( String nombre, int creditos)
                {
                    this.Nombre = nombre;
                    this.Creditos = creditos;
                }

        #endregion

#region metodos

        public override string ToString()
        {
            return nombre + " | Créditos: " + creditos;
        }

#endregion
    }
}
