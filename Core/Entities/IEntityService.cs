using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public interface IEntityService<T>
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
