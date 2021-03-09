using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Core.Entities.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService:IEntityService<Color>
    {
    }
}
