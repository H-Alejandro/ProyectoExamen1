using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoExamen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int limite = 0, suma = 0;

            limite = int.Parse(this.txtLimite.Text);
            suma = Clases.Examen.sumatoria(limite);
            this.txtSumatoria.Text = suma.ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
