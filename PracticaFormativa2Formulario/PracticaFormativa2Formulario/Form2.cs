using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PracticaFormativa2Formulario
{
    public partial class frmIngreso : Form
    {
        class Datos
        {
            int valor;

            public int getValor()
            {
                return valor;
            }

            public void setValor(int valor)
            {
                this.valor = valor;
            }

            public Datos(int valor)
            {
                setValor(valor);
            }

        }


        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Datos dato1 = new Datos(Int32.Parse(txtDato1.Text));
            Datos dato2 = new Datos(Int32.Parse(txtDato2.Text));

            MessageBox.Show("Se cargaron los datos");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La suma de ambos valores es " + (Int32.Parse(txtDato1.Text)) + Int32.Parse(txtDato2.Text))).);
        }
    }
}
