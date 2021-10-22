using BlogSpotMVC.Enums;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpotMVC.Models
{
    public class BlogPost
    {
        //Primary Key
        public int Id { get; set; }


        //Foreign Key
        public int BlogId { get; set; }

        //descriptive properties

        [Required]
        [Display(Name = "Title")]
        [StringLength(100, ErrorMessage = "{0} must be at least {2} and cannot be more than {2} characters long", MinimumLength = 4)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Abstract")]
        [StringLength(260, ErrorMessage = "{0} must be at least {2} and cannot be more than {2} characters long", MinimumLength = 25)]
        public string Abstract { get; set; }

        [Required]
        [Display(Name = "Content")]
        [StringLength(3000, ErrorMessage = "{0} must be at least {2} and cannot be more than {2} characters long", MinimumLength = 25)]
        public string Content { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created")]
        public DateTime Created { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = " Updated Date")]
        public DateTime? Updated { get; set; }

        [Required]
        [Display(Name = "ReadyStatus")]
        public ReadyState ReadyStatus { get; set; }

        //This will be the Title run through a formatter. A URL "slug" is the portion of a URL
        //that identifies as specific page in a website in a easy to read manner
        // ex: Role Based Security = role-based-security
        public string Slug { get; set; }

        //This represents the byte data not the physical file
        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        //This property represents a physical file chosen by the user
        [NotMapped]
        public IFormFile Image { get; set; }


        //Navigational Properties
        public virtual Blog Blog { get; set; }

    }
}
