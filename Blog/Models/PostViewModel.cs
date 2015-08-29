using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            this.tags = new HashSet<Tag>();
        }
        public int id_post { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> created { get; set; }
        public string shorDescription { get; set; }
        public string body { get; set; }
        public Nullable<int> id_author { get; set; }
        public Nullable<int> id_category { get; set; }
        public string imageList { get; set; }

        public virtual Author author { get; set; }
        public virtual Category category { get; set; }
        public virtual ICollection<Tag> tags { get; set; }
    }
}