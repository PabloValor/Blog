using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplication.Abstractions;
using Data;

namespace Aplication
{
    public class HomeService : IHomeService
    {
        private readonly BlogDBEntities db = new BlogDBEntities();

        public IList<Post> getAllPosts()
        {
            return db.Posts.ToList();
        }

        public IList<Tag> getAllTags()
        {
            return db.Tags.ToList();
        }
    }
}
