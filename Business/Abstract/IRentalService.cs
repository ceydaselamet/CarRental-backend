﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetRentalByCarId(int carId);


        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<RentalDetailDto>> GetRentalDetailsByCarId(int carId);
    }
}
