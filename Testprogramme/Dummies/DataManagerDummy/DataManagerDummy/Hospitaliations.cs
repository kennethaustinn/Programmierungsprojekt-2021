//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManagerDummy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hospitaliations
    {
        public int HospitaliationsID { get; set; }
        public string Reason { get; set; }
        public int Duration { get; set; }
        public int HealthDataHealthDataID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual HealthData HealthData { get; set; }
    }
}
