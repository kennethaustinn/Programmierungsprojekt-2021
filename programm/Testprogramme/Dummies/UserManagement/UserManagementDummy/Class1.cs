using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;

namespace UserManagementDummy
{
    public class UserManagement : DataManager.Worker, IUserManagement
    {
        // Dieser Dummy benötigt im Testprojekt einen Verweis auf DataManager/DataManagerDummy.
        // um Doppelungen zu vermeiden, ist diese Komponente hier nicht dazugeladen

        public int GetUserRights()
        {
            // Gibt die Nutzerrechte als Int zurück. 1 für Doctor 2 für Pfleger 3 für Pflegefachkraft, entsprechendes zum Test auskommentieren
            return 1;
            // return 2;
            // return 3;

        }

        public bool LogIn(string username, string password)
        {
            //behelfsmäßige Nutzerdatenbank
            Dictionary<string, string> loginDictionary = new Dictionary<string, string>();
            loginDictionary.Add("Peter", "xyz");
            loginDictionary.Add("Hans", "zzz");


            try
            {
                if (loginDictionary[username] == password)
                {
                    // login erfolgreich
                    return true;
                }

                // password stimmt nicht überein
                return false;                      
                
            }
            catch (KeyNotFoundException)
            {
                // Nutzername falsch
                return false;                         
            }
            
        }

        public bool LogOut()
        {
            return true;
        }
    }
}
