using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfaces
{

    public interface IDataManager<T> where T: IDataBaseConform
    {
        bool Update(T careSolutionObject); // darf nur Objekte von Person entgegennehmen, updatet vorhandenen DBObjekt
        bool CreateNew(T careSolutionObject);
        List<T> SearchPatient(string userSearchText);   //Nimmt den Übergabeparameter, sucht in der Datenbank bei Mensch/Patient mit dem Text und gibt Ergebnis (Objekt der Klasse) zurück als Ergebnis

        // Case: Mehrere Ergebnisse erhalten bei der Suche?
        // seachbyID, searchbyXY Methoden eventuell noetig
    }

    public interface IDataBaseConform  // identifiziert Klassen/Objecte, die von der Databank abgebildet werden können
    {

    }

    /*
     *  Oder public interface IUpdatable
     * {
     * bool Update();
     * } und dann Implementierung von Update in jeder Klasse
     */
    

    public interface IUserManagement
    {
        int ID { get; }         // Database Identifikator

        string Username { get; }    // Benutzername

        bool LoggedIn { get; }     // gibt true zurück, wenn der Nutzer eingelogged ist
        
        bool LogIn(string username, string password);  // Funktion zum einloggen, prüft das eingegebene Passwort in der Datenbank bzw. deren Hash Code in der Datenbank und gibt True zurück bei Übereinstimmung

        bool LogOut();             // Funktion zum ausloggen, bei Erfolg True als Rückgabewert

        int GetUserRights();      // Gibt die Nutzerrechte als Int zurück. 1 für Doctor 2 für Pfleger 3 für Pflegefachkraft




    }


    public interface IPatient
    {
        double CalculateBMI();
    }

    public interface IOCRManager
    {

        Dictionary<string, string> ExecuteOCR(string path);  // Nimmt den Pfad der Bildatei oder PFD Datei entgegeben.
                                                             // Erkennt automatisch, welches Formular eingelesen wird und befüllt entsprechend ein Dictionary
    }


}
