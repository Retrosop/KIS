using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooshop_App1
{
    public class Categories
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public string description { get; set; }

        public List<Products> products { get; set; }
    }
}
