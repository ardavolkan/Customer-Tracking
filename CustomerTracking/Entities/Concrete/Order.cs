using Core.Entities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entities.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public int productId { get; set; }
        public string Sell​​by { get; set; }
        public int LicenseCode { get; set; }
        public string LicenseTerm { get; set; }
    }
}
