﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int id);
        IDataResult<CarImage> GetByImageId(int id);
        IResult Add(IFormFile file,CarImage carImage);
        IResult Update(IFormFile file,CarImage carImage);
        IResult Delete(CarImage carImage);
    }
}
