using E_Commerce.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Entites
{
   public class User
    {
        public static int AutoIncrement = 0;
        public int UserId { get; }

        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserType UserType { get; set; }
        public User()
        {
            AutoIncrement++;
            UserId = AutoIncrement;
           UserType = UserType.Costumer;
        }

        public override string ToString()
        {
            return $"User Id : {this.UserId}\n Name :- {this.Name}\n Username :- {this.Username}\n Password :- {this.Password}\n UserType :- {this.UserType}";
        }
    }
}
