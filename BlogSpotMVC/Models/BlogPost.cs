using System;
using System.Collections.Generic;
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
        public string Title { get; set; }

        public string Abstract { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        //Navigational Properties
        public virtual Blog Blog { get; set; }
 
    }
}
