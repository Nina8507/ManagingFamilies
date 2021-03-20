using System;
using System.Collections.Generic;
using System.Linq;
using ManagingFamilies.Models;

namespace ManagingFamilies.Data.Impl
{
    public class InMemoryUserService:IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User()
                {
                    Password = "1234",
                    Role = "Manager",
                    UserName = "Jane"
                },
                new User()
                {
                    Password = "1234",
                    Role = "Analyst",
                    UserName = "John"
                }
            }.ToList();
        }
        
        public User ValidateUser(string userName, string password)
        {
            User registerUser = users.FirstOrDefault(user => user.UserName.Equals(userName));
            if (registerUser == null) {
                throw new Exception("User not found");
            }

            if (!registerUser.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return registerUser;
        }
    }
}