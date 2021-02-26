using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfRentCarDal : EfEntityRepositoryBase<Car, CarsRentalContext>, IRentCarDal
    {
        public List<CarsRentalDetailDto> GetCarsRentalDetail()
        {
            using (CarsRentalContext context = new CarsRentalContext())
            {
                var result = from c in context.Cars
                    join clr in context.Colors on c.ColorId equals clr.ColorId
                    join b in context.Brands on c.BrandId equals b.BrandId
                    select new CarsRentalDetailDto
                    {
                        CarId = c.CarId,
                        BrandName = b.BrandName,
                        ColorName = clr.ColorName,
                        ModelYear = c.ModelYear,
                        DailyPrice = c.DailyPrice,
                        Description = c.Description
                    };
                return result.ToList();
            }
        }
    }
}
