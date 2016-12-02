using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairBL
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public bool Unsellable { get; set; }
    }
}
