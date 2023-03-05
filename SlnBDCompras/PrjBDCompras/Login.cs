using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PrjBDCompras
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }
        //Metodo para ingresar
        public void login()
        {
            try
            {
                string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cadenaBD))
                {
                    conexion.Open();
                    using(SqlCommand cmd = new SqlCommand("select Usuario, Clave from Acceso where Usuario='" + txtUsuario.Text + "' and Clave='" + txtClave.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Form1 ventana = new Form1();
                            ventana.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Datos inorrectos");
                        }
                    }
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Boton Ingresar
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            login();
        }
        //Boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Esta seguro de salir de la App?","Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //
            if (r == DialogResult.Yes)
                Close();
        }
        //Validacion del campo Usuario
        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario, "El campo Usuario es obligatotio");
                txtUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //Validacion del campo Contraseña
        private void txtClave_Validated(object sender, EventArgs e)
        {
            if (txtClave.Text.Trim() == "")
            {
                epError.SetError(txtClave, "El campo Contraseña es obligatotio");
                txtClave.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
