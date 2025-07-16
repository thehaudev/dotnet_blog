
using DotNet_BLog.Data;
using DotNet_BLog.Data.DataSeeder;
using Microsoft.EntityFrameworkCore;

namespace DotNet_BLog.WebApi
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<BlogContext>()) {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }  
            }
            return app;
        }
    }
}
