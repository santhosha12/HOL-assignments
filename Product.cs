using HOL2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace HOL2.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
        {
new Product { ProductID =1,
                ProductName="Product1",Price=900.00},
new Product{ ProductID =2,
                ProductName="Product2",Price=700.00},
new Product{ ProductID =3,
                ProductName="Product3",Price=650.00},
new Product{ ProductID =4,
                ProductName="Product4",Price=950.00},
new Product{ ProductID =5,
                ProductName="Product5",Price=800.00},
    };
        }
    }
}
