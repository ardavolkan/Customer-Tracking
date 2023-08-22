using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public string ProductBrand { get; set; }
        public string ProductModel { get; set; }
        public int UnitPrice { get; set; }
        public string ProductExplanation { get; set; }

    }
}
