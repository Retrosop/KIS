using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooshop_App1
{
    public class Suppliers
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public List<Suppliers> suppliers { get; set; }
    }
}
