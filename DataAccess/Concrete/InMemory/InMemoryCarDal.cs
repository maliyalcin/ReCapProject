using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:IRentCarDal
    {
        List<CarRental> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<CarRental>
            {
                new CarRental{CarId = 1, ColorId = 2, BrandId = 3, ModelYear = 1997, DailyPrice = 125, Description = "Çok uygun fiyattan kiralama."},
                new CarRental{CarId = 2, ColorId = 4, BrandId = 2, ModelYear = 2008, DailyPrice = 185, Description = "Çok uygun fiyattan kiralama."},
                new CarRental{CarId = 3, ColorId = 1, BrandId = 2, ModelYear = 2019, DailyPrice = 155, Description = "Çok uygun fiyattan kiralama."},
                new CarRental{CarId = 4, ColorId = 5, BrandId = 4, ModelYear = 2020, DailyPrice = 130, Description = "Çok uygun fiyattan kiralama."},

            };
        }

        public List<CarRental> GetById()
        {
            return _cars;
        }

        public List<CarRental> GetAll()
        {
            return _cars;
        }

        public CarRental GetAll(Expression<Func<CarRental, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public CarRental Get(Expression<Func<CarRental, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public void Add(CarRental car)
        {
            _cars.Add(car);
        }

        public void Update(CarRental car)
        {
            CarRental carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
        }

        public void Delete(CarRental car)
        {
            CarRental carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        List<CarRental> IEntityRepository<CarRental>.GetAll(Expression<Func<CarRental, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarsRentalDetailDto> GetCarsRentalDetail()
        {
            throw new NotImplementedException();
        }
    }
}
