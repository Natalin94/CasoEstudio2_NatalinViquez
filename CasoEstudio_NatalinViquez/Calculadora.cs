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
        private string operaciones;

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

        // Funcion de los botones

        private void botonNum0_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void botonNum1_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void botonNum2_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void botonNum3_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void botonNum4_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void botonNum5_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void botonNum6_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void botonNum7_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void botonNum8_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + "9";
        }

        // Botones de funciones:

        private void botonSuma_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (calculadora.valores.primerValor == 0.0 && txtResultado.Text.Trim() != "")
                {
                    operaciones = "+";
                    calculadora.valores.primerValor = double.Parse(txtResultado.Text.Trim());
                    txtResultado.Text = txtResultado.Text + "+";
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (calculadora.valores.primerValor == 0.0 && txtResultado.Text.Trim() != "")
                {
                    operaciones = "-";
                    calculadora.valores.primerValor = double.Parse(txtResultado.Text.Trim());
                    txtResultado.Text = txtResultado.Text + "-";
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }

        }

        private void botonDivision_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (calculadora.valores.primerValor == 0.0 && txtResultado.Text.Trim() != "")
                {
                    operaciones = "/";
                    calculadora.valores.primerValor = double.Parse(txtResultado.Text.Trim());
                    txtResultado.Text = txtResultado.Text + "/";
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }

        }

        private void btnMultiplicion_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (calculadora.valores.primerValor == 0.0 && txtResultado.Text.Trim() != "")
                {
                    operaciones = "*";
                    calculadora.valores.primerValor = double.Parse(txtResultado.Text.Trim());
                    txtResultado.Text = txtResultado.Text + "*";
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }

        }

        private void btnClearError_Click(object sender, EventArgs e)
        {

            try
            {
                this.limpiar();
                string txtDisplay = txtResultado.Text.Trim();

                if (txtDisplay.Length > 1)
                {
                    txtDisplay = txtDisplay.Substring(0, txtDisplay.Length - 1);
                }
                else
                {
                    txtDisplay = "";
                }


                calculadora.LimpiarNumeros();
                operaciones = "";
                txtResultado.Text = txtDisplay;
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            calculadora.Limpiar();
            operaciones = "";
        }

        private void btnMemoryStorage_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (txtResultado.Text.Trim() != "")
                {
                    char[] operators = { '+', '-', '/', '*' };

                    if (txtResultado.Text.IndexOfAny(operators) == -1)
                    {
                        calculadora.almacenamientoEnMemoria(double.Parse(txtResultado.Text.Trim()));
                        txtResultado.Text = "";
                    }
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }
        }

        private void botonIgual_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (operaciones != null && operaciones != "")
                {

                    string[] numberTwo = txtResultado.Text.Split('+', '-', '/', '*');

                    if (numberTwo.Length == 2 && (numberTwo[1] != null && numberTwo[1] != ""))
                    {
                        calculadora.valores.segundoValor = double.Parse(numberTwo[1]);
                        txtResultado.Text = CalcularResultado(operaciones);
                        operaciones = "";
                    }
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }
        }

        public string CalcularResultado(string pOperation)
        {
            try
            {

                switch (pOperation)
                {
                    case "+":
                        this.calculadora.valores.resultado = this.calculadora.valores.primerValor + this.calculadora.valores.segundoValor;
                        break;

                    case "-":
                        this.calculadora.valores.resultado = this.calculadora.valores.primerValor - this.calculadora.valores.segundoValor;
                        break;

                    case "*":
                        this.calculadora.valores.resultado = this.calculadora.valores.primerValor * this.calculadora.valores.segundoValor;
                        break;
                    case "/":
                        this.calculadora.valores.resultado = this.calculadora.valores.primerValor / this.calculadora.valores.segundoValor;
                        break;
                    default:
                        return "Error";
                        
                }
                
                

                this.limpiar();

                return this.calculadora.valores.resultado.ToString();
            }

            catch (Exception)
            {
                return "Error";
            }

        }

        private void btnMOD_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (operaciones != "" && operaciones == "/")
                {
                    string[] numbers = txtResultado.Text.Split('/');

                    if (numbers.Length == 2 && (numbers[1] != null && numbers[1] != ""))
                    {
                        calculadora.valores.segundoValor = double.Parse(numbers[1]);
                        txtResultado.Text = mod().ToString();
                        operaciones = "";
                    }
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }
        }

        public int mod()
        {
            int quo = (int)((int)this.calculadora.valores.primerValor / (int)this.calculadora.valores.segundoValor);
            this.limpiar();
            return quo;
        }

        private void btnMemoryPlus_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (txtResultado.Text.Trim() != "")
                {
                    mPlus(double.Parse(txtResultado.Text.Trim()));
                    txtResultado.Text = "";
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }
        }

        public void mPlus(double pScreenNumber)
        {
            this.calculadora.valores.memoria += pScreenNumber;
        }

        private void btnMemoryMinus_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpiar();
                if (txtResultado.Text.Trim() != "")
                {
                    mMinus(double.Parse(txtResultado.Text.Trim()));
                    txtResultado.Text = "";
                }
            }
            catch (Exception)
            {
                txtResultado.Text = "Error";
            }
        }

        public void mMinus(double pScreenNumber)
        {
            this.calculadora.valores.memoria -= pScreenNumber;
        }

        private void btnMemoryClear_Click(object sender, EventArgs e)
        {
            calculadora.Limpiar();
            txtResultado.Text = "";
        }

        private void btnMemoryRecall_Click(object sender, EventArgs e)
        {
            this.limpiar();
            txtResultado.Text = txtResultado.Text + calculadora.RecuperarMemoria();
        }

    }
}
