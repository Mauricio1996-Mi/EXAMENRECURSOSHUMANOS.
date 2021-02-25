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
    public partial class frmempleado : Form
    {
        public frmempleado()
        {
            InitializeComponent();
        }

        private void frmempleado_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtcontrato_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            clases1.empleado vendedor1 = new clases1.empleado();
            vendedor1.Appaterno = txtpaterno.Text;
            vendedor1.Apmaterno = txtmaterno.Text;
            vendedor1.Nombre = txtnombre.Text;
            vendedor1.Sexo = cmdsexo.Text;
            vendedor1.Tipo = txtcedula.Text;
            vendedor1.Tipocontrato = txtcontrato.Text;
            vendedor1.Numseguro = txtsegurosocial.Text;
            dgvempleado.Rows.Insert(0, vendedor1.Appaterno, vendedor1.Apmaterno, vendedor1.Nombre, vendedor1.Sexo, vendedor1.Tipo, vendedor1.Tipocontrato, vendedor1.Numseguro);
        }
    }
}
