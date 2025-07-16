using AutoMapper;
using DotNet_BLog.Core.Repositories;
using DotNet_BLog.Core.SeedWorks;
using DotNet_BLog.Data.Repositories;

namespace DotNet_BLog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public UnitOfWork(BlogContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }

        public IPostRepository Posts { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
