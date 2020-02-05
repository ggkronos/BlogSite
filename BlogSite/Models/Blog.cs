using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string BlogDescription { get; set; }
        public string Picture { get; set; }
        public string Context { get; set; }
        public DateTime AddedTime { get; set; }
        public bool Approval { get; set; }
        public bool HomePage { get; set; }

        public int CategoryId { get; set; }

        //Navigation prop
        public Category Category { get; set; }

        
    }
}