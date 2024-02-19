namespace CodingWiki_Model.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Genre
    {
        [Key]
        public int GenreId { get; set; }

        public string GenreName { get; set; }

        public int DisplayOrder { get; set; }
    }
}