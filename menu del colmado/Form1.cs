using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_del_colmado
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
          
            if (cmbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida (número mayor a cero).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal precio = 0;

            switch (cmbProductos.SelectedIndex)
            {
                case 0:
                    precio = 40m; 
                    break;
                case 1:
                    precio = 150m; 
                    break;
                case 2:
                    precio = 60m; 
                    break;
                case 3:
                    precio = 200m; 
                    break;
                case 4:
                    precio = 30m; 
                    break;
                case 5:
                    precio = 180m; 
                    break;
                case 6:
                    precio = 10m; 
                    break;
            }

            
            decimal total = precio * cantidad;

            
            string formaPago = "";
            if (rbEfectivo.Checked)
            {
                formaPago = "Efectivo";
            }
            else if (rbTarjeta.Checked)
            {
                formaPago = "Tarjeta";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una forma de pago.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            lblTotal.Text = $"Total a Pagar: RD$ {total.ToString("N2")} (Pago con {formaPago})";
        }

    }
    }

