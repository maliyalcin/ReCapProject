﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
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

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length<3)
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }
            _brandsDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Update(Brand brand)
        {
            _brandsDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Delete(Brand brand)
        {
            _brandsDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }
    }
}