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
    public partial class Empleados : Form
    {

        int idEmpleado;

        public Empleados(int id)
        {
            InitializeComponent();
            idEmpleado = id;

            // Puedes usar este idEmpleado para cargar datos del usuario
        }

        public Empleados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
