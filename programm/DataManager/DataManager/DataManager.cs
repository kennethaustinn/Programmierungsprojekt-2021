using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfaces;
using Dapper;

namespace DataManager
{
    public class DataManager<T> : IDataManager<T> where T : IDataBaseConform
    {
        /// <summary>
        /// Dieser string stellt die Verbindungszeichungsfolge zu der Datenbank Datei (mdf). Mit dem wird die ganze Zeit weiter gearbeitet.
        /// </summary>
        public  string ConnectionString = ConfigurationManager.ConnectionStrings["CareSolution.Properties.Settings.AmbulantCareDBConnectionString"].ConnectionString;

        /// <summary>
        /// Liste für die neu hin zugefügten Personen/Patienten.
        /// </summary>
        public  List<Person> NewPerson = new List<Person>();

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
        /// Diese Methode sollte nach Patineten suchen und die die gefunndenen wieder geben (s.CommonInterfaces).
        /// </summary>
        /// <param name="userSearchText"> Value nach dem Gesucht wird, indem fall wäre es der Nachname</param>
        /// <returns> Gefundene Patienten</returns>
        public List<T> SearchPatient(string userSearchText)
        {
            throw new NotImplementedException();
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
    }
}
