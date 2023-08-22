using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetails : IDto
    {
        public string Customer { get; set; }
        public string ProdcutName { get; set; }
        public string Sell { get; set; }
        public int LicanseCode { get; set; }
        public string LicanseTerm { get; set; }
    }
}
