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


namespace PrjBDCompras
{
    public partial class Mantenimiento_RUC : Form
    {
        //cadena
        //ojo la referencia tuvo que ser agregada manualmente
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString);
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;
        DataTable tb = new DataTable();
        //trae los registros de la tabla RUC
        DataTable RUC()
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            SqlDataAdapter da = new SqlDataAdapter("select * from Tabla_Ruc", cn);

            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        //Columnas resividas de la tabla RUC
        public Mantenimiento_RUC()
        {
            InitializeComponent();
            tb.Columns.Add("ruc");
            tb.Columns.Add("razonSocial");
            //
            dgvRUC.DataSource = RUC();
            //
  
        }
        //boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cadenaBD);
            //
            SqlCommand cmd = new SqlCommand("buscar_ruc @ruc", cnn);
            cmd.Parameters.AddWithValue("@ruc", txtRUCact.Text);
            //
            cnn.Open();
            //
            SqlDataReader dr = cmd.ExecuteReader();
            tb.Rows.Clear();
            while (dr.Read())
            {
                DataRow fila = tb.NewRow();
                fila[0] = dr.GetString(0);
                fila[1] = dr.GetString(1);
                tb.Rows.Add(fila);
            }
            dgvRUC.DataSource = tb;
        }      
        //boton actualizar
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(cadenaBD);
            try
            {
                //
                SqlCommand cmd = new SqlCommand("actualizar_ruc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rucAct", txtRUCact.Text);
                cmd.Parameters.AddWithValue("@rucNue", txtRUCnue.Text);
                cmd.Parameters.AddWithValue("@razonSocial", txtRazonSocial.Text);
                //
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show($"Se ha actualizado {i} RUC");

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { cn.Close(); }
            dgvRUC.DataSource = RUC();
        }
        //boton eliminar 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Eliminar_ruc", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ruc", txtRUCact.Text);
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
            dgvRUC.DataSource = RUC();
        }
        //Permitira ver los datos de la compra en las cajas 
        private void dgvRUC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow f = dgvRUC.CurrentRow;
            txtRUCact.Text = f.Cells[0].Value.ToString();
            txtRazonSocial.Text = f.Cells[1].Value.ToString();
        }
        //Validacion
        private void txtRUCact_Validated(object sender, EventArgs e)
        {
            if (txtRUCact.Text.Trim() == "")
            {
                epError.SetError(txtRUCact, "El campo RUC debe ser llenado");
                txtRUCact.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        //Completar caja texto
        DataTable datos = new DataTable();
        void autocompletar()
        {
            AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM Tabla_Ruc", cn);
            adaptador.Fill(datos);
            //
            for(int i = 0; i < datos.Rows.Count; i++)
            {
                lista.Add(datos.Rows[i]["ruc"].ToString());
            }
            txtRUCact.AutoCompleteCustomSource = lista;
        }
        //no usar
        private void Mantenimiento_RUC_Load(object sender, EventArgs e)
        {
            //SqlConnection cnn = new SqlConnection(cadenaBD);
            //SqlDataAdapter da = new SqlDataAdapter("select * from Tabla_Ruc", cnn);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dgvRUC.DataSource = dt;
            autocompletar();
        }
    }
}
