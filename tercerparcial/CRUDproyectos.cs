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
    public partial class CRUDproyectos : Form
    {

        int idDepartamento;
        public CRUDproyectos(int idDep)
        {
            InitializeComponent();
            idDepartamento = idDep;

            // Aquí puedes usar idDepartamento para filtrar o precargar proyectos
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
