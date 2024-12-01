using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class EmpleadoQuery
    {


        ///Funcion agregar Empleado
        public static int AgregarEmpleado(Empleado empleado)
        {
            int retorno = 0;

            // Obtener ID_TURNO según el nombre del turno
            int idTurno = ObtenerIdTurno(empleado.turnoNombre);

            // Obtener ID_DEPARTAMENTO según el nombre del departamento
            string idDepartamento = ObtenerIdDepartamento(empleado.departamento);



            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                // Modificar la consulta SQL para incluir los ID_TURNO e ID_DEPARTAMENTO
                string query = "INSERT INTO EMPLEADO (NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, EDAD, SEXO, DEPARTAMENTO, ID_DEPARTAMENTO, ID_TURNO) " +
               "VALUES ('" + empleado.nombre + "', '" + empleado.apellidoPaterno + "', '" + empleado.apellidoMaterno + "', " +
               empleado.edad + ", '" + empleado.sexo + "', '" + empleado.departamento + "', '" + idDepartamento + "', '" + idTurno + "')";

                SqlCommand comando = new SqlCommand(query, conexion);

                // Ejecutar la consulta
                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }




        // Función para obtener el ID del turno según su nombre
        private static int ObtenerIdTurno(string turnoNombre)
        {
            int idTurno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                // Consulta para obtener el ID del turno según el nombre
                string query = "SELECT ID_TURNO FROM TURNOS WHERE NOMBRE_TURNO = @turnoNombre";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@turnoNombre", turnoNombre);

                // Ejecutar la consulta y obtener el ID_TURNO
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    idTurno = Convert.ToInt32(reader["ID_TURNO"]);
                }
            }

            return idTurno;
        }

        // Función para obtener el ID del departamento según su nombre
        private static string ObtenerIdDepartamento(string departamentoNombre)
        {
            string idDepartamento = null;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                // Consulta para obtener el ID del departamento según el nombre
                string query = "SELECT ID_DEPARTAMENTO FROM DEPARTAMENTO WHERE NOMBRE_DEPARTAMENTO = @departamentoNombre";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@departamentoNombre", departamentoNombre);

                // Ejecutar la consulta y obtener el ID_DEPARTAMENTO
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    // Usamos reader["ID_DEPARTAMENTO"].ToString() para obtener el valor como cadena
                    idDepartamento = reader["ID_DEPARTAMENTO"].ToString();
                }
            }

            return idDepartamento;
        }


        ///Fin de la funcion agregar empleado

        ////////////////////
        //
        //MOSTRA lista de datos

        public static List<Empleado> MostrarRegistro()
        {
            List<Empleado> Lista = new List<Empleado>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = @"
        SELECT E.ID_EMPLEADO_TE, E.NOMBRE, E.APELLIDO_PATERNO, E.APELLIDO_MATERNO, E.EDAD, E.SEXO, E.DEPARTAMENTO,E.ID_DEPARTAMENTO ,T.NOMBRE_TURNO
        FROM EMPLEADO E

        INNER JOIN TURNOS T ON E.ID_TURNO = T.ID_TURNO";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.id = reader.GetInt32(0);
                    empleado.nombre = reader.GetString(1);
                    empleado.apellidoPaterno = reader.GetString(2);
                    empleado.apellidoMaterno = reader.GetString(3);
                    empleado.edad = reader.GetInt32(4);
                    empleado.sexo = reader.GetString(5);
                    empleado.idDepartamento = reader.GetString(7);
                    empleado.departamento = reader.GetString(6);
                    empleado.turnoNombre = reader.GetString(8); // Aquí obtienes el nombre del turno desde la tabla TURNOS


                    Lista.Add(empleado);
                }

                conexion.Close();
                return Lista;

            }
        }//FIN DE LA FUNCION MOSTRAR REGISTRO




        public static int buscarEmpleado(int id)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = @"
            SELECT E.ID_EMPLEADO_TE, E.NOMBRE, E.APELLIDO_PATERNO, E.APELLIDO_MATERNO, E.EDAD, E.SEXO, E.DEPARTAMENTO, E.ID_DEPARTAMENTO, T.NOMBRE_TURNO
            FROM EMPLEADO E
            INNER JOIN TURNOS T ON E.ID_TURNO = T.ID_TURNO
            WHERE E.ID_EMPLEADO_TE = @id"; // Se incluye WHERE para filtrar por el ID

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                // Abrimos la conexión antes de ejecutar el comando
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }

                // Ejecutar la consulta y leer los datos
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    retorno = 1; // Si existen resultados, el registro ha sido encontrado
                }

                reader.Close();
            }

            return retorno;
        }

        public static List<Empleado> MostrarRegistroParticular(int argumentoId)
        {
            List<Empleado> Lista = new List<Empleado>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                // Hacemos un INNER JOIN con la tabla TURNOS para obtener también el nombre del turno
                string query = @"
            SELECT E.ID_EMPLEADO_TE, E.NOMBRE, E.APELLIDO_PATERNO, E.APELLIDO_MATERNO, E.EDAD, E.SEXO, E.DEPARTAMENTO, E.ID_DEPARTAMENTO, T.NOMBRE_TURNO
            FROM EMPLEADO E
            INNER JOIN TURNOS T ON E.ID_TURNO = T.ID_TURNO
            WHERE E.ID_EMPLEADO_TE = @id"; // Filtro por ID de empleado

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", argumentoId);

                // Ejecutar la consulta y leer los datos
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    // Leer los datos de la consulta
                    empleado.id = reader.GetInt32(0); // ID del empleado
                    empleado.nombre = reader.GetString(1); // Nombre del empleado
                    empleado.apellidoPaterno = reader.GetString(2); // Apellido Paterno
                    empleado.apellidoMaterno = reader.GetString(3); // Apellido Materno
                    empleado.edad = reader.GetInt32(4); // Edad
                    empleado.sexo = reader.GetString(5); // Sexo
                    empleado.departamento = reader.GetString(6); // Departamento
                    empleado.idDepartamento = reader.GetString(7); // ID de Departamento
                    empleado.turnoNombre = reader.GetString(8); // Nombre del turno

                    Lista.Add(empleado);
                }

                conexion.Close();
                return Lista;
            }
        }



        public static List<Empleado> MostrarRegistroJoin(int argumentoId,string argumentoFecha)
        {
            List<Empleado> Lista = new List<Empleado>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "SELECT * FROM EMPLEADO EMP JOIN CHECADA CHE ON EMP.ID_EMPLEADO_TE = CHE.ID_EMPLEADO_TC WHERE EMP.ID_EMPLEADO_TE = " + argumentoId+" AND CHE.FECHA = '"+argumentoFecha+"'";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();
                

                    empleado.id = reader.GetInt32(0);
                    empleado.nombre = reader.GetString(1);
                    empleado.apellidoPaterno = reader.GetString(2);
                    empleado.apellidoMaterno = reader.GetString(3);
                    empleado.edad = reader.GetInt32(4);
                    empleado.sexo = reader.GetString(5);
                    empleado.departamento = reader.GetString(6);
                    Lista.Add(empleado);
                }

                conexion.Close();
                return Lista;

            }
        }//FIN DE LA FUNCION MOSTRAR REGISTRO PARTICULAR

        //ELIMINAR EMPLEADO 

        //ELIMINAR EMPLEADO 
        public static int eliminarEmpleado(int parametroid)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "DELETE FROM EMPLEADO WHERE ID_EMPLEADO_TE = " + parametroid + "";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }// END ELIMANR EMPLEADO
        /*

        //MODIFICAR EMPLEADO 

        public static Empleado ModificarEmpleado(int idEmpleado)
        {
            string query = "SELECT NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, EDAD, SEXO, DEPARTAMENTO, TURNO FROM EMPLEADO WHERE ID_EMPLEADO_TE = @id";
            Empleado empleado = null;

            using (SqlConnection conexion = BDPrincipal.obtenerConexionAlternativa())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEmpleado);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                nombre = reader["NOMBRE"].ToString(),
                                apellidoPaterno = reader["APELLIDO_PATERNO"].ToString(),
                                apellidoMaterno = reader["APELLIDO_MATERNO"].ToString(),
                                edad = Convert.ToInt32(reader["EDAD"]),
                                sexo = reader["SEXO"].ToString(),
                                departamento = reader["DEPARTAMENTO"].ToString(),
                                turnoNombre=reader["TURNO"].ToString()

                            };
                        }
                    }
                }
            }

            return empleado;
        }//FIN DE MI FUNCION 


        //REGISTRA LOS EMPLEADOS 
        public static int ModificarEmpleadoCambios(int id, String nombre, String apellidoP, String apellidoM, int edad, String sexo, String departamento)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "update EMPLEADO set NOMBRE = '" + nombre + "', APELLIDO_PATERNO = '" + apellidoP + "', APELLIDO_MATERNO = '" + apellidoM + "', EDAD = " + edad + ", SEXO = '" + sexo + "',DEPARTAMENTO = '" + departamento + "' where ID_EMPLEADO_TE = " + id + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }//FIN DE MI FUNCION 
        */




        // Función para obtener un empleado por ID
        public static Empleado ModificarEmpleado(int idEmpleado)
        {
            string query = @"
        SELECT E.ID_EMPLEADO_TE, E.NOMBRE, E.APELLIDO_PATERNO, E.APELLIDO_MATERNO, E.EDAD, E.SEXO, E.DEPARTAMENTO, T.NOMBRE_TURNO
        FROM EMPLEADO E
        INNER JOIN TURNOS T ON E.ID_TURNO = T.ID_TURNO
        WHERE E.ID_EMPLEADO_TE = @id";
            Empleado empleado = null;

            using (SqlConnection conexion = BDPrincipal.obtenerConexionAlternativa())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEmpleado);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                id = idEmpleado, // Asigna el ID del empleado
                                nombre = reader["NOMBRE"].ToString(),
                                apellidoPaterno = reader["APELLIDO_PATERNO"].ToString(),
                                apellidoMaterno = reader["APELLIDO_MATERNO"].ToString(),
                                edad = Convert.ToInt32(reader["EDAD"]),
                                sexo = reader["SEXO"].ToString(),
                                departamento = reader["DEPARTAMENTO"].ToString(),
                                turnoNombre = reader["NOMBRE_TURNO"].ToString()
                            };
                        }
                    }
                }
            }

            return empleado;
        }



        // Función para actualizar los datos de un empleado
        public static int ModificarEmpleadoCambios(int id, string nombre, string apellidoP, string apellidoM, int edad, string sexo, string departamento, string turnoNombre)
        {
            int retorno = 0;

            // Obtener ID_TURNO e ID_DEPARTAMENTO para usarlos en la consulta
            int idTurno = ObtenerIdTurno(turnoNombre);
            string idDepartamento = ObtenerIdDepartamento(departamento);

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                // Consulta SQL para actualizar el empleado, usando parámetros para evitar inyección SQL
                string query = @"
            UPDATE EMPLEADO
            SET NOMBRE = @nombre,
                APELLIDO_PATERNO = @apellidoP,
                APELLIDO_MATERNO = @apellidoM,
                EDAD = @edad,
                SEXO = @sexo,
                DEPARTAMENTO = @departamento,
                ID_DEPARTAMENTO = @idDepartamento,
                ID_TURNO = @idTurno
            WHERE ID_EMPLEADO_TE = @id";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    // Agregar parámetros de manera segura para evitar inyección SQL
                    comando.Parameters.AddWithValue("@nombre", nombre);
                    comando.Parameters.AddWithValue("@apellidoP", apellidoP);
                    comando.Parameters.AddWithValue("@apellidoM", apellidoM);
                    comando.Parameters.AddWithValue("@edad", edad);
                    comando.Parameters.AddWithValue("@sexo", sexo);
                    comando.Parameters.AddWithValue("@departamento", departamento);
                    comando.Parameters.AddWithValue("@idDepartamento", idDepartamento);
                    comando.Parameters.AddWithValue("@idTurno", idTurno);
                    comando.Parameters.AddWithValue("@id", id);

                    // Ejecutar la consulta y devolver el número de filas afectadas
                    retorno = comando.ExecuteNonQuery();
                }
            }

            return retorno;
        }





















    }//END CLASS
}
