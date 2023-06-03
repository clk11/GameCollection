using Microsoft.EntityFrameworkCore;

namespace MvcVideoGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcVideoGameContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcVideoGameContext>>()))
            {
                // Look for any movies.
                if (context.VideoGame.Any())
                {
                    return;
                }

                context.VideoGame.AddRange(
                new VideoGame
                {
                    Title = "Super Mario Odyssey",
                    ReleaseDate = DateTime.Parse("2017-10-27"),
                    Genre = "Platformer",
                    Platform = "Nintendo Switch",
                    Developer = "Nintendo",
                    Multiplayer = false,
                    Price = 59.99M
                },
                new VideoGame
                {
                    Title = "The Legend of Zelda: Breath of the Wild",
                    ReleaseDate = DateTime.Parse("2017-03-03"),
                    Genre = "Action-Adventure",
                    Platform = "Nintendo Switch",
                    Developer = "Nintendo",
                    Multiplayer = false,
                    Price = 59.99M
                },
                new VideoGame
                {
                    Title = "Red Dead Redemption 2",
                    ReleaseDate = DateTime.Parse("2018-10-26"),
                    Genre = "Action-Adventure",
                    Platform = "PlayStation 4",
                    Developer = "Rockstar Games",
                    Multiplayer = true,
                    Price = 59.99M
                },
                new VideoGame
                {
                    Title = "Minecraft",
                    ReleaseDate = DateTime.Parse("2011-11-18"),
                    Genre = "Sandbox",
                    Platform = "Multiple Platforms",
                    Developer = "Mojang Studios",
                    Multiplayer = true,
                    Price = 26.99M
                },
                new VideoGame
                {
                    Title = "Grand Theft Auto V",
                    ReleaseDate = DateTime.Parse("2013-09-17"),
                    Genre = "Action-Adventure",
                    Platform = "PlayStation 4",
                    Developer = "Rockstar Games",
                    Multiplayer = true,
                    Price = 29.99M
                },
                new VideoGame
                {
                    Title = "Overwatch",
                    ReleaseDate = DateTime.Parse("2016-05-24"),
                    Genre = "First-Person Shooter",
                    Platform = "PC, PlayStation 4, Xbox One",
                    Developer = "Blizzard Entertainment",
                    Multiplayer = true,
                    Price = 39.99M
                },
                new VideoGame
                {
                    Title = "Game 3",
                    ReleaseDate = DateTime.Parse("2023-03-01"),
                    Genre = "Role-Playing",
                    Platform = "Nintendo Switch",
                    Developer = "Developer 3",
                    Multiplayer = false,
                    Price = 54.99M
                },
                new VideoGame
                {
                    Title = "Game 4",
                    ReleaseDate = DateTime.Parse("2023-04-01"),
                    Genre = "Strategy",
                    Platform = "PC",
                    Developer = "Developer 4",
                    Multiplayer = true,
                    Price = 29.99M
                },
                new VideoGame
                {
                    Title = "Game 5",
                    ReleaseDate = DateTime.Parse("2023-05-01"),
                    Genre = "Sports",
                    Platform = "PlayStation",
                    Developer = "Developer 5",
                    Multiplayer = true,
                    Price = 49.99M
                },
                new VideoGame
                {
                    Title = "Game 6",
                    ReleaseDate = DateTime.Parse("2023-06-01"),
                    Genre = "Shooter",
                    Platform = "Xbox",
                    Developer = "Developer 6",
                    Multiplayer = true,
                    Price = 39.99M
                },
                new VideoGame
                {
                    Title = "Game 7",
                    ReleaseDate = DateTime.Parse("2023-07-01"),
                    Genre = "Adventure",
                    Platform = "PC",
                    Developer = "Developer 7",
                    Multiplayer = false,
                    Price = 44.99M
                },
                new VideoGame
                {
                    Title = "Game 8",
                    ReleaseDate = DateTime.Parse("2023-08-01"),
                    Genre = "Racing",
                    Platform = "Nintendo Switch",
                    Developer = "Developer 8",
                    Multiplayer = true,
                    Price = 59.99M
                },
                new VideoGame
                {
                    Title = "Game 9",
                    ReleaseDate = DateTime.Parse("2023-09-01"),
                    Genre = "Action",
                    Platform = "PlayStation",
                    Developer = "Developer 9",
                    Multiplayer = true,
                    Price = 49.99M
                },
                new VideoGame
                {
                    Title = "Game 10",
                    ReleaseDate = DateTime.Parse("2023-10-01"),
                    Genre = "Role-Playing",
                    Platform = "Xbox",
                    Developer = "Developer 10",
                    Multiplayer = false,
                    Price = 34.99M
                },
                new VideoGame
                {
                    Title = "Game 11",
                    ReleaseDate = DateTime.Parse("2023-11-01"),
                    Genre = "Strategy",
                    Platform = "PC",
                    Developer = "Developer 11",
                    Multiplayer = true,
                    Price = 39.99M
                },
                new VideoGame
                {
                    Title = "Game 12",
                    ReleaseDate = DateTime.Parse("2023-12-01"),
                    Genre = "Sports",
                    Platform = "Nintendo Switch",
                    Developer = "Developer 12",
                    Multiplayer = true,
                    Price = 54.99M
                });
                context.SaveChanges();
            }
        }
    }
}