namespace BookProject.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public required string FName { get; set; }
        public string LName { get; set; }
        public required string Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}
