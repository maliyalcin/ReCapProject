using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Entities.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentCarService:IEntityService<CarRental>
    {
        IDataResult<List<CarsRentalDetailDto>> GetCarsRentalDetail();
    }
}
