using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string label { get; set; }
        public string description { get; set; }
        public double price { get; set; }

        public ICollection<ProductCart> ProductCarts { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }


}
