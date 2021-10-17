using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class FormCarga : Form
    {
        public FormCarga()
        {
            InitializeComponent();
        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            if (comboBoxTipo.SelectedIndex == 0)
            {
                lblInscripcion.Visible = false;
                textInscripcion.Visible = false;
                textSueldo.Visible = true;
                lblSueldo.Visible = true;
                textAntiguedad.Visible = true;
                lblAntiguedad.Visible = true;
                checkBoxEsSoloDocente.Visible = true;
            }
            else {
                lblInscripcion.Visible = true;
                textInscripcion.Visible = true;
                textSueldo.Visible = false;
                lblSueldo.Visible = false;
                textAntiguedad.Visible = false;
                lblAntiguedad.Visible = false;
                checkBoxEsSoloDocente.Visible = false;
            }
        }

        private void FormCarga_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            lblInscripcion.Visible = false;
            textInscripcion.Visible = false;
            textSueldo.Visible = false;
            lblSueldo.Visible = false;
            textAntiguedad.Visible = false;
            lblAntiguedad.Visible = false;
            checkBoxEsSoloDocente.Visible = false;

        }
    }
}
