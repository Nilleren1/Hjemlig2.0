using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hjemlig2._0.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public decimal TotalSum { get; set; }
        public List<Products> productsInCart { get; set; }
    }
}

