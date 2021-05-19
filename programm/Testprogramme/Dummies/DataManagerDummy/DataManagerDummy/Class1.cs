using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using System.Runtime;
using System.Runtime.Remoting.Messaging;


namespace DataManagerDummy
{


    public class DataManager<T> : IDataManager<T> where T : IDataBaseConform 
    {
        public bool CreateNew(T careSolutionObject)
        {
            Random rand = new Random();                // gibt zufällig 0 oder 1 zürück
            return rand.Next(2) == 0;
            /*
             * Falls nur Erfolgreich sein soll:
             * return true;
             */
            
        }
        
        public List<T> SearchPatient(string userSearchText)
        {
            throw new NotImplementedException();
        }

        public bool Update(T careSolutionObject)
        {
            Random rand = new Random();                // gibt zufällig 0 oder 1 zürück
            return rand.Next(2) == 0;
           
        }

    }
}
