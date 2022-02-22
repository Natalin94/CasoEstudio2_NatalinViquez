using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoEstudio_NatalinViquez
{
    public partial class Calculadora : Form
    {
        private Funciones calculadora;
        private string operation;

        public Calculadora()
        {
            this.calculadora = new Funciones();
            InitializeComponent();
        }

        private void limpiar()
        {
            if (txtResultado.Text == "Error" )
            {
                txtResultado.Text = "";
            }
        }

        private void botonNum5_Click(object sender, EventArgs e)
        {

        }

        private void botonNum0_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "0";
        }
    }
}
