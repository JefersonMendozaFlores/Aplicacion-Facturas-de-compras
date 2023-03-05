namespace PrjBDCompras
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RegistroRuc = new System.Windows.Forms.Button();
            this.RegistroCompra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModificarEstado = new System.Windows.Forms.Button();
            this.ExportarExcel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMantenimientoCompra = new System.Windows.Forms.Button();
            this.btnMantenimientoRUC = new System.Windows.Forms.Button();
            this.btnBuscarCompra = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 63);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Principal";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.RegistroRuc);
            this.groupBox1.Controls.Add(this.RegistroCompra);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registros";
            // 
            // RegistroRuc
            // 
            this.RegistroRuc.BackColor = System.Drawing.Color.CadetBlue;
            this.RegistroRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroRuc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegistroRuc.Location = new System.Drawing.Point(172, 36);
            this.RegistroRuc.Name = "RegistroRuc";
            this.RegistroRuc.Size = new System.Drawing.Size(169, 59);
            this.RegistroRuc.TabIndex = 1;
            this.RegistroRuc.Text = "Ir al Registro Ruc";
            this.RegistroRuc.UseVisualStyleBackColor = false;
            this.RegistroRuc.Click += new System.EventHandler(this.RegistroRuc_Click);
            // 
            // RegistroCompra
            // 
            this.RegistroCompra.BackColor = System.Drawing.Color.CadetBlue;
            this.RegistroCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RegistroCompra.Location = new System.Drawing.Point(6, 36);
            this.RegistroCompra.Name = "RegistroCompra";
            this.RegistroCompra.Size = new System.Drawing.Size(145, 59);
            this.RegistroCompra.TabIndex = 0;
            this.RegistroCompra.Text = "Ir al Registrar Comprar";
            this.RegistroCompra.UseVisualStyleBackColor = false;
            this.RegistroCompra.Click += new System.EventHandler(this.RegistroCompra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Controls.Add(this.btnModificarEstado);
            this.groupBox2.Controls.Add(this.ExportarExcel);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 12.75F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generar Reporte del Registro";
            // 
            // btnModificarEstado
            // 
            this.btnModificarEstado.BackColor = System.Drawing.Color.CadetBlue;
            this.btnModificarEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarEstado.Location = new System.Drawing.Point(172, 36);
            this.btnModificarEstado.Name = "btnModificarEstado";
            this.btnModificarEstado.Size = new System.Drawing.Size(169, 59);
            this.btnModificarEstado.TabIndex = 1;
            this.btnModificarEstado.Text = "Modificar Estado de Compra";
            this.btnModificarEstado.UseVisualStyleBackColor = false;
            this.btnModificarEstado.Click += new System.EventHandler(this.btnModificarEstado_Click);
            // 
            // ExportarExcel
            // 
            this.ExportarExcel.BackColor = System.Drawing.Color.CadetBlue;
            this.ExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarExcel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ExportarExcel.Location = new System.Drawing.Point(6, 36);
            this.ExportarExcel.Name = "ExportarExcel";
            this.ExportarExcel.Size = new System.Drawing.Size(145, 59);
            this.ExportarExcel.TabIndex = 0;
            this.ExportarExcel.Text = "Ir al Exportar en Excel";
            this.ExportarExcel.UseVisualStyleBackColor = false;
            this.ExportarExcel.Click += new System.EventHandler(this.ExportarExcel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Controls.Add(this.btnMantenimientoCompra);
            this.groupBox3.Controls.Add(this.btnMantenimientoRUC);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 12.75F);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(406, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 123);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mantenimiento";
            // 
            // btnMantenimientoCompra
            // 
            this.btnMantenimientoCompra.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMantenimientoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMantenimientoCompra.Location = new System.Drawing.Point(177, 36);
            this.btnMantenimientoCompra.Name = "btnMantenimientoCompra";
            this.btnMantenimientoCompra.Size = new System.Drawing.Size(164, 58);
            this.btnMantenimientoCompra.TabIndex = 1;
            this.btnMantenimientoCompra.Text = "Ir al Mantenimiento Compra";
            this.btnMantenimientoCompra.UseVisualStyleBackColor = false;
            this.btnMantenimientoCompra.Click += new System.EventHandler(this.btnMantenimientoCompra_Click);
            // 
            // btnMantenimientoRUC
            // 
            this.btnMantenimientoRUC.BackColor = System.Drawing.Color.CadetBlue;
            this.btnMantenimientoRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoRUC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMantenimientoRUC.Location = new System.Drawing.Point(16, 36);
            this.btnMantenimientoRUC.Name = "btnMantenimientoRUC";
            this.btnMantenimientoRUC.Size = new System.Drawing.Size(155, 58);
            this.btnMantenimientoRUC.TabIndex = 0;
            this.btnMantenimientoRUC.Text = "Ir al Mantenimiento RUC";
            this.btnMantenimientoRUC.UseVisualStyleBackColor = false;
            this.btnMantenimientoRUC.Click += new System.EventHandler(this.btnMantenimientoRUC_Click);
            // 
            // btnBuscarCompra
            // 
            this.btnBuscarCompra.BackColor = System.Drawing.Color.CadetBlue;
            this.btnBuscarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscarCompra.Location = new System.Drawing.Point(20, 36);
            this.btnBuscarCompra.Name = "btnBuscarCompra";
            this.btnBuscarCompra.Size = new System.Drawing.Size(155, 59);
            this.btnBuscarCompra.TabIndex = 2;
            this.btnBuscarCompra.Text = "Buscar Compra";
            this.btnBuscarCompra.UseVisualStyleBackColor = false;
            this.btnBuscarCompra.Click += new System.EventHandler(this.btnBuscarCompra_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Controls.Add(this.btnBuscarCompra);
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 12.75F);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(402, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(362, 124);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Verificacion de Compra";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(346, 362);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(776, 398);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RegistroCompra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ExportarExcel;
        private System.Windows.Forms.Button RegistroRuc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMantenimientoCompra;
        private System.Windows.Forms.Button btnMantenimientoRUC;
        private System.Windows.Forms.Button btnModificarEstado;
        private System.Windows.Forms.Button btnBuscarCompra;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSalir;
    }
}

