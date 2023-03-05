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
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace PrjBDCompras
{
    public partial class Modificar_Estado_de_Registro : Form
    {
        //cadena de conexion
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
        public Modificar_Estado_de_Registro()
        {
            InitializeComponent();
        }
        //Boton Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cadenaBD);
            SqlDataAdapter da = new SqlDataAdapter("Modificar_EstadoCompra @codigo, @Estado", cnn);
            da.SelectCommand.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            da.SelectCommand.Parameters.AddWithValue("@Estado", txtEstado.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MessageBox.Show("Se modifico el estado de manera correcta");
        }
        //Validacion de la caja Codigo
        private void txtCodigo_Validated(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Trim() == "")
            {
                epError.SetError(txtCodigo, "El campo CODIGO es obligatotio");
                txtCodigo.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //validacion de la caja Estado
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
