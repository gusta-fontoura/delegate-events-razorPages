using System.Threading;

namespace DownloadEventNotifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DownloadManager manager = new DownloadManager();

            manager.DownloadComplete += Alert;

            manager.IniciarDownload();
        }

        public static void Alert(string arquivo)
        {
            Console.WriteLine("O seu download foi concluido: " + arquivo);
        }
    }

    public class DownloadManager
    {
        public event Action<string> DownloadComplete;

        public void IniciarDownload()
        {
            Console.WriteLine("Download iniciado...");
            Console.WriteLine("Finaliando em 10s...");

            Thread.Sleep(10000);

            DownloadComplete?.Invoke("TP1.zip");
        }


    }
}
