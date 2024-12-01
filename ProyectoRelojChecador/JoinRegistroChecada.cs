using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class JoinRegistroChecada
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string hora { get; set; }
        public string fecha { get; set; }

        public JoinRegistroChecada() { }

        public JoinRegistroChecada(int id, string nombre, string apellidoPaterno, 
                                  string apellidoMaterno, string hora, string fecha)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.fecha = fecha;
            this.hora = hora;
        }

    }//FIN DE LA CLASE
}
