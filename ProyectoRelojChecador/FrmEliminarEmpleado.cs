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
    public partial class FrmEliminarEmpleado : Form
    {
        public FrmEliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtboxEliminarDato.Text) && int.TryParse(txtboxEliminarDato.Text, out int idBtnOk))
            {
                int variableLocalid = int.Parse(txtboxEliminarDato.Text);



                if (EmpleadoQuery.buscarEmpleado(variableLocalid) != 0)
                {
                    dataGridViewEliminarEmp.DataSource = EmpleadoQuery.MostrarRegistroParticular(variableLocalid);
                    ChecadaQuery.eliminarChecadaEmpleado(variableLocalid);
                    EmpleadoQuery.eliminarEmpleado(variableLocalid);


                    MessageBox.Show("Se ha eliminado correctamente al usuario");

                    dataGridViewEliminarEmp.DataSource = EmpleadoQuery.MostrarRegistroParticular(variableLocalid);
                }
                else
                {
                    MessageBox.Show("El id no se encuentra en la base de datos ");

                }


            }
            else 
            {
                MessageBox.Show("No dejes el campo vacia id o digita un valor numerico");

            }



                

        }//BTN ELIMINAR EMPLEADO 


    }//FIN CLASE
}
