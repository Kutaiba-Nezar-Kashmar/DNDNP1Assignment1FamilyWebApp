using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using FamilyBlazorWebApp.Impl;

namespace FamilyBlazorWebApp
{
    public class UserService : IUserService
    {
        private string userFile = "users.json";
        private IList<User> users;

        public void CreateUser(User user)
        {
            int max = users.Max(user => user.UserId);
            user.UserId = (++max);
            users.Add(user);
            writeToJson();
        }

        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (first == null)
            {
                throw new Exception("Incorrect user name");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("incorrect password");
            }

            return first;
        }

        private void writeToJson()
        {
            string userAsJson = JsonSerializer.Serialize(users);
            File.WriteAllText(userFile, userAsJson);
        }
    }
}