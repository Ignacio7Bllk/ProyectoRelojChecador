using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class ChecadaQuery
    {
        public static int AgregarChecada(int idEmpleado, TimeSpan horaActual, DateTime fechaActual,
            TimeSpan horaEntradaTurno, TimeSpan horaSalidaTurno, TimeSpan horaInicioComidaTurno, TimeSpan horaFinComidaTurno)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }

                // Verificar si la hora actual es válida para registrarse.
                if (horaActual < horaEntradaTurno || (horaActual > horaSalidaTurno && horaActual < horaSalidaTurno.Add(TimeSpan.FromHours(1))))
                {
                    Console.WriteLine("No se puede registrar la checada fuera del horario asignado.");
                    return -1; // Detener el registro si la hora está fuera del horario permitido.
                }

                // Calcular los retardos y horas extras.
                TimeSpan retardo = horaActual > horaEntradaTurno.Add(TimeSpan.FromMinutes(3)) ? horaActual - horaEntradaTurno : TimeSpan.Zero;
                TimeSpan horasExtras = horaActual > horaSalidaTurno ? horaActual - horaSalidaTurno : TimeSpan.Zero;

                string queryVerificarExistencia = @"
            SELECT ID_EMPLEADO_TC, FECHA, HORA_ENTRADA, HORA_INICIO_COMIDA, HORA_FIN_COMIDA, HORA_SALIDA
            FROM REGISTRO_CHECADO
            WHERE ID_EMPLEADO_TC = @idEmpleado AND FECHA = @fecha";

                SqlCommand comandoVerificar = new SqlCommand(queryVerificarExistencia, conexion);
                comandoVerificar.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                comandoVerificar.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fechaActual;

                bool registroExistente = false;
                List<SqlParameter> parametrosActualizar = new List<SqlParameter>();
                string queryActualizar = "";

                using (SqlDataReader lector = comandoVerificar.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        registroExistente = true;

                        // Verificar si se puede registrar la entrada.
                        if (lector["HORA_ENTRADA"] == DBNull.Value && horaActual <= horaEntradaTurno.Add(TimeSpan.FromMinutes(5)))
                        {
                            queryActualizar = "UPDATE REGISTRO_CHECADO SET HORA_ENTRADA = @horaEntrada WHERE ID_EMPLEADO_TC = @idEmpleado AND FECHA = @fecha";
                            parametrosActualizar.Add(new SqlParameter("@horaEntrada", SqlDbType.Time) { Value = horaActual });
                        }
                        // Verificar si se puede registrar el inicio de la comida.
                        else if (lector["HORA_INICIO_COMIDA"] == DBNull.Value && horaActual >= horaInicioComidaTurno && horaActual < horaFinComidaTurno)
                        {
                            queryActualizar = "UPDATE REGISTRO_CHECADO SET HORA_INICIO_COMIDA = @horaInicioComida WHERE ID_EMPLEADO_TC = @idEmpleado AND FECHA = @fecha";
                            parametrosActualizar.Add(new SqlParameter("@horaInicioComida", SqlDbType.Time) { Value = horaActual });
                        }
                        // Verificar si se puede registrar el fin de la comida.
                        else if (lector["HORA_FIN_COMIDA"] == DBNull.Value && horaActual >= horaFinComidaTurno)
                        {
                            queryActualizar = "UPDATE REGISTRO_CHECADO SET HORA_FIN_COMIDA = @horaFinComida WHERE ID_EMPLEADO_TC = @idEmpleado AND FECHA = @fecha";
                            parametrosActualizar.Add(new SqlParameter("@horaFinComida", SqlDbType.Time) { Value = horaActual });
                        }
                        // Verificar si se puede registrar la salida.
                        else if (lector["HORA_SALIDA"] == DBNull.Value && horaActual >= horaSalidaTurno)
                        {
                            queryActualizar = "UPDATE REGISTRO_CHECADO SET HORA_SALIDA = @horaSalida WHERE ID_EMPLEADO_TC = @idEmpleado AND FECHA = @fecha";
                            parametrosActualizar.Add(new SqlParameter("@horaSalida", SqlDbType.Time) { Value = horaActual });
                        }
                    }
                }

                if (registroExistente && !string.IsNullOrEmpty(queryActualizar))
                {
                    SqlCommand comandoActualizar = new SqlCommand(queryActualizar, conexion);
                    comandoActualizar.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                    comandoActualizar.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fechaActual;
                    comandoActualizar.Parameters.AddRange(parametrosActualizar.ToArray());
                    retorno = comandoActualizar.ExecuteNonQuery();
                }
                else if (!registroExistente)
                {
                    string queryInsert = @"
                INSERT INTO REGISTRO_CHECADO (ID_EMPLEADO_TC, FECHA, RETARDOS, HORAS_EXTRAS, HORA_ENTRADA)
                VALUES (@idEmpleado, @fecha, @retardos, @horasExtras, @horaEntrada)";

                    SqlCommand comandoInsert = new SqlCommand(queryInsert, conexion);
                    comandoInsert.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
                    comandoInsert.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fechaActual;
                    comandoInsert.Parameters.Add("@retardos", SqlDbType.Float).Value = retardo.TotalMinutes;
                    comandoInsert.Parameters.Add("@horasExtras", SqlDbType.Float).Value = horasExtras.TotalMinutes;
                    comandoInsert.Parameters.Add("@horaEntrada", SqlDbType.Time).Value = horaActual;
                    retorno = comandoInsert.ExecuteNonQuery();
                }
            }

            return retorno;
        }


        //ELIMINAR EMPLEADO 
        public static int eliminarChecadaEmpleado(int parametroid) 
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion()) 
            {
                string query = "DELETE FROM REGISTRO_CHECADO WHERE ID_EMPLEADO_TC = " + parametroid+"";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }// END ELIMANR EMPLADO
        



    }//FIN DE MI CLASE
}
