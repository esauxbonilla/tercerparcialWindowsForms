using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tercerparcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Establecer placeholder en los TextBox al cargar el formulario
            txtusuario.Text = "Usuario";
            txtusuario.ForeColor = Color.Gray;
            txtcontrasenia.Text = "Contraseña";
            txtcontrasenia.ForeColor = Color.Gray;
            this.txtusuario.Height = 40;  // Nuevo alto de 40 píxeles

            // Cambiar el alto del TextBox "txtcontrasenia"
            this.txtcontrasenia.Height = 40;  // Nuevo alto de 40 píxeles
        }

        // Cuando el TextBox recibe el foco (click)
        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.Black;
            }
        }

        // Cuando el TextBox pierde el foco
        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusuario.Text))
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.Gray;
            }
        }

        private void txtcontrasenia_Enter(object sender, EventArgs e)
        {
            if (txtcontrasenia.Text == "Contraseña")
            {
                txtcontrasenia.Text = "";
                txtcontrasenia.ForeColor = Color.Black;
            }
        }

        private void txtcontrasenia_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcontrasenia.Text))
            {
                txtcontrasenia.Text = "Contraseña";
                txtcontrasenia.ForeColor = Color.Gray;
            }
        }


    }
}
