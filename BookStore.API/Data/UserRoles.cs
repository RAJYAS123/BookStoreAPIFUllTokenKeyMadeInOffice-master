using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.API.Data
{
    [Table("AspNetRoles")]
    public class UserRoles
    {
        public const string User = "User";
        public const string Admin = "Admin";
    }
}
