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
    
    public partial class RiskValues
    {
        public int RiskValuesID { get; set; }
        public int Decubitus { get; set; }
        public int Pain { get; set; }
        public int Falling { get; set; }
        public int Dementia { get; set; }
        public int HealthDataHealthDataID { get; set; }
    
        public virtual HealthData HealthData { get; set; }
    }
}
