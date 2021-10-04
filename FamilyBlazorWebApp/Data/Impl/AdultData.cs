﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FamilyBlazorWebApp.Persistence;
using Models;

namespace Data.Impl
{
    public class AdultData : IAdultData
    {
        private string adultFile = "adults.json";
        private FileContext fileContext;
        private IList<Adult> adults;

        public AdultData()
        {
            if (!File.Exists(adultFile))
            {
               // new FileContext();
            }
            else
            {
                string content = File.ReadAllText(adultFile);
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
            int max = adults.Max(adult => adult.Id);
            adult.Id = (++max);
            adults.Add(adult);
            WriteTodosToFile();
        }

        public void RemoveAdult(int adultId)
        {
            Adult adultToRemove = adults.First(a => a.Id == adultId);
            adults.Remove(adultToRemove);
            WriteTodosToFile();
        }

        public void UpdateAdult(Adult adult)
        {
            Adult toUpdate = adults.First(a => a.Id == adult.Id);
            toUpdate.FirstName = adult.FirstName;
            toUpdate.LastName = adult.LastName;
            toUpdate.HairColor = adult.HairColor;
            toUpdate.EyeColor = adult.EyeColor;
            toUpdate.Age = adult.Age;
            toUpdate.Weight = adult.Weight;
            toUpdate.Height = adult.Height;
            toUpdate.Sex = adult.Sex;
            toUpdate.JobTitle.JobTitle = adult.JobTitle.JobTitle;
            toUpdate.JobTitle.Salary = adult.JobTitle.Salary;
            WriteTodosToFile();
        }

        public Adult get(int adultId)
        {
            return adults.FirstOrDefault(a => a.Id == adultId);
        }

        private void WriteTodosToFile()
        {
            string adultsAsJson = JsonSerializer.Serialize(adults);
            File.WriteAllText(adultFile, adultsAsJson);
        }
    }
}