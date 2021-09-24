using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;
namespace WinFormsApp1
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

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double auxiliar;
            if (!double.TryParse(textEuroIngresado.Text, out auxiliar))
            {
                MessageBox.Show("Error, intente nuevamente");
            }
            else {

                Euro EuroIngresado = auxiliar;
                Pesos pesosConvertidos = (Pesos)EuroIngresado;
                //textBox13
                textBox13.Text = pesosConvertidos.GetCantidad().ToString();



                MessageBox.Show($"Euros {EuroIngresado.GetCantidad()} a pesos: {pesosConvertidos.GetCantidad()}");


            }
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {

            if (btnLockCotizacion.ImageIndex == 1)
            {
                btnLockCotizacion.ImageIndex = 0;
            }
            else {
                btnLockCotizacion.ImageIndex = 1;
            }
        }
    }
}
