using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace Data.Impl
{
    public class FamilyData : IFamilyData
    {
        private string familyFile = "families.json";
        private IList<Family> families = new List<Family>();

        public FamilyData()
        {
            string content = File.ReadAllText(familyFile);
            families = JsonSerializer.Deserialize<List<Family>>(content);
        }

        public IList<Family> GetFamilies()
        {
            List<Family> fl = new List<Family>(families);
            return fl;
        }

        public void AddFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveFamily(int familyId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFamily(Family family)
        {
            throw new System.NotImplementedException();
        }

        public Family Get(int familyId)
        {
            throw new System.NotImplementedException();
        }
        
        private void WriteTodosToFile()
        {
            string familiesAsJson = JsonSerializer.Serialize(families);
            File.WriteAllText(familyFile, familiesAsJson);
        }
    }
}