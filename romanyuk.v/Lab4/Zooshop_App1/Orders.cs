using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooshop_App1
{
    public class Orders
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string order_date { get; set; }
        public int total { get; set; }
        public int status { get; set; }
        public Customers customer_ { get; set; }

        public List<Order_Items> order_items { get; set; }
    }
}
