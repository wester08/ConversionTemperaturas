

namespace Temperaturas 
{ 



    public class TemperaturaFahrenheit
    {

        public double gradosFahrenheit { get; set; }

        public TemperaturaFahrenheit(double fahrenheit)
        {
            gradosFahrenheit = fahrenheit;
        }

        public static implicit operator TemperaturaCelsius(TemperaturaFahrenheit temperaturaFahrenheit)
        {
            double gradosCelsius = (temperaturaFahrenheit.gradosFahrenheit - 32) * 5 / 9;
            return new TemperaturaCelsius(gradosCelsius);
        }


    }
}
