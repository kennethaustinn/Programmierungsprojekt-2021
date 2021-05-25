using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using System.Security.Cryptography;

namespace UserManagement
{
    public class UserManagement : DataManager.Worker, IUserManagement
    {

        // Das Password wird nicht als string gespeichert sondern als Hash
        /*Es wird "Salt" verwendet. Dabei wird dem Passwort ein zufälllig generierter String/Zahlen angehängt
         und danach eine Hashfunktion verwendet. Das Ergebnis und "Salt" werden in der Datenbank abgespeichert.
        So wird es für Angreifer ineffizient oder unmöglich, mit vorgefertigten Lookup tables, reverse lookup tables
        oder rainbow tables aus der Datenbank die Passworter zu generieren.
        "Salt" muss je Benuter und Passwort einzigartig sein

        Um Brute Force Angriffe oder Dictionary-Angriffe zu verhindern bzw. zu verlangsamen, wird ein langsamer Hash Algorithmus verwendet
        */


        // Hash und Salt müssen in DB gespeichert werden.. Daher evtl Speichern in Datamanager nötig
        private string Hash { get; set; }
        private String Salt { get; set; }


        public int GetUserRights()
        {
            throw new NotImplementedException();
        }

        public bool LogIn(string username, string password)
        {
            // 1. Nach Nutzername in Datenbank suchen
            // falls nicht vorhanden, false zurückgeben oder generische Antwort (Benutzername oder PW falsch)
            // niemals spezifizieren, was nicht übereinstimmmt!

            // falls vorhanden: Objekt der Klasse Usermanagement aus Datenbank landen

            // 2. Eingegebenes PW und Salt an ProduceHash übergeben, Ergebnis mit Hash in Datenbank vergleichen
            if (ProduceHash(password) == Hash) 
                return true;
            return false;

            
            
            throw new NotImplementedException();
        }

        public bool LogOut()
        {
            throw new NotImplementedException();
        }


        public bool CreateNewAccount(string username, string password) //TODO CreateNewAccount Rückgabewert überdenken
        {
            //1. Nutzername in Datenbank überprüfen, bereits vorhanden -> return false
            // bei true.. Objekt zurückgeben oder ID aus Datenbank?

            //2. Erstellen von Salt und Hash

            ProduceHash(password);
            
            throw new NotImplementedException();

        }


        private string ProduceNewSalt()
        {
            string newSalt;
            using (RandomNumberGenerator randomNumberG = new RNGCryptoServiceProvider())
            {
                byte[] byteSalt = new byte[32];     //evtl mehr Bytes für mehr Sicherheit?!
                
                // füllt Bytearray mit kryptografisch starker Folge von zufälligen Werte aus
                randomNumberG.GetBytes(byteSalt);


                //erstellt einen Salt-String der abgespeichert werden kann

                newSalt = Convert.ToBase64String(byteSalt);

                // TODO Salt muss abgespeichert werden!

            }

            return newSalt;
        }
        private string ProduceHash(string pwinput)   
        {
            using (RandomNumberGenerator randomNumberG = new RNGCryptoServiceProvider())
            {

                byte[] byteHash = new byte[32];



                int iterations = 1000;    //TODO Iterations anpassen, um Hash-Erzeugung zu verlangsamen

                //erstellt den Hash-Wert
                Rfc2898DeriveBytes pbkdf2Bytes = new Rfc2898DeriveBytes(pwinput, Convert.FromBase64String(Salt), iterations);
                byteHash = pbkdf2Bytes.GetBytes(32);

                return Convert.ToBase64String(byteHash);
                // TODO Hash muss abgespeichert werden!

                
            }
        }
    }
}
