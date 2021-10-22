using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpotMVC.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 5)]
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }

        //This represents the byte data not the physical file
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        //This property represents a physical file chosen by the user
        [NotMapped]
        public IFormFile Image { get; set; }

        public ICollection<BlogPost> BlogPosts = new HashSet<BlogPost>();
    }
}
