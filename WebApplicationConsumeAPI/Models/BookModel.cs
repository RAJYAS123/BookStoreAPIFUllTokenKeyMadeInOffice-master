using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationConsumeAPI.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Please Add title property")]

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
