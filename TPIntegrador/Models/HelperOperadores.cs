using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIntegrador.Models
{
    internal class HelperOperadores
    {
        //TODO MEJORAR TODOS LOS METODOS CON [] 
        public static double Sumar(double a, double b)
        {
            return a + b;
        }

        public static double Restar(double a, double b)
        {
            return a - b;
        }
        public static double Multiplicar(double a, double b)
        {
            return a * b;
        }
        public static decimal Dividir(decimal a, decimal b)
        {
            return b != 0 ? a / b : 0;
        }
        public static double Modulo(double a, double b)
        {
            return a % b;
        }
        public static double Potencia(double a, int potencia)
        {

            var result = a;
            for (int i = potencia; i >= 0; i--)
            {
                result = result * a;
                potencia--;
            }
            return result;
        }
        public static decimal Promedio(decimal a, decimal b, decimal c)
        {
            return (a + b + c) / 3;
        }
        public static decimal Area(decimal b, decimal h)
        {
            return (b * h) / 2;
        }
        public static double Perimetro(double r)
        {
            return (2 * Math.PI * r);
        }
        public static double ConvertirCelsiusAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5 + 32);
        }
        public static decimal PromedioNotas(decimal a, decimal b, decimal c, decimal d)
        {
            return (a + b + c + d) / 4;
        }
        public static double ConvertirCentimetrosAPulgadas(double centimetros)
        {
            return (centimetros * 2.54);
        }
        public static double ConvertirPesosADolares(double pesos, double cotizacionDolar)
        {
            return (pesos / cotizacionDolar);
        }

    }
}
