using System.Collections.Generic;
using Models;


namespace Data
{
    public interface IFamilyData
    {
        IList<Person> GetPeople();
        void AddPerson(Person person);
        void RemovePerson(int personId);
        void UpdatePerson(Person person);
        Person GetPerson(int personId);
    }
}