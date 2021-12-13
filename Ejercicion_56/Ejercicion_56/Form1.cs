using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicion_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void abrir()
        {
            try
            {
                OpenFileDialog archivo = new OpenFileDialog();
                
                archivo.ShowDialog();
                archivo.FileName //
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
