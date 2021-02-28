using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, ColorId = 2, BrandId = 3, ModelYear = 1997, DailyPrice = 125, Description = "Çok uygun fiyattan kiralama."},
                new Car{CarId = 2, ColorId = 4, BrandId = 2, ModelYear = 2008, DailyPrice = 185, Description = "Çok uygun fiyattan kiralama."},
                new Car{CarId = 3, ColorId = 1, BrandId = 2, ModelYear = 2019, DailyPrice = 155, Description = "Çok uygun fiyattan kiralama."},
                new Car{CarId = 4, ColorId = 5, BrandId = 4, ModelYear = 2020, DailyPrice = 130, Description = "Çok uygun fiyattan kiralama."},

            };
        }

        public List<Car> GetById()
        {
            return _cars;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Car entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        List<Car> IEntityRepository<Car>.GetAll(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarsRentalDetailDto> GetCarsRentalDetail()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
