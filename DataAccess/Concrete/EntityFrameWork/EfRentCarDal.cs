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
                var result = from carRental in context.CarRentals
                             join car in context.Cars on carRental.CarId equals car.CarId
                             join customer in context.Customers on carRental.CustomerId equals customer.CustomerId
                             join user in context.Users on customer.UserId equals user.Id
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new CarsRentalDetailDto
                             {

                                 Id = carRental.Id,
                                 CarName = car.CarName,
                                 BrandName = brand.BrandName,
                                 UserName = user.FirstName + " " + user.LastName,
                                 CompanyName = customer.CompanyName,
                                 RentDate = carRental.RentDate,
                                 ReturnDate = carRental.ReturnDate,

                             };
                return result.ToList();
            }
        }
    }
}
