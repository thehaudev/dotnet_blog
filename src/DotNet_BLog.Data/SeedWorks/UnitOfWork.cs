using DotNet_BLog.Core.Domain.identity;
using DotNet_BLog.Core.SeedWorks;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_BLog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }
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
