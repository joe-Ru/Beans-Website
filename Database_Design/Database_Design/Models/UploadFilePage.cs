﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_Design.Models
{
    public class UploadFilePage
    {
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        /*how do you get ProductId?
         ProductId is passed over automatically bc the person should already be logged in to upload this file
         what is IsPreferred?*/
    }
}
