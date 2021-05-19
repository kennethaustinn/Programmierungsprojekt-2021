using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;

namespace DummyPatient
{
    class Patient : DataManager.Patient, IPatient

    {
        public double CalculateBMI()
        {
            return Weight / Math.Pow(Height, 2); //Jede kompenenten testen und jede Methoden sieht
            //Patientdummy ein patient mit daten.

        }

        public string CheckWarning()
        {
            throw new NotImplementedException();
        }
    }
}
