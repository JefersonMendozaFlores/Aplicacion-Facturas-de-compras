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
    public partial class Generar_reporte_Excel : Form
    {
        DataTable tb = new DataTable();
        string cadenaBD = ConfigurationManager.ConnectionStrings["CadenaBD"].ConnectionString;

        public Generar_reporte_Excel()
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


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(cadenaBD);
            //
            SqlCommand cmd = new SqlCommand("Mostrar_Para_exportar @estado", cnn);
            cmd.Parameters.AddWithValue("@estado", txtEstado.Text);
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
                dgvEstado.DataSource = tb;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDatos(dgvEstado);
        }
        //metodo para exportar excel
        public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarExcel = new Microsoft.Office.Interop.Excel.Application();

            exportarExcel.Application.Workbooks.Add(true);

            int indicecolumna = 0;

            foreach(DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolumna++;

                exportarExcel.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 0;
            foreach(DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;
                foreach(DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarExcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }
        //validacion
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
