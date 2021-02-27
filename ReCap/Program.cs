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

                Console.WriteLine(car.CarId+" "+@" Brand : {0} / Color : {1} / Model : {2} / Model Year : {3} / Daily Price : {4} TL / Description : {5} ",
                    car.BrandName,car.ColorName,car.CarName,car.ModelYear,car.DailyPrice,car.Description);

                Console.WriteLine("-------------------------------------------------------------------------");


            }
        }
    }
}
