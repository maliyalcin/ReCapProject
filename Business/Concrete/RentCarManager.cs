using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

        public List<Car> GetAll()
        {
            return _rentCarDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _rentCarDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _rentCarDal.GetAll(c => c.CarId == colorId);
        }

        public List<CarsRentalDetailDto> GetCarsRentalDetail()
        {
            return _rentCarDal.GetCarsRentalDetail();
        }
    }
}
