using System.ComponentModel.DataAnnotations;

namespace MvcVideoGame.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string? Username { get; set; }

        public string? Message { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int VideoGameId { get; set; }

        public VideoGame VideoGame { get; set; }

    }
}