using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager;

namespace DatabaseTester
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true; // Variable, um while, Schleife zu verlassen
            int intInput; // User Input als Int umgewandelt
            string userInput;
            Console.WriteLine("Programm zum testen der DataManager Komponente");
            while (active)
            {
                //TODO Auslesen der propterties des Objekts fehlt noch
                //TODO Ausleihe starten noch nicht eingefügt
                Console.WriteLine("");
                Console.WriteLine("");

                Console.WriteLine("Was möchten Sie tun?");
                Console.WriteLine("1. Neue Person hinzufügen ");
                Console.WriteLine("2. Person nach Nachname suchen");
                Console.WriteLine("3. ");
                Console.WriteLine("4. ");
                Console.WriteLine("5. ");
                Console.WriteLine("6. ");
                Console.WriteLine("7. Programm beenden ");
                Console.WriteLine("");

                userInput = Console.ReadLine();


                if (Int32.TryParse(userInput,
                    out intInput)) // Versucht Nutzereingabe in Int zu konvertieren, bei Erfolg weiter zu switch
                {
                    switch (intInput)
                    {
                        case 1:
                            using (var context = new AmbulantCareDBContainer())
                            {
                                string personlastname;
                                string personfirstname;
                                string persongender;
                                string personphone;

                                Console.WriteLine("Geben Sie den Nachnamen ein.");
                                personlastname = Console.ReadLine();

                                Console.WriteLine("Geben Sie den Vornamen der Person an.");
                                personfirstname = Console.ReadLine();

                                Console.WriteLine("Geben Sie das Geschlecht der Person an.");
                                persongender = Console.ReadLine();

                                Console.WriteLine("Geben Sie die Rufnummer der Person an.");
                                personphone = Console.ReadLine();

                                var person = new Person()
                                {
                                    LastName = personlastname,
                                    FirstName = personfirstname,
                                    Gender = persongender,
                                    Phone = personphone
                                };

                                context.PersonSet.Add(person);
                                context.SaveChanges();
                                
                            }

                            break;

                        case 2:
                            using (var context = new AmbulantCareDBContainer())
                            {
                                Console.WriteLine("Geben Sie den Nachnamen ein.");
                                string personlastname =Console.ReadLine();
                                var query = from t in context.PersonSet
                                    where t.LastName == personlastname
                                    select t;

                                var person = query.FirstOrDefault<Person>();

                                Console.WriteLine(person.LastName+ ", "+ person.FirstName+ ", "+ person.Gender+ ", "+
                                    person.Phone); 
                                // ACHTUNG gibt Null Reference exception aus, wenn es den Suchbegriff nicht gibt!
                              
                            }

                            

                            

                            break;

                        case 3:


                            break;

                        case 4:

                            break;

                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:
                            active = false;

                            break;

                    }
                }
            }
        }
    }
}
