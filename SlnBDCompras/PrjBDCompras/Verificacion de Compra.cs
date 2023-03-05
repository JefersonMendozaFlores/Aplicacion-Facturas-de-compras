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
using System.Data.Common;

namespace PrjBDCompras
{
    public partial class Verificacion_de_Compra : Form
    {
        //
        DataTable tb = new DataTable();
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
        //
        public Verificacion_de_Compra()
        {
            InitializeComponent();
            tb.Columns.Add("Codigo");
            tb.Columns.Add("fecha_Compra");
            tb.Columns.Add("Serie");
            tb.Columns.Add("Comprobante");
            tb.Columns.Add("RUC");
            tb.Columns.Add("razonSocial");
            tb.Columns.Add("Sub_Total");
            tb.Columns.Add("Total");
            tb.Columns.Add("Estado");
        }
        //boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cadenaBD);
            //
            SqlCommand cmd = new SqlCommand("Verificacion_compra @fecha", cnn);
            cmd.Parameters.AddWithValue("@fecha", Convert.ToString(txtFecha.Text));
            //
            cnn.Open();
            //
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Rows.Clear();
            while (dr.Read())
            {
                DataRow fila = tb.NewRow();
                fila[0] = dr.GetInt32(0);
                fila[1] = dr.GetDateTime(1);
                fila[2] = dr.GetString(2);
                fila[3] = dr.GetString(3);
                fila[4] = dr.GetString(4);
                fila[5] = dr.GetString(5);
                fila[6] = dr.GetDecimal(6);
                fila[7] = dr.GetDecimal(7);
                fila[8] = dr.GetString(8);
                tb.Rows.Add(fila);
            }
            dgvCompra.DataSource = tb;
        }
        //
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
    }
}
