using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tercerparcial
{
    public partial class CRUDColaborador : Form
    {
        int idEmpleado;

        public CRUDColaborador(int idEmp)
        {
            InitializeComponent();
            idEmpleado = idEmp;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
            conx.Open();

            string query = @"SELECT Id_Actividad, NombreActividad, Estado, Url_Archivo 
                     FROM Actividades 
                     WHERE Id_Empleado = @idEmp";

            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.Parameters.AddWithValue("@idEmp", idEmpleado);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gridviewactividades.DataSource = dt;
            conx.Close();
        }

        private void gridviewactividades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdActividad.Text = gridviewactividades.Rows[e.RowIndex].Cells["Id_Actividad"].Value.ToString();
            txtNombreActividad.Text = gridviewactividades.Rows[e.RowIndex].Cells["NombreActividad"].Value.ToString();
            txtEstado.Text = gridviewactividades.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            txtUrlArchivo.Text = gridviewactividades.Rows[e.RowIndex].Cells["Url_Archivo"].Value.ToString();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdActividad.Text) || string.IsNullOrWhiteSpace(txtUrlArchivo.Text))
            {
                MessageBox.Show("Selecciona una actividad y proporciona la URL del archivo.");
                return;
            }

            SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
            conx.Open();

            string query = @"UPDATE Actividades 
                     SET Url_Archivo = @url, Estado = 'Entregado' 
                     WHERE Id_Actividad = @idAct AND Id_Empleado = @idEmp";

            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.Parameters.AddWithValue("@url", txtUrlArchivo.Text);
            cmd.Parameters.AddWithValue("@idAct", txtIdActividad.Text);
            cmd.Parameters.AddWithValue("@idEmp", idEmpleado);

            int filas = cmd.ExecuteNonQuery();

            MessageBox.Show(filas > 0 ? "Actividad entregada." : "Error al entregar actividad.");
            conx.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdActividad.Text) || string.IsNullOrWhiteSpace(txtUrlArchivo.Text))
            {
                MessageBox.Show("Selecciona una actividad y proporciona una nueva URL.");
                return;
            }

            SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
            conx.Open();

            string query = @"UPDATE Actividades 
                     SET Url_Archivo = @url 
                     WHERE Id_Actividad = @idAct AND Id_Empleado = @idEmp";

            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.Parameters.AddWithValue("@url", txtUrlArchivo.Text);
            cmd.Parameters.AddWithValue("@idAct", txtIdActividad.Text);
            cmd.Parameters.AddWithValue("@idEmp", idEmpleado);

            int filas = cmd.ExecuteNonQuery();

            MessageBox.Show(filas > 0 ? "Entrega modificada." : "No se pudo modificar.");
            conx.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
