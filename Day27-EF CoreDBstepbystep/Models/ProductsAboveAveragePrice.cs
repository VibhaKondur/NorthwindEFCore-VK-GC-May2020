using System;
using System.Collections.Generic;

namespace Day27_EF_CoreDBstepbystep.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
