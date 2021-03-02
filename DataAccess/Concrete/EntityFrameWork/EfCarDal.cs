using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal:EfEntityRepositoryBase<Car,CarsRentalContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarsRentalContext context = new CarsRentalContext())
            {
                var result = from car in context.Cars
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join color in context.Colors on car.ColorId equals color.ColorId
                    select new CarDetailDto
                    {
                        CarId = car.CarId,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        ModelYear = car.ModelYear
                    };
                return result.ToList();
            }
        }
    }
}
