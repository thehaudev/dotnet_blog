using DotNet_BLog.Core.Domain.Content;
using DotNet_BLog.Core.Repositories;
using DotNet_BLog.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_BLog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(BlogContext blogContext) : base(blogContext)
        {
        }

        public  Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return  _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }
    }
}
