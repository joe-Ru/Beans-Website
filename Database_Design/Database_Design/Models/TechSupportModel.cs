namespace Database_Design.Models
{
    public class TechSupportModel
    {
        /* The reason phone number is placed as a string and not an int is because
         I would rather not go through the hassle of creating a for loop to 
         remove all the hyphens, create an array, push to the array...you get the idea.... */
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Statement { get; set; }
        
    }
}