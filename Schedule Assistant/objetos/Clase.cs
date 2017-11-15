using System;

namespace SA_objetos
{
    class Clase
    {

#region propiedades

        public int Id;
        public String NombreMateria;
        public int Creditos;
        public int Profesor;


#endregion

#region contructor

        public Clase( String materia,int profesor, int creditos)
        {
            this.NombreMateria = materia;
            this.Creditos = creditos;
            this.Profesor = profesor;
        }

#endregion

#region metodos

        public override string ToString()
        {
            return NombreMateria + " | Créditos: " + Creditos;
        }

#endregion
    }
}
