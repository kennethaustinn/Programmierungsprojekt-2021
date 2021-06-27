
namespace DummyForOCR
{
    public class Program
    {
        // Die Konsolenanwendung wird hier mit Erzeugung einer Instanz des OcrManager gestartet.
        public static void Main(string[] args)
        {
            var run = new OcrManager();
            run.Menu();
        }
    }
}
