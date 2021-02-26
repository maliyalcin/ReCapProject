using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;

namespace ReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            RentCarManager rentCarManager = new RentCarManager(new EfRentCarDal());

            foreach (var car in rentCarManager.GetCarsRentalDetail())
            {
                Console.WriteLine(car.CarId + " " +" "+ car.BrandName +" "+ car.ColorName +" " +
                                  car.CarName+" "+car.ModelYear+" "+ car.DailyPrice+" TL  "+ car.Description);
            }
        }
    }
}
