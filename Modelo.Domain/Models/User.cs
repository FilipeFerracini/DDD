using Modelo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain.Models
{
    public class User : EntityDataBase
    {
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        protected User()
        {

        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
    }
}
