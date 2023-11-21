namespace BookProject.Models
{
    public class Rental
    {
        public int Id { get; set; }

        public int Cust_ID { get; set; }
        public Customer Customer { get; set; }

        public int Book_ID { get; set; }
        public Book Book { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
