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
        [Required]
        public IFormFile ImageUrl { get; set; }
        
        [Required]
        public string ProductName { get; set; }
        
        [Required]
        public decimal ProductPrice { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string CategoryId { get; set; }
        /*how do you get ProductId?
         ProductId is passed over automatically bc the person should already be logged in to upload this file
         what is IsPreferred?*/
    }
}
