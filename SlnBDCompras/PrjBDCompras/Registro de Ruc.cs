using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using para confi - data y data data cliente
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;


namespace PrjBDCompras
{
    public partial class Registro_de_Ruc : Form
    {
        //cadena de conexion
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
        //Trae de la tabka RUC
        DataTable RUC()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlDataAdapter da = new SqlDataAdapter("select * from Tabla_Ruc", cn);

            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        //Registros de la tabla RUC
        public Registro_de_Ruc()
        {
            InitializeComponent();
            dgvRUC.DataSource = RUC();
        }
        //boton Registrar
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                //
                SqlCommand cmd = new SqlCommand("regitrar_Ruc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ruc", txtRUC.Text);
                cmd.Parameters.AddWithValue("@razonSocial", txtRazonSocial.Text);
                //
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show($"Se ha registrado {i} RUC");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
            dgvRUC.DataSource = RUC();
        }
        //Validaciones
        //validacion del campo RUC
        private void txtRUC_Validated(object sender, EventArgs e)
        {
            if (txtRUC.Text.Trim() == "")
            {
                epError.SetError(txtRUC, "El campo RUC es obligatotio");
                txtRUC.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //validacion del campo Razon social
        private void txtRazonSocial_Validated(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Trim() == "")
            {
                epError.SetError(txtRazonSocial, "El campo RAZON SOCIAL es obligatotio");
                txtRazonSocial.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
