using Microsoft.EntityFrameworkCore;

public class MvcVideoGameContext : DbContext
{
    public MvcVideoGameContext(DbContextOptions<MvcVideoGameContext> options)
        : base(options)
    {
    }

    public DbSet<MvcVideoGame.Models.VideoGame> VideoGame { get; set; }
}
