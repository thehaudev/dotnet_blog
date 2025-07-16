using DotNet_BLog.Core.Domain.Content;
using DotNet_BLog.Core.Models;
using DotNet_BLog.Core.Models.Content;
using DotNet_BLog.Core.SeedWorks;

namespace DotNet_BLog.Core.Repositories
{
    public interface IPostRepository: IRepository<Post,Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);
        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
