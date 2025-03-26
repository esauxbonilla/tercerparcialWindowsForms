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
    public partial class Form1 : Form
    {
        SqlConnection conx = new SqlConnection("Data Source=KIX-ROG\\SQLEXPRESS;Initial Catalog=parcial4;Integrated Security=True;Encrypt=False");



        public Form1()
        {
            InitializeComponent();
 
        }
        public void ValidarUsuario(string usuario, string password)
        {
            try
            {
                conx.Open();

                SqlCommand cmd = new SqlCommand(@"
            SELECT Id_Empleado, Id_Rol, Nombre 
            FROM Empleados 
            WHERE Correo = @correo AND Password = @pass", conx);

                cmd.Parameters.AddWithValue("@correo", usuario);
                cmd.Parameters.AddWithValue("@pass", password);

                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sd.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    int idRol = Convert.ToInt32(dt.Rows[0]["Id_Rol"]);
                    int idEmpleado = Convert.ToInt32(dt.Rows[0]["Id_Empleado"]);
                    string nombreEmpleado = dt.Rows[0]["Nombre"].ToString();

                    this.Hide();

                    if (idRol == 1) // Encargado de Departamento
                    {
                        EncargadoDepartamento formLider = new EncargadoDepartamento(idEmpleado);
                        formLider.Show();
                    }
                    else if (idRol == 2) // Colaborador
                    {
                        Empleados formColab = new Empleados(idEmpleado);
                        formColab.Show();
                    }
                    else
                    {
                        MessageBox.Show("Rol no válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message);
            }
            finally
            {
                conx.Close();
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            ValidarUsuario(txtusuario.Text, txtcontrasenia.Text);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
