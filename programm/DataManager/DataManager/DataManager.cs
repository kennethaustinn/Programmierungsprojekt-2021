using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;

namespace DataManager
{
    public class DataManager<T> : IDataManager<T> where T : IDataBaseConform
    {
        public bool CreateNew(T careSolutionObject)
        {
            throw new NotImplementedException();
        }

        public List<T> SearchPatient(string userSearchText)
        {
            throw new NotImplementedException();
        }

        public bool Update(T careSolutionObject)
        {
            throw new NotImplementedException();
        }
    }
}
