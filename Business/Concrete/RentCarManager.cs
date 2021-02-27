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

        public List<CarRental> GetAll()
        {
            return _rentCarDal.GetAll();
        }

        public List<CarRental> GetAllByBrandId(int brandId)
        {
            return _rentCarDal.GetAll(cr => cr.BrandId == brandId);
        }

        public List<CarRental> GetAllByColorId(int colorId)
        {
            return _rentCarDal.GetAll(cr => cr.ColorId == colorId);
        }

        public List<CarsRentalDetailDto> GetCarsRentalDetail()
        {
            return _rentCarDal.GetCarsRentalDetail();
        }
    }
}
