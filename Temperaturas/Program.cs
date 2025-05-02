
namespace Temperaturas
{
    public class Program
    {
        static void Main(string[] args)
        {

            try 
            {

                Console.WriteLine("Aplicacion de converir temperaturas.");
                Console.WriteLine("Ingresar la temperatura que desea convertir: ");
                double temperatura = double.Parse(Console.ReadLine());

                Console.WriteLine("Seleccione el tipo de conversion a realizar:");
                Console.WriteLine("Opcion 1. De Celsius a Fahrenheit");
                Console.WriteLine("Opcion 2. De Fahrenheit a Celsius");

                Console.Write("Opcion: ");

                int tipoConversion = int.Parse(Console.ReadLine());


                if (tipoConversion == 1)
                {
                    TemperaturaCelsius temperaturaCelsius = new TemperaturaCelsius(temperatura);

                    TemperaturaFahrenheit temperaturaFahrenheit = temperaturaCelsius;

                    Console.WriteLine($"La temperatura en Fahrenheit es: {temperaturaFahrenheit.gradosFahrenheit} °F");
                }

                else if (tipoConversion == 2)
                {
                    TemperaturaFahrenheit temperaturaFahrenheit = new TemperaturaFahrenheit(temperatura);
                    TemperaturaCelsius temperaturaCelsius = temperaturaFahrenheit;
                    Console.WriteLine($"La temperatura en Celsius es: {temperaturaCelsius.gradosCelsius} °C");
                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }

            }
            catch (FormatException e)
            {
                Console.WriteLine($"Entrada inválida. Debe ingresar un número. {e.Message}");
            }

            Console.ReadKey();
        }

    }
               
    
}