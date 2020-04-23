using Microsoft.AspNetCore.Mvc;

namespace Database_Design.Models
{
    public class UploadFilePage
    {
        public string ProductImage { get; set; }//how do?
        public string ImageDescription { get; set; }
        public string Price { get; set; }
        public string ProductName { get; set; }
    }
}
/*
    UploadFilePage
        image description
        upload image(option to upload/remove multiple?)
        price of product
        name of product
        submit button
*/