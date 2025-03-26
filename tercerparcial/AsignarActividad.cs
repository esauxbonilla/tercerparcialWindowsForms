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
    public partial class AsignarActividad : Form
    {
        int idDepartamento;

        public AsignarActividad(int idDep)
        {
            InitializeComponent();
            idDepartamento = idDep;

            // Aquí filtrarás empleados y actividades del departamento
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
