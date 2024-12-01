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
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            dataGridViewAgregarEmp.DataSource = EmpleadoQuery.MostrarRegistro();
          // Asegurarse de que el ComboBox no permita la edición, solo selección
            comboBoxTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOcupation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;

        }


        //REGISTRAR NUEVO EMPLEADO
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
          
           

        }//FIN DE LA FUNCION 

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxOcupation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTurno.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void comboBoxOcupation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAgar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            if (!string.IsNullOrEmpty(txtBoxName.Text) && !string.IsNullOrEmpty(txtBoxLastNameP.Text) && !string.IsNullOrEmpty(txtBoxLastNameM.Text) && !string.IsNullOrEmpty(txtBoxAge.Text) && int.TryParse(txtBoxAge.Text, out int idBtnOk) && !string.IsNullOrEmpty(comboBoxSex.Text) && !string.IsNullOrEmpty(comboBoxOcupation.Text) && !string.IsNullOrEmpty(comboBoxTurno.Text))
            {
                empleado.nombre = txtBoxName.Text;
                empleado.apellidoPaterno = txtBoxLastNameP.Text;
                empleado.apellidoMaterno = txtBoxLastNameM.Text;
                empleado.edad = Convert.ToInt32(txtBoxAge.Text);
                empleado.sexo = comboBoxSex.Text;
                empleado.departamento = comboBoxOcupation.Text;
                empleado.turnoNombre = comboBoxTurno.Text;

                int result = EmpleadoQuery.AgregarEmpleado(empleado);

                if (result != 0)
                {
                    MessageBox.Show("El empleado se a registrado correctamente! ");

                    dataGridViewAgregarEmp.DataSource = EmpleadoQuery.MostrarRegistro();

                    txtBoxName.Text = "";
                    txtBoxLastNameP.Text = "";
                    txtBoxLastNameM.Text = "";
                    txtBoxAge.Text = "";
                    comboBoxSex.SelectedIndex = -1;
                    comboBoxOcupation.SelectedIndex = -1;
                    comboBoxTurno.SelectedIndex = -1;

                }
                else
                {

                    MessageBox.Show("No se realizo el registro");
                }


            }
            else
            {
                MessageBox.Show("LLene todos los campos porfavor o Digite un valor numerico en el campo Edad");

            }

        }

        private void txtBoxSex_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
