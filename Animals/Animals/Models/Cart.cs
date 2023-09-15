using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Cart
    {
        public int Id { get; set; }
   
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ProductCart> ProductCarts { get; set; }

    }
}
