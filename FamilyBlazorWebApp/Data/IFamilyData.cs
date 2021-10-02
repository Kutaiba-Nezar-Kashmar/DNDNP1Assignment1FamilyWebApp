using System.Collections.Generic;


namespace FamilyBlazorWebApp
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