using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForOCR
{
    class Program
    {
        public static void Main(string[] args)
        {
            var run = new OCRManager();
            var analysis = new AnalysisProgram();
            analysis.AddCompareList();
            run.Menu(analysis);
        }
    }
}
