namespace conversor_de_unidades
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.rbKmAMillas = new System.Windows.Forms.RadioButton();
            this.rbMillasAKm = new System.Windows.Forms.RadioButton();
            this.rbCelsiusAFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbFahrenheitACelsius = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(297, 49);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(164, 31);
            this.txtValor.TabIndex = 0;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbKmAMillas
            // 
            this.rbKmAMillas.AutoSize = true;
            this.rbKmAMillas.Location = new System.Drawing.Point(61, 150);
            this.rbKmAMillas.Name = "rbKmAMillas";
            this.rbKmAMillas.Size = new System.Drawing.Size(154, 29);
            this.rbKmAMillas.TabIndex = 1;
            this.rbKmAMillas.TabStop = true;
            this.rbKmAMillas.Text = "Km a Millas";
            this.rbKmAMillas.UseVisualStyleBackColor = true;
            // 
            // rbMillasAKm
            // 
            this.rbMillasAKm.AutoSize = true;
            this.rbMillasAKm.Location = new System.Drawing.Point(507, 150);
            this.rbMillasAKm.Name = "rbMillasAKm";
            this.rbMillasAKm.Size = new System.Drawing.Size(224, 29);
            this.rbMillasAKm.TabIndex = 2;
            this.rbMillasAKm.TabStop = true;
            this.rbMillasAKm.Text = "Millas a Kilómetros";
            this.rbMillasAKm.UseVisualStyleBackColor = true;
            this.rbMillasAKm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbCelsiusAFahrenheit
            // 
            this.rbCelsiusAFahrenheit.AutoSize = true;
            this.rbCelsiusAFahrenheit.Location = new System.Drawing.Point(61, 248);
            this.rbCelsiusAFahrenheit.Name = "rbCelsiusAFahrenheit";
            this.rbCelsiusAFahrenheit.Size = new System.Drawing.Size(111, 29);
            this.rbCelsiusAFahrenheit.TabIndex = 3;
            this.rbCelsiusAFahrenheit.TabStop = true;
            this.rbCelsiusAFahrenheit.Text = "°C a °F";
            this.rbCelsiusAFahrenheit.UseVisualStyleBackColor = true;
            // 
            // rbFahrenheitACelsius
            // 
            this.rbFahrenheitACelsius.AutoSize = true;
            this.rbFahrenheitACelsius.BackColor = System.Drawing.SystemColors.Control;
            this.rbFahrenheitACelsius.Location = new System.Drawing.Point(507, 248);
            this.rbFahrenheitACelsius.Name = "rbFahrenheitACelsius";
            this.rbFahrenheitACelsius.Size = new System.Drawing.Size(111, 29);
            this.rbFahrenheitACelsius.TabIndex = 4;
            this.rbFahrenheitACelsius.TabStop = true;
            this.rbFahrenheitACelsius.Text = "°F a °C";
            this.rbFahrenheitACelsius.UseVisualStyleBackColor = false;
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConvertir.Location = new System.Drawing.Point(271, 386);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(190, 52);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(47, 322);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(115, 25);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.rbFahrenheitACelsius);
            this.Controls.Add(this.rbCelsiusAFahrenheit);
            this.Controls.Add(this.rbMillasAKm);
            this.Controls.Add(this.rbKmAMillas);
            this.Controls.Add(this.txtValor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.RadioButton rbKmAMillas;
        private System.Windows.Forms.RadioButton rbMillasAKm;
        private System.Windows.Forms.RadioButton rbCelsiusAFahrenheit;
        private System.Windows.Forms.RadioButton rbFahrenheitACelsius;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}

