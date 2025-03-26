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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnEntregarActividad_Click(object sender, EventArgs e)
        {
            CRUDColaborador frm = new CRUDColaborador(idEmpleado);
            frm.Show();
        }

        private void btnActividadesAsignadas_Click(object sender, EventArgs e)
        {
            CRUDColaborador frm = new CRUDColaborador(idEmpleado);
            frm.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra este form y vuelve al anterior si lo había

        }
    }
}
