
namespace DummyForOCR
{
    public class Program
    {
        /// <summary>
        /// Die Konsolenanwendung wird hier mit Erzeugung einer Instanz des OcrManager gestartet. Nur für die Testung des Auswertungsprogramm
        /// in dieser Konsolenanwendung.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var run = new OcrManager();
            run.Menu();
        }
    }
}
