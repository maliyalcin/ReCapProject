using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

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

        public List<Car> GetCarsByBrandId(int id)
        {
            return _rentCarDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _rentCarDal.GetAll(p => p.ColorId == id);
        }
    }
}
