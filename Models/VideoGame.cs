using System.ComponentModel.DataAnnotations;

namespace MvcVideoGame.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public string? Platform { get; set; }
        public string? Developer { get; set; }
        public bool Multiplayer { get; set; }
        public decimal Price { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}