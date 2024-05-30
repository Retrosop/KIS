using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooshop_App1
{
    public class Order_Items
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int quantity { get; set; }
        public int total { get; set; }

        public Orders orders_ { get; set; }
        public Products products_ { get; set; }
    }
}
