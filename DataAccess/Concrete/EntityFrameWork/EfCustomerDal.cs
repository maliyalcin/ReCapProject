using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCustomerDal:EfEntityRepositoryBase<Customer, CarsRentalContext>,ICustomerDal
    {
    }
}
