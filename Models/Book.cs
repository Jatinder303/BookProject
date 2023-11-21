using System.ComponentModel.DataAnnotations;

namespace BookProject.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string BookTitle { get; set; }
        public required string Author { get; set; }
        public required string Publisher { get; set; }
        public DateTime Date_of_publish { get; set; }
    }
}
