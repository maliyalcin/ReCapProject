using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentCarService
    {
        List<CarRental> GetAll();
        List<CarRental> GetAllByBrandId(int brandId);
        List<CarRental> GetAllByColorId(int colorId);
        List<CarsRentalDetailDto> GetCarsRentalDetail();
    }
}
