using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class Checada
    {
        public int id { get; set; }
        public TimeSpan hora { get; set; }
        public DateTime fecha { get; set; }

        public Checada() { }

        public Checada(int id, TimeSpan hora, DateTime fecha)
        {
            this.id = id;
            this.hora = hora;
            this.fecha = fecha;
        }

        public string HoraComoCadena()
        {
            return hora.ToString(@"hh\:mm\:ss");
        }
    }
}
