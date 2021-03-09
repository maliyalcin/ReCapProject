using System.Collections.Generic;
using Core.Utilities.Results;

namespace Core.Entities.Abstract
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
