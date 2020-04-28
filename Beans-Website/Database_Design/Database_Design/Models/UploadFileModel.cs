using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Database_Design.Models
{
    public class UploadFilePage
    {
        public IFormFile ImageUrl { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }

        public string Description { get; set; }

        public string CategoryId { get; set; }
    }
}
