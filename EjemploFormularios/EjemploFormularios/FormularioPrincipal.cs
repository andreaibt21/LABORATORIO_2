using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace EjemploFormularios
{
    public partial class FormularioPrincipal : Form
    {
        string mensaje;
        List<Alumno> alumnado;

        public FormularioPrincipal()
        {
            InitializeComponent();
            alumnado = new List<Alumno>();
            alumnado.Add(new Alumno("123123", "pepe peposo", "calle guau guau 123"));

        }

        public FormularioPrincipal(string auxMensaje) : this()
        {
            this.mensaje = auxMensaje;
        }

        private void btn_mensaje_Click(object sender, EventArgs e)
        {

            FormManejadorAlumnos alta = new FormManejadorAlumnos();
            alta.Show();

        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {



        }
        /// <summary>
        /// crear alumno de 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_dialog_Click(object sender, EventArgs e)
        {

            FormManejadorAlumnos alta2 = new FormManejadorAlumnos();
            DialogResult miResultado = alta2.ShowDialog();

            if (miResultado == DialogResult.OK)
            {
                MessageBox.Show("ALUMNO CONFIRMADO");
                alumnado.Add(alta2.AlumnoCreado);
            }
            else
            {
                MessageBox.Show("ALUMNO CANCELADO");
            }

            MessageBox.Show(alumnado.Count.ToString());
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Alumno alumnoAModificar = alumnado[0];

            string alumnoAnterior = alumnoAModificar.ToString();

            FormManejadorAlumnos instanciaModificacion = new FormManejadorAlumnos(alumnoAModificar);
            
            if(instanciaModificacion.ShowDialog() == DialogResult.OK)
            {

                MessageBox.Show("ALUMNO MODIFICADO");

                MessageBox.Show(alumnoAnterior + "\n" + alumnoAModificar.ToString());

            }


        }
    }
}
