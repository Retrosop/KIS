using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Records
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Record_Date { get; set; }
        public string Due_Date { get; set; }
        public string Return_Date { get; set; }

        public Members Members_ { get; set; }
        public Books Books_ { get; set; }
    }
}
