using System;
using System.Collections.Generic;
using API.Extensions;

namespace API.Entities

// acess 
// Public means other class can get or set from ANY CLASS
// Protected acessed from this class or any class that is nested
// private means ONLY that class can interact with it
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }   
        public string City { get; set; }    
        public string Country { get; set; } 
        public ICollection<Photo>  Photos { get; set; }

        public  int GetAge()
        {
            return DateOfBirth.CalculateAge();
        }
    }
}