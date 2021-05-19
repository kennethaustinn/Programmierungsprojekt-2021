using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using DataManager;

namespace Patient
{

    public class Patient : DataManager.Patient, IPatient

    {
        public double CalculateBMI()
        {
            throw new NotImplementedException();
        }

        public string CheckWarning()
        {
            throw new NotImplementedException();
        }

        public void SetTestData()
        {
            // Test Patient wechler mit Beispieldaten befüllt wird.
            var testPatient = new Patient();

            // Beipieldaten für eine Instanz der CareReport Klasse
            var testCareReport = new CareReport();
            testCareReport.CareReportID = 001;
            testCareReport.ActionPlanFulfilled = true;
            testCareReport.CreatedOn = new DateTime(2021,05,19);
            testCareReport.Deviations = "Es kam zu keiner Abweichung im Vergleich zu den vorigen Tagen";
            testCareReport.CaregiverPersonID = 123456;

            // Beipieldaten für eine Instanz der HealthData Klasse
            var testHealthData = new HealthData();
            testHealthData.HealthDataID = 001;
            testHealthData.MedicalHistory = "Patient hatte Lungenkrebs, da er viel Rauchte";
            testHealthData.ChronicDiseases = "Asthma";

            // Beipieldaten für eine Instanz der HealthData Klasse
            var testVitalParameters = new VitalParameters();
            testVitalParameters.VitalParametersID = 111;
            testVitalParameters.DateTime = new DateTime(2021, 05, 19);
            testVitalParameters.TypeOfMeasurement = "Puls";
            testVitalParameters.Value = 120;
            testVitalParameters.Unit = "/min";
            testVitalParameters.HealthDataHealthDataID = 001;

            // Beipieldaten für eine Instanz der Medication Klasse
            var testMedication = new Medication();
            testMedication.MedicationID = 111;
            testMedication.Drug = "Pantoprazol";
            testMedication.Dosage = "1 Tab.";
            testMedication.Frequency = "Jeden Tag morgens vorm Frühstück";
            testMedication.Reason = "Beschwerden an Magenschmerzen --> Gastritis";
            testMedication.AdministeredBy = "Otto Müller";
            testMedication.HealthDataHealthDataID = 001;

            // Beipieldaten für eine Instanz der RiskValues Klasse
            var testRiskValues = new RiskValues();
            testRiskValues.RiskValuesID = 111;
            testRiskValues.Decubitus = 2;
            testRiskValues.Dementia = 5;
            testRiskValues.Falling = 1;
            testRiskValues.Pain = 3;
            testRiskValues.HealthDataHealthDataID = 001;

            // Beipieldaten für eine Instanz der Hospitaliations Klasse
            var testHospitaliations = new Hospitaliations();
            testHospitaliations.HospitaliationsID = 01;
            testHospitaliations.Reason = "Wunde am Kopf, ein Objekt der durch ein Sturz von der Treppe zustande kam.";
            testHospitaliations.Duration = 2;
            testHospitaliations.Date = new DateTime(2021, 05, 17);
            testHospitaliations.HealthDataHealthDataID = 001;

            // Beipieldaten für eine Instanz der Caregiver Klasse
            var testCaregiver = new Caregiver();
            testCaregiver.IsSpecialist = false;

            // Beipieldaten für eine Instanz der Doctor Klasse
            var testDoctor = new Doctor();
            testDoctor.Address = "Spandauerstr. 24 12564 Berlin";
            testDoctor.MedicalSpecialty = "Facharzt für Allgemeinmedizin";

            //Hinzufügen der Instanzen zu der Klasse HealthData
            testHealthData.VitalParameters.Add(testVitalParameters);
            testHealthData.Medication.Add(testMedication);
            testHealthData.RiskValues.Add(testRiskValues);
            testHealthData.Hospitaliations.Add(testHospitaliations);


            //Hinzufügen der Instanzen zu der Klasse Patient
            testPatient.Caregiver.Add(testCaregiver);
            testPatient.Doctor.Add(testDoctor);
            testPatient.CareReport.Add(testCareReport);
            testPatient.HealthData = testHealthData;

        }
    }
}
