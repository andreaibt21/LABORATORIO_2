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

namespace Formulario
{
    public partial class FormPpal : Form
    {

        private EjercitoImperial ejercitoImperial;
        public FormPpal()
        {
            ejercitoImperial = new EjercitoImperial(20);
            TrooperAsalto ta = new TrooperAsalto(Blaster.EC17);
            ejercitoImperial += ta;
            InitializeComponent();

        }
        private void FormPpal_Load(object sender, EventArgs e)
        {
            cmbBlaster.DataSource = Enum.GetValues(typeof(Blaster));
            RefrescarEjercito();
            cmbTipo.Items.Add("Arena");
            cmbTipo.Items.Add("Asalto"); 
            cmbTipo.Items.Add("Explorador");
        }

        /// <summary>
        /// Limpia la listBox y carga todos los los troopers del ejercitoImperial
        /// </summary>
       private void RefrescarEjercito()
        {
            listEjercito.Items.Clear();
            foreach (Trooper item in ejercitoImperial.Troopers)
            {
                listEjercito.Items.Add(item.infoTrooper());
            }

        }

        //CAMBIAR ESTOOOO
        private void btnAgregar_Click(object sender, EventArgs e)
        {

           
            Trooper trooperAuxiliar = null;
            if(cmbTipo.SelectedItem != null && cmbBlaster.SelectedItem != null)
            {
                switch (cmbTipo.Text)
                {
                    case "Arena":
                        trooperAuxiliar = new TrooperArena((Blaster)cmbBlaster.SelectedItem);
                        break;

                    case "Asalto":
                        trooperAuxiliar = new TrooperAsalto((Blaster)cmbBlaster.SelectedItem);                      
                        break;

                    case "Explorador":
                        if ((Blaster)cmbBlaster.SelectedItem != Blaster.EC17)
                        {
                            MessageBox.Show("Los Trooper de tipo Explorador solo\r\n pueden usar el blaster EC17.");
                        }
                        else
                        {
                            trooperAuxiliar = new TrooperExplorador("Moto");
                        }
                        break;

                }
                if (trooperAuxiliar is not null)
                {
                    trooperAuxiliar.EsClon = checkBoxEsClone.Checked;
                    this.ejercitoImperial += trooperAuxiliar;
                    RefrescarEjercito();

                }
               
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Trooper trooperAuxiliar = null;
            if (cmbTipo.Text != null)
            {
                switch (cmbTipo.Text)
                {
                    case "Arena":

                        trooperAuxiliar = new TrooperArena(Blaster.EC17);
                        break;

                    case "Asalto":
                        trooperAuxiliar = new TrooperAsalto(Blaster.E11);
                        break;

                    case "Explorador":
                        trooperAuxiliar = new TrooperExplorador("Moto");
                        break;
                }
                ejercitoImperial -= trooperAuxiliar;
                RefrescarEjercito();
            }

        }
    }
}