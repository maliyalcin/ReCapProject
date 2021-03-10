using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Entities.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService:IEntityService<Car>
    {
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IResult AddTransactionalTest(Car car);
    }
}
