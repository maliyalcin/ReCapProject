using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentCarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
        List<CarsRentalDetailDto> GetCarsRentalDetail();
    }
}
