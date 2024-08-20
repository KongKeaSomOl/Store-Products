using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Products
{
    internal class Products
    {
        public String ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        //public double PriceSale { get; set; }
        public double Total { get; set; }
        public DateTime Date { get; set; }
        public DateTime Expire { get; set; }

    }
}
