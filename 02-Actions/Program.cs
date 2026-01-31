namespace Actions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Em qual idioma você quer receber a saudação: ");
            string lang = Console.ReadLine().ToLower();

            Action<string> mensagem = null;

            switch (lang)
            {
                case "português":
                    mensagem = MensagemPT;
                    break;
                case "espanhol":
                    mensagem = MensagemESP;
                    break;
                case "inglês":
                    mensagem = MensagemENG;
                    break;
                default:
                    Console.WriteLine("Idioma inválido!");
                    break;
            }
            mensagem(lang);
        }

        static void MensagemPT(string lang)
        {
            Console.WriteLine("Olá, bem-vindo!");
        }

        static void MensagemENG(string lang)
        {
            Console.WriteLine("Hello, welcome!");
        }

        static void MensagemESP(string lang)
        {
            Console.WriteLine("Hola, bienvenido!");
        }

    }
}
