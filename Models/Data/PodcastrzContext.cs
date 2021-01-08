using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI;
using Podcastrz.Models;

namespace Podcastrz.Data
{
    public class PodcastrzContext : IdentityDbContext
    {
        public PodcastrzContext (DbContextOptions<PodcastrzContext> options)
            : base(options)
        {

        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //     => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");
        public DbSet<Podcast> Podcast { get; set; }

    }
}