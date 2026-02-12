namespace MulticastDelegate
{

    internal class Program
    {

        static void Main(string[] args)
        {
           Logger logs = new Logger();

            Action<string> Multicast = null;

            Console.WriteLine("Teste de atribuição null");
            Multicast?.Invoke("Erro: sem atribuição de métodos.");


            Console.WriteLine("Teste de atribuição normal");
            Multicast += logs.LogToConsole;
            Multicast += logs.LogToFile; 
            Multicast += logs.LogToDatabase;

            Multicast?.Invoke("Registrados");
        }
    }

    public class Logger
    {
        public void LogToConsole(string msg)
        {
            Console.WriteLine("Log no console:" + msg);

        }

        public void LogToFile(string msg)
        {
            Console.WriteLine("Log no File: " + msg);
        }

        public void LogToDatabase(string msg)
        {
            Console.WriteLine("Log na Db: " + msg);
        }
    }
}
