using DotNet_BLog.Core.Repositories;

namespace DotNet_BLog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        IPostRepository Posts {  get; }
        Task<int> CompleteAsync();
    }
}
