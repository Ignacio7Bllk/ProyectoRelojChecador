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
    public partial class FrmRegistroChecada : Form
    {
        public FrmRegistroChecada()
        {
            InitializeComponent();
        }

        private void FrmRegistroChecada_Load(object sender, EventArgs e)
        {

        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtboxIdEmpleado.Text) && int.TryParse(txtboxIdEmpleado.Text, out int idBtnOk))
            {
                int VrFrmRegistroChecadaid = int.Parse(txtboxIdEmpleado.Text);
                string vrFrmRegistroChecadafecha = textBoxfecha.Text;


                //editar NO CONFUNDIR EL txtFecha con txtfecha MAYUSCULA Y MINUSCULA

                if (EmpleadoQuery.buscarEmpleado(VrFrmRegistroChecadaid) != 0)
                {

                    txtboxIdEmpleado.Text = "";
                    textBoxfecha.Text = "";
                    dataGridViewRegistroChecada.DataSource = JoinRegistroChecadaQuery.MostrarRegistroJoin(VrFrmRegistroChecadaid, vrFrmRegistroChecadafecha);


                }
                else
                {
                    MessageBox.Show("Digita nuevamente el id");
                    txtboxIdEmpleado.Text = "";
                    textBoxfecha.Text = "";

                }
            }
            else 
            {
                MessageBox.Show("Digita un valor numerico en id o no dejes el campo vacio");
            }

                

        }// FIN DE BUSCAR REGISTRRO



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxIdEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }//FIN DE CLASE 
}
