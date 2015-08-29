using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;

namespace Blog.Models
{
    public class TagViewModel
    {
        public TagViewModel()
        {
            this.posts = new HashSet<Post>();
        }
    
        public int id_tag { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<Post> posts { get; set; }
    }
}