using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationConsumeAPI.Models
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Company { get; set; }

        public int CustomerType { get; set; }

        public System.Nullable<int> CustomerStatus { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        public string MainAddress1 { get; set; }


        public string MainCity { get; set; }

        public string MainState { get; set; }

        public string MainZip { get; set; }

        public string MainCountry { get; set; }

        public string MailAddress1 { get; set; }

        public string MailAddress2 { get; set; }
        public string MiddleName { get; set; }

        public string NameSuffix { get; set; }
    }
}
