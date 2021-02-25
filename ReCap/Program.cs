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

            foreach (var car in rentCarManager.GetAll())
            {
                Console.WriteLine(car.CarId+" "+ car.ColorId +" "
                                  +car.BrandId+" "+ car.ModelYear+" "+ car.DailyPrice +" "+ car.Description );
            }

            Console.ReadLine();
        }
    }
}
