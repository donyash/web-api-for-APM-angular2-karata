using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace xworkout.WebApi.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ProductCode { get; set; }
        public int ProductId { get; set; }

        [Required()]
        [MinLength(4, ErrorMessage ="Product Name minimum length is 4 characters.")]
        [MaxLength(12, ErrorMessage = "Product Name maximum length is 12 characters.")]
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal StarRating { get; set; }
        public string ImageUrl { get; set; }
    }
}