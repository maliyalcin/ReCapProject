using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
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

        public IResult Add(CarRental carRental)
        {
            _rentCarDal.Add(new CarRental());
            return new Result(true, Messages.CarRentalAdded);
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
