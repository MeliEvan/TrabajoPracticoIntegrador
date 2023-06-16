//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TPIntegrador.Models;

class Program
{

    private static async Task Main(String[] args)
    {
        string a = null;
        string b = null;
        string c = null;
        string d = null;
        string h = null;
        string r = null;
        string celsius = null;
        string centrimetros = null;
        string pesos = null;
        string hotDogs = null;
        string frenchFries = null;
        string soda = null;

        Console.WriteLine("Ejercicio clase 31/5/2023");
        Console.WriteLine("Sumar dos numeros. Ingrese los numeros seprados por ,");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        var sumar = HelperOperadores.Sumar(Convert.ToDouble(a), Convert.ToDouble(b));
        Console.WriteLine("Resultado: ", sumar);

        Console.WriteLine("Restar dos numeros. Ingrese uno");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        var restar = HelperOperadores.Restar(Convert.ToDouble(a), Convert.ToDouble(b));
        Console.WriteLine("Resultado: ", restar);

        Console.WriteLine("Multiplicar dos numeros. Ingrese uno");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        var multiplicar = HelperOperadores.Multiplicar(Convert.ToDouble(a), Convert.ToDouble(b));
        Console.WriteLine("Resultado: ", multiplicar);

        Console.WriteLine("Dividir dos numeros. Ingrese uno");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        var dividir = HelperOperadores.Dividir(Convert.ToDecimal(a), Convert.ToDecimal(b));
        Console.WriteLine("Resultado: ", dividir);

        Console.WriteLine("Modulo dos numeros. Ingrese uno");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        var modulo = HelperOperadores.Modulo(Convert.ToDouble(a), Convert.ToDouble(b));
        Console.WriteLine("Resultado: ", modulo);

        Console.WriteLine("Potencia dos numeros. Ingrese uno");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        var potencia = HelperOperadores.Potencia(Convert.ToDouble(a), Convert.ToInt16(b));
        Console.WriteLine("Resultado: ", potencia);

        Console.WriteLine("Promedio tres numeros. Ingrese uno");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese numero dos");
        b = Console.ReadLine();
        Console.WriteLine("Ingrese numero tres");
        c = Console.ReadLine();
        var promedio = HelperOperadores.Promedio(Convert.ToDecimal(a), Convert.ToDecimal(b), Convert.ToDecimal(c));
        Console.WriteLine("Resultado: ", promedio);

        Console.WriteLine("Area de un triangulo. Ingrese base");
        b = Console.ReadLine();
        Console.WriteLine("Ingrese numero altura");
        h = Console.ReadLine();
        var area = HelperOperadores.Area(Convert.ToDecimal(b), Convert.ToDecimal(h));
        Console.WriteLine("Resultado: ", area);

        Console.WriteLine("Perimetro de un circulo. Ingrese radio");
        r = Console.ReadLine();
        var pertimetro = HelperOperadores.Perimetro(Convert.ToDouble(r));
        Console.WriteLine("Resultado: ", pertimetro);


        Console.WriteLine("Convertir grado Ceslsius a Fahrenheit. Ingrese grados");
        celsius = Console.ReadLine();
        var fahrenheit = HelperOperadores.Perimetro(Convert.ToDouble(celsius));
        Console.WriteLine("Resultado: ", fahrenheit);

        Console.WriteLine("Fin ejercicio uno");
        Console.WriteLine("Ejercicio dos");
        Console.WriteLine("Promedio 4 notas. Ingrese la primera");
        a = Console.ReadLine();
        Console.WriteLine("Ingrese nota dos");
        b = Console.ReadLine();
        Console.WriteLine("Ingrese nota tres");
        c = Console.ReadLine();
        Console.WriteLine("Ingrese nota cuatrp");
        d = Console.ReadLine();
        var promedioNotas = HelperOperadores.PromedioNotas(Convert.ToDecimal(a), Convert.ToDecimal(b), Convert.ToDecimal(c), Convert.ToDecimal(c));
        Console.WriteLine("Resultado: ", promedioNotas);

        Console.WriteLine("Ejercicio tres");
        Console.WriteLine("Convertir centimereso a pulgadas. Ingrese la centimetros");
        centrimetros = Console.ReadLine();
        var pulgadas = HelperOperadores.ConvertirCentimetrosAPulgadas(Convert.ToDouble(centrimetros));
        Console.WriteLine("Resultado: ", pulgadas);

        Console.WriteLine("Ejercicio cuatro");
        Console.WriteLine("Convertir pesos a dolares. Ingrese la cantidad de pesos");
        pesos = Console.ReadLine();
        Console.WriteLine("Ingrese la cotizacion del dolar");
        string dolar = Console.ReadLine();
        var dolares = HelperOperadores.ConvertirPesosADolares(Convert.ToDouble(pesos), Convert.ToDouble(dolar));
        Console.WriteLine("Resultado: ", dolares);

        Console.WriteLine("Ejercicio cinco");
        Console.WriteLine("Cuenta. Enter the number of hot dogs:");
        Restaurante restaurante = new Restaurante();
        restaurante.CargarDatos(2, 1, 0.85, 10);
        hotDogs = Console.ReadLine();
        Console.WriteLine("Enter the number of french fries:");
        frenchFries = Console.ReadLine();
        Console.WriteLine("Enter the number of sodas::");
        soda = Console.ReadLine();
        var cuenta = restaurante.CalcularCuenta(Convert.ToInt16(hotDogs), Convert.ToInt16(frenchFries), Convert.ToInt16(soda));
        Console.WriteLine("Your bill is: ", cuenta);



        Console.WriteLine("Ejercicio seis");

        await Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddHostedService<HostedService>();
            })
            .Build()
            .RunAsync();
    }
}