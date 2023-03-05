using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrjBDCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //registro RUC
        private void RegistroRuc_Click(object sender, EventArgs e)
        {
            Registro_de_Ruc ventana = new Registro_de_Ruc();
            ventana.Show();

            //para cerrar la ventana anterior
            //usar este codigo
            //this.Hide();
        }
        //mantenimiento RUC
        private void btnMantenimientoRUC_Click(object sender, EventArgs e)
        {
            Mantenimiento_RUC ventana = new Mantenimiento_RUC();
            ventana.Show();
        }
        //registro compra
        private void RegistroCompra_Click(object sender, EventArgs e)
        {
            Registro_de_Compra ventana = new Registro_de_Compra();
            ventana.Show();
        }
        //mantenimiento compra
        private void btnMantenimientoCompra_Click(object sender, EventArgs e)
        {
            Mantenimiento_de_Compra ventana = new Mantenimiento_de_Compra();
            ventana.Show();
        }
        //Generar Reporte compra
        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tener en cuenta que solo se deben exportar registro con estado NO");
            Generar_reporte_Excel ventana = new Generar_reporte_Excel();
            ventana.Show();
        }
        //Modificar el estado de compra
        private void btnModificarEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tener en cuenta que solo se deben modificar los estados de registros ya exportados");

            Modificar_Estado_de_Registro ventana = new Modificar_Estado_de_Registro();
            ventana.Show();
        }
        //Modificar el Verificacion de Compra
        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            Verificacion_de_Compra ventana = new Verificacion_de_Compra();
            ventana.Show();
        }
        //Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login ventana = new Login();
            ventana.Show();
            this.Hide();
        }
    }
}
