using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public string ProductBrand { get; set; }
        public string ProductModel { get; set; }
        public string UnitPrice { get; set; }
        public string ProductExplanation { get; set; }
    }
}
