using DotNet_BLog.Core.Domain.Content;
using DotNet_BLog.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_BLog.Core.Repositories
{
    public interface IPostRepository: IRepository<Post,Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
    }
}
