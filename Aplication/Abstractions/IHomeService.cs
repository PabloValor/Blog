using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Aplication.Abstractions
{
    public interface IHomeService
    {
        IList<Post> getAllPosts();
        IList<Tag> getAllTags();
    }
}
