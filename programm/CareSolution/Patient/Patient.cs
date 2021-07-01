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
        public double CalculateBmi()
        {
            throw new NotImplementedException();
        }

        public string CheckWarning()
        {
            throw new NotImplementedException();
        }

        public Patient SetTestData()
        {
            // Test Patient mit Beispieldaten.
            var testPatient = new Patient();
            testPatient.PersonID = 1;
            testPatient.FirstName = "Max";
            testPatient.LastName = "Mustermann";
            testPatient.Gender = "Male";
            testPatient.Phone = "030 0940185";
            testPatient.BirthDate = new DateTime(1990, 3, 3);
            testPatient.Address = "Berlinstr. 1, 12345 Berlin";
            testPatient.Contactperson = "Sophia";
            testPatient.ContactpersonPhone = "01488872662";
            testPatient.HealthInsurance = "AOK";
            testPatient.Height = 180;
            testPatient.Weight = 75.5;
            testPatient.DegreeOfCare = 2;
            testPatient.PowerOfAttorney = "Müller Mustermann (1. Kind)";

            // Beipieldaten für eine Instanz der Bio Klasse
            var testBio = new Bio();
            testBio.BioID = 1;
            testBio.School = "Gymnasium";
            testBio.Training = "IDK";
            testBio.University = "HTW Berlin";
            testBio.Job = "Bauwerker";
            testBio.Partnership = "Witwer";
            testBio.Children = "Ja, 2 Kinder";
            testBio.Leisure = "----";
            testBio.Family_Members = "2 Kinder";
            testBio.Languages = "Deutsch";

            // Beipieldaten für eine Instanz der Home Klasse
            var testHome = new Home();
            testHome.HomeID = 123;
            testHome.Tools = "Verfügt mit Krankenhausbett";
            testHome.Barrier_Free_Kitchen = false;
            testHome.Barrier_Free_Bath = true;
            testHome.Barrier_Free_Living_Area = false;
            testHome.Barrier_Free_Stairlift = false;
            testHome.Barrier_Free_Elevator = true;

            // Beipieldaten für eine Instanz der CaringRelatives Klasse
            var testCaringRelatives = new CaringRelatives();
            testCaringRelatives.CaringRelativesID = 1;
            testCaringRelatives.Name = "Müller Mustermann";
            testCaringRelatives.LivesInHousehold = true;
            testCaringRelatives.VisitFrequency = "sehr oft";
            testCaringRelatives.Activity = "Student";
            testCaringRelatives.PatientPersonID = 001;

            // Beipieldaten für eine Instanz der ActionPlan Klasse
            var testActionPlan = new ActionPlan();
            testActionPlan.ActionPlanID = 1;
            testActionPlan.CreatedOn = new DateTime(2021, 5, 19);
            testActionPlan.Actions_Morning = "Puls messen";
            testActionPlan.Actions_Noon = "Medikamente A geben";
            testActionPlan.Actions_Afternoon = "nichts";
            testActionPlan.Actions_Eve = "Puls messen und Medikamente B geben";

            
            // Beipieldaten für eine Instanz der CareReport Klasse
            var testCareReport = new CareReport();
            testCareReport.CareReportID = 001;
            testCareReport.ActionPlanFulfilled = true;
            testCareReport.CreatedOn = new DateTime(2021,05,19);
            testCareReport.Deviations = "Keine Abweichung zu den Vortagen";
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
            testDoctor.FirstName = "Hans";
            testDoctor.LastName = "Otto";
            testDoctor.Address = "Spandauerstr. 24 12564 Berlin";
            testDoctor.MedicalSpecialty = "Facharzt für Allgemeinmedizin";
            testDoctor.ToDoList = "Puls messen";


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
            testPatient.Bio = testBio;
            testPatient.Home = testHome;
            testPatient.CaringRelatives.Add(testCaringRelatives);
            testPatient.ActionPlan.Add(testActionPlan);

            return testPatient;

        }
    }
}
