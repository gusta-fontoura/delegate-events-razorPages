

namespace Delegate
{

    internal class Program
    {
        public delegate void CalculateDiscount(double value);
        static void Main(string[] args)
        {
            Console.Write("Informe o preço original: ");
            double price = double.Parse(Console.ReadLine());

            CalculateDiscount discout = Discount;

            discout(price);


        }
        static void Discount(double value)
        {
            double result;
            if (value == null)
            {
                Console.WriteLine("Not available discount");
            }
            result = value * 0.90;
            Console.WriteLine(result);
        }
    }
}
