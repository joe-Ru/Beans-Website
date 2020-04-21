using Microsoft.AspNetCore.Mvc;

namespace Database_Design.Models
{
    public class ReportContent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Statement { get; set; }
        public string ArtistProduct { get; set; }
        public string ArtistProfile { get; set; }
    }
}