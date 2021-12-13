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
    public partial class FormManejadorAlumnos : Form
    {
        private Alumno alumno;
        private bool alta;

        public FormManejadorAlumnos() // uso para crear de 0 
        {
            InitializeComponent();
            alta = true;
        }

        public FormManejadorAlumnos(Alumno auxAlumnoAModificar) : this() // uso para modificar
        {
            alumno = auxAlumnoAModificar;
            alta = false;
        }


        public Alumno AlumnoCreado
        {
            get
            {
                return alumno;
            }
        }




        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {


                if (alta)
                {
                    alumno = new Alumno(this.tbx_dni.Text,
                                            this.txt_nombre.Text,
                                            this.txt_direccion.Text);
                }
                else
                {
                    alumno.Direccion = this.txt_direccion.Text;
                    alumno.Nombre = this.txt_nombre.Text;
                }


                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

             
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;

        }

        private void FormManejadorAlumnos_Load(object sender, EventArgs e)
        {

            if (alumno is null)
            {
                this.Text = "Alta de Alumno";
                this.btn_ok.Text = "Guardar Alumno";
            }
            else
            {
                this.Text = "Modificacion de Alumno";
                this.tbx_dni.Enabled = false;

                this.btn_ok.Text = "Modificar Alumno";

                this.tbx_dni.Text = alumno.DNI;
                this.txt_direccion.Text = alumno.Direccion;
                this.txt_nombre.Text = alumno.Nombre;

            }

            //private void ActualizarCmb(Pokemon pokemon)
            //{
            //    List<Pokemon> diferente = new List<Pokemon>();
            //    foreach (Pokemon item in miLiga.Pokemones)
            //    {
            //        if (!miLiga.Pokemones.Exists((x) => item == x))
            //        {
            //            diferente.Add(item);
            //        }
            //    }
            //    cmb_pokemon1.DataSource = null;
            //    cmb_pokemon1.DataSource = diferente;
            //}
        }
    }
}
