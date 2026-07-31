using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_asistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {


            if (lstEstudiantes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un estudiante de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string estudianteSeleccionado = lstEstudiantes.SelectedItem.ToString();
            string estadoAsistencia = "No especificado";

            if (chkPresente.Checked)
            {
                estadoAsistencia = "Presente";
            }
            else if (chkAusente.Checked)
            {
                estadoAsistencia = "Ausente";
            }

           
            string registroAsistencia = $"{estudianteSeleccionado} - {estadoAsistencia}";

           
            lstResumenAsistencia.Items.Add(registroAsistencia);
        }

        
    }
}
