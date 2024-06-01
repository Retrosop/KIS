using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Members
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Join_Date { get; set; }

        List<Records> records { get; set; }
    }
}
