namespace ManipulacaoDeStringsComDelegatesEncadeados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> concatenate = (nome, sobrenome) =>
            {
                string resultado = nome + " " + sobrenome;
                Console.WriteLine(resultado);
                return resultado;
            };

            concatenate += (nome, sobrenome) =>
            {
                string concatUpper = $"{nome} {sobrenome}".ToUpper();
                Console.WriteLine(concatUpper);
                return concatUpper;
            };

            concatenate += (nome, sobrenome) =>
            {
                string concatNoSpace = $"{nome} {sobrenome}".Replace(" ", "");
                Console.WriteLine(concatNoSpace);
                return concatNoSpace;
            };

            

            string final = concatenate("Gustavo", "Fontoura");
        }
    }
}
