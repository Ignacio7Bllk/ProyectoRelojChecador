using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string departamento { get; set; }
        public string idDepartamento { get; set; }
        public string turnoNombre { get; set; }  // Propiedad para almacenar el nombre del turno
        



        //CONTRUCTORES

        public Empleado() { }

        public Empleado(int id, string nombre, string apellidoPaterno,
                        string apellidoMaterno, int edad, string sexo,
                        string departamento,string idDepartamento, string turnoNombre)
        { 
            this.id = id;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.edad = edad;
            this.sexo = sexo;
            this.departamento = departamento;
            this.idDepartamento = idDepartamento;
            this.turnoNombre = turnoNombre;  // Asignación del nombre del turno

        }


    }
}
