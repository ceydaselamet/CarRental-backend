using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
    }
}
