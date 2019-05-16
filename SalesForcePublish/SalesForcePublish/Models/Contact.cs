using System;
using System.Collections.Generic;
using System.Text;

namespace SalesForcePublish.Models
{
    public class Contact: Account
    {
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
