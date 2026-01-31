namespace Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Cálculo de Área --");
            Console.WriteLine("Informe a base: ");
            double abase = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a altura: ");
            double altura = double.Parse(Console.ReadLine());

            Func<double, double, double> calculo;

            calculo = CalculoArea;
            Console.WriteLine(calculo(abase, altura));
        }

        static double CalculoArea(double ab, double al)
        {
            return ab * al;
        }
    }
}
