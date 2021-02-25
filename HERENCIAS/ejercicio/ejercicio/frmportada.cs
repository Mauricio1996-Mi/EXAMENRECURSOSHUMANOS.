using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio
{
    public partial class frmportada : Form
    {
        public frmportada()
        {
            InitializeComponent();
        }

        private void frmportada_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            ejercicio.frmcliente cliente= new ejercicio.frmcliente  ();
            cliente.Show();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            ejercicio.frmempleado empleado =new ejercicio.frmempleado  ();
            empleado.Show();
        }
    }
}
