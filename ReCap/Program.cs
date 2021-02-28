using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities.Concrete;

namespace ReCap
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarRentalList();
            //AddCustomer();
            //AddCar();
        }

        private static void AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarId = 1, CarName = "Civic", ColorId = 3, BrandId = 6, ModelYear = 2019, DailyPrice = 150,
                Description = "Konfora düşkün insanlar için."
            });
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer {UserId = 1, CompanyName = "Eflatun"});
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void CarRentalList()
        {
            RentCarManager rentCarManager = new RentCarManager(new EfRentCarDal());

            foreach (var car in rentCarManager.GetCarsRentalDetail().Data)
            {
                Console.WriteLine(
                    car.CarId + " " +
                    @" Brand : {0} / Color : {1} / Model : {2} / Model Year : {3} / Daily Price : {4} TL / Description : {5} ",
                    car.BrandName, car.ColorName, car.CarName, car.ModelYear, car.DailyPrice, car.Description);

                Console.WriteLine("-------------------------------------------------------------------------");
            }
        }
    }
}
