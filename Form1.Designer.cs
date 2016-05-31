namespace COPYPRO
{
    partial class FormularioOpaco
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.btnExportarTXT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(713, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 36);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Location = new System.Drawing.Point(632, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 36);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(250, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 47);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "C O P Y P R O 2016";
            // 
            // txtCaja
            // 
            this.txtCaja.AcceptsReturn = true;
            this.txtCaja.AcceptsTab = true;
            this.txtCaja.AllowDrop = true;
            this.txtCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.txtCaja.ForeColor = System.Drawing.Color.White;
            this.txtCaja.Location = new System.Drawing.Point(51, 126);
            this.txtCaja.Multiline = true;
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCaja.Size = new System.Drawing.Size(700, 432);
            this.txtCaja.TabIndex = 3;
            this.txtCaja.Text = "Escriba aquí...";
            // 
            // btnExportarTXT
            // 
            this.btnExportarTXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarTXT.Location = new System.Drawing.Point(51, 84);
            this.btnExportarTXT.Name = "btnExportarTXT";
            this.btnExportarTXT.Size = new System.Drawing.Size(141, 36);
            this.btnExportarTXT.TabIndex = 4;
            this.btnExportarTXT.Text = "Exportar a txt...";
            this.btnExportarTXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarTXT.UseVisualStyleBackColor = true;
            this.btnExportarTXT.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioOpaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(45)))), ((int)(((byte)(168)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnExportarTXT);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSalir);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "FormularioOpaco";
            this.Opacity = 0.6D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COPYPRO Escribe sin limites v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Button btnExportarTXT;
    }
}

