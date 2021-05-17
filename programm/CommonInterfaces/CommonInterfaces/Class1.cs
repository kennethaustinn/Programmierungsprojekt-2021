using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfaces
{
    // Die Datenstruktur (Eigenschaften/Felder) der Klassen sind über das Datenbankmodel in Datamanger erzeugt worden.
    // Komponenten, die diese Datenstruktur verwenden, müssen von den Klassen im Datamanger erben und
    // ihre jeweilige Schnittstelle implementieren.

    public interface IDataManager<T> where T: IDataBaseConform
    {
        // generische Schnittstelle der Komponente Datamanger
        // Kann Objekte verarbeiten, welche die Schnittstelle IDataBaseConform implementieren

        // speichert/überschreibt das übergebene Objekt in der Datenbank ab. true = erfolgreich
        bool Update(T careSolutionObject);

        // erstellt einen neuen Datenbankeintrag für das übergebene Objekt, true = erfolgreich
        bool CreateNew(T careSolutionObject);

        // Sucht mit dem übergebenen String in der Datenbank. Gibt als Ergebnis Liste von IDataBaseConform'en Objekten zurück
        List<T> SearchPatient(string userSearchText);
    }

    public interface IDataBaseConform  
    {
        // identifiziert Klassen/Objecte, die von der Databank abgebildet werden können
    }

    public interface IUserManagement
    {
        // Interface für das Nutzer und Rechtemangement 


        // Funktion zum einloggen, prüft das eingegebene Passwort in der Datenbank
        // bzw. deren Hash Code in der Datenbank und gibt True zurück bei Übereinstimmung
        bool LogIn(string username, string password);  

        bool LogOut();             // Funktion zum ausloggen, bei Erfolg True als Rückgabewert

        // Gibt die Nutzerrechte als Int zurück. 1 für Doctor 2 für Pfleger 3 für Pflegefachkraft
        int GetUserRights();      
    }


    public interface IPatient
    {
        // Interface für die Patientendaten
        double CalculateBMI();  // Berechnet den BMI des Patienten

        // prüft alle Vitalparameter des Patienten und gibt Warnungen bei Überschreitung des Grenzwertes als string zurück
        string CheckWarning();  
    }

    public interface IOCRManager
    {
        // Interface für die Kommunikation mit dem OCR Manager
        Dictionary<string, string> ExecuteOCR(string path);  
        // Nimmt den Pfad der Bild oder PDF-Datei entgegeben.
        // Erkennt automatisch, welches Formular eingelesen wird und befüllt entsprechend ein Dictionary
    }


}
