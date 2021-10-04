using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FamilyBlazorWebApp.Persistence;
using Models;

namespace Data.Impl
{
    public class AdultData : IAdultData
    {
        private FileContext fileContext;
        private IList<Adult> adults;

        public AdultData()
        {
            if (!File.Exists("adults.json"))
            {
                new FileContext();
            }
            else
            {
                string content = File.ReadAllText("adults.json");
                adults = JsonSerializer.Deserialize<List<Adult>>(content);
            }
        }

        public IList<Adult> GetAdults()
        {
            List<Adult> al = new List<Adult>(adults);
            return al;
        }

        public void AddAdult(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAdult(int adultId)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateAdult(Adult adult)
        {
            throw new System.NotImplementedException();
        }

        public Adult get(int adultId)
        {
            throw new System.NotImplementedException();
        }
    }
}