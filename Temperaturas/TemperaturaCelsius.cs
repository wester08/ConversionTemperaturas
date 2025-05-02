

namespace Temperaturas
{
    public class TemperaturaCelsius
    {

        public double gradosCelsius { get; set; }

    public TemperaturaCelsius(double celsius)
        {
            gradosCelsius = celsius;
        }
        public static implicit operator TemperaturaFahrenheit(TemperaturaCelsius temperaturaCelsius)
        {
            double gradosFahrenheit = (temperaturaCelsius.gradosCelsius * 9 / 5) + 32;
            return new TemperaturaFahrenheit(gradosFahrenheit);
        }
    }
}
