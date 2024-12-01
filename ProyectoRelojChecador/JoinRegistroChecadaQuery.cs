using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class JoinRegistroChecadaQuery
    {

        public static List<JoinRegistroChecada> MostrarRegistroJoin(int argumentoId, string argumentoFecha)
        {
            List<JoinRegistroChecada> Lista = new List<JoinRegistroChecada>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "SELECT ID_EMPLEADO_TE, NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, DEPARTAMENTO, FECHA, HORA FROM EMPLEADO EMP JOIN REGISTRO_CHECADO CHE ON EMP.ID_EMPLEADO_TE = CHE.ID_EMPLEADO_TC WHERE EMP.ID_EMPLEADO_TE = " + argumentoId + " AND CHE.FECHA = '" + argumentoFecha + "'";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    JoinRegistroChecada joinRegistroChecada = new JoinRegistroChecada();



                    joinRegistroChecada.id = reader.GetInt32(0);
                    joinRegistroChecada.nombre = reader.GetString(1);
                    joinRegistroChecada.apellidoPaterno = reader.GetString(2);
                    joinRegistroChecada.apellidoMaterno = reader.GetString(3);
                    joinRegistroChecada.fecha = reader.GetString(4);
                    joinRegistroChecada.hora = reader.GetString(5);


    
                    Lista.Add(joinRegistroChecada);
                }

                conexion.Close();
                return Lista;

            }
        }//FIN DE LA FUNCION MOSTRAR REGISTRO PARTICULAR


    }//FIN DE LA CLASE
}
