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
    public partial class FrmTestDelegados : Form
    {
        //private FrmMostrar frmMostrar;
        //private FrmPrincipal frmPrincipal;
        //public FrmTestDelegados()
        //{
        //    InitializeComponent();
        //}
        /*
            Se deberá utilizar un delegado dentro de FrmTestDelegados,
            convenientemente diseñado, a fin de cumplir este punto.
            El delegado deberá ser invocado (método Invoke) al presionar el btnActualizar.
            Al instanciar FrmTestDelegados se deberá asociar el delegado al método ActualizarNombre de FrmMostrar.*/

        public delegate void ActuralizarNombreDelegate(String nombre);
        private ActuralizarNombreDelegate acturalizarNombreDelegate;

        public FrmTestDelegados(ActuralizarNombreDelegate acturalizarNombreDelegate) 
        {
            this.acturalizarNombreDelegate = acturalizarNombreDelegate;
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            acturalizarNombreDelegate.Invoke(txtNombre.Text);

        }
    }
}
