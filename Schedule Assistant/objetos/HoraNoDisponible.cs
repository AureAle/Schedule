
namespace Schedule_Assistant
{
    class HoraNoDisponible
    {

#region atributos

        public int id;
        public int hora;
        public int dia;
        public string[] strings = {"err", "2:10-3:00","3:00-3:50", "3:50-4:40", "5:10-6:00", "6:00-6:50", "6:50-7:40", "7:40-8:30"};
        // private int idprofesor;

        #endregion

#region constructor

        public HoraNoDisponible( int hora, int día)
        {
            this.hora = hora;
            this.dia = día;
           // this.idprofesor = idprofesor;
        }

        #endregion

#region metodos

        public override string ToString()
        {
            return strings[hora];
        }

        #endregion

    }
}
