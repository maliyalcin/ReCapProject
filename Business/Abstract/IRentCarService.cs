using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentCarService
    {
        IDataResult<List<CarRental>> GetAll();
        IDataResult<List<CarsRentalDetailDto>> GetCarsRentalDetail();
        IDataResult<CarRental> GetById(int id);
        IResult Add(CarRental carRental);
    }
}
