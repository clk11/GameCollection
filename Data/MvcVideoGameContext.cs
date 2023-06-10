using Microsoft.EntityFrameworkCore;
using MvcVideoGame.Models;

public class MvcVideoGameContext : DbContext
{
    public MvcVideoGameContext(DbContextOptions<MvcVideoGameContext> options)
        : base(options)
    {
    }

    public DbSet<VideoGame> VideoGame { get; set; }
    public DbSet<Review> Review { get; set; }
}
