using Core.DateAcsess.EntityFramrework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, CustomerContext>, IProductDal
    {
        public List<ProductDetails> GetProductDetails()
        {
            using (var c = new CustomerContext())
            {

                var list = from p in c.Products
                           join ox in c.Orders on p.ProductId equals ox.productId
                           select new ProductDetails
                           {
                               Customer = ox.Customer,
                               LicanseCode = ox.LicenseCode,
                               LicanseTerm = ox.LicenseTerm,
                               ProdcutName = p.ProductName,
                               Sell = ox.Sellby
                           };
                return list.ToList();
            }
           
        }
    }
}
