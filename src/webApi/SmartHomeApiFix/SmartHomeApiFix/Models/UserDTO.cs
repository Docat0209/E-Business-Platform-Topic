using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartHomeApiFix.Models
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public string Country { get; set; }
        public string Language { get; set; }
    }
}