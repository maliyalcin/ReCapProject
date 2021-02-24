using System;
using Business.Concrete;
using DataAccess.Concrete;

namespace ReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            RentCarManager rentCarManager = new RentCarManager(new InMemoryCarDal());

            foreach (var car in rentCarManager.GetAll())
            {
                Console.WriteLine(car.BrandId+" "+ car.ColorId+" "+car.DailyPrice+" "+car.Description);
            }

            Console.ReadLine();
        }
    }
}
