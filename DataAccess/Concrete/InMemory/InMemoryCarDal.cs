﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal:ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=2, DailyPrice=450, ModelYear=2016, Description="Skoda SuperB" },
                new Car{CarId=2, BrandId=1, ColorId=1, DailyPrice=550, ModelYear=2018, Description="Volkswagen Passat" },
                new Car{CarId=3, BrandId=2, ColorId=1, DailyPrice=650, ModelYear=2017, Description="Volkswagen Golf" },
                new Car{CarId=4, BrandId=3, ColorId=3, DailyPrice=350, ModelYear=2016, Description="Fiat Egea" },
                new Car{CarId=5, BrandId=1, ColorId=2, DailyPrice=450, ModelYear=2020, Description="Skoda Octavia" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.CarId == id).ToList();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetail(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
