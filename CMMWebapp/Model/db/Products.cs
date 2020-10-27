using System;
using System.Collections.Generic;

namespace CMMWebapp.Model.db
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
    }
}
