using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetCarsByBrandId(int id);
        IDataResult<Car> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetCarByUnitPrice(decimal min, decimal max);
        IDataResult<Car> GetByCarId(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
