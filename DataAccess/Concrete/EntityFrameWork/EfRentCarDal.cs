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
    public class EfRentCarDal : EfEntityRepositoryBase<CarRental, CarsRentalContext>, IRentCarDal
    {
        public List<CarsRentalDetailDto> GetCarsRentalDetail()
        {
            using (CarsRentalContext context = new CarsRentalContext())
            {
                var result = from cr in context.CarRental
                             join clr in context.Colors on cr.ColorId equals clr.ColorId
                             join b in context.Brands on cr.BrandId equals b.BrandId
                             join c in context.Cars on cr.CarId equals c.CarId
                             select new CarsRentalDetailDto
                             {
                                 Id = cr.Id,
                                 CarId = cr.CarId,
                                 BrandName = b.BrandName,
                                 CarName = c.CarName,
                                 ColorName = clr.ColorName,
                                 ModelYear = cr.ModelYear,
                                 DailyPrice = cr.DailyPrice,
                                 Description = cr.Description
                             };
                return result.ToList();
            }
        }
    }
}
