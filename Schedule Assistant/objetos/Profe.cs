using System;

namespace Schedule_Assistant
{
    class Profe
    {

#region atributos

        private int id;
        private String nombre;

        #endregion

#region constructor

        public Profe(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        #endregion

#region geters

        public int Id { get => id;}
        public string Nombre { get => nombre; }

        #endregion

#region metodos

        public override string ToString()
        { return Nombre; }

        #endregion

    }
}
