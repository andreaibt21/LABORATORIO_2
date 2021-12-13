using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SimuladorForm
{
    public partial class SimuladorForm : Form
    {
        private Microrganismo miMicrorganismo;
        CancellationTokenSource source;
        CancellationToken token;
        Task t1;
        public SimuladorForm()
        {

            InitializeComponent();
        }
        private void SimuladorForm_Load(object sender, EventArgs e)
        {
            cmbMicroorganismo.SelectedIndex = 0;
            this.source = new CancellationTokenSource();
            this.token = source.Token;
        }
        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (cmbMicroorganismo.SelectedIndex == 0)
            {
                miMicrorganismo = new Covid19("Covid-19");
            }
            else
            {
                miMicrorganismo = new Gripe("Gripe", Microrganismo.ETipo.Virus, Microrganismo.EContagiosidad.Moderada);
            }

            txtEvolucion.Text += miMicrorganismo.Informe();
            //1   Guardo en un delegado de la clase el metodo del formulario imprimir avance
            GrupoDePrueba<Microrganismo>.delAvanceInfectados = imprimirInformeAvance;
          
            //2   Guardo el delegado anterior en un evento de la clase
            GrupoDePrueba<Microrganismo>.InformeDeAvance += GrupoDePrueba<Microrganismo>.delAvanceInfectados;
            
            //1  Guardo en un delegado de la clase el metodo del formulario informar fin infeccion
            GrupoDePrueba<Microrganismo>.delFinInfectacion = informarFinInfectacion;
            
            //2 Guardo el delegado anterior en un evento de la clase
            GrupoDePrueba<Microrganismo>.FinalizaSimulacion += GrupoDePrueba<Microrganismo>.delFinInfectacion;
            
            //Corro en un hilo secundario el metodo para iniciar la simulacion
             t1 = Task.Run(() => GrupoDePrueba<Microrganismo>.InfectarPoblacion(miMicrorganismo));


        }
        //EMPEZAR POR ACÁ 
        private void imprimirInformeAvance(int dias, long infectados)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Dia {dias}: {infectados} de la poblacion total");
            if (txtEvolucion.InvokeRequired)
            {
                //pides acceso al principal
                this.txtEvolucion.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.txtEvolucion.Text += sb.ToString();
                } );
            }
            else
            {
                txtEvolucion.Text += sb.ToString();
            }
           
        }

        private void informarFinInfectacion()
        {
            if (txtEvolucion.InvokeRequired)
            {
                this.txtEvolucion.BeginInvoke((MethodInvoker)delegate ()
                {
                    this.txtEvolucion.Text += "Toda la poblacion fue infectada!";
                }
                );
            }
            else
            {
                txtEvolucion.Text += "Toda la poblacion fue infectada!";
            }
                this.source.Cancel();

        }

        private void SimuladorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.t1 != null && !this.t1.IsCompleted)
            {
                this.source.Cancel();
            }

        }

        private void lblPoblacion_Click(object sender, EventArgs e)
        {

        }

     
    } 
}
