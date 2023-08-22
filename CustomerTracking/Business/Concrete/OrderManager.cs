using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }
       
        [ValidationAspect(typeof(OrderValidator))]
        public IResult Add(Order order)
        {
            //var context = new ValidationContext<Order>(order);
            //OrderValidator orderValidator = new OrderValidator();

            //var result = orderValidator.Validate(context);
            //if (result.IsValid)
            //{
            //    throw new Exception(result.Errors.ToString());
            //}
            _orderDal.Add(order);
            return new SuccessResult(Messages.OrderAdded);
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GettAll(),Messages.OrderListed);
        }
    }
}
