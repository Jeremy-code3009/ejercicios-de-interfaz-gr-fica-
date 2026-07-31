using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversor_de_unidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
         
          
            if (!double.TryParse(txtValor.Text, out double valorIngresado))
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = 0;
            string unidadFinal = "";

          
            if (rbKmAMillas.Checked)
            {
                resultado = valorIngresado * 0.621371;
                unidadFinal = "Millas";
            }
            else if (rbMillasAKm.Checked)
            {
                resultado = valorIngresado / 0.621371;
                unidadFinal = "Kilómetros";
            }
            else if (rbCelsiusAFahrenheit.Checked)
            {
                resultado = (valorIngresado * 9 / 5) + 32;
                unidadFinal = "°F";
            }
            else if (rbFahrenheitACelsius.Checked)
            {
                resultado = (valorIngresado - 32) * 5 / 9;
                unidadFinal = "°C";
            }
            else
            {
                MessageBox.Show("Debe seleccionar una opción de conversión.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

          
            lblResultado.Text = $"Resultado: {resultado.ToString("N2")} {unidadFinal}";
        }
        }
    }

