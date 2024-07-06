namespace videogames
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCrear = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvJuegosRegistrados = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPuntajeAcumulado = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSeleccionarJuego = new System.Windows.Forms.ComboBox();
            this.btnJugar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crear VideoJuego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreCrear
            // 
            this.txtNombreCrear.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCrear.Location = new System.Drawing.Point(142, 215);
            this.txtNombreCrear.Name = "txtNombreCrear";
            this.txtNombreCrear.Size = new System.Drawing.Size(198, 40);
            this.txtNombreCrear.TabIndex = 5;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(172, 293);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(144, 42);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(635, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 33);
            this.label5.TabIndex = 11;
            this.label5.Text = "Juegos Registrados";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dgvJuegosRegistrados
            // 
            this.dgvJuegosRegistrados.AllowUserToAddRows = false;
            this.dgvJuegosRegistrados.AllowUserToDeleteRows = false;
            this.dgvJuegosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegosRegistrados.Location = new System.Drawing.Point(472, 132);
            this.dgvJuegosRegistrados.Name = "dgvJuegosRegistrados";
            this.dgvJuegosRegistrados.ShowEditingIcon = false;
            this.dgvJuegosRegistrados.Size = new System.Drawing.Size(546, 480);
            this.dgvJuegosRegistrados.TabIndex = 10;
            this.dgvJuegosRegistrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dueno_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1339, 847);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total de Puntaje Acumulado";
            // 
            // txtPuntajeAcumulado
            // 
            this.txtPuntajeAcumulado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuntajeAcumulado.Location = new System.Drawing.Point(1665, 847);
            this.txtPuntajeAcumulado.Name = "txtPuntajeAcumulado";
            this.txtPuntajeAcumulado.ReadOnly = true;
            this.txtPuntajeAcumulado.Size = new System.Drawing.Size(198, 40);
            this.txtPuntajeAcumulado.TabIndex = 14;
            // 
            // btnExportar
            // 
            this.btnExportar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(1665, 913);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(198, 42);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1480, 918);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Reporte Word";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1360, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Seleccionar Juego";
            // 
            // cbSeleccionarJuego
            // 
            this.cbSeleccionarJuego.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSeleccionarJuego.FormattingEnabled = true;
            this.cbSeleccionarJuego.Location = new System.Drawing.Point(1366, 135);
            this.cbSeleccionarJuego.Name = "cbSeleccionarJuego";
            this.cbSeleccionarJuego.Size = new System.Drawing.Size(187, 34);
            this.cbSeleccionarJuego.TabIndex = 23;
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(1366, 209);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(198, 42);
            this.btnJugar.TabIndex = 24;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.cbSeleccionarJuego);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.txtPuntajeAcumulado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvJuegosRegistrados);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtNombreCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegosRegistrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreCrear;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvJuegosRegistrados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPuntajeAcumulado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSeleccionarJuego;
        private System.Windows.Forms.Button btnJugar;
    }
}

