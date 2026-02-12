using System.Data;

namespace TemperatureMonitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            TemperatureSensor sensor = new TemperatureSensor();
            sensor.TemperatureSense += Alert;

            Console.WriteLine("Monitor de Temperatura Iniciado.");
            while (true)
            {
                Console.WriteLine("Informe as temperaturas: ");
                if (double.TryParse(Console.ReadLine(), out double inputTemp))
                {
                    sensor.Monitor(inputTemp);
                }

            }

            static void Alert(double temp)
            {
                Console.WriteLine($"Perigo! {temp} graus!");
            }
        }
    }

    public class TemperatureSensor
    {
        public event Action<double> TemperatureSense;

        public void Monitor(double temperature)
        {
            if (temperature > 99)
            {
                TemperatureSense?.Invoke(temperature);
            }
        }
    }
}
