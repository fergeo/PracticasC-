using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFormativa2Formulario
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ingrese valores para los datos indicados.", "Mensajes", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El Nombre ingreado es " + txtNombre.Text);

            MessageBox.Show("El Apellido ingreado es " + txtApellido.Text);

            MessageBox.Show("El Documento ingreado es " + txtDocumento.Text);
        }
    }
}
