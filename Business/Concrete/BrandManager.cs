using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager:IBrandService
    {
        IBrandsDal _brandsDal;

        public BrandManager(IBrandsDal brandsDal)
        {
            _brandsDal = brandsDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandsDal.GetAll(), Messages.BrandList);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandsDal.Get(b => b.BrandId == id));
        }

        [SecuredOperation("brand.add,admin")]
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand brand)
        {
            _brandsDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        [SecuredOperation("brand.update,admin")]
        public IResult Update(Brand brand)
        {
            _brandsDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        [SecuredOperation("brand.delete,admin")]
        public IResult Delete(Brand brand)
        {
            _brandsDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }
    }
}
