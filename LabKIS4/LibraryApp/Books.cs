using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public int Publish_Year { get; set; }
        public int Copies { get; set; }

        public Genres Genres_ { get; set; }

        List<Records> records { get; set; }
    }
}
