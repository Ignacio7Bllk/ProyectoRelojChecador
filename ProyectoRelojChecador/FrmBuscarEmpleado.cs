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
    public partial class FrmBuscarEmpleado : Form
    {
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
        }


        //BUSCAR EMPLEADO
        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(txtboxBuscarDato.Text) && int.TryParse(txtboxBuscarDato.Text, out int idBtnOk))
            {

                int idArgumento = int.Parse(txtboxBuscarDato.Text);


                int result = EmpleadoQuery.buscarEmpleado(idArgumento);



                if (result != 0)
                {
                    dataGridViewBuscarEmp.DataSource = EmpleadoQuery.MostrarRegistroParticular(idArgumento);

                }
                else
                {
                    MessageBox.Show("El id digitado no esta registrado");
                    txtboxBuscarDato.Text = "";

                }

            }
            else 
            {
                MessageBox.Show("Digita un numero en el campo id o No lo dejes vacio");
            }

        }



        private void FrmBuscarEmpleado_Load(object sender, EventArgs e)
        {

            //dataGridViewBuscarEmp.DataSource = EmpleadoQuery.MostrarRegistro();

        }


    }//FIN DE MI CLASE 
}
