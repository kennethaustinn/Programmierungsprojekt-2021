//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medication
    {
        public int MedicationID { get; set; }
        public string Drug { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string AdministeredBy { get; set; }
        public int HealthDataHealthDataID { get; set; }
    
        public virtual HealthData HealthData { get; set; }
    }
}