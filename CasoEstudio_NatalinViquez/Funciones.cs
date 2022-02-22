using System;
using System.Collections.Generic;
using System.Text;
using static CasoEstudio_NatalinViquez.Models;

namespace CasoEstudio_NatalinViquez
{
    public class Funciones
    {

        public Valores val = new Valores();

        public void BorrarMemoria()
        {
            this.val.mem = 0;
        }

        public double RecuperarMemoria()
        {
            return this.val.mem;
        }

        public void almacenamientoEnMemoria(double pMemoryNumber)
        {
            this.val.mem = pMemoryNumber;
        }

        public void Sumar(double number)
        {
            this.val.mem += number;
        }

        public void Restar(double number)
        {
            this.val.mem -= number;
        }

        public void Limpiar()
        {
            val = new Valores();
        }

        public void LimpiarNumeros()
        {
            this.val.numeroUno = 0.0;
            this.val.numeroDos = 0.0;
        }

        public int mod()
        {
            int quo = (int)((int)this.val.numeroUno / (int)this.val.numeroDos);
            this.LimpiarNumeros();
            return quo;
        }

        public string FuncionesPrincipales(string TipoOperacion)
        {
            try
            {
                switch (TipoOperacion)
                {
                    case "+":
                        this.val.resultado = this.val.numeroUno + this.val.numeroDos;
                        break;

                    case "-":
                        this.val.resultado = this.val.numeroUno - this.val.numeroDos;
                        break;
                    case "/":
                        this.val.resultado = this.val.numeroUno / this.val.numeroDos;
                        break;

                    case "*":
                        this.val.resultado = this.val.numeroUno * this.val.numeroDos;
                        break;

                    default:
                        return "Error";
                        
                }

                this.LimpiarNumeros();

                return this.val.resultado.ToString();


            }

            catch (Exception)
            {
                return null;
            }

        }

    }
}
