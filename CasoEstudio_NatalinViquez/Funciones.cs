using System;
using System.Collections.Generic;
using System.Text;
using static CasoEstudio_NatalinViquez.Models;

namespace CasoEstudio_NatalinViquez
{
    public class Funciones
    {

        public Valores valores = new Valores();

        public void BorrarMemoria()
        {
            this.valores.memoria = 0;
        }

        public double RecuperarMemoria()
        {
            return this.valores.memoria;
        }

        public void almacenamientoEnMemoria(double pMemoryNumber)
        {
            this.valores.memoria = pMemoryNumber;
        }

        public void Sumar(double number)
        {
            this.valores.memoria += number;
        }

        public void Restar(double number)
        {
            this.valores.memoria -= number;
        }

        public void Limpiar()
        {
            valores = new Valores();
        }

        public void LimpiarNumeros()
        {
            this.valores.primerValor = 0.0;
            this.valores.segundoValor = 0.0;
        }

        public int mod()
        {
            int quo = (int)((int)this.valores.primerValor / (int)this.valores.segundoValor);
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
                        this.valores.resultado = this.valores.primerValor + this.valores.segundoValor;
                        break;

                    case "-":
                        this.valores.resultado = this.valores.primerValor - this.valores.segundoValor;
                        break;
                    case "/":
                        this.valores.resultado = this.valores.primerValor / this.valores.segundoValor;
                        break;

                    case "*":
                        this.valores.resultado = this.valores.primerValor * this.valores.segundoValor;
                        break;

                    default:
                        return "Error";
                        
                }

                this.LimpiarNumeros();

                return this.valores.resultado.ToString();


            }

            catch (Exception)
            {
                return null;
            }

        }

    }
}
