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
    public partial class EncargadoDepartamento : Form
    {

        int idEmpleado;
        int idDepartamento;

        SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");

        public EncargadoDepartamento(int id)
        {
            InitializeComponent();
            idEmpleado = id;
            ObtenerDepartamento();

            // Aquí podrías cargar los proyectos que pertenecen a ese líder
        }

        private void ObtenerDepartamento()
        {
            try
            {
                conx.Open();
                string query = "SELECT Id_Departamento FROM Empleados WHERE Id_Empleado = @id";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@id", idEmpleado);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    idDepartamento = Convert.ToInt32(reader["Id_Departamento"]);
                    this.Text = "Encargado - Departamento " + idDepartamento;
                }
                else
                {
                    MessageBox.Show("No se encontró el departamento del encargado.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener departamento: " + ex.Message);
            }
            finally
            {
                conx.Close();
            }
        }


        public EncargadoDepartamento()
        {
            InitializeComponent();
        }

        private void btncrearactividad_Click(object sender, EventArgs e)
        {
            CRUDactividad frm = new CRUDactividad(idDepartamento);
            frm.Show();
        }

        private void btnAccionesProyecto_Click(object sender, EventArgs e)
        {
            CRUDproyectos frm = new CRUDproyectos(idDepartamento);
            frm.Show();
        }

        private void btnasignaractividad_Click(object sender, EventArgs e)
        {
            AsignarActividad frm = new AsignarActividad(idDepartamento);
            frm.Show();
        }

        private void btnconsultarentregas_Click(object sender, EventArgs e)
        {
            string query = @"
            SELECT A.Id_Actividad, A.NombreActividad, A.Estado, A.FechaEntregaA, E.Nombre 
            FROM Actividades A
            JOIN Empleados E ON A.Id_Empleado = E.Id_Empleado
            WHERE A.Estado = 'Finalizada'
              AND A.Id_Proyecto IN (SELECT Id_Proyecto FROM Proyectos WHERE Id_Departamento = @idDep)
        ";

            try
            {
                conx.Open();
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@idDep", idDepartamento);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gridviewencargado.DataSource = dt; // Asegúrate de tener un DataGridView en el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar entregas: " + ex.Message);
            }
            finally
            {
                conx.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
