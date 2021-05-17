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
        return Weight / Math.Pow(Height, 2);
    }
    }
}
