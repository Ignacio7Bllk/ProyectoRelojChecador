using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class BDPrincipal
    {

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Data Source=IGNACIO;Initial Catalog=RelojChecadorBD;Integrated Security=True");
            conexion.Open();

            return conexion;
        }

        public static SqlConnection obtenerConexionAlternativa()
        {
            return new SqlConnection("Data Source=IGNACIO;Initial Catalog=RelojChecadorBD;Integrated Security=True");
        }


    
    }

  
    
}
