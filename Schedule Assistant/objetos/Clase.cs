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
        private String nombreMateria;
        private int creditos;
        private int profesor;


        public int Id { get => id; set => id = value; }
        /// <summary> nombre de la materia </summary>
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        /// <summary> devuelve las horas que se da dicha materia a la semana </summary>
        public int Creditos { get => creditos; set => creditos = value; }
        /// <summary> profesor que da dicha clase </summary>
        public int Profesor { get => profesor; set => profesor = value; }

        #endregion

        #region contructor
        public Clase( String materia,int profesor, int creditos)
        {
            this.nombreMateria = materia;
            this.Creditos = creditos;
            this.Profesor = profesor;
        }

        #endregion

#region metodos

        public override string ToString()
        {
            return nombreMateria + " | Créditos: " + creditos;
        }

#endregion
    }
}
