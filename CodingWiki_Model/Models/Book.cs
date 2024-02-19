namespace CodingWiki_Model.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }
    }
}