using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomersListed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(p => p.UserId == id), Messages.CustomersListed);
        }

        public IResult Add(Customer user)
        {
            _customerDal.Add(user);
            return new SuccessResult(Messages.CustomersAdded);
        }

        public IResult Update(Customer user)
        {
            _customerDal.Update(user);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        public IResult Delete(Customer user)
        {
            _customerDal.Get(p => p.UserId == user.UserId);
            _customerDal.Delete(user);
            return new SuccessResult(Messages.CustomerDeleted);
        }
    }
}
