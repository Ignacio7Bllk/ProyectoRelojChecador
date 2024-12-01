using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRelojChecador
{
    public partial class FrmModificarEmpleado : Form
    {



        public FrmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textBoxId.Text) && int.TryParse(textBoxId.Text, out int idBtnOk))
            {

                int variableLocalid = int.Parse(textBoxId.Text);
                string nombreLocal = "";
                string apellidoPLocal = "";
                string apelldoMLocal = "";
                int edadLocal = 0;
                string sexoLocal = "";
                string puestoLocal = "";
                string turnoLocal = "";


                if (EmpleadoQuery.buscarEmpleado(variableLocalid) != 0)
                {
                    dataGridViewModificarEmpleado.DataSource = EmpleadoQuery.MostrarRegistroParticular(variableLocalid);
                    Empleado empleado = EmpleadoQuery.ModificarEmpleado(variableLocalid);


                    //ASINAMOS A LA VARIABLES LOCALES LOS VALORES DEL OBJETO empleado

                    nombreLocal = empleado.nombre;
                    apellidoPLocal = empleado.apellidoPaterno;
                    apelldoMLocal = empleado.apellidoMaterno;
                    edadLocal = empleado.edad;
                    sexoLocal = empleado.sexo;
                    puestoLocal = empleado.departamento;
                    turnoLocal = empleado.turnoNombre;

                    //ASIGNAMOS A LOS TEXBOX LAS VARIABLES QUE SEVOLVEMOS DEL OBJETO PERSONA 
                    txtBoxName.Text = nombreLocal;
                    txtBoxLastNameP.Text = apellidoPLocal;
                    txtBoxLastNameM.Text = apelldoMLocal;
                    txtBoxAge.Text = edadLocal.ToString();
                    comboBoxsex.Text = sexoLocal;
                    comboBoxOcupation.Text = puestoLocal;
                    comboBoxTurno.Text = turnoLocal;

                    // Hacemos que el campo ID no sea editable
                    textBoxId.ReadOnly = true;

                    MessageBox.Show("Agregar los cambios en los campos requeridos");



                }
                else
                {
                    MessageBox.Show("El id no se encuentra en la base de datos ");

                }

            }
            else 
            {
                MessageBox.Show("Digita un numero en el campo id o digita al menos un valor");

            }


              


            //empleado = EmpleadoQuery.ModificarEmpleado(1);
            //MessageBox.Show("1" + empleado.nombre);
        }//FIN METODO 

        private void btnModificarTrue_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBoxName.Text) && !string.IsNullOrEmpty(txtBoxLastNameP.Text) && !string.IsNullOrEmpty(txtBoxLastNameM.Text) && !string.IsNullOrEmpty(txtBoxAge.Text) && int.TryParse(txtBoxAge.Text, out int idBtnOk) && !string.IsNullOrEmpty(comboBoxsex.Text) && !string.IsNullOrEmpty(comboBoxOcupation.Text) && !string.IsNullOrEmpty(comboBoxTurno.Text))
            {
                int variableLocalid = int.Parse(textBoxId.Text);
                string nombreLocal = txtBoxName.Text;
                string apellidoPLocal = txtBoxLastNameP.Text;
                string apelldoMLocal = txtBoxLastNameM.Text;
                int edadLocal = int.Parse(txtBoxAge.Text);
                string sexoLocal = comboBoxsex.Text;
                string puestoLocal = comboBoxOcupation.Text;
                string turnolocal= comboBoxTurno.Text;


                EmpleadoQuery.ModificarEmpleadoCambios(variableLocalid, nombreLocal, apellidoPLocal, apelldoMLocal, edadLocal, sexoLocal, puestoLocal,turnolocal);



                MessageBox.Show("Los datos se han Modificado correctamente");

                textBoxId.Text = "";
                txtBoxName.Text = "";
                txtBoxLastNameM.Text = "";
                txtBoxLastNameP.Text = "";
                txtBoxAge.Text = "";
                comboBoxsex.Text = "";
                comboBoxOcupation.Text = "";
                comboBoxTurno.Text = "";

                dataGridViewModificarEmpleado.DataSource = EmpleadoQuery.MostrarRegistroParticular(variableLocalid);
                textBoxId.ReadOnly = false;

            }
            else
            {
                MessageBox.Show("LLene todos los campos porfavor o Digite un valor numerico en el campo Edad");

            }





        }

        private void txtBoxOcupation_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void comboBoxsex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//FIN DE MI CLASE 
}


