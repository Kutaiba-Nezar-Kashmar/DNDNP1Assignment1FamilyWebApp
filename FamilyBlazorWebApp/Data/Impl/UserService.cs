using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;


namespace Data.Impl
{
    public class UserService : IUserService
    {
        private string userFile = "users.json";
        private IList<User> users;

        public UserService()
        {
           Seed();
           writeToJson();
        }

        public void CreateUser(User user)
        {
            users.Add(user);
            writeToJson();
        }

        private void Seed()
        {
            users = new[]
            {
                new User()
                {
                    FirstName = "kutaiba",
                    LastName = "Kashmar",
                    UserName = "kt",
                    Password = "1234",
                    Age = 27,
                    EmailAddress = "bl"
                },
                new User()
                {
                    FirstName = "kutaiba2",
                    LastName = "Kashmar2",
                    UserName = "kt2",
                    Password = "123411",
                    Age = 271,
                    EmailAddress = "bl2"
                }
            }.ToList();
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