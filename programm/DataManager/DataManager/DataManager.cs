using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CommonInterfaces;
using Dapper;

namespace DataManager
{
    public class DataManager<T> : IDataManager<T, Patient> where T : IDataBaseConform
    {
        public Patient Patient = new Patient();
        /// <summary>
        /// Dieser string stellt die Verbindungszeichungsfolge zu der Datenbank Datei (mdf). Mit dem wird die ganze Zeit weiter gearbeitet.
        /// </summary>
        public string ConnectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;

        /// <summary>
        /// Liste für die neu hin zugefügten Personen/Patienten.
        /// </summary>
        public List<Person> NewPerson = new List<Person>();

        public List<Bio> NewBio = new List<Bio>();
        public List<CareReport> NewCareReport = new List<CareReport>();

        /// <summary>
        /// Diese Methode erstellt einen Neuen Datensatz für Person in der Tabelle PersonSet (s.CommonInterfaces).
        /// </summary>
        /// <param name="careSolutionObject"> Eine Instanz von Person</param>
        /// <returns></returns>
        public bool CreateNew(T careSolutionObject)
        {
            var lastName = typeof(T).GetProperty("LastName")?.GetValue(careSolutionObject).ToString();
            var firstName = typeof(T).GetProperty("FirstName")?.GetValue(careSolutionObject).ToString();
            var gender = typeof(T).GetProperty("Gender")?.GetValue(careSolutionObject).ToString();
            var phone = typeof(T).GetProperty("Phone")?.GetValue(careSolutionObject).ToString();

            using (IDbConnection connections = new SqlConnection(ConnectionString))
            {
                //connections.Open();
                NewPerson.Add(new Person { LastName = lastName, FirstName = firstName, Gender = gender, Phone = phone });
                connections.Execute("dbo.Insert_Patient @LastName, @FirstName, @Gender, @Phone", NewPerson);
                //connections.Close();
            }

            return true;
        }

        /// <summary>
        /// Diese Methode gibt den  Patienten wieder der ausgewählt wurde. 
        /// </summary>
        /// <param name="id"> Value nach dem Gesucht wird, indem fall wäre es der Nachname</param>
        /// <returns> Gefundene Patienten</returns>
        public List<Patient> GetPatient(string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            using (IDbConnection connections = new SqlConnection(ConnectionString))
            {
                var output = connections.Query<Patient>("dbo.GetPatient @PersonID", new { PersonID = id }).ToList();
                return output;
            }
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Diese Methode sollte die Person/Patienten aktulisieren, falls sich irgendwas in der Datenbank  ändern sollte (s.CommonInterfaces).
        /// </summary>
        /// <param name="careSolutionObject">Eine Instanz von Person</param>
        /// <returns> Gibt True aus falls</returns>
        public bool Update(T careSolutionObject)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Die Methode speichert und fügt die eingescannte Biografie mittels Ocr in die Datenbank ein.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="school"></param>
        /// <param name="training"></param>
        /// <param name="uni"></param>
        /// <param name="job"></param>
        /// <param name="partnership"></param>
        /// <param name="children"></param>
        /// <param name="leisure"></param>
        /// <param name="family"></param>
        /// <param name="languages"></param>
        public void addBioToDb(string id, string school, string training, string uni, string job, string partnership,
            string children,
            string leisure, string family, string languages)
        {
            using (IDbConnection connections = new SqlConnection(ConnectionString))
            {
                //connections.Open();
                NewBio.Add(new Bio()
                {
                    School = school,
                    Training = training,
                    University = uni,
                    Job = job,
                    Partnership = partnership,
                    Children = children,
                    Leisure = leisure,
                    Family_Members = family,
                    Languages = languages
                });
                connections.Execute("dbo.InsertBioFromOcr @School, @Training, @University, @Job, @Partnership," +
                                    "@Children, @Leisure, @Family_Members, @Languages", NewBio);
                //connections.Close();
            }

        }

        public void addCareReportToDb(string careGiverid, string date, bool fullFilled, string deviations)
        {
            using (IDbConnection connections = new SqlConnection(ConnectionString))
            {
                //connections.Open();
                NewCareReport.Add(new CareReport()
                {
                    CreatedOn = Convert.ToDateTime(date),
                    ActionPlanFulfilled = fullFilled,
                    Deviations = deviations,
                    CaregiverPersonID = Convert.ToInt32(careGiverid)    //name ala/kenneth

                });
                connections.Execute("dbo.InsertCareReportFromOc @CreatedOn, @ActionPlanFulfilled, @Deviations, @CaregiverPersonID", NewCareReport);
                //connections.Close();
            }
        }
    }
}
