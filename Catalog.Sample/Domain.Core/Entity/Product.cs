using Liquid.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Sample.Domain.Core.Entity
{
    public class Product : LiquidEntity<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
