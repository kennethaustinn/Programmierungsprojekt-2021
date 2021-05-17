using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;

namespace Patient
{
    public class Class1 : DataManager.Patient, IPatient
    {
        public double CalculateBMI()
        {
            throw new NotImplementedException();
        }

        public string CheckWarning()
        {
            throw new NotImplementedException();
        }
    }
}
