using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convertidor
{
    public partial class Form1 : Form
    {
        double valor, conversion;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if(rbCantidadD.Checked && rbDolares.Checked)
            {
                MessageBox.Show("No se puede convertir de dolares a dolares");
            }
            if (txtValor.Text == String.Empty)
            {
                MessageBox.Show("Favor de introducir valores");
            }

            if(rbCantidadP.Checked && rbPesos.Checked)
            {
                MessageBox.Show("No se puede convertir de Pesos a Pesos");
            }

            if (rbCantidadP.Checked && rbDolares.Checked)
            {

                valor = Convert.ToDouble(txtValor.Text);
                conversion = valor / 21.33;
                lblRespuesta.Text = Convert.ToString(conversion)+" Dolares";
            }

            if (rbCantidadD.Checked && rbPesos.Checked)
            {
                valor = Convert.ToDouble(txtValor.Text);
                conversion = valor * 21.33;
                lblRespuesta.Text = Convert.ToString(conversion)+" Pesos";
            }
        }
    }
}
