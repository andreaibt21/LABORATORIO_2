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

namespace FormLiga
{
    public partial class Form_ManejoEntrenadores : Form
    {

        Liga miLiga;
        private bool esAlta;
        public Form_ManejoEntrenadores()
        {
            InitializeComponent();
        }
        public Form_ManejoEntrenadores(Liga liga, bool esAlta): this()
        {
            miLiga = liga;
            this.esAlta = esAlta;
        }
        private void lbl_Pokemones_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form_ManejoEntrenadores_Load(object sender, EventArgs e)
        {
            Liga ligaAuxiliar1 = miLiga;
            Liga ligaAuxiliar2 = miLiga;
            Liga ligaAuxiliar3 = miLiga;
            Liga ligaAuxiliar4 = miLiga;

            cmb_Entrenadores.DataSource = ligaAuxiliar1.Entrenadores.ToList();

            cmb_Islas.DataSource = Enum.GetValues(typeof(Islas));
            cmb_pokemon1.DataSource = miLiga.Pokemones.ToList();
            cmb_pokemon2.DataSource = ligaAuxiliar1.Pokemones.ToList();
            cmb_pokemon3.DataSource = ligaAuxiliar2.Pokemones.ToList();
            cmb_pokemon4.DataSource = ligaAuxiliar3.Pokemones.ToList();
            cmb_pokemon5.DataSource = ligaAuxiliar4.Pokemones.ToList();
            cmb_pokemon1.DisplayMember = "Especie";
            cmb_pokemon2.DisplayMember = "Especie";
            cmb_pokemon3.DisplayMember = "Especie";
            cmb_pokemon4.DisplayMember = "Especie";
            cmb_pokemon5.DisplayMember = "Especie";

            cmb_pokemon1.Enabled = true;
            cmb_pokemon2.Enabled = false;
            cmb_pokemon3.Enabled = false;
            cmb_pokemon4.Enabled = false;
            cmb_pokemon5.Enabled = false;
        }
     
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
                   
            try
            {
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                int edad; 
                int dni;
                int.TryParse(txt_edad.Text, out edad);
                int.TryParse(txt_edad.Text, out dni);
                int cantidadDePokebolas = (int)numUD_pokebolas.Value;
                bool Escampeon = checkB_EsCampeon.Checked;
                Islas isla =(Islas)cmb_Islas.SelectedItem;
                Pokemon pokemon1 = (Pokemon)cmb_pokemon1.SelectedItem;
                Pokemon pokemon2 = (Pokemon)cmb_pokemon2.SelectedItem;
                Pokemon pokemon3 = (Pokemon)cmb_pokemon3.SelectedItem;
                Pokemon pokemon4 = (Pokemon)cmb_pokemon3.SelectedItem;
                Pokemon pokemon5 = (Pokemon)cmb_pokemon3.SelectedItem;

                if (esAlta) 
                {
                    List<Pokemon> pokemonesSeleccionados = new List<Pokemon>();
            
                    switch (cantidadDePokebolas)
                    {
                        case 1:
                            pokemonesSeleccionados.Add(pokemon1);
                            break;
                        case 2:
                            pokemonesSeleccionados.Add(pokemon1);
                            pokemonesSeleccionados.Add(pokemon2);
                            break;
                        case 3:
                            pokemonesSeleccionados.Add(pokemon1);
                            pokemonesSeleccionados.Add(pokemon2);
                            pokemonesSeleccionados.Add(pokemon3);
                            break;
                        case 4:
                            pokemonesSeleccionados.Add(pokemon1);
                            pokemonesSeleccionados.Add(pokemon2);
                            pokemonesSeleccionados.Add(pokemon3);
                            pokemonesSeleccionados.Add(pokemon4);
                            pokemonesSeleccionados.Add(pokemon5);
                            break;
                        case 5:
                            pokemonesSeleccionados.Add(pokemon1);
                            pokemonesSeleccionados.Add(pokemon2);
                            pokemonesSeleccionados.Add(pokemon3);
                            pokemonesSeleccionados.Add(pokemon4);
                            pokemonesSeleccionados.Add(pokemon5);

                            break;
                    }
                   

                    Entrenador entrenador = new Entrenador( dni, 
                                                            nombre, 
                                                            apellido,
                                                            edad, 
                                                            cantidadDePokebolas, 
                                                            Escampeon, 
                                                            isla, 
                                                            pokemonesSeleccionados);
                    miLiga += entrenador;
                
                MessageBox.Show($"Entrenador inscripto exitosamente con los siguientes datos: \n\n {entrenador.ToString()} ");
                }
                else
                {
                    Entrenador entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;

                    entrenadorAuxiliar.Nombre = nombre;
                    entrenadorAuxiliar.Apellido = apellido;
                    entrenadorAuxiliar.Edad = edad;
                    entrenadorAuxiliar.Dni = dni;
                    entrenadorAuxiliar.CantidadDePokebolas = cantidadDePokebolas;
                    entrenadorAuxiliar.Campeon = Escampeon;
                    entrenadorAuxiliar.Isla = isla;
                    cmb_pokemon1.SelectedItem = entrenadorAuxiliar.Pokemones[0];
                    cmb_pokemon1.SelectedItem = entrenadorAuxiliar.Pokemones[1];
                    cmb_pokemon1.SelectedItem = entrenadorAuxiliar.Pokemones[2];
                    cmb_pokemon1.SelectedItem = entrenadorAuxiliar.Pokemones[3];
                    cmb_pokemon1.SelectedItem = entrenadorAuxiliar.Pokemones[4];

                }



            }
            catch (Exception ex)
            {


            }
        }

