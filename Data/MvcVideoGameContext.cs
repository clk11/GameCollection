using Microsoft.EntityFrameworkCore;

public class MvcVideoGameContext : DbContext
{
    public MvcVideoGameContext(DbContextOptions<MvcVideoGameContext> options)
        : base(options)
    {
    }

    public DbSet<MvcVideoGame.Models.VideoGame> VideoGame { get; set; }
    public DbSet<MvcVideoGame.Models.Review> Review { get; set; }
}
