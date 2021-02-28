using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarsRentalContext>,ICarDal
    {
        ICarDal _carDal;

        public EfCarDal()
        {
        }

        public EfCarDal(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(cr => cr.ColorId == colorId));
        }

        IDataResult<List<Car>> ICarDal.GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }
    }
}
