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
        BlogDBEntities db = new BlogDBEntities();

        public IList<Post> getAllPost()
        {
            return db.Posts.ToList();
        }
    }
}
