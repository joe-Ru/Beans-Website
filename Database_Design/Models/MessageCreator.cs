using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Database_Design.Models
{
    public class MessageCreator
    {
		public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
	}
}