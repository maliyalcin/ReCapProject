using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class RentCarManager:IRentCarService
    {
        IRentCarDal _rentCarDal;

        public RentCarManager(IRentCarDal rentCarDal)
        {
            _rentCarDal = rentCarDal;
        }

        [ValidationAspect(typeof(RentCarValidator))]
        public IResult Add(CarRental carRental)
        {
            _rentCarDal.Add(new CarRental());
            return new Result(true, Messages.CarRentalAdded);
        }

        public IResult Update(CarRental carRental)
        {
            _rentCarDal.Update(carRental);
            return new Result(true, Messages.CarRentalUpdated);
        }

        public IResult Delete(CarRental carRental)
        {
            _rentCarDal.Delete(carRental);
            return new SuccessResult(Messages.CarRentalDeleted);
        }

        public IDataResult<List<CarRental>> GetAll()
        {
            if (DateTime.Now.Hour==20)
            {
                //return new ErrorDataResult<List<CarRental>>(Messages.MaintenanceTime);
                return new ErrorDataResult<List<CarRental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarRental>>(_rentCarDal.GetAll(),Messages.CarRentalListed);
        }

        public IDataResult<CarRental> GetById(int id)
        {
            return new SuccessDataResult<CarRental>(_rentCarDal.Get(cr => cr.Id == id));
        }

        public IDataResult<List<CarsRentalDetailDto>> GetCarsRentalDetail()
        {
            return new SuccessDataResult<List<CarsRentalDetailDto>>(_rentCarDal.GetCarsRentalDetail());
        }
    }
}
