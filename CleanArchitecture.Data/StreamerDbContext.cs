using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data
{
    public class StreamerDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DES-AUX-01\\\\SQLSERVIDOR;Initial Catalog=Streamer;Persist Security Info=True;User Id=sa;Password=dimitriv3g4s\");
            optionsBuilder.UseSqlServer(@"Server=DES-AUX-01;Database=Streamer;Integrated Security=True;TrustServerCertificate=True;User Id=sa;Password=dimitriv3g4s");
        }
        public DbSet<Streamer>? Streamers { get; set; }
        public DbSet<Video>? Videos { get; set; }

    }
}
