using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01_delegado
{
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegados frmTestDelegados;
        private FrmMostrar frmMostrar;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se asignará una instancia de FrmMostrar a un atributo de la clase.
        /// El MdiParent de dicha instancia será FrmPrincipal.
        /// Se asignará una instancia de FrmTestDelegados a un atributo de la clase.
        /// El MdiParent de dicha instancia será FrmPrincipal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados.Show();
            motrarToolStripMenuItem.Enabled = true;



        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}
