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
    public partial class CRUDproyectos : Form
    {

        int idDepartamento;
        public CRUDproyectos(int idDep)
        {
            InitializeComponent();
            idDepartamento = idDep;
            CargarProyectos();

            // Aquí puedes usar idDepartamento para filtrar o precargar proyectos
        }
        private void CargarProyectos()
        {
            try
            {
                using (SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False"))
                {
                    conx.Open();
                    string query = "SELECT * FROM Proyectos WHERE Id_Departamento = @idDep";
                    SqlCommand cmd = new SqlCommand(query, conx);
                    cmd.Parameters.AddWithValue("@idDep", idDepartamento);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridProyectos.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message);
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncrearproyecto_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False"))
                {
                    conx.Open();
                    string insert = @"INSERT INTO Proyectos 
                (Id_Proyecto, Id_Departamento, Nombre_Proyecto, Observaciones, FechaInicio, FechaEntrega, EstadoProyecto, Descripcion) 
                VALUES (@id, @dep, @nombre, @obs, @inicio, @entrega, @estado, @desc)";

                    SqlCommand cmd = new SqlCommand(insert, conx);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtIdProyecto.Text));
                    cmd.Parameters.AddWithValue("@dep", idDepartamento);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProyecto.Text);
                    cmd.Parameters.AddWithValue("@obs", txtObservaciones.Text);
                    cmd.Parameters.AddWithValue("@inicio", txtFechaInicio.Text);
                    cmd.Parameters.AddWithValue("@entrega", txtFechaEntrega.Text);
                    cmd.Parameters.AddWithValue("@estado", txtEstadoProyecto.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proyecto creado exitosamente.");
                    CargarProyectos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear proyecto: " + ex.Message);
            }
        }

        private void btnmodificarproyecto_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False"))
                {
                    conx.Open();
                    string update = @"UPDATE Proyectos 
                SET Nombre_Proyecto = @nombre, Observaciones = @obs, FechaInicio = @inicio,
                    FechaEntrega = @entrega, EstadoProyecto = @estado, Descripcion = @desc
                WHERE Id_Proyecto = @id AND Id_Departamento = @dep";

                    SqlCommand cmd = new SqlCommand(update, conx);
                    cmd.Parameters.AddWithValue("@id", int.Parse(txtIdProyecto.Text));
                    cmd.Parameters.AddWithValue("@dep", idDepartamento);
                    cmd.Parameters.AddWithValue("@nombre", txtNombreProyecto.Text);
                    cmd.Parameters.AddWithValue("@obs", txtObservaciones.Text);
                    cmd.Parameters.AddWithValue("@inicio", txtFechaInicio.Text);
                    cmd.Parameters.AddWithValue("@entrega", txtFechaEntrega.Text);
                    cmd.Parameters.AddWithValue("@estado", txtEstadoProyecto.Text);
                    cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proyecto modificado correctamente.");
                    CargarProyectos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar proyecto: " + ex.Message);
            }
        }

        private void btneliminarproyecto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProyecto.Text))
            {
                MessageBox.Show("Por favor, ingresa el ID del proyecto a eliminar.");
                return;
            }

            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = "DELETE FROM Proyectos WHERE Id_Proyecto = @id";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@id", txtIdProyecto.Text);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show("Proyecto eliminado correctamente.");
                    txtIdProyecto.Clear(); 
                }
                else
                {
                    MessageBox.Show("No se encontró el proyecto.");
                }

                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar proyecto: " + ex.Message);
            }
        }

        private void btnconsultarproyecto_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = "SELECT * FROM Proyectos WHERE Id_Departamento = @idDep";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@idDep", idDepartamento);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridProyectos.DataSource = dt;
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar proyectos: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
