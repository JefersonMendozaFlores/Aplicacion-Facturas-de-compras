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
    public partial class Registro_de_Compra : Form
    {
        //Cadena de conexion
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
        //Tabla Comprar
        DataTable Compra()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlDataAdapter da = new SqlDataAdapter("select * from Tabla_Compra", cn);

            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        //Registros de la compra
        public Registro_de_Compra()
        {
            InitializeComponent();
            //
            dgvCompra.DataSource = Compra();
        }
        //boton Registrar
        private void btnRegistar_Click(object sender, EventArgs e)
        {
            //
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                //
                SqlCommand cmd = new SqlCommand("regitrar_Compra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_Compra", Convert.ToString(txtFecha.Text));
                cmd.Parameters.AddWithValue("@Serie", txtSerie.Text);
                cmd.Parameters.AddWithValue("@Comprobante", txtComprobante.Text);
                cmd.Parameters.AddWithValue("@RUC", txtRUC.Text);
                cmd.Parameters.AddWithValue("@Sub_Total", txtSubTotal.Text);
                cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                //
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show($"Se ha registrado {i} compra");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
            dgvCompra.DataSource = Compra();     
        }
        //Validacion del campo FECHA
        private void txtFecha_Validated(object sender, EventArgs e)
        {
            if (txtFecha.Text.Trim() == "")
            {
                epError.SetError(txtFecha, "El campo FECHA es obligatotio");
                txtFecha.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //Validacion del campo SERIE
        private void txtSerie_Validated(object sender, EventArgs e)
        {
            if (txtSerie.Text.Trim() == "")
            {
                epError.SetError(txtSerie, "El campo SERIE es obligatotio");
                txtSerie.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //Validacion del campo COMPROBANTE
        private void txtComprobante_Validated(object sender, EventArgs e)
        {
            if (txtComprobante.Text.Trim() == "")
            {
                epError.SetError(txtComprobante, "El campo COMPROBANTE es obligatotio");
                txtComprobante.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //Validacion del campo RUC
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
        //Validacion del campo SUBTOTAL
        private void txtSubTotal_Validated(object sender, EventArgs e)
        {
            if (txtSubTotal.Text.Trim() == "")
            {
                epError.SetError(txtSubTotal, "El campo SUBTOTAL es obligatotio");
                txtSubTotal.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //Validacion del campo ESTADO
        private void txtEstado_Validated(object sender, EventArgs e)
        {
            if (txtEstado.Text.Trim() == "")
            {
                epError.SetError(txtEstado, "El campo ESTADO es obligatotio");
                txtEstado.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}   
