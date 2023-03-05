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
    public partial class Mantenimiento_de_Compra : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString);
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
        DataTable tb = new DataTable();
        //
        //Registros pedidos
        DataTable Compra()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlDataAdapter da = new SqlDataAdapter("select * from Tabla_Compra", cn);

            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        //
        public Mantenimiento_de_Compra()
        {
            InitializeComponent();
            //
            tb.Columns.Add("Codigo");
            tb.Columns.Add("fecha_Compra");
            tb.Columns.Add("Serie");
            tb.Columns.Add("Comprobante");
            tb.Columns.Add("RUC");
            tb.Columns.Add("razonSocial");
            tb.Columns.Add("Sub_Total");
            tb.Columns.Add("Total");
            tb.Columns.Add("Estado");
            //
            dgvCompra.DataSource = Compra();
        }
        //Boton buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cadenaBD);
            //
            SqlCommand cmd = new SqlCommand("Mostrar_Detalle_Compra @codigo", cnn);
            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
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
        //Boton Actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                //
                SqlCommand cmd = new SqlCommand("actualizar_Compra", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@fecha_Compra", Convert.ToString(txtFecha.Text));
                cmd.Parameters.AddWithValue("@Serie", txtSerie.Text);
                cmd.Parameters.AddWithValue("@Comprobante", txtComprobante.Text);
                cmd.Parameters.AddWithValue("@RUC", txtRUC.Text);
                cmd.Parameters.AddWithValue("@Sub_Total", txtSubTotal.Text);
                cmd.Parameters.AddWithValue("@Estado", txtEstado.Text);
                //
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show($"Se ha actualizado {i} compra");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
            dgvCompra.DataSource = Compra();
        }
        //Boton Eliminar  
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Eliminar_Productos", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);
            cn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + "registro eliminado");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();

            }
            dgvCompra.DataSource = Compra();
        }      
        //Permitira ver los datos de la compra en las cajas - Verificar
        private void dgvCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow f = dgvCompra.CurrentRow;
            txtCodigo.Text = f.Cells[0].Value.ToString();
            txtFecha.Text = f.Cells[1].Value.ToString();
            txtSerie.Text = f.Cells[2].Value.ToString();
            txtComprobante.Text = f.Cells[3].Value.ToString();
            txtRUC.Text = f.Cells[4].Value.ToString();
            txtSubTotal.Text = f.Cells[5].Value.ToString();
            txtTotal.Text = f.Cells[6].Value.ToString();
            txtEstado.Text = f.Cells[7].Value.ToString();
        }
        //Validacion del campo Codigo
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
        //metodo para autocompletar caja ruc
        DataTable datos = new DataTable();
        void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Tabla_Ruc", cn);
            adaptador.Fill(datos);
            //
            for (int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["ruc"].ToString());
            }
            txtRUC.AutoCompleteCustomSource = lista;
        }
        //Puesto metodo aucompletar caja ruc
        private void Mantenimiento_de_Compra_Load(object sender, EventArgs e)
        {
            autocompletar();
        }
        //
        //
        //No usar
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
