using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Shop.Models
{
    public class User:IdentityUser
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
    }
}
