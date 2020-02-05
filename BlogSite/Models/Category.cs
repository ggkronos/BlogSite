using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSite.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        //Her category altında birdan fazla blog olacağı için blog tipinde bir listeye ihtiyacımız var
        public List<Blog> Blogs { get; set; }
    }
}