using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string label { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