        private void numUD_pokebolas_ValueChanged(object sender, EventArgs e)
        {
            switch ((int)numUD_pokebolas.Value)
            {
                case 1:
                    cmb_pokemon1.Enabled = true;
                    cmb_pokemon2.Enabled = false;
                    cmb_pokemon3.Enabled = false;
                    cmb_pokemon4.Enabled = false;
                    cmb_pokemon5.Enabled = false;
                break;
                case 2:
                    cmb_pokemon1.Enabled = true;
                    cmb_pokemon2.Enabled = true;
                    cmb_pokemon3.Enabled = false;
                    cmb_pokemon4.Enabled = false;
                    cmb_pokemon5.Enabled = false;

                    break;
                case 3:
                    cmb_pokemon1.Enabled = true;
                    cmb_pokemon2.Enabled = true;
                    cmb_pokemon3.Enabled = true;
                    cmb_pokemon4.Enabled = false;
                    cmb_pokemon5.Enabled = false;
                    break;
                case 4:
                    cmb_pokemon1.Enabled = true;
                    cmb_pokemon2.Enabled = true;
                    cmb_pokemon3.Enabled = true;
                    cmb_pokemon4.Enabled = true;
                    cmb_pokemon5.Enabled = false;
                    break;
                case 5:
                    cmb_pokemon1.Enabled = true;
                    cmb_pokemon2.Enabled = true;
                    cmb_pokemon3.Enabled = true;
                    cmb_pokemon4.Enabled = true;
                    cmb_pokemon5.Enabled = true;
                    break;
            }

        }
        private void cmb_pokemon1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_pokemon2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cmb_pokemon3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Entrenadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmb_TipoEdicion.SelectedItem == ) 
            //{
            //}
            Entrenador entrenadorAuxiliar = (Entrenador)cmb_Entrenadores.SelectedItem;

            txt_dni.Enabled = false;
            txt_dni.Text = entrenadorAuxiliar.Dni.ToString(); 
            txt_nombre.Text = entrenadorAuxiliar.Nombre;
            txt_apellido.Text = entrenadorAuxiliar.Apellido;           
            txt_edad.Text = entrenadorAuxiliar.Edad.ToString();
            numUD_pokebolas.Value = entrenadorAuxiliar.CantidadDePokebolas;
            checkB_EsCampeon.Checked = entrenadorAuxiliar.Campeon;
            cmb_pokemon1.SelectedItem = entrenadorAuxiliar.Pokemones[0];
            cmb_pokemon2.SelectedItem = entrenadorAuxiliar.Pokemones[1];
            //cmb_pokemon3.SelectedItem = entrenadorAuxiliar.Pokemones[2];
            //cmb_pokemon4.SelectedItem = entrenadorAuxiliar.Pokemones[3];
            //cmb_pokemon5.SelectedItem = entrenadorAuxiliar.Pokemones[4];
        }
    }
}
