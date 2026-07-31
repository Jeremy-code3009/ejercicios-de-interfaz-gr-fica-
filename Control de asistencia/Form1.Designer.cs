namespace Control_de_asistencia
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
            this.lstEstudiantes = new System.Windows.Forms.ListBox();
            this.chkPresente = new System.Windows.Forms.CheckBox();
            this.btnResumen = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.chkAusente = new System.Windows.Forms.CheckBox();
            this.lstResumenAsistencia = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstEstudiantes
            // 
            this.lstEstudiantes.FormattingEnabled = true;
            this.lstEstudiantes.ItemHeight = 25;
            this.lstEstudiantes.Items.AddRange(new object[] {
            "Carlos Pérez",
            "María Rodríguez",
            "Juan Gómez",
            "Ana Martínez",
            "Jose Serano",
            "Mauricio Baez",
            "Nicauri Sanches",
            "Kendry Nayeli",
            "Yosmerkis Reyes",
            "Elena Mendes"});
            this.lstEstudiantes.Location = new System.Drawing.Point(41, 89);
            this.lstEstudiantes.Name = "lstEstudiantes";
            this.lstEstudiantes.Size = new System.Drawing.Size(177, 254);
            this.lstEstudiantes.TabIndex = 0;
            // 
            // chkPresente
            // 
            this.chkPresente.AutoSize = true;
            this.chkPresente.Location = new System.Drawing.Point(328, 22);
            this.chkPresente.Name = "chkPresente";
            this.chkPresente.Size = new System.Drawing.Size(130, 29);
            this.chkPresente.TabIndex = 1;
            this.chkPresente.Text = "Presente";
            this.chkPresente.UseVisualStyleBackColor = true;
            // 
            // btnResumen
            // 
            this.btnResumen.Location = new System.Drawing.Point(241, 307);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(194, 51);
            this.btnResumen.TabIndex = 2;
            this.btnResumen.Text = "Generar";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(286, 269);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(229, 25);
            this.lblResumen.TabIndex = 3;
            this.lblResumen.Text = "Resumen:                    \r\n";
            // 
            // chkAusente
            // 
            this.chkAusente.AutoSize = true;
            this.chkAusente.Location = new System.Drawing.Point(328, 79);
            this.chkAusente.Name = "chkAusente";
            this.chkAusente.Size = new System.Drawing.Size(123, 29);
            this.chkAusente.TabIndex = 4;
            this.chkAusente.Text = "Ausente";
            this.chkAusente.UseVisualStyleBackColor = true;
            // 
            // lstResumenAsistencia
            // 
            this.lstResumenAsistencia.FormattingEnabled = true;
            this.lstResumenAsistencia.ItemHeight = 25;
            this.lstResumenAsistencia.Location = new System.Drawing.Point(509, 89);
            this.lstResumenAsistencia.Name = "lstResumenAsistencia";
            this.lstResumenAsistencia.Size = new System.Drawing.Size(279, 254);
            this.lstResumenAsistencia.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResumenAsistencia);
            this.Controls.Add(this.chkAusente);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.btnResumen);
            this.Controls.Add(this.chkPresente);
            this.Controls.Add(this.lstEstudiantes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEstudiantes;
        private System.Windows.Forms.CheckBox chkPresente;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.CheckBox chkAusente;
        private System.Windows.Forms.ListBox lstResumenAsistencia;
    }
}

