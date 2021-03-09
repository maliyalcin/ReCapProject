﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfUserDal:EfEntityRepositoryBase<User, CarsRentalContext>,IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new CarsRentalContext())
            {
                var result =
                    from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims on operationClaim.Id equals
                        userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim
                    {
                        Id = operationClaim.Id,
                        Name = operationClaim.Name

                    };
                return result.ToList();
            }
        }
    }
}
