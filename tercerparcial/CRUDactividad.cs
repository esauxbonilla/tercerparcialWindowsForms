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
    public partial class CRUDactividad : Form
    {
        int idDepartamento;
        public CRUDactividad(int idDep)
        {
            InitializeComponent();
            idDepartamento = idDep;

            CargarProyectosDelDepartamento();
        }
        private void CargarProyectosDelDepartamento()
        {
            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = "SELECT Id_Proyecto, Nombre_Proyecto FROM Proyectos WHERE Id_Departamento = @idDep";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@idDep", idDepartamento);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxProyectos.DisplayMember = "Nombre_Proyecto";
                comboBoxProyectos.ValueMember = "Id_Proyecto";
                comboBoxProyectos.DataSource = dt;

                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proyectos: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncrearactividad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = @"INSERT INTO Actividades (Id_Proyecto, NombreActividad, FechaInicioA, FechaEntregaA, DescripcionA, Estado, Url_Archivo)
                         VALUES (@idProy, @nombre, @inicio, @entrega, @desc, @estado, @archivo)";

                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@idProy", comboBoxProyectos.SelectedValue);
                cmd.Parameters.AddWithValue("@nombre", txtNombreActividad.Text);
                cmd.Parameters.AddWithValue("@inicio", txtFechaInicio.Text);
                cmd.Parameters.AddWithValue("@entrega", txtFechaEntrega.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                cmd.Parameters.AddWithValue("@archivo", txtArchivo.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Actividad creada con éxito.");
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear actividad: " + ex.Message);
            }
        }

        private void btnconsultaractividad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = "SELECT * FROM Actividades WHERE Id_Proyecto = @idProy";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@idProy", comboBoxProyectos.SelectedValue);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridviewactividades.DataSource = dt;
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar actividades: " + ex.Message);
            }
        }

        private void btneliminaractividad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdActividad.Text))
            {
                MessageBox.Show("Ingresa el ID de la actividad.");
                return;
            }

            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = "DELETE FROM Actividades WHERE Id_Actividad = @id";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@id", txtIdActividad.Text);

                int filas = cmd.ExecuteNonQuery();
                MessageBox.Show(filas > 0 ? "Actividad eliminada." : "No se encontró la actividad.");
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar actividad: " + ex.Message);
            }
        }

        private void btnmodificaractividad_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = @"UPDATE Actividades SET 
                            NombreActividad = @nombre,
                            FechaInicioA = @inicio,
                            FechaEntregaA = @entrega,
                            DescripcionA = @desc,
                            Estado = @estado,
                            Url_Archivo = @archivo
                         WHERE Id_Actividad = @id";

                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@nombre", txtNombreActividad.Text);
                cmd.Parameters.AddWithValue("@inicio", txtFechaInicio.Text);
                cmd.Parameters.AddWithValue("@entrega", txtFechaEntrega.Text);
                cmd.Parameters.AddWithValue("@desc", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
                cmd.Parameters.AddWithValue("@archivo", txtArchivo.Text);
                cmd.Parameters.AddWithValue("@id", txtIdActividad.Text);

                int filas = cmd.ExecuteNonQuery();
                MessageBox.Show(filas > 0 ? "Actividad modificada." : "No se encontró la actividad.");
                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar actividad: " + ex.Message);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
