using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zooshop_App1
{
    public class Products
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }

        public Categories categories_ { get; set; }
        public Suppliers suppliers_ { get; set; }

        public List<Order_Items> order_items { get; set; }
    }
}
