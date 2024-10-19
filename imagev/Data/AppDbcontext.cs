using imagev.MVVM.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace imagev.Data
{
    class AppDbcontext : DbContext
    {
        public DbSet<Foldermodel> Folders { get; set; }

        public string ConnectionString { get; }

        public AppDbcontext()
        {

            ConnectionString = @"Host=localhost;Username=postgres;Password=dannewton;Database=imagep";

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set up database connection
            optionsBuilder.UseNpgsql(ConnectionString);
        }
    }
}
