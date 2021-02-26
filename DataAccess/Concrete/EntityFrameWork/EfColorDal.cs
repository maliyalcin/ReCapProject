using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfColorDal:EfEntityRepositoryBase<Color,CarsRentalContext>,IColorDal
    {
        
    }
}
