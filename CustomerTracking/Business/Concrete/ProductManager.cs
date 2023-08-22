using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using Business.BusinessAspects.Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //[SecuredOperation("product.add")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(CheckIfProductNameExists(product.ProductName));

            if (result == null)
            {
                _productDal.Add(product);
                return new SuccessResult(Messages.ProductAdded);
            }

            return new ErrorResult(result.Message);
            
    
            //var context = new ValidationContext<Product>(product);
            //ProductValidator productValidator = new ProductValidator();

            //var result = productValidator.Validate(context);
            //if (result.IsValid)
            //{
            //    throw new Exception(result.Errors.ToString());
            //}
            //_productDal.Add(product);
            //return new SuccessResult(Messages.ProductAdded);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Delete(Product product)
        {
            //var context = new ValidationContext<Product>(product);
            //ProductValidator productValidator = new ProductValidator();

            //var result = productValidator.Validate(context);
            //if (result.IsValid) 
            //{
            //    throw new Exception(result.Errors.ToString());
            //}
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        
        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List< Product>> (_productDal.GettAll(),Messages.ProductsListed);   
        }

        public IDataResult<List<ProductDetails>> GetAllDetails()
        {
            return new SuccessDataResult<List<ProductDetails>>(_productDal.GetProductDetails(), Messages.ProductsListed);
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {
            //var context = new ValidationContext<Product>(product);
            //ProductValidator productValidator = new ProductValidator();

            //var result = productValidator.Validate(context);
            //if(result.IsValid)
            //{
            //    throw new Exception(result.Errors.ToString());
            //}
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
        
        
        private IResult CheckIfProductNameExists(string productName)
        {
            var result = _productDal.GettAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExists);
            }
            return new SuccessResult();
        }

    }
}
