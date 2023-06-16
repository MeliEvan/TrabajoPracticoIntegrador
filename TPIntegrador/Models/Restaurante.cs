using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIntegrador.Models
{
    internal class Restaurante
    {

        public double HotDog { get; set; }
        public double FrenchFries { get; set; }
        public double Soda { get; set; }
        public double Propina { get; set; }


        public void CargarDatos(double hotdog, double frenchfries, double soda, double propina)
        {
            HotDog = hotdog;
            FrenchFries = frenchfries;
            Soda = soda;
            Propina = propina;
        }

        public double CalcularCuenta(int cantHotdog, int cantFrenchFries, int cantSoda)
        {
            double cuenta = cantHotdog * this.HotDog;
            cuenta += cantFrenchFries * this.FrenchFries;
            cuenta += cantSoda * this.Soda;
            cuenta = cuenta + ((cuenta * this.Propina) / 100);
            return cuenta;
        }
    }
}
