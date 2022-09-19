using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.DTOs
{
    public class LoginDto
    {
        public string? username { get; set; }
        public string? password { get; set; }
    }
}