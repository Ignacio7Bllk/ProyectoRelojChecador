using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoRelojChecador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BOTONES

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 0;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 1;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 3;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 5;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 6;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 7;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 8;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 9;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(etiquetaIntroducir.Text))
            {
                // Get the length of the text
                int CADENA = etiquetaIntroducir.Text.Length;

                // Remove the last character using Substring
                etiquetaIntroducir.Text = etiquetaIntroducir.Text.Substring(0, CADENA - 1);
            }
        }
        /*
        // Primera version
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(etiquetaIntroducir.Text))
            {
                int idBtnOk;
                if (int.TryParse(etiquetaIntroducir.Text, out idBtnOk))
                {
                    string horaBtnOk = DateTime.Now.ToString("HH:mm:ss");
                    TimeSpan horaActual = TimeSpan.Parse(horaBtnOk);
                    DateTime fechaActual = DateTime.Now.Date;

                    Checada checada = new Checada
                    {
                        id = idBtnOk,
                        hora = horaActual,
                        fecha = fechaActual
                    };

                    if (EmpleadoQuery.buscarEmpleado(idBtnOk) != 0)
                    {
                        using (SqlConnection conexion = BDPrincipal.obtenerConexion())
                        {
                            string queryTurno = @"
                        SELECT T.HORA_ENTRADA, T.HORA_SALIDA, T.HORA_COMIDA_INICIO, T.HORA_COMIDA_FIN
                        FROM TURNOS T
                        INNER JOIN EMPLEADO E ON E.ID_TURNO = T.ID_TURNO
                        WHERE E.ID_EMPLEADO_TE = @idEmpleado;";

                            SqlCommand comandoTurno = new SqlCommand(queryTurno, conexion);
                            comandoTurno.Parameters.AddWithValue("@idEmpleado", idBtnOk);

                            SqlDataReader reader = comandoTurno.ExecuteReader();
                            if (reader.Read())
                            {
                                TimeSpan horaEntradaTurno = reader.GetTimeSpan(0);
                                TimeSpan horaSalidaTurno = reader.GetTimeSpan(1);
                                TimeSpan horaInicioComidaTurno = reader.GetTimeSpan(2);
                                TimeSpan horaFinComidaTurno = reader.GetTimeSpan(3);
                                reader.Close();

                                if ((horaActual >= horaEntradaTurno && horaActual <= horaSalidaTurno) &&
                                    (horaActual < horaInicioComidaTurno || horaActual > horaFinComidaTurno))
                                {
                                    int resgistroExito = ChecadaQuery.AgregarChecada(idBtnOk, horaActual, fechaActual, horaEntradaTurno, horaSalidaTurno, horaInicioComidaTurno, horaFinComidaTurno);
                                    if (resgistroExito != 0)
                                    {
                                        MessageBox.Show("Haz Checado");
                                        etiquetaIntroducir.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("No Haz Checado");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("La checada no está dentro del horario permitido.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El empleado no tiene un turno asignado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digita nuevamente el id");
                        etiquetaIntroducir.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Introduce tu id por favor");
            }
        }

        *//*
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(etiquetaIntroducir.Text))
            {
                if (int.TryParse(etiquetaIntroducir.Text, out int idBtnOk))
                {
                    TimeSpan horaActual = DateTime.Now.TimeOfDay;
                    DateTime fechaActual = DateTime.Now.Date;

                    if (EmpleadoQuery.buscarEmpleado(idBtnOk) != 0)
                    {
                        using (SqlConnection conexion = BDPrincipal.obtenerConexion())
                        {
                            string queryTurno = @"
                        SELECT T.HORA_ENTRADA, T.HORA_SALIDA, T.HORA_COMIDA_INICIO, T.HORA_COMIDA_FIN
                        FROM TURNOS T
                        INNER JOIN EMPLEADO E ON E.ID_TURNO = T.ID_TURNO
                        WHERE E.ID_EMPLEADO_TE = @idEmpleado;";

                            SqlCommand comandoTurno = new SqlCommand(queryTurno, conexion);
                            comandoTurno.Parameters.AddWithValue("@idEmpleado", idBtnOk);

                            SqlDataReader reader = comandoTurno.ExecuteReader();
                            if (reader.Read())
                            {
                                TimeSpan horaEntradaTurno = reader.GetTimeSpan(0);
                                TimeSpan horaSalidaTurno = reader.GetTimeSpan(1);
                                TimeSpan horaInicioComidaTurno = reader.GetTimeSpan(2);
                                TimeSpan horaFinComidaTurno = reader.GetTimeSpan(3);
                                reader.Close();

                                int registroExito = ChecadaQuery.AgregarChecada(idBtnOk, horaActual, fechaActual, horaEntradaTurno, horaSalidaTurno, horaInicioComidaTurno, horaFinComidaTurno);

                                if (registroExito != 0)
                                {
                                    MessageBox.Show("Checada registrada exitosamente.");
                                    etiquetaIntroducir.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo registrar la checada.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El empleado no tiene un turno asignado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digita nuevamente el ID.");
                        etiquetaIntroducir.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Introduce tu ID por favor.");
            }
        }
        */
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(etiquetaIntroducir.Text))
            {
                if (int.TryParse(etiquetaIntroducir.Text, out int idBtnOk))
                {
                    TimeSpan horaActual = DateTime.Now.TimeOfDay;
                    DateTime fechaActual = DateTime.Now.Date;

                    if (EmpleadoQuery.buscarEmpleado(idBtnOk) != 0)
                    {
                        using (SqlConnection conexion = BDPrincipal.obtenerConexion())
                        {
                            string queryTurno = @"
            SELECT T.HORA_ENTRADA, T.HORA_SALIDA, T.HORA_COMIDA_INICIO, T.HORA_COMIDA_FIN
            FROM TURNOS T
            INNER JOIN EMPLEADO E ON E.ID_TURNO = T.ID_TURNO
            WHERE E.ID_EMPLEADO_TE = @idEmpleado;";

                            SqlCommand comandoTurno = new SqlCommand(queryTurno, conexion);
                            comandoTurno.Parameters.AddWithValue("@idEmpleado", idBtnOk);

                            SqlDataReader reader = comandoTurno.ExecuteReader();
                            if (reader.Read())
                            {
                                TimeSpan horaEntradaTurno = reader.GetTimeSpan(0);
                                TimeSpan horaSalidaTurno = reader.GetTimeSpan(1);
                                TimeSpan horaInicioComidaTurno = reader.GetTimeSpan(2);
                                TimeSpan horaFinComidaTurno = reader.GetTimeSpan(3);
                                reader.Close();

                                // Verificar si la hora actual está fuera del horario permitido
                                if (horaActual < horaEntradaTurno || horaActual > horaSalidaTurno)
                                {
                                    MessageBox.Show("No se puede registrar la checada fuera del horario asignado.");
                                    return;
                                }

                                int registroExito = ChecadaQuery.AgregarChecada(idBtnOk, horaActual, fechaActual, horaEntradaTurno, horaSalidaTurno, horaInicioComidaTurno, horaFinComidaTurno);

                                if (registroExito != 0)
                                {
                                    MessageBox.Show("Checada registrada exitosamente.");
                                    etiquetaIntroducir.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo registrar la checada. Por favor, verifica los horarios o intenta nuevamente.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El empleado no tiene un turno asignado.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digita nuevamente el ID.");
                        etiquetaIntroducir.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("El ID ingresado no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Introduce tu ID por favor.");
            }
        }




        private void TimerHoraFecha_Tick(object sender, EventArgs e)
        {
            etiquetaHora.Text = DateTime.Now.ToString("HH:mm:ss");
            etiquetaFecha.Text = DateTime.Now.ToString("ddd d MMM y");
        }

        //BONTONES QUE TE LLEVANA OTRO WINDOWS FORM

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frmAgregarEmpleado = new FrmAgregarEmpleado();
            frmAgregarEmpleado.ShowDialog();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmBuscarEmpleado frmBuscarEmpleado = new FrmBuscarEmpleado();
            frmBuscarEmpleado.ShowDialog();
        }

        private void btnRegistroChecadas_Click(object sender, EventArgs e)
        {
            FrmRegistroChecada frmRegistroChecada = new FrmRegistroChecada();
            frmRegistroChecada.ShowDialog();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            FrmEliminarEmpleado frmEliminarEmpleado = new FrmEliminarEmpleado();
            frmEliminarEmpleado.ShowDialog();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            FrmModificarEmpleado frmModificarEmpleado = new FrmModificarEmpleado();
            frmModificarEmpleado.ShowDialog();
        }

        private void etiquetaHora_Click(object sender, EventArgs e)
        {

        }
    }
}
