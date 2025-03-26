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
    public partial class AsignarActividad : Form
    {
        int idDepartamento;

        public AsignarActividad(int idDep)
        {
            InitializeComponent();
            idDepartamento = idDep;
            CargarColaboradores();
            CargarActividades();
            // Aquí filtrarás empleados y actividades del departamento
        }
        private void CargarColaboradores()
        {
            SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
            conx.Open();

            string query = "SELECT Id_Empleado, Nombre FROM Empleados WHERE Id_Departamento = @idDep AND Id_Rol = 2";
            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.Parameters.AddWithValue("@idDep", idDepartamento);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxColaboradores.DisplayMember = "Nombre";
            comboBoxColaboradores.ValueMember = "Id_Empleado";
            comboBoxColaboradores.DataSource = dt;

            conx.Close();
        }
        private void CargarActividades()
        {
            SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
            conx.Open();

            string query = "SELECT Id_Actividad, NombreActividad FROM Actividades WHERE Id_Empleado IS NULL AND Id_Proyecto IN (SELECT Id_Proyecto FROM Proyectos WHERE Id_Departamento = @idDep)";
            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.Parameters.AddWithValue("@idDep", idDepartamento);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBoxActividades.DisplayMember = "NombreActividad";
            comboBoxActividades.ValueMember = "Id_Actividad";
            comboBoxActividades.DataSource = dt;

            conx.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (comboBoxColaboradores.SelectedIndex == -1 || comboBoxActividades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un colaborador y una actividad.");
                return;
            }

            try
            {
                SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");
                conx.Open();

                string query = "UPDATE Actividades SET Id_Empleado = @idEmp WHERE Id_Actividad = @idAct";

                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.Parameters.AddWithValue("@idEmp", comboBoxColaboradores.SelectedValue);
                cmd.Parameters.AddWithValue("@idAct", comboBoxActividades.SelectedValue);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Actividad asignada correctamente.");
                    btnConsultarAsignaciones.PerformClick(); // Actualiza el grid si ya está implementado
                }
                else
                {
                    MessageBox.Show("No se pudo asignar la actividad.");
                }

                conx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asignar actividad: " + ex.Message);
            }
        }

        private void btnConsultarAsignaciones_Click(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;InitialCatalog=parcial4;Integrated Security=True;Encrypt=False");
            conx.Open();

            string query = @"
        SELECT A.NombreActividad, E.Nombre + ' ' + E.ApellidoPaterno AS Empleado
        FROM Actividades A
        INNER JOIN Empleados E ON A.Id_Empleado = E.Id_Empleado
        INNER JOIN Proyectos P ON A.Id_Proyecto = P.Id_Proyecto
        WHERE P.Id_Departamento = @idDep";

            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.Parameters.AddWithValue("@idDep", idDepartamento);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gridviewAsignaciones.DataSource = dt;
            conx.Close();
        }

        private void comboBoxColaboradores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
