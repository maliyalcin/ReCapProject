using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        ICustomerService _customerService;

        public UserManager(IUserDal userDal, ICustomerService customerService) 
        {
            _userDal = userDal;
            _customerService = customerService;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }




        //JWT Yetkilendirme işleminden önceki methotlar.

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserList);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == id));
        }

        //[ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(CheckIfUserNameExists(user.FirstName),
                CheckIfUserCountCorrect(user.Id), CheckIfCustomerLimitExceded());

            if (result != null)
            {
                return result;
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);

        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        private IResult CheckIfUserCountCorrect(int userId)
        {
            var result = _userDal.GetAll(u => u.Id == userId).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.UserCountError);
            }

            return new SuccessResult();
        }

        private IResult CheckIfUserNameExists(string firstName)
        {
            var result = _userDal.GetAll(u => u.FirstName == firstName).Any();
            if (result)
            {
                return new ErrorResult(Messages.UserNameAlreadyExists);
            }

            return new SuccessResult();

        }

        private IResult CheckIfCustomerLimitExceded()
        {
            var result = _customerService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.CustomerLimiExceded);
            }
            return new SuccessResult();
        }
    }
}
