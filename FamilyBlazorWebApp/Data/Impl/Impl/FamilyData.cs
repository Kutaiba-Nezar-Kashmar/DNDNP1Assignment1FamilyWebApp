using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace FamilyBlazorWebApp
{
    public class FamilyData : IFamilyData
    {
        private string adultFile = "adults.json";

        private IList<Person> people;

        public FamilyData()
        {
            if (!File.Exists(adultFile))
            {
                seed();
                WriteAdultToFile();
            }
            else
            {
                string content = File.ReadAllText(adultFile);
                people = JsonSerializer.Deserialize<List<Person>>(content);
            }
        }

        private void seed()
        {
            //Todo check this method 
            string content = File.ReadAllText(adultFile);
            people = JsonSerializer.Deserialize<List<Person>>(content);
        }

        public IList<Person> GetPeople()
        {
            List<Person> people = new List<Person>();
            return people;
        }

        public void AddPerson(Person person)
        {
            int max = people.Max(person => person.Id);
            person.Id = (++max);
            people.Add(person);
            WriteAdultToFile();
        }

        public void RemovePerson(int personId)
        {
            Person toRemove = people.First(p => p.Id == personId);
            people.Remove(toRemove);
            WriteAdultToFile();
        }

        public void UpdatePerson(Person person)
        {
            Person toUpdate = people.First(p => p.Id == person.Id);
            toUpdate.Id = person.Id;
            toUpdate.FirstName = person.FirstName;
            toUpdate.LastName = person.LastName;
            toUpdate.HairColor = person.HairColor;
            toUpdate.EyeColor = person.EyeColor;
            toUpdate.Age = person.Age;
            toUpdate.Weight = person.Weight;
            toUpdate.Height = person.Height;
            toUpdate.Sex = person.Sex;
            WriteAdultToFile();
        }

        public Person GetPerson(int personId)
        {
            return people.FirstOrDefault(p => p.Id == personId);
        }

        private void WriteAdultToFile()
        {
            string personAsJson = JsonSerializer.Serialize(people);
            File.WriteAllText(adultFile, personAsJson);
        }
    }
}